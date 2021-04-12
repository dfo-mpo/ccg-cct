using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.CCGMember
{
    public class SearchTypeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; } = string.Empty;
        [BindProperty(SupportsGet = true)]
        public int PositionId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Level { get; set; } = string.Empty;
        public void OnGet()
        {

        }
    }
}