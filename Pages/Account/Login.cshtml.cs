using Autenticacion.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Identity.Client.Platforms.Features.Desktop;
using Microsoft.Identity.Client;
using System.Security.Claims;


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
                // se recrea los Claim, datos a almacenar en el Cookie
                var claims = new List<Claim>
                {
                 new Claim(ClaimTypes.Name, "admin"),
                 new Claim(ClaimTypes.Email,User.Email),
                };
                // se asocia los clains creados a un nombre de una cookie
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                // se agrega la identidad creada al ClainsPrincipal de la aplicacion
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                // Se registra exitosamente la autenticacion y se crea la cookie en el navegador
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);
                return RedirectToPage("/index");
            }
           return Page();
        }
    }
}
