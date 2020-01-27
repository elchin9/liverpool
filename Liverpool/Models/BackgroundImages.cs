using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class BackgroundImages
    {
        public int Id { get; set; }

        public string HistoryPhotoURL { get; set; }

        public string SquadPhotoURL { get; set; }

        public string CupPhotoURL { get; set; }

        public string StadiumPhotoURL { get; set; }

        [NotMapped]
        public IFormFile HistoryPhoto { get; set; }

        [NotMapped]
        public IFormFile SquadPhoto { get; set; }

        [NotMapped]
        public IFormFile CupPhoto { get; set; }

        [NotMapped]
        public IFormFile StadiumPhoto { get; set; }
    }
}
