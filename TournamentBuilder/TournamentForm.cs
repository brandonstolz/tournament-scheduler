using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentBuilder.Models;

namespace TournamentBuilder
{
    public partial class TournamentForm : Form
    {
        public List<Round> rounds { get; set; }

        // Default x values
        public const int TXTBOX_TEAM1_X = 181;
        public const int TXTBOX_TEAM2_X = 429;
        public const int LBL_TEAM1_X = 106;
        public const int LBL_TEAM2_X = 592;
        public const int CBX_OVERTIME_X = 797;

        // Default y values
        public const int STARTING_LINE_Y = 120;
        public const int LINE_SPACING_Y = 65;

        public TournamentForm(List<Round> rounds)
        {
            InitializeComponent();
            this.rounds = rounds;
            adjustTabs();
            initializeTabs();
        }

        public void adjustTabs()
        {
            if (rounds.Count < 7)
            {
                TabControlTournament.TabPages.Remove(tabRound7);
            }
            if (rounds.Count < 6)
            {
                TabControlTournament.TabPages.Remove(tabRound6);
            }
        }

        public void initializeTabs()
        {
            for (int i = 0; i < rounds.Count; i++)
            {
                int gameNumber = 0;
                TabPage tabPage = TabControlTournament.TabPages[i];

                // Create the column labels
                createColumnLabels(tabPage);

                // Add each game row to the tab
                foreach (Game game in rounds[i].Games)
                {
                    createGameRow(tabPage, game, gameNumber++);
                }
            }
        }

        public void createGameRow(TabPage tabRound, Game game, int gameNumber)
        {
            int verticalOffset = STARTING_LINE_Y + (gameNumber * LINE_SPACING_Y);

            TextBox TxtBoxTeam1 = new TextBox();
            TextBox TxtBoxTeam2 = new TextBox();
            Label LblTeam1 = new Label();
            Label LblTeam2 = new Label();
            CheckBox CbxOverTime = new CheckBox();

            // Team 1 TextBox Specs
            TxtBoxTeam1.Location = new Point(TXTBOX_TEAM1_X, verticalOffset);
            TxtBoxTeam1.Size = new Size(140, 27);
            TxtBoxTeam1.Tag = game.team1.teamName;

            // Team 2 TextBox Specs
            TxtBoxTeam2.Location = new Point(TXTBOX_TEAM2_X, verticalOffset);
            TxtBoxTeam2.Size = new Size(140, 27);
            TxtBoxTeam2.Tag = game.team2.teamName;

            // Team 1 Label Specs
            LblTeam1.AutoSize = true;
            LblTeam1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LblTeam1.Location = new Point(LBL_TEAM1_X, verticalOffset);
            LblTeam1.Size = new Size(58, 23);
            LblTeam1.Text = game.team1.teamName;

            // Team 2 Label Specs
            LblTeam2.AutoSize = true;
            LblTeam2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LblTeam2.Location = new Point(LBL_TEAM2_X, verticalOffset);
            LblTeam2.Size = new Size(58, 23);
            LblTeam2.Text = game.team2.teamName;

            // Overtime Checkbox Specs
            CbxOverTime.AutoSize = true;
            CbxOverTime.Location = new Point(CBX_OVERTIME_X, verticalOffset);
            CbxOverTime.Size = new Size(18, 17);
            CbxOverTime.UseVisualStyleBackColor = true;
            //Set the tag equal to team 1's team name, as this is all we need to identify the appropriate game within a round
            CbxOverTime.Tag = game.team1.teamName;

            // Add new controls to the TabPage
            tabRound.Controls.Add(TxtBoxTeam1);
            tabRound.Controls.Add(TxtBoxTeam2);
            tabRound.Controls.Add(LblTeam1);
            tabRound.Controls.Add(LblTeam2);
            tabRound.Controls.Add(CbxOverTime);
        }

        public void createColumnLabels(TabPage tabRound)
        {
            Label LblScore1 = new Label();
            Label LblScore2 = new Label();
            Label LblOvertime = new Label();

            LblScore1.AutoSize = true;
            LblScore1.Location = new Point(218, 70);
            LblScore1.Size = new Size(58, 20);
            LblScore1.Text = "Score 1";

            LblScore2.AutoSize = true;
            LblScore2.Location = new Point(469, 70);
            LblScore2.Size = new Size(58, 20);
            LblScore2.Text = "Score 2";

            LblOvertime.AutoSize = true;
            LblOvertime.Location = new Point(769, 70);
            LblOvertime.Size = new Size(73, 20);
            LblOvertime.Text = "OverTime";

            tabRound.Controls.Add(LblScore1);
            tabRound.Controls.Add(LblScore2);
            tabRound.Controls.Add(LblOvertime);
        }

        private void TournamentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
