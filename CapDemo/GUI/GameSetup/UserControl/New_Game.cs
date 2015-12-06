using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.BL;
using CapDemo.DO;

namespace CapDemo.GUI.User_Controls
{
    public partial class New_Game : UserControl
    {
        public New_Game()
        {
            InitializeComponent();
        }
        Setting_Game sg = new Setting_Game();
        private void New_Game_Load(object sender, EventArgs e)
        {
        }

        private void New_Game_DoubleClick(object sender, EventArgs e)
        {
            ContinueSetting continueSetting = new ContinueSetting();
            continueSetting.ContestID = Convert.ToInt32(label2.Text);

            DialogResult result = continueSetting.ShowDialog();
            if (result == DialogResult.OK)
            {
                load();  
            }
            else
            {
                load();
            }
        }
        //LOAD
        public void load()
        {
            sg.flp_Game.Controls.Clear();
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).IDContest == Convert.ToInt32(label2.Text) )
                    {
                        lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        label2.Text = ListContest.ElementAt(i).IDContest.ToString();
                        lbl_Number.Text = (i + 1).ToString();
                        if (ListContest.ElementAt(i).NumberChallenge > 0)
                        {
                            lbl_Status.Text = "Hoàn tất";
                            lbl_Status.ForeColor = Color.LightGreen;
                        }
                        else
                        {
                            lbl_Status.Text = "Chưa hoàn Tất";
                            lbl_Status.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
        private void New_Game_MouseClick(object sender, MouseEventArgs e)
        {
            //this.BackColor = Color.LightBlue;

        }

        private void New_Game_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }

        private void New_Game_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = Color.Cyan;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        
    }
}
