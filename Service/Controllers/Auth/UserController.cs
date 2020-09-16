using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Commands.Auth;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Queries.Auth;
using CCG.AspNetCore.Web.Authorization;
using DataModel;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers.Auth
{
    [Route("api/auth/[controller]")]
    public class UserController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProcessor;

        public UserController(ICommandSender commandSender, IQueryProcessor queryProcessor)
        {
            _commandSender = commandSender;
            _queryProcessor = queryProcessor;
        }

        [HttpGet, Route(""), PrivilegeAuthorize("Auth_User_View")]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Index()
        {
            var results = await _queryProcessor.ProcessAsync<GetAllUsersQueryHandler<ExampleDbContext>, IEnumerable<UserDto>>();
            return Ok(results);
        }

        [HttpPost, Route(""), PrivilegeAuthorize("Auth_User_Manage")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> Add([FromBody] InviteNewUserAccountCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPut, Route("{userId}"), PrivilegeAuthorize("Auth_User_Manage")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> Save(Guid userId, [FromBody] SaveUserCommand command)
        {
            if (command.Id != userId)
            {
                ModelState.AddModelError(nameof(command.Id), Core.Resources.Validation.RouteParameterMustMatchFormDataParameter);
                return BadRequest(ModelState);
            }

            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}