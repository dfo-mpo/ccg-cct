using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;


namespace Business.Queries.JobCertificates
{
    public class GetJobCertificateDescriptionByIdQuery : IQuery<JobCertificateDto>
    {
        public int Id { get; set; }
    }
    public class GetJobCertificateDescriptionByIdQueryHandler : IQueryHandler<GetJobCertificateDescriptionByIdQuery, JobCertificateDto>
    {
        private readonly CctDbContext _db;

        public GetJobCertificateDescriptionByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobCertificateDto> HandleAsync(GetJobCertificateDescriptionByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CertificateDescriptions.Where(e => e.Id == query.Id)

                .Select(e => new JobCertificateDto()
                {
                    Id = e.Id,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,
                    Active = e.Active

                }).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
