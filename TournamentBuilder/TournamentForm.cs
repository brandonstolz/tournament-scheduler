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
                if (i == 0)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab1.Visible = true;
                            TxtBox1Tab1.Visible = true;
                            LblTeam2Tab1.Visible = true;
                            TxtBox2Tab1.Visible = true;
                            Cbx1Tab1.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab1.Visible = true;
                            TxtBox3Tab1.Visible = true;
                            LblTeam4Tab1.Visible = true;
                            TxtBox4Tab1.Visible = true;
                            Cbx2Tab1.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab1.Visible = true;
                            TxtBox5Tab1.Visible = true;
                            LblTeam6Tab1.Visible = true;
                            TxtBox6Tab1.Visible = true;
                            Cbx3Tab1.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab1.Visible = true;
                            TxtBox7Tab1.Visible = true;
                            LblTeam8Tab1.Visible = true;
                            TxtBox8Tab1.Visible = true;
                            Cbx4Tab1.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab1.Visible = true;
                            TxtBox9Tab1.Visible = true;
                            LblTeam10Tab1.Visible = true;
                            TxtBox10Tab1.Visible = true;
                            Cbx5Tab1.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab1.Visible = true;
                            TxtBox11Tab1.Visible = true;
                            LblTeam12Tab1.Visible = true;
                            TxtBox12Tab1.Visible = true;
                            Cbx6Tab1.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab1.Visible = true;
                            TxtBox13Tab1.Visible = true;
                            LblTeam14Tab1.Visible = true;
                            TxtBox14Tab1.Visible = true;
                            Cbx7Tab1.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab1.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab1.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab1.Visible = true;
                            TxtBox15Tab1.Visible = true;
                            LblTeam16Tab1.Visible = true;
                            TxtBox16Tab1.Visible = true;
                            Cbx8Tab1.Visible = true;
                        }
                    }
                }
                if (i == 1)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab2.Visible = true;
                            TxtBox1Tab2.Visible = true;
                            LblTeam2Tab2.Visible = true;
                            TxtBox2Tab2.Visible = true;
                            Cbx1Tab2.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab2.Visible = true;
                            TxtBox3Tab2.Visible = true;
                            LblTeam4Tab2.Visible = true;
                            TxtBox4Tab2.Visible = true;
                            Cbx2Tab2.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab2.Visible = true;
                            TxtBox5Tab2.Visible = true;
                            LblTeam6Tab2.Visible = true;
                            TxtBox6Tab2.Visible = true;
                            Cbx3Tab2.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab2.Visible = true;
                            TxtBox7Tab2.Visible = true;
                            LblTeam8Tab2.Visible = true;
                            TxtBox8Tab2.Visible = true;
                            Cbx4Tab2.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab2.Visible = true;
                            TxtBox9Tab2.Visible = true;
                            LblTeam10Tab2.Visible = true;
                            TxtBox10Tab2.Visible = true;
                            Cbx5Tab2.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab2.Visible = true;
                            TxtBox11Tab2.Visible = true;
                            LblTeam12Tab2.Visible = true;
                            TxtBox12Tab2.Visible = true;
                            Cbx6Tab2.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab2.Visible = true;
                            TxtBox13Tab2.Visible = true;
                            LblTeam14Tab2.Visible = true;
                            TxtBox14Tab2.Visible = true;
                            Cbx7Tab2.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab2.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab2.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab2.Visible = true;
                            TxtBox15Tab2.Visible = true;
                            LblTeam16Tab2.Visible = true;
                            TxtBox16Tab2.Visible = true;
                            Cbx8Tab2.Visible = true;
                        }
                    }
                }
                if (i == 2)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab3.Visible = true;
                            TxtBox1Tab3.Visible = true;
                            LblTeam2Tab3.Visible = true;
                            TxtBox2Tab3.Visible = true;
                            Cbx1Tab3.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab3.Visible = true;
                            TxtBox3Tab3.Visible = true;
                            LblTeam4Tab3.Visible = true;
                            TxtBox4Tab3.Visible = true;
                            Cbx2Tab3.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab3.Visible = true;
                            TxtBox5Tab3.Visible = true;
                            LblTeam6Tab3.Visible = true;
                            TxtBox6Tab3.Visible = true;
                            Cbx3Tab3.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab3.Visible = true;
                            TxtBox7Tab3.Visible = true;
                            LblTeam8Tab3.Visible = true;
                            TxtBox8Tab3.Visible = true;
                            Cbx4Tab3.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab3.Visible = true;
                            TxtBox9Tab3.Visible = true;
                            LblTeam10Tab3.Visible = true;
                            TxtBox10Tab3.Visible = true;
                            Cbx5Tab3.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab3.Visible = true;
                            TxtBox11Tab3.Visible = true;
                            LblTeam12Tab3.Visible = true;
                            TxtBox12Tab3.Visible = true;
                            Cbx6Tab3.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab3.Visible = true;
                            TxtBox13Tab3.Visible = true;
                            LblTeam14Tab3.Visible = true;
                            TxtBox14Tab3.Visible = true;
                            Cbx7Tab3.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab3.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab3.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab3.Visible = true;
                            TxtBox15Tab3.Visible = true;
                            LblTeam16Tab3.Visible = true;
                            TxtBox16Tab3.Visible = true;
                            Cbx8Tab3.Visible = true;
                        }
                    }
                }
                if (i == 3)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab4.Visible = true;
                            TxtBox1Tab4.Visible = true;
                            LblTeam2Tab4.Visible = true;
                            TxtBox2Tab4.Visible = true;
                            Cbx1Tab4.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab4.Visible = true;
                            TxtBox3Tab4.Visible = true;
                            LblTeam4Tab4.Visible = true;
                            TxtBox4Tab4.Visible = true;
                            Cbx2Tab4.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab4.Visible = true;
                            TxtBox5Tab4.Visible = true;
                            LblTeam6Tab4.Visible = true;
                            TxtBox6Tab4.Visible = true;
                            Cbx3Tab4.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab4.Visible = true;
                            TxtBox7Tab4.Visible = true;
                            LblTeam8Tab4.Visible = true;
                            TxtBox8Tab4.Visible = true;
                            Cbx4Tab4.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab4.Visible = true;
                            TxtBox9Tab4.Visible = true;
                            LblTeam10Tab4.Visible = true;
                            TxtBox10Tab4.Visible = true;
                            Cbx5Tab4.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab4.Visible = true;
                            TxtBox11Tab4.Visible = true;
                            LblTeam12Tab4.Visible = true;
                            TxtBox12Tab4.Visible = true;
                            Cbx6Tab4.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab4.Visible = true;
                            TxtBox13Tab4.Visible = true;
                            LblTeam14Tab4.Visible = true;
                            TxtBox14Tab4.Visible = true;
                            Cbx7Tab4.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab4.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab4.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab4.Visible = true;
                            TxtBox15Tab4.Visible = true;
                            LblTeam16Tab4.Visible = true;
                            TxtBox16Tab4.Visible = true;
                            Cbx8Tab4.Visible = true;
                        }
                    }
                }
                if (i == 4)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab5.Visible = true;
                            TxtBox1Tab5.Visible = true;
                            LblTeam2Tab5.Visible = true;
                            TxtBox2Tab5.Visible = true;
                            Cbx1Tab5.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab5.Visible = true;
                            TxtBox3Tab5.Visible = true;
                            LblTeam4Tab5.Visible = true;
                            TxtBox4Tab5.Visible = true;
                            Cbx2Tab5.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab5.Visible = true;
                            TxtBox5Tab5.Visible = true;
                            LblTeam6Tab5.Visible = true;
                            TxtBox6Tab5.Visible = true;
                            Cbx3Tab5.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab5.Visible = true;
                            TxtBox7Tab5.Visible = true;
                            LblTeam8Tab5.Visible = true;
                            TxtBox8Tab5.Visible = true;
                            Cbx4Tab5.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab5.Visible = true;
                            TxtBox9Tab5.Visible = true;
                            LblTeam10Tab5.Visible = true;
                            TxtBox10Tab5.Visible = true;
                            Cbx5Tab5.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab5.Visible = true;
                            TxtBox11Tab5.Visible = true;
                            LblTeam12Tab5.Visible = true;
                            TxtBox12Tab5.Visible = true;
                            Cbx6Tab5.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab5.Visible = true;
                            TxtBox13Tab5.Visible = true;
                            LblTeam14Tab5.Visible = true;
                            TxtBox14Tab5.Visible = true;
                            Cbx7Tab5.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab5.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab5.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab5.Visible = true;
                            TxtBox15Tab5.Visible = true;
                            LblTeam16Tab5.Visible = true;
                            TxtBox16Tab5.Visible = true;
                            Cbx8Tab5.Visible = true;
                        }
                    }
                }
                if (i == 5)
                {
                    for (int j = 0; j < rounds[i].Games.Count; j++)
                    {
                        if (j == 0)
                        {
                            LblTeam1Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam2Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam1Tab6.Visible = true;
                            TxtBox1Tab6.Visible = true;
                            LblTeam2Tab6.Visible = true;
                            TxtBox2Tab6.Visible = true;
                            Cbx1Tab6.Visible = true;
                        }
                        if (j == 1)
                        {
                            LblTeam3Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam4Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam3Tab6.Visible = true;
                            TxtBox3Tab6.Visible = true;
                            LblTeam4Tab6.Visible = true;
                            TxtBox4Tab6.Visible = true;
                            Cbx2Tab6.Visible = true;
                        }
                        if (j == 2)
                        {
                            LblTeam5Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam6Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam5Tab6.Visible = true;
                            TxtBox5Tab6.Visible = true;
                            LblTeam6Tab6.Visible = true;
                            TxtBox6Tab6.Visible = true;
                            Cbx3Tab6.Visible = true;
                        }
                        if (j == 3)
                        {
                            LblTeam7Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam8Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam7Tab6.Visible = true;
                            TxtBox7Tab6.Visible = true;
                            LblTeam8Tab6.Visible = true;
                            TxtBox8Tab6.Visible = true;
                            Cbx4Tab6.Visible = true;
                        }
                        if (j == 4)
                        {
                            LblTeam9Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam10Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam9Tab6.Visible = true;
                            TxtBox9Tab6.Visible = true;
                            LblTeam10Tab6.Visible = true;
                            TxtBox10Tab6.Visible = true;
                            Cbx5Tab6.Visible = true;
                        }
                        if (j == 5)
                        {
                            LblTeam11Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam12Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam11Tab6.Visible = true;
                            TxtBox11Tab6.Visible = true;
                            LblTeam12Tab6.Visible = true;
                            TxtBox12Tab6.Visible = true;
                            Cbx6Tab6.Visible = true;
                        }
                        if (j == 6)
                        {
                            LblTeam13Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam14Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam13Tab6.Visible = true;
                            TxtBox13Tab6.Visible = true;
                            LblTeam14Tab6.Visible = true;
                            TxtBox14Tab6.Visible = true;
                            Cbx7Tab6.Visible = true;
                        }
                        if (j == 7)
                        {
                            LblTeam15Tab6.Text = rounds[i].Games[j].team1.teamName;
                            LblTeam16Tab6.Text = rounds[i].Games[j].team2.teamName;
                            LblTeam15Tab6.Visible = true;
                            TxtBox15Tab6.Visible = true;
                            LblTeam16Tab6.Visible = true;
                            TxtBox16Tab6.Visible = true;
                            Cbx8Tab6.Visible = true;
                        }
                    }
                }
            }
        }

        private void TournamentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
