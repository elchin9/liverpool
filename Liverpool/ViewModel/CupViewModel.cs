using Liverpool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class CupViewModel
    {
        public BackgroundImages Image { get; set; }

        public IEnumerable<CupType> CupType { get; set; }

        public IEnumerable<Cup> AllCups { get; set; }

    }
}
