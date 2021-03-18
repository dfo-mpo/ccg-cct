using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPositions
{
        public class GetAllJobCertificatesByJobPositionIdQuery : IQuery<List<JobCertificateDto>>
        {
            public int Id { get; set; }
        }
        public class GetAllJobCertificatesByJobPositionIdQueryHandler : IQueryHandler<GetAllJobCertificatesByJobPositionIdQuery, List<JobCertificateDto>>
        {

        private readonly CctDbContext _db;
        public GetAllJobCertificatesByJobPositionIdQueryHandler (CctDbContext db)
            {
                _db = db;
            }

            public Task<List<JobCertificateDto>> HandleAsync(GetAllJobCertificatesByJobPositionIdQuery query, CancellationToken cancellationToken = new CancellationToken())
            {
                return _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.Id)
                    .Include(e => e.Certificate)
                    .Include(e => e.CertificateDescription)
                    .Select(e => new JobCertificateDto()
                    {
                        Id = e.CertificateId,
                        NameEng = e.Certificate.NameEng,
                        NameFre = e.Certificate.NameFre,
                        DescEng = e.CertificateDescription.DescEng,
                        DescFre = e.CertificateDescription.DescFre,
                        

                    }).ToListAsync(cancellationToken);
            }
        }
    
}
