using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Eventin başlığı boş ola bilməz."), StringLength(100, ErrorMessage = "Eventin başlığı 100 simvoldan çox  ola bilməz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Eventin yeri boş ola bilməz.")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Eventin yeri boş ola bilməz.")]
        public string Map { get; set; }

        [Required(ErrorMessage = "Eventin nömrəsi boş ola bilməz.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Eventin saatı boş ola bilməz.")]
        public string Clock { get; set; }

        [Required(ErrorMessage = "Eventin vaxtı boş ola bilməz.")]
        public DateTime Time { get; set; }
    }
}
