using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Queries.Codes;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Models;
using CCG.AspNetCore.Web.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers.Code
{
    [ApiController, Route("api/code/[controller]"), AllowAnonymous]
    public class StatusController : Controller
    {
        private readonly IQueryProcessor _queryProcessor;

        public StatusController(IQueryProcessor queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(IEnumerable<LocalizedCodeManager>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results = await _queryProcessor.ProcessAsync<GetAllStatusQueryHandler, IEnumerable<StatusDto>>();
            return Ok(results);
        }

    }
}