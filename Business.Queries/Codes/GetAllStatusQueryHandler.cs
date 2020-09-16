using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Models;
using DataModel;
using DataModel.CodeTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Codes
{
    public class GetAllStatusQueryHandler : IQueryHandler<IEnumerable<StatusDto>>
    {
        private readonly ExampleDbContext _db;

        public GetAllStatusQueryHandler(ExampleDbContext db)
        {
            _db = db;
        }

        private static StatusDto ToDto(Status node, List<Status> allNodes)
        {
            if (node == null) return null;

            var dto = new StatusDto
            {
                Id = node.Id,
                Code = node.Code,
                En = node.DescEng,
                Fr = node.DescFre,
                IsActive = node.IsActive,
                SortOrder = node.SortOrder,
            };

            if (allNodes.Any(e => e.ParentStatusId == node.Id))
            {
                dto.Children = allNodes.Where(e => e.ParentStatusId == node.Id).Select(child => ToDto(child, allNodes)).ToList();
            }
            return dto;
        }

        public async Task<IEnumerable<StatusDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var allParties = await _db.Statuses.Where(e => e.IsActive).ToListAsync(cancellationToken: cancellationToken);
            var rootNodes = allParties.Where(e => !e.ParentStatusId.HasValue);
            return rootNodes.Select(e => ToDto(e, allParties));
        }
    }

    public class StatusDto : LocalizedCodeManager
    {
        public IList<StatusDto> Children { get; set; }
    }
}