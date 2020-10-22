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
    public class GetAllJobCategoriesValuesQueryHandler : IQueryHandler<List<string>>
    {
        private readonly CctDbContext _db;

    public GetAllJobCategoriesValuesQueryHandler(CctDbContext db)
    {
        _db = db;
    }

    public Task<List<string>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
     {
            return _db.JobCategory
                .Select(e => 
                    e.JobCategoryValueEng
                ).ToListAsync(cancellationToken);
     }
    }
}
