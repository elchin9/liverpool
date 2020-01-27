using Liverpool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Video> Videos { get; set; }
        public IEnumerable<News> News { get; set; }
        public Event Event { get; set; }
    }
}
