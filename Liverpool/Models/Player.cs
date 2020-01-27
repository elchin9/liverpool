using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string PhotoURL { get; set; }

        public string BackgroundPhotoURL { get; set; }

        [Required(ErrorMessage ="Oyunçunun adı mütləq doldurulmalıdır."), StringLength(100,ErrorMessage ="Oyunçunun adı 100 simvoldan çox ola bilməz")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Oyunçunun soyadı mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Oyunçunun soyadı 100 simvoldan çox ola bilməz")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Oyunçunun ölkəsi mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Oyunçunun ölkəsi 100 simvoldan çox ola bilməz")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Oyunçunun doğum tarixi mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Oyunçunun doğum tarixi 100 simvoldan çox ola bilməz")]
        public string Birthday { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        [Required(ErrorMessage = "Oyunçunun məlumatları mütləq doldurulmalıdır."), StringLength(100, ErrorMessage = "Oyunçunun məlumatları 100 simvoldan çox ola bilməz")]
        public string Info { get; set; }

        public virtual ICollection<FirstTeam> FirstTeam { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile BackgroundPhoto { get; set; }

    }
}
