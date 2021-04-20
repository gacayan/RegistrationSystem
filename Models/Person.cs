using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Models
{
    public class Person
    {
        [Key]
        public int UserID { get; set; }

      



        [Required(ErrorMessage = "UserName is mandatory!")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string EmailAddress { get; set; }
    }
}
