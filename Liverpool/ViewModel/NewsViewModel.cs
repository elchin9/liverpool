using Liverpool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class NewsViewModel
    {
        public News News { get; set; }
        public IEnumerable<News> AllNews { get; set; }
    }
}
