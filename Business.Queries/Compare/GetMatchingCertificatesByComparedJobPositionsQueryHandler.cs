﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.JobCompetencies;

namespace Business.Queries.Compare
{
    public class GetMatchingCertificatesByComparedJobPositionsQuery : IQuery<List<JobCertificateDto>>
    {
        public int PositionId { get; set; }
        public int ObjectiveId { get; set; }
    }

    public class GetMatchingCertificatesByComparedJobPositionsQueryHandler : IQueryHandler<GetMatchingCertificatesByComparedJobPositionsQuery, List<JobCertificateDto>>
    {
        private readonly CctDbContext _db;

        public GetMatchingCertificatesByComparedJobPositionsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCertificateDto>> HandleAsync(GetMatchingCertificatesByComparedJobPositionsQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return (from pos in _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.PositionId && e.Certificate.Active != 0)
                    join obj in _db.JobRolePositionCertificates.Where(e => e.JobPositionId == query.ObjectiveId && e.Certificate.Active != 0)
                    on pos.CertificateId equals obj.CertificateId
                    orderby obj.CertificateId
                    select new JobCertificateDto()
                    {
                        NameEng = pos.Certificate.NameEng,
                        NameFre = pos.Certificate.NameFre,
                        DescEng = pos.CertificateDescription.DescEng,
                        DescFre = pos.CertificateDescription.DescFre,
                        Id = pos.CertificateId,
                        CertificateDescEng = pos.Certificate.DescEng,
                        CertificateDescFre = pos.Certificate.DescFre,
                        Active = 1

                    }).ToListAsync(cancellationToken);
        }

    }
}