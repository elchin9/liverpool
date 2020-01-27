using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class StadiumPhotos
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string PhotoURL { get; set; }

        public int StadiumId { get; set; }
        public virtual Stadium Stadium { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
