using System.Collections.Generic;
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

        [HttpGet, Route("descriptions")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCertificateDescriptions()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCertificateDescriptionsQueryHandler, List<JobCertificateDto>>();
            return Ok(results);
        }

        [HttpGet, Route("descriptions/{Id}")]
        [ProducesResponseType(typeof(List<JobCertificateDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetJobCertificateDescriptionById([FromRoute] GetJobCertificateDescriptionByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addjobcertificate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddJobCertificate([FromBody] AddJobCertificateCommand query)

        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("addjobcertificatedescription")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddJobCertificate([FromBody] AddJobCertificateDescriptionCommand query)
        {
            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("deletejobcertificate")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteJobCertificate([FromBody] DeleteJobCertificateByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updatejobcertificate")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateJobCertificate([FromBody] UpdateJobCertificateCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("updatejobcertificatedescription")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateJobCertificateDescription([FromBody] UpdateJobCertificateDescriptionCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }

        [HttpPost, Route("deletejobcertificatedescription")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteJobCertificateDescription([FromBody] DeleteJobCertificateDescriptionByIdCommand command)
        {
            await _commandSender.ValidateAndSendAsync(command, ModelState);
            return Ok();
        }
    }
}