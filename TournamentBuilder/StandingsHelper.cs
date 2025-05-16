using System.Data;
using TournamentBuilder.Models;

namespace TournamentBuilder
{
    public class StandingsHelper
    {
        public static BindingSource generateStandings(List<Team> orderedTeams)
        {
            BindingSource standings = new BindingSource();

            DataTable standingsTable = new DataTable();

            standingsTable.Columns.Add(new DataColumn("Team", typeof(string)));
            standingsTable.Columns.Add(new DataColumn("Games Played", typeof(string)));
            standingsTable.Columns.Add(new DataColumn("Points Percent", typeof(double)));
            standingsTable.Columns.Add(new DataColumn("Points", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("GD", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("GF", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("GA", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("Wins", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("Losses", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("OTW", typeof(int)));
            standingsTable.Columns.Add(new DataColumn("OTL", typeof(int)));

            foreach (Team team in orderedTeams)
            {
                standingsTable.Rows.Add(team.teamName,
                                        team.gamesPlayed,
                                        Math.Round(team.pointsPercent, digits: 2),
                                        team.points,
                                        team.goalDifferential,
                                        team.goalsFor,
                                        team.goalsAgainst,
                                        team.wins,
                                        team.losses,
                                        team.overtimeWins,
                                        team.overtimeLosses);
            }

            standings.DataSource = standingsTable;

            return standings;
        }

        public static bool validateRoundTab(TabPage tabRound, int roundNumber)
        {
            bool isValidTab = true;

            // Check each score within the tab and verify it's an int, and a non negative value
            foreach(TextBox txtBoxScore in tabRound.Controls.OfType<TextBox>())
            {
                if (!(int.TryParse(txtBoxScore.Text, out int score) && score >= 0))
                {
                    isValidTab = false;
                    MessageBox.Show($"Invalid score in round {roundNumber}", "Standings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return isValidTab;
        }
    }
}
