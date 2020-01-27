using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class FirstTeam
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        [Required(ErrorMessage = "Mövqey mütləq doldurulmalıdır"), StringLength(100, ErrorMessage = "Mövqey 100 simvoldan çox ola bilməz.")]
        public string Name { get; set; }
    }
}
