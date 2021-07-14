using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Queries.JobPositions;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.Admin.JobPositions;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/jobpositions")]
    public class JobPositionController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public JobPositionController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<JobPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobPositionsQueryHandler, List<JobPositionDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobPositionDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] GetJobPositionByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("IdValues")]
        [ProducesResponseType(typeof(List<JobPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByIdValues(

          [FromQuery] int[] positionId)
        {
            var query = new GetJobPositionByIdValuesQuery
            {
                Id = positionId,

            };

            var result = await _queryProvider.ProcessAsync(query);
            return Ok(result);
        }

        [HttpGet, Route("{Id}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyRatingDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesById([FromRoute] GetJobCompetencyRatingsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/{competencytypeId}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesByTypeId([FromRoute] GetJobCompetenciesByTypeIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/certificates")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPositionCertificatesByGroupLevelId([FromRoute] GetAllJobCertificatesByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addjobposition")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCompetency([FromBody] AddJobPositionCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpGet, Route("postjobpositionreturnid/{TitleEng}/{TitleFre}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> PostJobPositionGetId([FromRoute] PostJobPositionCommandGetJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("updatejobposition")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task UpdateJobCompetency([FromBody] UpdateJobPositionCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("addjobrolepositioncompetency")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCompetency([FromBody] AddJobRolePositionCompetencyCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("addjobrolepositioncertificate")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCertificate([FromBody] AddJobRolePositionCertificateCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpGet, Route("getjobpositionid/{Title}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetJobPositionId([FromRoute] GetJobPositionIdByJobTitleQuery query)
        {
            var results =
                        await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addjobrolepositionlocation")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCertificate([FromBody] AddJobRolePositionLocationsCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("addjobrolepositionhlcategory")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCertificate([FromBody] AddJobRolePositionHLCategoryCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("deletejobposition")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task DeleteJobPosition([FromBody] DeleteJobPositionByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}
