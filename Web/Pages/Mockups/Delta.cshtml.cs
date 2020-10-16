using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FormsTagHelper.ViewModels
{
    public enum Levels
    {
        AS01,
        AS02,
        AS03,
        AS04,
        AS05,
        AS06,
        AS07,
        AS08
    }
}

namespace Web.Pages.Mockups
{
    public class DeltaModel : PageModel
    {
        public void OnGet()
        {
        }
        
    }
}
