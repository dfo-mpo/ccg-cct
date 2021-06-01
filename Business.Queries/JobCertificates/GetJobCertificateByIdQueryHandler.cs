using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobCertificates
{
    public class GetJobCertificateByIdQuery : IQuery<JobCertificateDto>
    {
        public int Id { get; set; }
    }
    public class GetJobCertificateByIdQueryHandler : IQueryHandler<GetJobCertificateByIdQuery, JobCertificateDto>
    {
        private readonly CctDbContext _db;

        public GetJobCertificateByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobCertificateDto> HandleAsync(GetJobCertificateByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Certificates.Where(e => e.Id == query.Id)

                .Select(e => new JobCertificateDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
