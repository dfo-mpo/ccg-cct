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
    public class GetAllJobCertificatesQueryHandler : IQueryHandler<List<JobCertificateDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCertificatesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCertificateDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Certificates
                .Select(e => new JobCertificateDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,
                })
                .ToListAsync(cancellationToken);

        }
    }
}