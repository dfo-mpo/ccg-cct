﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dtos.JobCompetencies;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Commands.Admin.JobCertificates;
using Business.Queries.JobCertificates;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/jobcertificates")]
    public class JobCertificateController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public JobCertificateController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCertificatesQueryHandler, List<JobCertificateDto>>();
            return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobCertificateDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute] GetJobCertificateByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("certificatedescriptions")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCertificateDescriptions()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCertificateDescriptionsQueryHandler, List<JobCertificateDto>>();
            return Ok(results);
        }
        [HttpPost, Route("addjobcertificate")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCertificate([FromBody] AddJobCertificateCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("addjobcertificatedescription")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task AddJobCertificate([FromBody] AddJobCertificateDescriptionCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("deletejobcertificate")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task DeleteJobCertificate([FromBody] DeleteJobCertificateByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPost, Route("updatejobcertificate")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task UpdateJobCertificate([FromBody] UpdateJobCertificateCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
        [HttpPost, Route("updatejobcertificatedescription")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task UpdateJobCertificateDescription([FromBody] UpdateJobCertificateDescriptionCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}