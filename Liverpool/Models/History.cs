using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class History
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mətn boş ola bilməz.")]
        public string Info { get; set; }
    }
}
