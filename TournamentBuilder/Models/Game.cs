namespace TournamentBuilder.Models
{
    public class Game
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }
        public bool overtime { get; set; }

        public Game(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
            team1Score = 0;
            team2Score = 0;
            overtime = false;
        }
    }
}
