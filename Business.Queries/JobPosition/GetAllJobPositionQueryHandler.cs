using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using DataModel;
using System.Threading.Tasks;
using CCG.AspNetCore;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.JobPosition
{
    public class JobPositionDto
    {
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public int ClassificationLevelId { get; set; }
        public string ClassificationLevel { get; set; }
        public int JobPositionId { get; set; }
        public string JobPositionNameEng { get; set; }
        public string JobPositionNameFre { get; set; }
    }

    public class GetAllJobPositionQueryHandler : IQueryHandler<List<JobPositionDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobPositionQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobPositionDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.JobGroupPositions
                  .Select(e => new JobPositionDto()
                  {
                      //
                    
                  }).ToListAsync(cancellationToken);
        }

    }
}
