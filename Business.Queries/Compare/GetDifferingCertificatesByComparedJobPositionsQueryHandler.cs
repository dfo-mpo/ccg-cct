using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.Shared;

namespace Business.Queries.Compare
{
    public class GetDifferingCertificatesByComparedJobPositionsQuery : IQuery<List<SharedJobCertificateDto>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
    }

    public class GetDifferingCertificatesByComparedJobPositionsQueryHandler : IQueryHandler<GetDifferingCertificatesByComparedJobPositionsQuery, List<SharedJobCertificateDto>>
    {
        private readonly CctDbContext _db;

        public GetDifferingCertificatesByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<SharedJobCertificateDto>> HandleAsync(GetDifferingCertificatesByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var currentcertificateIds = _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.PositionId && e.Certificate.Active != 0)
                .Select(e=>e.CertificateId)
                .ToList();

            var objectivecertificateIds = _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.ObjectiveId && e.Certificate.Active != 0)
                .Select(e => e.CertificateId)
                .ToList();

            var currentcertificates = _db.JobRolePositionCertificates
                .Where(e => e.JobPositionId == query.PositionId)
                .Where(e => currentcertificateIds.Contains(e.CertificateId))
                .Where(e=>!objectivecertificateIds.Contains(e.CertificateId))
                 .Include(e => e.Certificate) 
                 .Include(e=>e.CertificateDescription)
                 .Select(e => new SharedJobCertificateDto()
                 {
                     NameEng = e.Certificate.NameEng,
                     NameFre = e.Certificate.NameFre,
                     DescEng = e.CertificateDescription.DescEng,
                     DescFre = e.CertificateDescription.DescFre,
                     Id = e.CertificateId,
                     Active = 1,
                     CurrentPositionHas = "✔",
                     ObjectivePositionHas = "x",

                 });

            var objectivecertificates = _db.JobRolePositionCertificates
               .Where(e => e.JobPositionId == query.ObjectiveId)
               .Where(e => !currentcertificateIds.Contains(e.CertificateId))
               .Where(e => objectivecertificateIds.Contains(e.CertificateId))
                .Include(e => e.Certificate)
               .Include(e => e.CertificateDescription)
              .Select(e => new SharedJobCertificateDto()
                      {
                         NameEng = e.Certificate.NameEng,
                         NameFre = e.Certificate.NameFre,
                         DescEng = e.CertificateDescription.DescEng,
                         DescFre = e.CertificateDescription.DescFre,
                         Id = e.CertificateId,
                         Active = 1,
                         CurrentPositionHas = "x",
                         ObjectivePositionHas = "✔",

                      });

            return currentcertificates.Union(objectivecertificates).ToListAsync(cancellationToken);


        }
    }
}