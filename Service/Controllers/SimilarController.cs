using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Queries.Similar;


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
            
            [FromQuery] int   jobPositionId, 
            [FromQuery] int[] sameLevelCompetencyId,
            [FromQuery] int[] higherLevelCompetencyId,
            [FromQuery] int[] sameOrHigherLevelCompetencyId,
            [FromQuery] int[] addedCompetencyId,
            [FromQuery] int[] certificateId,
            [FromQuery] double   percentMatch)
        {
            var query = new GetAllSimilarPositionsByPositionIdQuery
            {
                JobPositionId = jobPositionId,
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
    }
}
