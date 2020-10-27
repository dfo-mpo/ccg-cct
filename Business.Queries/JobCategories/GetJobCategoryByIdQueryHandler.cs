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

namespace Business.Queries.JobCategories
{
    public class GetJobCategoryByIdQuery : IQuery<JobCategoryDto>
    {
        public int JobCategoryId { get; set; }
    }

    public class GetJobCategoryByIdQueryHandler : IQueryHandler<GetJobCategoryByIdQuery,JobCategoryDto>
    {
        private readonly CctDbContext _db;

        public GetJobCategoryByIdQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<JobCategoryDto> HandleAsync(GetJobCategoryByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobCategory.Where(e => e.JobCategoryId == query.JobCategoryId)
                .Select(e => new JobCategoryDto()
                {
                    JobCategoryId = e.JobCategoryId,
                    JobCategoryValueEng = e.JobCategoryValueEng,
                    JobCategoryValueFra = e.JobCategoryValueFra
                }).FirstOrDefaultAsync(cancellationToken);

        }
    }
}