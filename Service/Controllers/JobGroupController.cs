using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Queries.JobGroups;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Common.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Queries.JobPositions;

namespace Service.Controllers
{

    [ApiController, AllowAnonymous, Route("api/jobgroups")]
    public class JobGroupController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;
        private readonly GetJobGroupByIdQuery jobGroupQuery = new GetJobGroupByIdQuery();
        private readonly GetJobGroupPositionsByIdQuery jobGroupPositionsQuery = new GetJobGroupPositionsByIdQuery();
        private readonly GetJobPositionsByLevelGroupIdQuery positionslevelgroupQuery = new GetJobPositionsByLevelGroupIdQuery();
        public JobGroupController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<JobGroupDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobGroupsQueryHandler, List<JobGroupDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobGroupDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int Id)
        {
            jobGroupQuery.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(jobGroupQuery);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/levels")]
        [ProducesResponseType(typeof(List<JobGroupPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetLevelsById(int Id)
        {
            jobGroupPositionsQuery.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(jobGroupPositionsQuery);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/levels/{level}/positions")]
        [ProducesResponseType(typeof(List<JobPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPositionsByGroupLevelId(int Id, int level)
        {
            positionslevelgroupQuery.Id = Id;
            positionslevelgroupQuery.level = level;
            var results =
                await _queryProvider.ProcessAsync(positionslevelgroupQuery);
            return Ok(results);
        }
    }
}
