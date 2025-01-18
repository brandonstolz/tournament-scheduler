using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentBuilder.Models
{
    public class Team
    {
        public string teamName { get; set; }
        public int gamesPlayed { get; set; }
        public int points { get; set; }
        double pointsPercent { get; set; }
        int goalsFor { get; set; }
        int goalsAgainst { get; set; }

        public Team (string teamName)
        {
            this.teamName = teamName;
            gamesPlayed = 0;
        }

        public void calculatePointsPercentage()
        {
            double pointsPossible = gamesPlayed * 3;
            pointsPercent = points / pointsPossible;
        }
    }
}
