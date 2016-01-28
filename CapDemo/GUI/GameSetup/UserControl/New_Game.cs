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
        public event EventHandler onDelete;
        //id control
        int iD_NewGame;
        public int ID_NewGame
        {
            get { return iD_NewGame; }
            set { iD_NewGame = value; }
        }
        //checked when game have run
        bool run;
        public bool Run
        {
            get { return run; }
            set { run = value; }
        }
        private void New_Game_Load(object sender, EventArgs e)
        {
        }
        //Double Click to edit setting
        private void New_Game_DoubleClick(object sender, EventArgs e)
        {
            ContinueSetting continueSetting = new ContinueSetting();
            continueSetting.ContestID = Convert.ToInt32(lbl_IDContest.Text);
            continueSetting.Run = run;

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
        //LOAD after edit
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
                    if (ListContest.ElementAt(i).IDContest == Convert.ToInt32(lbl_IDContest.Text) )
                    {
                        lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        lbl_IDContest.Text = ListContest.ElementAt(i).IDContest.ToString();
                        //lbl_Number.Text = (i + 1).ToString();
                        if (ListContest.ElementAt(i).NumberChallenge > 0)
                        {
                            lbl_Status.Text = "Hoàn tất";
                            lbl_Status.ForeColor = Color.Red;
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


        private void New_Game_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(this, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muôn xóa câu hỏi này không?", "Xóa câu hỏi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Contest Contest = new Contest();
                Phase Phase = new Phase();
                Player Player = new Player();
                Record Record = new Record();

                ContestBL ContestBL = new ContestBL();
                PhaseBL PhaseBl = new PhaseBL();
                PlayerBL PlayerBL = new PlayerBL();
                PhaseQuestionBL PhaseQuestionBL = new PhaseQuestionBL();
                RecordBL RecordBL = new RecordBL();

                Contest.IDContest = Convert.ToInt32(lbl_IDContest.Text);
                Phase.IDContest = Convert.ToInt32(lbl_IDContest.Text);
                Player.IDContest = Convert.ToInt32(lbl_IDContest.Text);
                Record.IDContest = Convert.ToInt32(lbl_IDContest.Text);

                RecordBL.DeleteRecordByIDContest(Record);
                PhaseQuestionBL.DeletePhaseQuestionbyIDContest(Phase);
                PlayerBL.DeletePlayerbyIDContest(Player);
                PhaseBl.DeletePhasebyIDContest(Phase);
                ContestBL.DeleteContestbyID(Contest);
                LoadAll();

                EventHandler delete = onDelete;

                if (delete != null)
                {
                    MyEventArgs args = new MyEventArgs();
                    args.IDNewGame = iD_NewGame;
                    delete(this, args);
                }
            }
        }
        //Load all Setup
        public void LoadAll()
        {
            Setting_Game sg = new Setting_Game();
            sg.flp_Game.Controls.Clear();
            ContestBL ContestBL = new ContestBL();
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();

            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    //New_Game game = new New_Game();
                    lbl_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                    lbl_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                    lbl_ContestName.Text = ListContest.ElementAt(i).NameContest;
                    lbl_IDContest.Text = ListContest.ElementAt(i).IDContest.ToString();
                    //lbl_Number.Text = (i + 1).ToString();
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
                    sg.flp_Game.Controls.Add(this);
                }
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void New_Game_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void New_Game_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }
        
    }
}
