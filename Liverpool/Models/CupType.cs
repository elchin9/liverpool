using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class CupType
    {
        public int Id { get; set; }

        public string PhotoURL { get; set; }

        [Required(ErrorMessage = "Kubokun adı boş ola bilməz.")]
        public string Name { get; set; }

        public virtual ICollection<Cup> Cups { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
