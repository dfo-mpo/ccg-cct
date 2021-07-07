using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.HighSchool
{
    [Breadcrumb("HighSchool", FromPage = typeof(Student.IndexModel))]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
