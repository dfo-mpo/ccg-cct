using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages.Student.College.Shoreside
{
    [Breadcrumb("Shoreside", FromPage = typeof(College.IndexModel))]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
