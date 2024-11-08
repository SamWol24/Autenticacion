using Autenticacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Identity.Client.Platforms.Features.Desktop;
using Microsoft.Identity.Client;


namespace Autenticacion.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync() {
           if (!ModelState.IsValid) return Page();

           if (User.Email == "correo@gmail.com" && User.Password == "12345")
            {
                return RedirectToPage("/index");
            }
           return Page();
        }
    }
}
