using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Data.Classes.JobCompetencies;
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
                    .Select(e => new JobCertificateDto()
                    {
                        Id = e.CertificateId,
                        NameEng = e.Certificate.NameEng,
                        NameFre = e.Certificate.NameFre,
                        DescEng = e.Certificate.DescEng,
                        DescFre = e.Certificate.DescFre,
                        RequireIndicatorEng = e.Certificate.RequireIndicatorEng,
                        RequireIndicatorFre = e.Certificate.RequireIndicatorFre,
                    }).ToListAsync(cancellationToken);
            }
        }
    
}
