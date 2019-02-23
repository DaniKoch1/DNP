using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = "Let's be examinated!";
        public string quote { get; set; }

        public void OnGet()
        {
            Message += $"Server time is {DateTime.Now}";
            quote = "Imagination is more important than knowledge";
        }

//        public IActionResult GO()
//        {
//            return Redirect("/About");
//        }
    }
}