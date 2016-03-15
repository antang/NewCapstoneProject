using CapDemo.BL;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
        int iDcontest;
        public int IDcontest
        {
            get { return iDcontest; }
            set { iDcontest = value; }
        }
        private void Result_Load(object sender, EventArgs e)
        {
            Record records = new Record();
            records.IDContest = iDcontest;
            RecordBL recordBL = new RecordBL();
            List<Record> ListRecord = recordBL.GetsScoreplayerByIDContest(records);
            //Sort player assending in list player
            int length = ListRecord.Count;
            Record temp = ListRecord[0];
            //Declare data
            string[] Rank = new string[] { "st", "nd", "rd", "th", "th" };

            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = i + 1; j < length; j++)
            //    {
            //        if (ListRecord.ElementAt(i).TeamScore < ListRecord.ElementAt(j).TeamScore)
            //        {
            //            temp = ListRecord[i];

            //            ListRecord[i] = ListRecord[j];

            //            ListRecord[j] = temp;
            //        }
            //    }
            //}
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (ListRecord.ElementAt(i).TeamScore < ListRecord.ElementAt(j).TeamScore)
                    {
                        temp = ListRecord[i];

                        ListRecord[i] = ListRecord[j];

                        ListRecord[j] = temp;
                    }
                    else
                    {
                        if (ListRecord.ElementAt(i).TeamScore == ListRecord.ElementAt(j).TeamScore)
                        {
                            if (ListRecord.ElementAt(i).Sub < ListRecord.ElementAt(j).Sub)
                            {
                                temp = ListRecord[i];

                                ListRecord[i] = ListRecord[j];

                                ListRecord[j] = temp;
                            }
                        }
                    }

                }
            }
            
            //Declare data
            int width = flp_TeamEndGame.Width;
            //Show player
            for (int i = 0; i < ListRecord.Count; i++)
            {
                TeamEndGame teamEndGame = new TeamEndGame();
                teamEndGame.lbl_Score.Text = ListRecord.ElementAt(i).TeamScore.ToString();
                teamEndGame.lbl_Name.Text = nameplayer(ListRecord.ElementAt(i).IDPlayer);
                teamEndGame.pb_TeamShirt.BackColor = Color.FromArgb(colorplayer(ListRecord.ElementAt(i).IDPlayer));
                teamEndGame.Size = new System.Drawing.Size(width - 10, teamEndGame.Height);
                //if (i == 0)
                //{
                //    teamEndGame.BackgroundImage = Properties.Resources.First;
                //}
                //if (i == 1)
                //{
                //    if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(0).TeamScore)
                //    {
                //        teamEndGame.BackgroundImage = Properties.Resources.First;
                //    }
                //    else
                //    {
                //        teamEndGame.BackgroundImage = Properties.Resources.Second;
                //    }
                //}
                //if (i == 2)
                //{
                //    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(0).TeamScore)
                //    {
                //        teamEndGame.BackgroundImage = Properties.Resources.First;
                //    }
                //    else
                //    {
                //        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(1).TeamScore)
                //        {
                //            teamEndGame.BackgroundImage = Properties.Resources.Second;
                //        }
                //        else
                //        {
                //            if (ListRecord.ElementAt(0).TeamScore == ListRecord.ElementAt(1).TeamScore)
                //            {
                //                teamEndGame.BackgroundImage = Properties.Resources.Second;
                //            }
                //            else
                //            {
                //                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                //            }
                //        }
                //    }
                //}
                //if (i == 3)
                //{
                //    if (ListRecord.ElementAt(3).TeamScore == ListRecord.ElementAt(0).TeamScore)
                //    {
                //        teamEndGame.BackgroundImage = Properties.Resources.First;
                //    }
                //    else
                //    {
                //        if (ListRecord.ElementAt(3).TeamScore == ListRecord.ElementAt(1).TeamScore)
                //        {
                //            teamEndGame.BackgroundImage = Properties.Resources.Second;
                //        }
                //        else
                //        {
                //            if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(0).TeamScore)
                //            {
                //                teamEndGame.BackgroundImage = Properties.Resources.Second;
                //            }
                //            else
                //            {
                //                if (ListRecord.ElementAt(3).TeamScore == ListRecord.ElementAt(2).TeamScore)
                //                {
                //                    teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                //                }
                //                else
                //                {
                //                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(1).TeamScore)
                //                    {
                //                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                //                    }
                //                    else
                //                    {
                //                        teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                //                    }
                //                }
                //            }

                //        }
                //    }

                //}

                //i==0
                if (i == 0)
                {
                    teamEndGame.BackgroundImage = Properties.Resources.First;
                }
                //i==1
                if (i == 1)
                {
                    if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(0).TeamScore)
                    {
                        if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(0).Sub)
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.First;
                        }
                        else
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                        }
                    }
                    else
                    {
                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                    }
                }
                //i==2
                if (i == 2)
                {
                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(0).TeamScore)
                    {
                        if (ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(0).Sub)
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.First;
                        }
                        else
                        {
                            if (ListRecord.ElementAt(0).TeamScore == ListRecord.ElementAt(1).TeamScore)
                            {
                                if (ListRecord.ElementAt(0).Sub == ListRecord.ElementAt(1).Sub)
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Second;
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore && ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                }
                            }
                            else
                            {
                                if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore && ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Second;
                                }
                                else
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ListRecord.ElementAt(0).TeamScore == ListRecord.ElementAt(1).TeamScore)
                        {
                            if (ListRecord.ElementAt(0).Sub == ListRecord.ElementAt(1).Sub)
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                            }
                            else
                            {
                                if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore && ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Second;
                                }
                                else
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                }
                            }
                        }
                        else
                        {
                            if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore && ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                            }
                            else
                            {
                                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                            }
                        }
                    }
                }
                //i==3
                if (i == 3)
                {
                    if (ListRecord.ElementAt(3).TeamScore == ListRecord.ElementAt(0).TeamScore)
                    {
                        if (ListRecord.ElementAt(3).Sub == ListRecord.ElementAt(0).Sub)
                        {
                            teamEndGame.BackgroundImage = Properties.Resources.First;
                        }
                        else
                        {
                            if (ListRecord.ElementAt(0).TeamScore == ListRecord.ElementAt(1).TeamScore)
                            {
                                if (ListRecord.ElementAt(0).Sub == ListRecord.ElementAt(1).Sub)
                                {
                                    if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                                    {
                                        if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                                        }
                                        else
                                        {
                                            if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                                            }
                                            else
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                    }
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                                    {
                                        if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                        {
                                            if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Second;
                                            }
                                            else
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                            }
                                        }
                                        else
                                        {
                                            if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                            }
                                            else
                                            {
                                                teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                                {
                                    if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                    }
                                    else
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                        }
                                    }
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (ListRecord.ElementAt(0).TeamScore == ListRecord.ElementAt(1).TeamScore)
                        {
                            if (ListRecord.ElementAt(0).Sub == ListRecord.ElementAt(1).Sub)
                            {
                                if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                                {
                                    if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                                    }
                                    else
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                    }
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                }
                            }
                            else
                            {
                                if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                                {
                                    if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Second;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }

                                    }
                                    else
                                    {
                                        if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                        }
                                        else
                                        {
                                            teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                        }
                                    }
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (ListRecord.ElementAt(1).TeamScore == ListRecord.ElementAt(2).TeamScore)
                            {
                                if (ListRecord.ElementAt(1).Sub == ListRecord.ElementAt(2).Sub)
                                {
                                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Second;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                }
                                else
                                {
                                    if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                    }
                                    else
                                    {
                                        teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                    }
                                }
                            }
                            else
                            {
                                if (ListRecord.ElementAt(2).TeamScore == ListRecord.ElementAt(3).TeamScore && ListRecord.ElementAt(2).Sub == ListRecord.ElementAt(3).Sub)
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Thirst;
                                }
                                else
                                {
                                    teamEndGame.BackgroundImage = Properties.Resources.Fourth;
                                }
                            }
                        }
                    }

                }
                flp_TeamEndGame.Controls.Add(teamEndGame);
            }
        }
        Player Player = new Player();
        PlayerBL PlayerBL = new PlayerBL();
        //Get name of player by id player
        public string nameplayer(int idplayer)
        {
            Player.IDPlayer = idplayer;
            List<Player> Listplayer;
            Listplayer = PlayerBL.GetPlayerByIDplayer(Player);
            return Listplayer.ElementAt(0).PlayerName;
        }
        //Get color of player by id player
        public int colorplayer(int idplayer)
        {
            Player.IDPlayer = idplayer;
            List<Player> Listplayer;
            Listplayer = PlayerBL.GetPlayerByIDplayer(Player);
            return Convert.ToInt32(Listplayer.ElementAt(0).Color);
        }
    }
}
