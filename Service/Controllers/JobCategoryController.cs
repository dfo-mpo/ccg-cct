using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Business.Commands.Classifications;
using Business.Queries.JobCategories;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Common.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    
    [ApiController, AllowAnonymous, Route("api/jobcategories")]
    public class JobCategoryController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public JobCategoryController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
            _queryProvider = queryProvider;
            _commandSender = commandSender;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(typeof(List<JobCategoryDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCategoriesQueryHandler, List<JobCategoryDto>>();
            return Ok(results);
        }

        [HttpGet, Route("en")]
        [ProducesResponseType(typeof(string[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetValues()
        {
            var results =
                await _queryProvider.ProcessAsync<GetAllJobCategoriesValuesQueryHandler, List<string>>();
            return Ok(results);
        }
        public GetJobCategoryByIdQuery query = new GetJobCategoryByIdQuery();
        [HttpGet, Route("{Id}")]
        [ProducesResponseType(typeof(JobCategoryDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int Id)
        {
            query.JobCategoryId = Id;
            var results =
                await _queryProvider.ProcessAsync(query);
            return Ok(results);
        }
    }
}
