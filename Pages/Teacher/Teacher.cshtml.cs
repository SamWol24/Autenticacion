using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Autenticacion.Pages.Shared.Teacher
{
    [Authorize]
    public class TeacherModel : PageModel
    {
      
        public void OnGet()
        {
        }
    }
}
