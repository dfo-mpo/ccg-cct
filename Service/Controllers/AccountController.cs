using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Queries.Account;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Service.Controllers
{
    [Route("api/account"), Authorize]
    public class AccountController : Controller
    {
        private readonly IQueryProcessor _queryProcessor;
        private readonly ICommandSender _commandSender;

        public AccountController(IQueryProcessor queryProcessor, ICommandSender commandSender)
        {
            _queryProcessor = queryProcessor;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(UserProfileDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProfile()
        {
            var profile = await _queryProcessor.ProcessAsync<GetUserProfileQueryHandler<ExampleDbContext>, UserProfileDto>();
            return Ok(profile);
        }
    }
}