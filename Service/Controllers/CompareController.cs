using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.Shared;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Business.Queries.Compare;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/compare")]

    public class CompareController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public CompareController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("matching/competencies/{TypeId}/{PositionId}/{ObjectiveId}")]
        [ProducesResponseType(typeof(SharedJobCompetencyRating[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMatchingById([FromRoute] GetMatchingCompetenciesByComparedJobPositionsQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("differing/competencies/{TypeId}/{PositionId}/{ObjectiveId}")]
        [ProducesResponseType(typeof(SharedJobCompetencyRating[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDifferingById([FromRoute] GetDifferingCompetenciesByComparedJobPositionsQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("matching/certificates/{PositionId}/{ObjectiveId}")]
        [ProducesResponseType(typeof(JobCertificateDto[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMatchingCertificatesById([FromRoute] GetMatchingCertificatesByComparedJobPositionsQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
        [HttpGet, Route("differing/certificates/{PositionId}/{ObjectiveId}")]
        [ProducesResponseType(typeof(JobCertificateDto[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDifferingCertificatesById([FromRoute] GetDifferingCertificatesByComparedJobPositionsQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
    }

}

