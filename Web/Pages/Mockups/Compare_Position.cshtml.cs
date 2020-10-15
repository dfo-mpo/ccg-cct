using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FormsTagHelper.ViewModels
{
    public enum Level
    {
        [Display(Name = "AS 01")] AS01,
        [Display(Name = "AS 02")] AS02,
        [Display(Name = "AS 03")] AS03,
        AS04,
        AS05,
        AS06,
        AS07,
        AS08
    }

    public enum Position
    {
        [Display(Name = "Officer (Business Services, Regulatory Coast Guard Planning, Investment, Project Planning & Control, Planning, Staff Management & Business Services) / Policy Analyst")] 
        POS1,
        [Display(Name = "Senior Analyst Public Affairs and International Management (PAIM)/Business Resource Management (BRM)")] POS2,
        [Display(Name = "Performance & Quality Assurance Officer")] POS3,
        [Display(Name = "Executive Assistant to the Assistant Commissioner (AC), Deputy Commissioner (DC), Staff Officer to the Director General (DG)")] POS4,
        [Display(Name = "Workforce Development Manager")] POS5,
        [Display(Name = "Workforce Development Analyst")] POS6,
        [Display(Name = "Fleet Resources Manager")] POS7,
        [Display(Name = "Public Affairs - Web Officer / Leader Communications (Comms) & Internet / PIO Manager")] POS8
    }
}
namespace Web.Pages.Mockups
{
    public class Compare_PositionModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
