using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Queries.JobCompetencies;
using Business.Commands.Admin.JobCompetencies;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/jobcompetencies")]
    public class JobCompetencyController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;
        public JobCompetencyController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<JobCompetencyDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCompetenciesQueryHandler, List<JobCompetencyDto>>();
            return Ok(results);
        }

        [HttpGet, Route("types")]
        [ProducesResponseType(typeof(JobCompetencyTypeDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllTypes()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCompetencyTypesQueryHandler, List<JobCompetencyTypeDto>>();
            return Ok(results);
        }

        [HttpGet, Route("types/{TypeId}")]
        [ProducesResponseType(typeof(List<JobCompetencyTypeDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCompetenciesByTypeId([FromRoute] GetJobCompetencyTypeByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{TypeId}/jobcompetencies")]
        [ProducesResponseType(typeof(List<JobCompetencyDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCompetenciesByTypeId([FromRoute] GetAllJobCompetenciesByTypeIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobCompetencyDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetJobCompetencyById([FromRoute] GetJobCompetencyByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("{Id}/{LevelId}")]
        [ProducesResponseType(typeof(JobCompetencyRatingDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetJobCompetencyLevelRequirementByIdLevelId([FromRoute] GetJobCompetencyLevelRequirementByIdLevelIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("{Id}/{Value}/description")]
        [ProducesResponseType(typeof(JobCompetencyRatingDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetJobCompetencyLevelRequirementByIdLevelId([FromRoute] GetJobCompetencyLevelRequirementDescriptionByIdLevelValueQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpPost, Route("addjobcompetency")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCompetency([FromBody] AddJobCompetencyCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
        [HttpDelete, Route("deletejobcompetency")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteJobCompetency([FromQuery] DeleteJobCompetencyByIdCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}