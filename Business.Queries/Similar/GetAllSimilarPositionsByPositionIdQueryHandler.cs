using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using System;
using Microsoft.AspNetCore.Mvc;
using Core;

namespace Business.Queries.Similar
{
    public class GetAllSimilarPositionsByPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobPositionId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int JobGroupId { get; set; }
        public int[] HigherLevelCompetencyId { get; set; }
        public int[] SameLevelCompetencyId { get; set; }
        public int[] SameOrHigherLevelCompetencyId { get; set; }
        public int[] CertificateId { get; set; }
        public double PercentMatch { get; set; }
    }

    public class GetAllSimilarPositionsByPositionIdQueryHandler : IQueryHandler<GetAllSimilarPositionsByPositionIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllSimilarPositionsByPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<List<JobPositionDto>> HandleAsync(GetAllSimilarPositionsByPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {         
            var allPositionCompetencyRatings = await _db.JobRolePositionCompetencyRatings
            .Include(e => e.CompetencyRatingLevel)
            .Where(e =>
            e.JobPositionId == query.JobPositionId
            && e.JobGroupLevelId == query.JobGroupLevelId
            && e.JobGroupId == query.JobGroupId)
            .ToDictionaryAsync(k => k.CompetencyId, v => v.CompetencyRatingLevel.Value);

            var sameLevelCompetencies = allPositionCompetencyRatings.Where(e => query.SameLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var higherLevelCompetencies = allPositionCompetencyRatings.Where(e => query.HigherLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var sameOrHigherLevelCompetencies = allPositionCompetencyRatings.Where(e => query.SameOrHigherLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var allCurrentCompetencies = allPositionCompetencyRatings.Keys.ToList();

            var resultCertificates = (
                    await _db.JobRolePositionCertificates
                    .Include(e => e.Certificate).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobPositionId })
                .Select(g => new 
                {
                     JobPositionId = g.Key.JobPositionId,
                     Certificates = g.Select(e=>e.CertificateId).ToList()
                 })
                .Where(e =>
                    query.CertificateId.Any() &&
                    query.CertificateId.All(sl => e.Certificates.Any(cr => cr == sl))
                    && e.JobPositionId != query.JobPositionId
                    );

            return (await _db.JobRolePositionCompetencyRatings
                    .Include(e => e.JobPosition)
                    .Include(e => e.JobGroupLevel)
                    .Include(e => e.JobGroup)
                    .Include(e => e.CompetencyRatingLevel).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobGroup.Code, e.JobGroupLevel.LevelValue, e.JobPositionId, e.JobPosition.TitleEng, e.JobPosition.TitleFre })
                .Select(g => new
                {
                    JobTitleEng = g.Key.TitleEng,
                    JobTitleFre = g.Key.TitleFre,
                    JobGroupCode = g.Key.Code,
                    JobGroupId = g.Key.JobGroupId,
                    JobGroupLevelId = g.Key.JobGroupLevelId,
                    JobGroupLevel = g.Key.LevelValue,
                    JobPositionId = g.Key.JobPositionId,
                    CompetencyRatings = g.Select(e => new JobCompetencyRatingDto { CompetencyId = e.CompetencyId, RatingValue = e.CompetencyRatingLevel.Value }).ToList()
                })
                .Where(e =>
                    !sameLevelCompetencies.Any()
                    || sameLevelCompetencies.All(
                            sl => e.CompetencyRatings.Any(cr => cr.RatingValue == sl.Value
                                && cr.CompetencyId == sl.Key))
                 )
                .Where(e =>
                    !higherLevelCompetencies.Any()
                    || higherLevelCompetencies.All(
                            sl => e.CompetencyRatings.Any(cr => cr.RatingValue > sl.Value
                                && cr.CompetencyId == sl.Key))
                 )
                .Where(e =>
                    !sameOrHigherLevelCompetencies.Any()
                    || sameOrHigherLevelCompetencies.All(
                            sl => e.CompetencyRatings.Any(cr => cr.RatingValue >= sl.Value
                                && cr.CompetencyId == sl.Key))
                 )
                .Where(e => 
                    !resultCertificates.Any()
                    || resultCertificates.Any(sl => sl.JobPositionId == e.JobPositionId)
                )
                .Select(e => new JobPositionDto()
                {
                    JobTitleEng = e.JobTitleEng,
                    JobTitleFre = e.JobTitleFre,
                    JobGroupId = e.JobGroupId,
                    JobGroupCode = e.JobGroupCode,
                    JobLevelValue = e.JobGroupLevel,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobTitleId = e.JobPositionId,
                    Competencies = e.CompetencyRatings.Select(e => e.CompetencyId).ToList(),
                }
                )
                .Where(e => allCurrentCompetencies.Intersect(e.Competencies).ToList().Count / Convert.ToDouble(e.Competencies.ToList().Count) >= query.PercentMatch / 100 && e.JobTitleId != query.JobPositionId).ToList();           
        }
    }
}