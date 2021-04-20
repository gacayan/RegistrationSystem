using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationSystem.Models;

namespace RegistrationSystem.Pages
{
    
    public class PersonModel : PageModel
    {
        public PersonModel(RegistrationDBContext registrationcontext)
        {
            _registrationdbcontext = registrationcontext;
        }

        private readonly RegistrationDBContext _registrationdbcontext;


        [BindProperty]
        public Person Person{ get; set; }

        public List<Person> Persons = new List<Person>();
        public void OnGet()
        {
            Persons = _registrationdbcontext.Persons.ToList();
        }
        public void OnPost()
        {
            _registrationdbcontext.Persons.Add(Person);
            _registrationdbcontext.SaveChanges();
        }
    }
}
