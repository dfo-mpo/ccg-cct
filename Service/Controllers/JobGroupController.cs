using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Queries.JobGroups;
using Business.Dtos.JobPositions;
using Business.Dtos.JobGroups;
using CCG.AspNetCore.Business.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Service.Controllers
{

    [ApiController, AllowAnonymous, Route("api/jobgroups")]
    public class JobGroupController : Controller
    {
        private readonly ICommandSender _commandSender;
        private readonly IQueryProcessor _queryProvider;

        public JobGroupController(IQueryProcessor queryProvider, ICommandSender commandSender)
        {
        }
    }
}
