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
        public int wins { get; set; }
        public int losses { get; set; }
        public int overtimeWins { get; set; }
        public int overtimeLosses { get; set; }
        public double pointsPercent { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifferential { get; set; }

        public Team (string teamName)
        {
            this.teamName = teamName;
            gamesPlayed = 0;
        }

        public void calculatePointsPercentage()
        {
            double pointsPossible = gamesPlayed * 3;
            pointsPercent = (points / pointsPossible) * 100;
        }

        public void calculateGoalDifferential()
        {
            goalDifferential = goalsFor - goalsAgainst;
        }

        /// <summary>
        /// Clears the fields set during a tournament
        /// *Should eventually change, as this causes change amplification by having to 
        /// update this method every time a new field is added to the class that gets modified during a tournament*
        /// </summary>
        public void clearResultsFields()
        {
            points = 0;
            pointsPercent = 0;
            goalsFor = 0;
            goalsAgainst = 0;
            goalDifferential = 0;
            overtimeWins = 0;
            overtimeLosses = 0;
            wins = 0;
            losses = 0;
        }
    }
}
