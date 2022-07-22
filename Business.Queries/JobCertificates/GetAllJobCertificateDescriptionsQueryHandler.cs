using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCertificates
{
    public class GetAllJobCertificateDescriptionsQueryHandler : IQueryHandler<List<JobCertificateDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCertificateDescriptionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCertificateDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CertificateDescriptions
                .Select(e => new JobCertificateDto()
                {
                    Id = e.Id,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,
                    Active = e.Active,
                    CertificateDescEng = e.DescEng,
                    CertificateDescFre = e.DescFre
                })
                .ToListAsync(cancellationToken);

        }
    }
}
