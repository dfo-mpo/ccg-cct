﻿using System.Collections.Generic;
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
    public class GetAllSimilarJobPositionsByJobPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobPositionId { get; set; }
        public int[] SimilarJobPositionId { get; set; }
        public int[] RequiredCompetencyId { get; set; }
        public int[] HigherLevelCompetencyId { get; set; }
        public int[] SameLevelCompetencyId { get; set; }
        public int[] SameOrHigherLevelCompetencyId { get; set; }
        public int[] AddedCompetencyId { get; set; }
        public int[] CertificateId { get; set; }
        public double PercentMatch { get; set; }
    }

    public class GetAllSimilarJobPositionsByJobPositionIdQueryHandler : IQueryHandler<GetAllSimilarJobPositionsByJobPositionIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllSimilarJobPositionsByJobPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public async Task<List<JobPositionDto>> HandleAsync(GetAllSimilarJobPositionsByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var allPositionCompetencyRatings = await _db.JobRolePositionCompetencyRatings
            .Include(e => e.CompetencyRatingLevel)
            .Where(e =>
            e.JobPositionId == query.JobPositionId
            )
            .ToDictionaryAsync(k => k.CompetencyId, v => v.CompetencyRatingLevel.Value);

            var sameLevelCompetencies = allPositionCompetencyRatings.Where(e => query.SameLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var higherLevelCompetencies = allPositionCompetencyRatings.Where(e => query.HigherLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var sameOrHigherLevelCompetencies = allPositionCompetencyRatings.Where(e => query.SameOrHigherLevelCompetencyId.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var allPositionCompetencies = allPositionCompetencyRatings.Keys.ToList();
            var allCurrentCompetencies = allPositionCompetencies.Union(query.AddedCompetencyId.ToList());

            var allSimilarJobPositions = await _db.JobPositions.Where(e => query.SimilarJobPositionId.Contains(e.Id)).Select(e => e.Id
                                      ).ToArrayAsync(cancellationToken);

            var resultCertificates = (
                    await _db.JobRolePositionCertificates
                    .Include(e => e.Certificate).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobPositionId })
                .Select(g => new
                {
                    JobPositionId = g.Key.JobPositionId,
                    Certificates = g.Select(e => e.CertificateId).ToList()
                })
                .Where(e =>
                    query.CertificateId.Any() &&
                    query.CertificateId.All(sl => e.Certificates.Any(cr => cr == sl))
                    //&& e.JobPositionId != query.JobPositionId
                    );

            return (await _db.JobRolePositionCompetencyRatings.Where(e => allSimilarJobPositions.Contains(e.JobPositionId) && e.JobPosition.Active != 0)
                    .Include(e => e.JobPosition)
                    .Include(e => e.JobGroupLevel)
                    .Include(e => e.JobGroup)
                    .Include(e =>e.SubJobGroup)
                    .Include(e => e.CompetencyRatingLevel).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobGroup.Code, e.JobGroupLevel.LevelValue, e.SubJobGroup.SubCode, e.JobPositionId, e.JobPosition.TitleEng, e.JobPosition.TitleFre })
                .Select(g => new
                {
                    JobTitleEng = g.Key.TitleEng,
                    JobTitleFre = g.Key.TitleFre,
                    JobGroupCode = g.Key.Code,
                    SubGroupCode = g.Key.SubCode,
                    JobGroupId = g.Key.JobGroupId,
                    JobGroupLevelId = g.Key.JobGroupLevelId,
                    JobGroupLevel = g.Key.LevelValue,
                    JobPositionId = g.Key.JobPositionId,
                    CompetencyRatings = g.Select(e => new JobCompetencyRatingDto { CompetencyId = e.CompetencyId, RatingValue = e.CompetencyRatingLevel.Value }).ToList()
                })
                .Where(e =>
                    !query.RequiredCompetencyId.Any()
                    || e.CompetencyRatings.Any(s => query.RequiredCompetencyId.Contains(s.CompetencyId))
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
                    LevelCode = string.IsNullOrEmpty(e.SubGroupCode) ? e.JobGroupCode + '-' + e.JobGroupLevel : e.SubGroupCode + '-' + e.JobGroupLevel,
                    Active = 1
                }
                )
                //.Where(e => allCurrentCompetencies.Intersect(e.Competencies).ToList().Count / Convert.ToDouble(e.Competencies.ToList().Count) >= query.PercentMatch / 100 && e.JobTitleId != query.JobPositionId)
                .ToList();
        }
    }
}