using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Queries.JobPositions;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Queries.JobCompetencies;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/jobcompetency")]
    public class JobCompetencyController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public JobCompetencyController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("types")]
        [ProducesResponseType(typeof(JobCompetencyDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllTypes()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCompetencyTypesQueryHandler, List<JobCompetencyDto>>();
            return Ok(results);
        }
    }
}
