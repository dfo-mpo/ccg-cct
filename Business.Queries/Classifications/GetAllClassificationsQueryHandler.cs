using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Classifications
{
    public class GetAllClassificationsQueryHandler : IQueryHandler<List<ClassificationDto>>
    {
        private readonly CctDbContext _db;

        public GetAllClassificationsQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<ClassificationDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Classification
                .Select(e => new ClassificationDto()
                {
                    Id = e.Id,
                    Code = e.Code,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre
                }).ToListAsync(cancellationToken);
        }
    }
}