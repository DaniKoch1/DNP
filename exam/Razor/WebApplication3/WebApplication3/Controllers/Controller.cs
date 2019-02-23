using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Go()
        {     
            return Redirect("/About");
        }
    }
}