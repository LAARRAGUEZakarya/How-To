using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace How_To.Areas.Identity.Data
{
    public class HowToUser : IdentityUser
    {
        [PersonalData]
        public int IdUser { get; set; }


        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
      [Column(TypeName = "nvarchar(100)")]
       public string LastName { get; set; }

       

   
    }
}
