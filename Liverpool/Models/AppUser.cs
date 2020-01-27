using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class AppUser : IdentityUser
    {
        public string PhotoURL { get; set; }

        [Required(ErrorMessage = "Mağazanın Adı mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Mağazanın Adı 100 hərfdən çox ola bilməz.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Mağazanın Adı mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Mağazanın Adı 100 hərfdən çox ola bilməz.")]
        public string Lastname { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
