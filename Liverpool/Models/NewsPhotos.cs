﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.Models
{
    public class NewsPhotos
    {
        public int Id { get; set; }

        public string PhotoURL { get; set; }

        public int NewsId { get; set; }
        public virtual News News { get; set; }

        public bool IsMain { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
