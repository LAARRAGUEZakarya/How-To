using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace How_To.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string Description { get; set; }
        public DateTime Date_of_share { get; set; }

        public User user { get; set; }
        public Category category { get; set; }

        public string Images { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }
    }
}
