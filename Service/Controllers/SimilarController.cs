using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Queries.Similar;
using Business.Dtos.Similar;
using Business.Commands.Admin.Similar;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/similar")]
    public class SimilarController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public SimilarController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("positions")]
        [ProducesResponseType(typeof(List<JobPositionDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllSimilarPositionsByPositionId(

            [FromQuery] int jobPositionId,
            [FromQuery] int[] positionId,
            [FromQuery] int[] requiredCompetencyId,
            [FromQuery] int[] sameLevelCompetencyId,
            [FromQuery] int[] higherLevelCompetencyId,
            [FromQuery] int[] sameOrHigherLevelCompetencyId,
            [FromQuery] int[] addedCompetencyId,
            [FromQuery] int[] certificateId,
            [FromQuery] double percentMatch)
        {
            var query = new GetAllSimilarJobPositionsByJobPositionIdQuery
            {
                JobPositionId = jobPositionId,
                SimilarJobPositionId = positionId,
                RequiredCompetencyId = requiredCompetencyId,
                SameLevelCompetencyId = sameLevelCompetencyId,
                HigherLevelCompetencyId = higherLevelCompetencyId,
                SameOrHigherLevelCompetencyId = sameOrHigherLevelCompetencyId,
                AddedCompetencyId = addedCompetencyId,
                CertificateId = certificateId,
                PercentMatch = percentMatch
            };

            var result = await _queryProvider.ProcessAsync(query);
            return Ok(result);
        }
        [HttpGet, Route("ids")]
        [ProducesResponseType(typeof(List<int>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllSearchSimilarJobsPositionIdsQueryHandler, List<int>>();
            return Ok(results);
        }
        [HttpPost, Route("updatesimilarjobpositions")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task UpdateSimilarPositions([FromBody] UpdateSimilarPositionsCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("addsimilarjobpositions")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddSimilarPositions([FromBody] AddSimilarPositionsCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpGet, Route("hundredpercentsimilarjobpositions/{JobPositionId}")]
        [ProducesResponseType(typeof(SimilarSearchDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetHundredPercentSimilar([FromRoute] GetAllOneHundredPercentSimilarJobPositionsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("ninetypercentsimilarjobpositions/{JobPositionId}")]
        [ProducesResponseType(typeof(SimilarSearchDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetNinetyPercentSimilar([FromRoute] GetAllNinetyPercentSimilarJobPositionsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("eightypercentsimilarjobpositions/{JobPositionId}")]
        [ProducesResponseType(typeof(SimilarSearchDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSeventyPercentSimilar([FromRoute] GetAllEightyPercentSimilarJobPositionsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("seventypercentsimilarjobpositions/{JobPositionId}")]
        [ProducesResponseType(typeof(SimilarSearchDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSeventyPercentSimilar([FromRoute] GetAllSeventyPercentSimilarJobPositionsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
    }
}
