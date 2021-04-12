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

namespace Business.Queries.Similar
{
    public class GetAllSimilarPositionsByJobPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobPositionId { get; set; }
        public int[] RequiredCompetencyId { get; set; }
        public int[] HigherLevelCompetencyId { get; set; }
        public int[] SameLevelCompetencyId { get; set; }
        public int[] SameOrHigherLevelCompetencyId { get; set; }
        public int[] AddedCompetencyId { get; set; }
        public int[] CertificateId { get; set; }
        public double PercentMatch { get; set; }
    }

    public class GetAllSimilarPositionsByJobPositionIdQueryHandler : IQueryHandler<GetAllSimilarPositionsByJobPositionIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllSimilarPositionsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<List<JobPositionDto>> HandleAsync(GetAllSimilarPositionsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var allPositionCompetencyRatings = await _db.JobRolePositionCompetencyRatings
                    .Include(e => e.CompetencyRatingLevel)
                    .Where(e => e.JobPositionId == query.JobPositionId)
                    .ToDictionaryAsync(k => k.CompetencyId, v => v.CompetencyRatingLevel.Value);      
            
            var allPositionCertificates = await _db.JobRolePositionCertificates
                    .Include(e => e.Certificate)
                    .Where(e => e.JobPositionId == query.JobPositionId)
                    .Select(c=>c.CertificateId)
                    .ToListAsync();
            
            var sameLevelCompetencies = allPositionCompetencyRatings
                   .Where(e => query.SameLevelCompetencyId
                   .Any(sl => sl == e.Key))
                   .ToDictionary(k => k.Key, v => v.Value);
            
            var higherLevelCompetencies = allPositionCompetencyRatings
                   .Where(e => query.HigherLevelCompetencyId
                   .Any(sl => sl == e.Key))
                   .ToDictionary(k => k.Key, v => v.Value);
            
            var sameOrHigherLevelCompetencies = allPositionCompetencyRatings
                   .Where(e => query.SameOrHigherLevelCompetencyId
                   .Any(sl => sl == e.Key))
                   .ToDictionary(k => k.Key, v => v.Value);
           
            var allCurrentCompetencies = allPositionCompetencyRatings.Keys.Union(query.AddedCompetencyId.ToList());
           
            var certificatePositions = (
                    await _db.JobRolePositionCertificates
                    .Include(e => e.Certificate).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobPositionId })
                .Select(g => new
                {
                    JobPositionId = g.Key.JobPositionId,
                    Certificates = g.Select(e => e.CertificateId).ToList()
                })
                .Where(e => e.JobPositionId != query.JobPositionId
                    );

            return (from competencies in (await _db.JobRolePositionCompetencyRatings
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
                    !query.RequiredCompetencyId.Any()
                    || e.CompetencyRatings.Select(s => s.CompetencyId).Intersect(query.RequiredCompetencyId).Count()==query.RequiredCompetencyId.Count()
                 )
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
                join cert in certificatePositions on competencies.JobPositionId equals cert.JobPositionId into certificateCompetencies
                from cc in certificateCompetencies.DefaultIfEmpty()
                     select new JobPositionDto
                          {
                                  JobTitleEng = competencies.JobTitleEng,
                                  JobTitleFre = competencies.JobTitleFre,
                                  JobGroupId = competencies.JobGroupId,
                                  JobGroupCode = competencies.JobGroupCode,
                                  JobLevelValue = competencies.JobGroupLevel,
                                  JobGroupLevelId = competencies.JobGroupLevelId,
                                  JobTitleId = competencies.JobPositionId,
                                  Competencies = competencies.CompetencyRatings.Select(e => e.CompetencyId).ToList(),
                                  Certificates = cc == null ? new List<int> { } : cc.Certificates.ToList()
                           }
                     )    
                    .Where(e => !query.CertificateId.Any() 
                        || e.Certificates.Intersect(query.CertificateId).Count() 
                                == query.CertificateId.Count()
                     )
                    .Where(e => (allCurrentCompetencies.Intersect(e.Competencies).ToList().Count + allPositionCertificates.Intersect(e.Certificates).ToList().Count)
                                 / Convert.ToDouble(e.Competencies.ToList().Count + e.Certificates.ToList().Count) 
                                 >= query.PercentMatch / 100 && e.JobTitleId != query.JobPositionId
                    ).ToList();
        }
    }
}