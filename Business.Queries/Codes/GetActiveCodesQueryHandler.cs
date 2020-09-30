using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Models;
using CCG.AspNetCore.Data.Interface;
using DataModel;
using DataModel.CodeTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Codes
{
    public class GetActiveCodesQueryHandler<TModel> : IQueryHandler<IEnumerable<LocalizedCodeManager>>
        where TModel : class, ICodeEntity
    {
        private readonly ExampleDbContext _db;

        public GetActiveCodesQueryHandler(ExampleDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<LocalizedCodeManager>> HandleAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _db.Set<TModel>()
                .Where(e => e.IsActive)
                .Select(e => new LocalizedCodeManager()
                {
                    Id = e.Id,
                    Code = e.Code,
                    En = e.DescEng,
                    Fr = e.DescFre,
                    IsActive = e.IsActive,
                    SortOrder = e.SortOrder
                }).ToListAsync(cancellationToken);
        }
    }}