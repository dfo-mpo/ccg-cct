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
using HybridModelBinding;

namespace Business.Queries.Similar
{
    [HybridBindClass(defaultBindingOrder: new[] { Source.Route, Source.QueryString } )]
    public class GetAllSimilarPositionsByPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobPositionId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int JobGroupId { get; set; }
        public int[] HigherLevels { get; set; }
        public int[] SameLevels { get; set; }
        public int[] Certificates { get; set; }
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

            var sameLevelCompetencies = allPositionCompetencyRatings.Where(e => query.SameLevels.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);
            var higherLevelCompetencies = allPositionCompetencyRatings.Where(e => query.HigherLevels.Any(sl => sl == e.Key)).ToDictionary(k => k.Key, v => v.Value);

            var resultCertificates = (
                    await _db.JobRolePositionCertificates
                    .Include(e => e.Certificate).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobPositionId })
                 .Select(g => new
                 {
                     JobGroupId = g.Key.JobGroupId,
                     JobGroupLevelId = g.Key.JobGroupLevelId,
                     JobPositionId = g.Key.JobPositionId,
                     Certificates = g.ToList()
                 })
                .Where(e =>
                    !query.Certificates.Any() ||
                    query.Certificates.All(sl => e.Certificates.Any(cr => cr.CertificateId == sl))
                )
                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobTitleId = e.JobPositionId,
                });

            var resultCompetencies = (
                    await _db.JobRolePositionCompetencyRatings
                    .Include(e => e.CompetencyRatingLevel).ToListAsync()
                )
                .GroupBy(e => new { e.JobGroupId, e.JobGroupLevelId, e.JobPositionId })
                .Select(g => new
                {
                    JobGroupId = g.Key.JobGroupId,
                    JobGroupLevelId = g.Key.JobGroupLevelId,
                    JobPositionId = g.Key.JobPositionId,
                    CompetencyRatings = g.ToList()
                })
                .Where(e =>
                    !sameLevelCompetencies.Any()
                    || sameLevelCompetencies.All(
                            sl => e.CompetencyRatings.Any(cr => cr.CompetencyRatingLevel.Value == sl.Value
                                && cr.CompetencyId == sl.Key)))
                .Where(e =>
                    !higherLevelCompetencies.Any()
                    || higherLevelCompetencies.All(
                            sl => e.CompetencyRatings.Any(cr => cr.CompetencyRatingLevel.Value > sl.Value
                                && cr.CompetencyId == sl.Key)))

                .Select(e => new JobPositionDto()
                {
                    JobGroupId = e.JobGroupId,
                    JobGroupLevelId = e.JobGroupLevelId,
                    JobTitleId = e.JobPositionId,
                });

            return resultCompetencies.Union(resultCertificates).ToList();
        }
    }
}