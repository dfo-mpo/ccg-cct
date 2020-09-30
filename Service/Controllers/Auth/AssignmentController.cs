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
    [Route("api/auth/assignment")]
    public class AssignmentController : Controller
    {
        private readonly IQueryProcessor _queryProcessor;
        private readonly ICommandSender _commandSender;

        public AssignmentController(IQueryProcessor queryProcessor, ICommandSender commandSender)
        {
            _queryProcessor = queryProcessor;
            _commandSender = commandSender;
        }

        [HttpGet, Route(""), PrivilegeAuthorize("Auth_Assign_View")]
        [ProducesResponseType(typeof(AssignmentDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAssignments()
        {
            var results = await _queryProcessor.ProcessAsync<GetAssignmentsQueryHandler<ExampleDbContext>, AssignmentDto>();
            return Ok(results);
        }

        [HttpPost, Route(""), PrivilegeAuthorize("Auth_Assign_Manage")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddPrivilege([FromBody] AddSystemRolePrivilegeCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpDelete, Route(""), PrivilegeAuthorize("Auth_Assign_Manage")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemovePrivilege([FromBody] RemoveSystemRolePrivilegeCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

    }
}
