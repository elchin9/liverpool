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

        [Required, StringLength(100)]
        public string PhotoURL { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
