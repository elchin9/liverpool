using Liverpool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class VideoViewModel
    {
        public Video OneVideo { get; set; }
        public IEnumerable<Video> Videos { get; set; }
    }
}
