using System.Text;
using TournamentBuilder.Models;

namespace TournamentBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ContextMenuStrip = CMSDelete;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string newTeamName = TxtBoxTeam.Text;
            bool invalidName = false;

            if (!newTeamName.Equals(string.Empty))
            {
                foreach (string teamName in ListBoxTeams.Items)
                {
                    if (teamName.Equals(newTeamName))
                    {
                        invalidName = true;
                    }
                }
            }
            else
            {
                invalidName = true;
            }

            if (!invalidName)
            {
                ListBoxTeams.Items.Add(newTeamName);
            }
        }

        private void CMSOptionDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxTeams.SelectedItems.Count == 1)
            {
                ListBoxTeams.Items.Remove(ListBoxTeams.SelectedItems[0]);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            List<Team> teamList1 = new List<Team>();
            List<Team> teamList2 = new List<Team>();

            for (int i = 0; i < ListBoxTeams.Items.Count; i++)
            {
                Team newTeam = new Team(ListBoxTeams.Items[i].ToString());

                if (i + 1 <= Math.Ceiling((decimal)ListBoxTeams.Items.Count / 2))
                {
                    teamList1.Add(newTeam);
                }
                else
                {
                    teamList2.Add(newTeam);
                }
            }

            bool duplicatesAllowed = ListBoxTeams.Items.Count < 6 ? true : false;

            List<Round> rounds = createPairings(teamList1, teamList2, ListBoxTeams.Items.Count, duplicatesAllowed);

            this.Hide();
            TournamentForm tournamentForm = new TournamentForm(rounds);
            tournamentForm.ShowDialog();
        }


        private static List<Round> createPairings(List<Team> teamList1, List<Team> teamList2, int teamCount, bool duplicatesAllowed)
        {
            List<Round> rounds = new List<Round>();
            int numRounds = 5 + teamCount % 2;

            for (int i = 0; i < numRounds; i++)
            {
                rounds.Add(new Round());
            }

            if (numRounds == 6)
            {
                teamList2.Add(new Team("BYE"));
            }

            int startingOpponentIndex = 0;

            foreach (Round round in rounds)
            {
                foreach (Team team in teamList1)
                {
                    pairTeam(team, teamListNumber: 2, teamList1, teamList2, round, rounds, startingOpponentIndex, duplicatesAllowed);
                }

                foreach (Team team in teamList2)
                {
                    pairTeam(team, teamListNumber: 1, teamList1, teamList2, round, rounds, startingOpponentIndex, duplicatesAllowed);
                }

                if (++startingOpponentIndex == teamList1.Count)
                {
                    startingOpponentIndex = 0;
                }
            }

            if (duplicatesAllowed)
            {
                Round makeupRound = new Round();
                makeupRound.Games.Add(new Game(teamList1[teamList1.Count - 1], teamList2[0]));
                rounds.Add(makeupRound);

                teamList1[teamList1.Count - 1].gamesPlayed++;
                teamList2[0].gamesPlayed++;
            }

            StringBuilder sb = new StringBuilder();

            foreach(Round round in rounds)
            {
                sb.AppendLine($"Round {rounds.IndexOf(round) + 1}");

                foreach (Game game in round.Games)
                {
                    sb.AppendLine($"\tTeam 1: {game.team1.teamName}\t\tTeam 2: {game.team2.teamName}");
                }
            }

            return rounds;
        }

        private static void pairTeam(Team team, int teamListNumber, List<Team> teamList1, List<Team> teamList2, Round round, List<Round> rounds, int startingOpponentIndex, bool duplicatesRequired)
        {
            List<Team> opposingTeamList;

            opposingTeamList = teamListNumber == 1 ? teamList1 : teamList2;
            int opponentIndex = startingOpponentIndex;
            bool gameCreated = false;
            int timesSwitchedTeamLists = 0;

            while (!team.teamName.Equals("BYE") && gameCreated == false && !hasGameInRound(team, round))
            {
                if (opponentIndex == opposingTeamList.Count)
                {
                    teamListNumber = teamListNumber == 1 ? 2 : 1;
                    opposingTeamList = teamListNumber == 1 ? teamList1 : teamList2;
                    opponentIndex = 0;
                    timesSwitchedTeamLists++;
                }
                else
                {
                    if (!team.teamName.Equals(opposingTeamList[opponentIndex].teamName)
                        && !hasGameInRound(opposingTeamList[opponentIndex], round))
                    {
                        if (!hasGameInRound(team, round))
                        {
                            if (validPairing(rounds, team, opposingTeamList[opponentIndex])
                                || (duplicatesRequired && timesSwitchedTeamLists > 1))
                            {
                                round.Games.Add(new Game(team, opposingTeamList[opponentIndex]));
                                gameCreated = true;

                                if (!opposingTeamList[opponentIndex].teamName.Equals("BYE"))
                                {
                                    team.gamesPlayed++;
                                    opposingTeamList[opponentIndex].gamesPlayed++;
                                }
                            }
                            else
                            {
                                opponentIndex++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        opponentIndex++;
                    }
                }
            }
        }

        private static bool validPairing(List<Round> rounds, Team team1, Team team2)
        {
            bool validPairing = true;
            int gameCounter = 0;

            foreach (Round round in rounds)
            {
                foreach (Game game in round.Games)
                {
                    if (game.team1.teamName.Equals(team1.teamName) && game.team2.teamName.Equals(team2.teamName)
                        || game.team2.teamName.Equals(team1.teamName) && game.team1.teamName.Equals(team2.teamName))
                    {
                        gameCounter++;
                    }
                }
            }

            if (gameCounter > 0)
            {
                validPairing = false;
            }

            return validPairing;
        }

        private static bool hasGameInRound(Team team, Round round)
        {
            bool hasGameInRound = false;

            foreach (Game game in round.Games)
            {
                if (game.team1.teamName.Equals(team.teamName) || game.team2.teamName.Equals(team.teamName))
                {
                    hasGameInRound = true;
                }
            }

            return hasGameInRound;
        }
    }
}