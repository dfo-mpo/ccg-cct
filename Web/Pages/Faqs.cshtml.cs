using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmartBreadcrumbs.Attributes;

namespace Web.Pages
{
    [Breadcrumb("FAQs", FromPage = typeof(Pages.IndexModel))]
    public class FaqsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
