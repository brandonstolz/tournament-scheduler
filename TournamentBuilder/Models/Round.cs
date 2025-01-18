using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBuilder.Models
{
    public class Round
    {
        public List<Game> Games { get; set; }

        public Round()
        {
            Games = new List<Game>();
        }
    }
}
