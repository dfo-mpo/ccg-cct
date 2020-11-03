using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    public class JobGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
