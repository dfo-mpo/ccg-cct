﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using Business.Dtos.JobPositions;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Dtos.Shared;
using Business.Queries.Similar;
using System.Linq;


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
            [FromQuery] int   jobGroupLevelId,
            [FromQuery] int   jobGroupId,
            [FromQuery] int[] sameLevelCompetencyId,
            [FromQuery] int[] higherLevelCompetencyId,
            [FromQuery] int[] certificateId)
        {
            var query = new GetAllSimilarPositionsByPositionIdQuery
            {
                JobGroupId = jobGroupId,
                JobGroupLevelId = jobGroupLevelId,
                JobPositionId = jobPositionId,
                SameLevelCompetencyId = sameLevelCompetencyId,
                HigherLevelCompetencyId = higherLevelCompetencyId,
                CertificateId = certificateId
            };

            var result = await _queryProvider.ProcessAsync(query);
            return Ok(result);
        }
    }
}