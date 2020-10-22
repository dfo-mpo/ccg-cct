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

namespace Business.Queries.JobCategories
{
    public class GetAllJobCategoriesQueryHandler : IQueryHandler<List<JobCategoryDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobCategoriesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobCategoryDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobCategory
                .Select(e => new JobCategoryDto()
                {
                    JobCategoryId = e.JobCategoryId,
                    JobCategoryValueEng = e.JobCategoryValueEng,
                    JobCategoryValueFra = e.JobCategoryValueFra
                }).ToListAsync(cancellationToken);
        }
    }
}
