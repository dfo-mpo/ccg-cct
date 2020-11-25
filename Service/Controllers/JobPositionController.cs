using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Queries.JobPositions;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Common.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataModel;

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

        [HttpGet, Route("{Id}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyRatingDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesById([FromRoute]GetJobCompetencyRatingsByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/{competencytypeId}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesByTypeId([FromRoute]GetJobCompetenciesByTypeIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/certificates")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPositionCertificatesByGroupLevelId([FromRoute]GetAllJobCertificatesByJobPositionIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

    }
}
