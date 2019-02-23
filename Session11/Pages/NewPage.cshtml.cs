using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Session11.Pages{
    public class NewPage : PageModel
    {
        //[BindProperty]
        public string message {get; set;}
        
        public void OnGet(){
            message="Message from model";
        }
       
    }
}