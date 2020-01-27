using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Cup
    {
        public int Id { get; set; }

        public string BackgroundPhotoURL { get; set; }

        [Required(ErrorMessage = "Kubokun yeri boş ola bilməz.")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Kubokun vaxtı boş ola bilməz.")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Kubokun haqqında hissəsi boş ola bilməz.")]
        public string Info { get; set; }

        public int CupTypeId{ get; set; }
        public virtual CupType CupType { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
