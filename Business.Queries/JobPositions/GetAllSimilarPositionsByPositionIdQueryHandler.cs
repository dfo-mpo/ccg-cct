using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;

namespace Business.Queries.JobPositions
{
    public class GetAllSimilarPositionsByPositionIdQuery : IQuery<List<JobPositionDto>>
    {
        public int JobGroupId { get; set; }
        public int JobGroupLevelId { get; set; }
        public int JobPositionId { get; set; }
        public int[] HigherLevels { get; set; }
        public int[] SameLevels { get; set; }
        public int[] Certificates { get; set; }
        public int[] HigherLevelCompetencyId { get; set; }
        public int[] SameLevelCompetencyId { get; set; }
        public int[] CertificateId { get; set; }
    }

    public class GetAllSimilarPositionsByPositionIdQueryHandler : IQueryHandler<GetAllSimilarPositionsByPositionIdQuery, List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllSimilarPositionsByPositionIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Assume each JobRolePosition only has one competency type per competency
        /// </summary>
        /// <param name="query"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<List<JobPositionDto>> HandleAsync(GetAllSimilarPositionsByPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var allPositionCompetencyRatings = await GetAllJobRolePositionCompetencyRating(query, cancellationToken);
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
                    JobPositionId = e.JobPositionId,
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
                    JobPositionId = e.JobPositionId,
                });

            //.Select(e => new JobPositionDto()
            //    {
            //        // JobGroupId = e.JobGroupId,
            //        JobGroupId= e.JobGroupId,
            //        JobPositionId = e.JobPositionId,
            //        JobGroupLevelId = e.JobGroupLevelId
            //        //JobLevelValue = e.JobGroupLevel.LevelValue,
            //        //JobGroupCode = e.JobGroup.Code,
            //        //JobGroupTitleEng = e.JobGroup.NameEng,
            //        //JobGroupTitleFre = e.JobGroup.NameFre,
            //        //JobGroupLevelId = e.JobGroupLevelId,
            //        //JobGroupLevelValue = e.JobGroupLevel.LevelValue,
            //        //JobTitleId = e.JobPositionId,
            //        //JobTitleFre = e.JobPosition.TitleFre,
            //        //JobTitleEng = e.JobPosition.TitleEng
            //    })
            //    .ToList();

            //var result = await _db.JobGroupPositions
            //      .Where(
            //          jgp => !sameLevelComptencies.Any() ||
            //              sameLevelComptencies.All(sl => jgp.JobPosition.JobRolePositionCompetencies
            //                  .SelectMany(c => c.Competency.JobRolePositionCompetencyRatings)
            //                  .Any(jrpcr => jrpcr.CompetencyId == sl.CompetencyId && jrpcr.CompetencyRatingLevel.Value == sl.RatingLevelValue)
            //                )
            //              )
            //      .Select(e => new JobPositionDto()
            //      {
            //          JobPositionId = e.JobPositionId,
            //          JobGroupLevelId = e.JobGroupLevelId
            //      })
            //      .ToListAsync(cancellationToken);


            //var resultQuery = _db.JobRolePositionCompetencyRatings
            //    //.Include(e => e.Competency)
            //    .Include(e => e.CompetencyRatingLevel)
            //    //.Include(e => e.JobGroup)
            //    //.Include (e => e.JobPosition)
            //   // .Where(e => e.JobPositionId == query.Id)
            //    .Where(e => query.SameLevels.All(sl => e.CompetencyRatingLevel.Value  ==sl ))
            //     .Where(e => query.HigherLevels.All(sl => e.CompetencyRatingLevel.Value > sl))
            //   .Where(e => query.CompetencyId.All(sl => e.CompetencyId ==sl))
            //   .Where(e=>query.CompetencyTypeId.All(s1=>e.CompetencyTypeId==s1))




            return resultCompetencies.Union(resultCertificates).ToList();
        }

        private async Task<Dictionary<int, int>> GetAllJobRolePositionCompetencyRating(GetAllSimilarPositionsByPositionIdQuery query, CancellationToken cancellationToken)
        {
            return await _db.JobRolePositionCompetencyRatings
                .Include(e=>e.CompetencyRatingLevel)
                .Where(e =>
                e.JobPositionId == query.JobPositionId
                    && e.JobGroupLevelId == query.JobGroupLevelId
                    && e.JobGroupId == query.JobGroupId)
                .ToDictionaryAsync(k => k.CompetencyId, v => v.CompetencyRatingLevel.Value);
        }

        //private async Task<List<int>> GetAllJobRolePositionCertificates(GetAllSimilarPositionsByPositionIdQuery query, CancellationToken cancellationToken)
        //{
        //    return await _db.JobRolePositionCertificates
        //       .Where(e =>

        //       e.JobPositionId == query.JobPositionId
        //            && e.JobGroupLevelId == query.JobGroupLevelId
        //            && e.JobGroupId == query.JobGroupId
        //            )
        //        .Select(e => e.CertificateId)
        //        .ToListAsync(cancellationToken);
        //}


    }
}