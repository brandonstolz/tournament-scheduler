namespace TournamentBuilder.Models
{
    public class Game
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }
        public bool overtime { get; set; }

        private const int POINTS_WIN = 3;
        private const int OVERTIME_WIN = 2;
        private const int OVERTIME_LOSS = 1;

        public Game(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
            team1Score = 0;
            team2Score = 0;
            overtime = false;
        }

        public void evaluateGame()
        {
            if (team1Score > team2Score)
            {
                calculatePoints(winningTeam: team1, losingTeam: team2);   
            }
            else
            {
                calculatePoints(winningTeam: team2, losingTeam: team1);
            }

            calculateGFGA();
        }

        private void calculatePoints(Team winningTeam, Team losingTeam)
        {   
            if (overtime)
            {
                losingTeam.points += OVERTIME_LOSS;
                winningTeam.points += OVERTIME_WIN;

                losingTeam.overtimeLosses++;
                winningTeam.overtimeWins++;
            }
            else
            {
                winningTeam.points += POINTS_WIN;
                winningTeam.wins++;
                losingTeam.losses++;
            }
        }

        private void calculateGFGA()
        {
            team1.goalsFor += team1Score;
            team1.goalsAgainst += team2Score;

            team2.goalsFor += team2Score;
            team2.goalsAgainst += team1Score;
        }
    }
}
