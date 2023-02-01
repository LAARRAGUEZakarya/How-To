using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace How_To.Models
{
    public class User
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Adress { get; set; }
        //public string Matricule { get; set; }

        public DateTime date_birth { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "numéro incorrect")]

        public string Tel { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_embauche { get; set; }



        public string Sex { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Speciality { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }

        public virtual Category Category { get; set; }

        public string EmailOld { get; set; }
    }
}
