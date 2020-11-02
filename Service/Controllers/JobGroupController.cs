using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Business.Commands.Classifications;
using Business.Queries.JobGroups;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Common.Resources;
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

        public GetJobGroupByIdQuery query = new GetJobGroupByIdQuery();
        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobCategoryDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int Id)
        {
            query.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
    }
}
