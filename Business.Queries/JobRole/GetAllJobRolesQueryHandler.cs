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


namespace Business.Queries.JobRole
{
    public class JobRoleDto
    {
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
        public int ClassificationLevelId { get; set; }
        public string ClassificationLevel { get; set; }
    }

    public class GetAllJobRolesQueryHandler : IQueryHandler<List<JobRoleDto>>
    {
        private readonly CctDbContext _db;

        public GetAllJobRolesQueryHandler(CctDbContext db)
        {
            _db = db;
        }

        public Task<List<JobRoleDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
          return _db.JobGroupPositions
                .Select(e => new JobRoleDto()
                {
                    /*ClassificationId = e.JobGroup.Id,
                    ClassificationName = e.JobGroup.ClassificationName,
                    ClassificationLevelId = e.JobGroupLevel.Id,
                    ClassificationLevel = e.JobGroupLevel.ClassificationLevel */
                }).ToListAsync(cancellationToken);
        } 
    }
}
