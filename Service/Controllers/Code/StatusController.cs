using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Queries.Codes;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Models;
using CCG.AspNetCore.Web.Authorization;
using DataModel.CodeTables;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers.Code
{
    [ApiController, Route("api/code/[controller]"), AllowAnonymous]
    public class StatusController : AbstractCodeManagerViewController<StatusCode>
    {
        private readonly IQueryProcessor _queryProcessor;

        public StatusController(IQueryProcessor queryProcessor) : base(queryProcessor)
        {
            _queryProcessor = queryProcessor;
        }



    }
}