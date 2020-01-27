using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Stadium
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Stadionun adı boş ola bilməz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Stadionun mətni boş ola bilməz.")]
        public string MainInfo { get; set; }

        [Required(ErrorMessage = "Xəbərin məlumat hissəsi boş ola bilməz."), StringLength(10, ErrorMessage = "Stadionun ili 10 simvoldan çox ola bilməz.")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Stadionun tutumu boş ola bilməz."), StringLength(100, ErrorMessage = "Stadionun tutumu 100 simvoldan çox ola bilməz.")]
        public string Capacity { get; set; }

        public virtual ICollection<StadiumPhotos> Photos { get; set; }

        [NotMapped]
        public ICollection<IFormFile> AllPhotos { get; set; }
    }
}
