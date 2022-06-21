using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Admin.Pages.Session
{
    public class SetValueModel : PageModel
    {
        public IActionResult OnGet(string? key, string? value)
        {
            if ((!string.IsNullOrWhiteSpace(key)) && (!string.IsNullOrWhiteSpace(value)))
            {
                HttpContext.Session.SetString(key, value);
            }
            return Redirect("/Index");
        }
    }
}
