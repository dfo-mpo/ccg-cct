using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.CCGMember
{
    public class SearchTypeModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public int positionid { get; set; }
        public void OnGet()
        {

        }
    }
}