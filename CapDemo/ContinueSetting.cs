using CapDemo.BL;
using CapDemo.DO;
using CapDemo.GUI.User_Controls;
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
    public partial class ContinueSetting : Form
    {
        private int contestID;

        General_Setting gs = new General_Setting();
        Phase_Setting ps = new Phase_Setting();
        Team_Setting ts = new Team_Setting();
        Competition_Setting cs = new Competition_Setting();
        QuestionSetting qs = new QuestionSetting();

        //BL
        CompetitionBL CompetitionBL = new CompetitionBL();
        RoundBL RoundBL = new RoundBL();
        ContestBL ContestBL = new ContestBL();
        PhaseBL PhaseBL = new PhaseBL();
        PlayerBL PlayerBL = new PlayerBL();
        CatalogueBL CatalogueBL = new BL.CatalogueBL();
        //DO
        Competition Competition = new Competition();
        Round Round = new Round();
        Contest Contest = new Contest();
        Phase Phase = new DO.Phase();
        Player Player = new DO.Player();
        Catalogue Catalogue = new DO.Catalogue();

        public ContinueSetting()
        {
            InitializeComponent();
        }

        public ContinueSetting(int contestID)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.contestID = contestID;
        }
        int i = 1;
        public void next()
        {
            if (i==1)
            {
                //Load Phase setup
                if (gs.CheckFormEmpty() == false)
                {
                    SaveGeneralSetting();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (i==2)
            {

                if (ps.MoreOnePhase() == true)
                {
                    if (ps.checkPhaseEmpty() == false)
                    {
                        if (ps.PhaseDuplicate() == false)
                        {
                            if (ps.InvalidSequence() == false)
                            {
                                SavePhaseSetting();
                            }
                            else
                            {
                                MessageBox.Show("Số thứ tự không hợp lý.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thông tin của giai đoạn bị trùng nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Các trường thông tin không được phép rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Giai đoạn phải tối thiểu là 1 và tối đa là 5.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (i==3)
            {
                QuestionSetting qs = new QuestionSetting(contestID);
                if (qs.countquestion() == true)
                {
                    pnl_CreateSetup.Controls.Clear();
                    pnl_CreateSetup.Controls.Add(ts);
                    i++;
                    lbl_Status.Text = i.ToString() + "/5";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập câu hỏi cho giai đoạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (i==4)
            {
                
            }
        }
        //Click next
        private void btn_Next_Click(object sender, EventArgs e)
        {
            next();
        }
        //load form
        private void ContinueSetting_Load(object sender, EventArgs e)
        {
            //Load general setting
            pnl_CreateSetup.Controls.Add(gs);
            lbl_Status.Text = i.ToString() + "/5";
            LoadGeneralSetting();
        }

        //load general Setting
        public void LoadGeneralSetting()
        {
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();
            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).IDContest == contestID)
                    {
                        //General Setting
                        gs.txt_CompetitionName.Text = ListContest.ElementAt(i).Competition.NameCompetition;
                        gs.txt_CompetitionName.Enabled = false;
                        gs.txt_RoundName.Text = ListContest.ElementAt(i).Round.NameRound;
                        gs.txt_RoundName.Enabled = false;
                        gs.txt_ContestName.Text = ListContest.ElementAt(i).NameContest;
                        gs.txt_ContestName.Enabled = false;
                        gs.txt_Bonus.Text = ListContest.ElementAt(i).Bonus.ToString();
                        gs.txt_NumStepFail.Text = ListContest.ElementAt(i).TimesFalse.ToString();
                        gs.txt_NumStepPass.Text = ListContest.ElementAt(i).TimesTrue.ToString();
                        if (ListContest.ElementAt(i).TimeShowQuestion == 0)
                        {
                            gs.txt_TimeQuestion.Text = "30";
                        }
                        else
                        {
                            gs.chk_Question.Checked = true;
                            gs.txt_TimeQuestion.Text = ListContest.ElementAt(i).TimeShowQuestion.ToString();
                        }

                        if (ListContest.ElementAt(i).TimeShowAnswer == 0)
                        {
                            gs.txt_TimeAnswer.Text = "5";
                        }
                        else
                        {
                            gs.chk_Answer.Checked = true;
                            gs.txt_TimeAnswer.Text = ListContest.ElementAt(i).TimeShowAnswer.ToString();
                        }
                    }
                }
            }
        }
        //Save General Setting
        public void SaveGeneralSetting()
        {
            Contest.IDContest = contestID;
            Contest.NameContest = gs.txt_ContestName.Text;
            Contest.Bonus = Convert.ToInt32(gs.txt_Bonus.Text.Trim());
            Contest.TimesFalse = Convert.ToInt32(gs.txt_NumStepFail.Text.Trim());
            Contest.TimesTrue = Convert.ToInt32(gs.txt_NumStepPass.Text.Trim());

            if (gs.chk_Question.Checked == true)
            {
                Contest.TimeShowQuestion = Convert.ToInt32(gs.txt_TimeQuestion.Text.Trim());
            }
            else
            {
                Contest.TimeShowQuestion = 0;
            }
            if (gs.chk_Answer.Checked == true)
            {
                Contest.TimeShowAnswer = Convert.ToInt32(gs.txt_TimeAnswer.Text.Trim());
            }
            else
            {
                Contest.TimeShowAnswer = 0;
            }

            ContestBL.EditContestbyID(Contest);
            pnl_CreateSetup.Controls.Clear();
            pnl_CreateSetup.Controls.Add(ps);
            i = i + 1;
            lbl_Status.Text = i.ToString() + "/5";
            LoadPhaseSetting();
        }
        //Check phase have already created
        public bool CheckPhaseSetting()
        {
            Phase.IDContest = contestID;
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhaseByIDContest(Phase);
            if (ListPhase != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Load Phase Setting
        public bool LoadPhaseSetting()
        {
            if (CheckPhaseSetting() == true)
            {
                ps.btn_AddPhase.Visible = false;
                List<Phase> ListPhase;
                ListPhase = PhaseBL.GetPhase();
                if (ListPhase != null)
                {
                    for (int j = 0; j < ListPhase.Count; j++)
                    {
                        if (ListPhase.ElementAt(j).IDContest == contestID)
                        {
                            Add_Phase AddPhase = new Add_Phase();
                            AddPhase.lbl_IDPhase.Text = ListPhase.ElementAt(j).IDPhase.ToString();
                            AddPhase.txt_PhaseName.Text = ListPhase.ElementAt(j).NamePhase;
                            AddPhase.txt_Time.Text = ListPhase.ElementAt(j).TimePhase.ToString();
                            AddPhase.txt_Score.Text = ListPhase.ElementAt(j).ScorePhase.ToString();
                            AddPhase.txt_Minus.Text = ListPhase.ElementAt(j).MinusPhase.ToString();
                            AddPhase.txt_Sequence.Text = ListPhase.ElementAt(j).Sequence.ToString();
                            AddPhase.btn_Delete.Visible = false;
                            ps.flp_Phase.Controls.Add(AddPhase);
                        }
                    }
                }
                return true;
            }
            else
            {
                ps.btn_AddPhase.Visible = true;
                return false;
            }
        }

        //Save Phase Setting
        public void SavePhaseSetting()
        {
            if (LoadPhaseSetting() == true)
            {
                foreach (Add_Phase item in ps.flp_Phase.Controls)
                {
                    Phase.IDPhase = Convert.ToInt32(item.lbl_IDPhase.Text.Trim());
                    Phase.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Phase.NamePhase = item.txt_PhaseName.Text.Trim();
                    Phase.ScorePhase = Convert.ToInt32(item.txt_Score.Text.Trim());
                    Phase.MinusPhase = Convert.ToInt32(item.txt_Minus.Text.Trim());
                    Phase.TimePhase = Convert.ToInt32(item.txt_Time.Text.Trim());

                    PhaseBL.EditPhasebyID(Phase);
                }
                QuestionSetting qs = new QuestionSetting(contestID);
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(qs);
                i++;
                lbl_Status.Text = i.ToString() + "/5";
            }
            else
            {
                foreach (Add_Phase item in ps.flp_Phase.Controls)
                {
                    Phase.IDContest = contestID;
                    Phase.NamePhase = item.txt_PhaseName.Text.Trim();
                    Phase.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Phase.ScorePhase = Convert.ToInt32(item.txt_Score.Text.Trim());
                    Phase.MinusPhase = Convert.ToInt32(item.txt_Minus.Text.Trim());
                    Phase.TimePhase = Convert.ToInt32(item.txt_Time.Text.Trim());

                    PhaseBL.AddPhase(Phase);
                }
                QuestionSetting qs = new QuestionSetting(contestID);
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(qs);
                i++;
                lbl_Status.Text = i.ToString() + "/5";
            }
        }

        //Check player have already created
        public bool CheckPlayerSetting()
        {
            Player.IDContest = contestID;
            List<Player> ListPlayer;
            ListPlayer = PlayerBL.GetPlayerByIDContest(Player);
            if (ListPlayer != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Load Player Setting
        public bool LoadPlayerSetting()
        {
            if (CheckPlayerSetting() == true)
            {
                ts.btn_AddTeam.Visible = false;
                List<Player> ListPlayer;
                ListPlayer = PlayerBL.GetPlayer();
                if (ListPlayer != null)
                {
                    for (int j = 0; j < ListPlayer.Count; j++)
                    {
                        if (ListPlayer.ElementAt(j).IDContest  == contestID)
                        {
                            Add_Team AddTeam = new Add_Team();
                            AddTeam.lbl_IDPlayer.Text = ListPlayer.ElementAt(j).IDPlayer.ToString();
                            AddTeam.txt_Sequence.Text = ListPlayer.ElementAt(j).Sequence.ToString();
                            AddTeam.txt_TeamName.Text = ListPlayer.ElementAt(j).PlayerName.ToString();
                            AddTeam.txt_TeamScore.Text = ListPlayer.ElementAt(j).PlayerScore.ToString();
                            AddTeam.btn_Paint.BackColor = Color.FromName(ListPlayer.ElementAt(j).Color.ToString());
                            AddTeam.pnl_ColorCoat.BackColor = Color.FromName(ListPlayer.ElementAt(j).Color.ToString());
                            AddTeam.btn_Delete.Visible = false;

                            ts.flp_Team.Controls.Add(AddTeam);
                        }
                    }
                }
                return true;
            }
            else
            {
                ts.btn_AddTeam.Visible = true;
                return true;
            }
        }
    }
}
