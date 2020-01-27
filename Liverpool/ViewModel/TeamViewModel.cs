using Liverpool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liverpool.ViewModel
{
    public class TeamViewModel
    {
        public BackgroundImages Image { get; set; }
        public IEnumerable<Position> Position { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<FirstTeam> FirstTeam { get; set; }
    }
}
