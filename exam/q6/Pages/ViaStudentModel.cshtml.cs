using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace q6.Pages
{

[Authorize(Policy="IsViaStudent")]
public class ViaStudentModel : PageModel
{
    public void OnGet()
    {

    }
        
}
}