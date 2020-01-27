using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Ad mütləq doldurulmalıdır.")]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PhotoURL { get; set; }

        [Required(ErrorMessage = "Telefon nömrəsi mütləq doldurulmalıdır."), StringLength(15, ErrorMessage = "Telefon nömrəsi 15 simvoldan çox ola bilməz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email mütləq doldurulmalıdır."), EmailAddress, DataType(DataType.EmailAddress, ErrorMessage = "Düzgün Email daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username mütləq doldurulmalıdır.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Parol mütləq doldurulmalıdır."), DataType(DataType.Password, ErrorMessage = "Düzgün Parol daxil edin")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Parol mütləq doldurulmalıdır."), Compare(nameof(Password)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
