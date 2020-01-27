using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class Position
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mövqe boş ola bilməz.")]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
