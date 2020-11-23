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
        private readonly GetJobPositionByIdQuery jobPositionQuery = new GetJobPositionByIdQuery();
        private readonly GetJobCompetencyRatingsByJobPositionIdQuery competenciesbyJobIdQuery = new GetJobCompetencyRatingsByJobPositionIdQuery();
        private readonly GetJobCompetenciesByTypeIdQuery competenciesType = new GetJobCompetenciesByTypeIdQuery();
        private readonly GetAllJobCertificatesByJobPositionIdQuery positioncertificatesQuery = new GetAllJobCertificatesByJobPositionIdQuery();


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
        public async Task<IActionResult> GetById(int Id)
        {
            jobPositionQuery.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(jobPositionQuery);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyRatingDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesById(int Id)
        {
            competenciesbyJobIdQuery.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(competenciesbyJobIdQuery);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/{competencytypeId}/competencies")]
        [ProducesResponseType(typeof(List<JobCompetencyDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCompetenciesByTypeId(int Id, int competencytypeId)
        {
            competenciesType.TypeId = competencytypeId;
            var results =
                await _queryProvider.ProcessAsync(competenciesType);
            return Ok(results);
        }

        [HttpGet, Route("{Id}/certificates")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetPositionCertificatesByGroupLevelId(int Id, int level)
        {
            positioncertificatesQuery.Id = Id;
            var results =
                await _queryProvider.ProcessAsync(positioncertificatesQuery);
            return Ok(results);
        }

    }
}
