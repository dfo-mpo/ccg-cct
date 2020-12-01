using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Queries.JobGroups;
using Data.Classes.JobPositions;
using Data.Classes.JobGroups;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Service.Controllers
{

    [ApiController, AllowAnonymous, Route("api/jobgroups")]
    public class JobGroupController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

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
        public async Task<IActionResult> GetById([FromRoute]GetJobGroupByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/levels")]
        [ProducesResponseType(typeof(List<JobGroupPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetLevelsById([FromRoute]GetJobGroupPositionsByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/levels/{level}/positions")]
        [ProducesResponseType(typeof(List<JobPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPositionsByGroupLevelId([FromRoute]GetJobPositionsByLevelGroupIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
    }
}
