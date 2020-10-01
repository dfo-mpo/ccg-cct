using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Commands.Classifications;
using Business.Queries.Classifications;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Common.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/classification")]
    public class ClassificationController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public ClassificationController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<ClassificationDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllClassificationsQueryHandler, List<ClassificationDto>>();
             return Ok(results);
        }

        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(ClassificationDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById([FromRoute]GetClassificationByIdQuery query)
        {
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }

        [HttpPost, Route("")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> Add([FromBody]AddClassificationCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }

        [HttpPut, Route("{id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update(Guid id, [FromBody]UpdateClassificationCommand command)
        {
            if (command.Id == id) return await _commandSender.ValidateAndSendAsync(command, ModelState);
            ModelState.AddModelError("Id", ValidationMessages.RouteParameterMustMatchFormDataParameter);
            return BadRequest(ModelState);
        }

        [HttpDelete, Route("{Id}")]
        [ProducesResponseType(typeof(void), StatusCodes.Status200OK)]
        public async Task<IActionResult> Remove([FromRoute]RemoveClassificationCommand command)
        {
            return await _commandSender.ValidateAndSendAsync(command, ModelState);
        }
    }
}
