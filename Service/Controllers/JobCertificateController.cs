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

        [HttpGet, Route("addjobcertificate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddJobCertificate(

                [FromQuery] string nameEng,
                [FromQuery] string nameFre,
                [FromQuery] string descEng,
                [FromQuery] string descFre)

        {
            var query = new AddJobCertificateCommand
            {
                NameEng = nameEng,
                NameFre = nameFre,
                DescEng = descEng,
                DescFre = descFre,
            };

            var results =
            await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpGet, Route("addjobcertificatedescription/{DescEng}/{DescFre}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddJobCertificate([FromRoute] AddJobCertificateDescriptionCommand query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
                   return Ok(results);
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