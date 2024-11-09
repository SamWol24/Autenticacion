using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages
{
    [Authorize]
    public class SubjectModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
