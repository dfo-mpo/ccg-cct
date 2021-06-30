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

        [HttpGet, Route("addjobcompetency")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddJobCompetency(
                [FromQuery] int typeId,
                [FromQuery] string nameEng,
                [FromQuery] string nameFre,
                [FromQuery] string  descEng,
                [FromQuery] string  descFre,
                [FromQuery] string level1DescEng,
                [FromQuery] string level1DescFre,
                [FromQuery] string level2DescEng,
                [FromQuery] string level2DescFre,
                [FromQuery] string level3DescEng,
                [FromQuery] string level3DescFre,
                [FromQuery] string level4DescEng,
                [FromQuery] string level4DescFre,
                [FromQuery] string level5DescEng,
                [FromQuery] string level5DescFre)
        {
            var query = new AddJobCompetencyCommand
            {
                TypeId = typeId,
                NameEng = nameEng,
                NameFre = nameFre,
                DescEng = descEng,
                DescFre = descFre,
                Level1DescEng = level1DescEng,
                Level1DescFre = level1DescFre,
                Level2DescEng = level2DescEng,
                Level2DescFre = level2DescFre,
                Level3DescEng = level3DescEng,
                Level3DescFre = level3DescFre,
                Level4DescEng = level4DescEng,
                Level4DescFre = level4DescFre,
                Level5DescEng = level5DescEng,
                Level5DescFre = level5DescFre,

            };

            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("deletejobcompetency")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task DeleteJobCompetency([FromBody] DeleteJobCompetencyByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("updatejobcompetency")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task UpdateJobCompetency([FromBody] UpdateJobCompetencyCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}