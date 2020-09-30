using System;
using System.Collections.Generic;
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
    public class GetClassificationByIdQuery : IQuery<ClassificationDto>
    {
        public Guid Id { get; set; }
    }

    public class GetClassificationByIdQueryHandler : IQueryHandler<GetClassificationByIdQuery, ClassificationDto>
    {
        private readonly ExampleDbContext _db;

        public GetClassificationByIdQueryHandler(ExampleDbContext db)
        {
            _db = db;
        }

        public Task<ClassificationDto> HandleAsync(GetClassificationByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Classifications.Where(e => e.Id == query.Id)
                .Select(e => new ClassificationDto()
                {
                    Id = e.Id,
                    Code = e.Code,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
