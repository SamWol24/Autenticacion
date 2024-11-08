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
        public void OnPost() {
            Console.WriteLine("User: " + User.Email + " Password : " + User.Password);
        }
    }
}
