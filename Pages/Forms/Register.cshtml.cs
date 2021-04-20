using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationSystem.Models;

namespace RegistrationSystem.Pages.Forms
{
    public class RegisterModel : PageModel
    {
     [BindProperty]   
      public Person Person { get; set; }
        public void OnGet(string username,string password,string confirmpassword,string emailaddress)
        {
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return Redirect("/Index");
            // string name =  Request.Form["txtusername"];
            // string password =  Request.Form["txtpassword"];
            //tring confirmpassword =  Request.Form["txtconfirmpassword"];
            //string emailaddress =  Request.Form["txtemailaddress"];
        }
    }
}
