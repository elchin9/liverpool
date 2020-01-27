using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.Models;

namespace Liverpool.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad bölməsi mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Adınız 100 simvoldan çox ola bilməz.")]
        public string Name { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
