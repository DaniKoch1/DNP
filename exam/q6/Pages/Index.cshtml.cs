using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace q6.Pages
{
    public class IndexModel : PageModel
    {
        
        [HttpPost]
        public async Task<IActionResult> LoginAsync(string name){
           
            var claims=new List<Claim>()
            {
                new Claim(ClaimTypes.Name, name),
                new Claim("ViaId", "007")
            };

            var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            return RedirectToAction(nameof(Index));
        }

    }
}
