using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Gallery
    {
        public int Id { get; set; }

        public string PhotoURL { get; set; }

        [NotMapped]
        public ICollection<IFormFile> Photo { get; set; }
    }
}
