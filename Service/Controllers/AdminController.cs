using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Commands.Admin;
using Business.Dtos.Shared;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace Service.Controllers
{
    [ApiController, AllowAnonymous, Route("api/admin")]
    public class AdminController : Controller
    {
        private readonly ICommandSender _commandSender;

        public AdminController(ICommandSender commandSender)
        {
            _commandSender = commandSender;
        }

        [HttpGet, Route("reseed")]
        [ProducesResponseType(typeof(Task<IActionResult>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Reseed()
        {
            await _commandSender.ValidateAndSendAsync(new ReseedDataCommand(), ModelState);
            return Ok();
        }
    }
}
