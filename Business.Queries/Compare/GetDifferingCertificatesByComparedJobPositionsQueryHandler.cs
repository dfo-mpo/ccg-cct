using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;

namespace Business.Queries.Compare
{
    public class GetDifferingCertificatesByComparedJobPositionsQuery : IQuery<List<JobCertificateDto>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
    }

    public class GetDifferingCertificatesByComparedJobPositionsQueryHandler : IQueryHandler<GetDifferingCertificatesByComparedJobPositionsQuery, List<JobCertificateDto>>
    {
        private readonly CctDbContext _db;

        public GetDifferingCertificatesByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCertificateDto>> HandleAsync(GetDifferingCertificatesByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            var currentcertificates = _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.PositionId)
                .Select(e=>e.CertificateId)
                .ToList();
            return _db.JobRolePositionCertificates
                .Where(e => e.JobPositionId == query.ObjectiveId)
                .Where(e=>!currentcertificates.Contains(e.CertificateId))
                 .Include(e => e.Certificate) 
                 .Include(e=>e.CertificateDescription)
                 .Select(e => new JobCertificateDto()
                 {
                     NameEng = e.Certificate.NameEng,
                     NameFre = e.Certificate.NameFre,
                     DescEng = e.CertificateDescription.DescEng,
                     DescFre = e.CertificateDescription.DescFre,
                     Id = e.CertificateId

                 }).ToListAsync(cancellationToken);           
        }
    }
}