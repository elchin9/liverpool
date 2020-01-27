using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Video
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public virtual VideoCategory Category { get; set; }

        public string PhotoURL { get; set; }

        [Required(ErrorMessage = "Icmalın başlığı boş ola bilməz."), StringLength(100, ErrorMessage = "Icmalın başlığı 100 simvoldan çox  ola bilməz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Icmalın mətni boş ola bilməz.")]
        public string MainInfo { get; set; }

        [Required(ErrorMessage = "Icmalın linki boş ola bilməz.")]
        public string VideoLink { get; set; }

        public DateTime Time { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
