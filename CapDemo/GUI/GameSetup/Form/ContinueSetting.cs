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
        PhaseQuestionBL PhaseQuestionBL = new PhaseQuestionBL();
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
        // ID contest
        int contestID;
        public int ContestID
        {
            get { return contestID; }
            set { contestID = value; }
        }
        //Checked when game have run
        bool run;
        public bool Run
        {
            get { return run; }
            set { run = value; }
        }

        int i = 1;
        public void next()
        {
            if (i == 1)
            {
                //Save general setting and Load Phase setting
                if (gs.CheckFormEmpty() == false)
                {
                        EditGeneralSetting();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (i == 2)
            {
                if (ps.MoreOnePhase() == true)
                {
                    if (ps.checkPhaseEmpty() == false)
                    {
                        if (ps.PhaseDuplicate() == false)
                        {
                            if (ps.InvalidSequence() == false)
                            {
                                    EditPhaseSetting();
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
            else if (i == 3)
            {
                QuestionSetting qs = new QuestionSetting(contestID);
                if (qs.countquestion() == true)
                {
                    pnl_CreateSetup.Controls.Clear();
                    pnl_CreateSetup.Controls.Add(ts);
                    LoadTeamSetting();
                    i++;
                    lbl_Status.Text = i.ToString() + "/5";
                    if (run == true)
                    {
                        ts.btn_AddTeam.Enabled = false;
                        foreach (Add_Team Add_Team in ts.flp_Team.Controls)
                        {
                            Add_Team.Enabled = false;
                        }
                    }
                    else
                    {
                        ts.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ số lượng câu hỏi cho từng giai đoạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (i == 4)
            {
                //Load Competition setup
                if (ts.MoreOneTeam() == true)
                {
                    if (ts.checkTeamEmpty() == false)
                    {
                        if (ts.checkDuplicateColor() == false)
                        {
                            EditTeamSetting();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin của của đội thi đấu bị trùng nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thông tin cho đội.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm tối thiểu là 2 đội.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Back
        public void back()
        {
            i = i - 1;
            if (i == 4)
            {
                btn_Next.Visible = true;
                btn_Save.Visible = false;
                btn_Back.Visible = true;
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ts);
                LoadTeamSetting();
                if (run == true)
                {
                    ts.btn_AddTeam.Enabled = false;
                    foreach (Add_Team Add_Team in ts.flp_Team.Controls)
                    {
                        Add_Team.Enabled = false;
                    }
                }
                else
                {
                    ts.Enabled = true;
                }

            }
            else if (i == 3)
            {
                QuestionSetting qs = new QuestionSetting(contestID);
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(qs);
                btn_Back.Visible = true;

                if (run == true)
                {
                    qs.btn_DeleteQuestion.Enabled = false;
                    qs.btn_ImportQuestion.Enabled = false;
                }
                else
                {
                    qs.Enabled = true;
                }
            }
            else if (i == 2)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ps);
                LoadPhaseSetting();
                btn_Back.Visible = true;
                if (run == true)
                {
                    ps.btn_AddPhase.Enabled = false;
                    foreach (Add_Phase Add_Phase in ps.flp_Phase.Controls)
                    {
                        Add_Phase.Enabled = false;
                    }
                }
                else
                {
                    ps.Enabled = true;
                }

            }
            else if (i == 1)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(gs);
                LoadGeneralSetting();
                btn_Back.Visible = false;

                if (run == true)
                {
                    gs.Enabled = false;
                }
                else
                {
                    gs.Enabled = true;
                }
            }
        }
        //Click next
        private void btn_Next_Click(object sender, EventArgs e)
        {
            next();
        }
        //click back
        private void btn_Back_Click(object sender, EventArgs e)
        {
            back();
        }
        //load form
        private void ContinueSetting_Load(object sender, EventArgs e)
        {
            //Load general setting
            pnl_CreateSetup.Controls.Add(gs);
            lbl_Status.Text = i.ToString() + "/5";
            LoadGeneralSetting();
            if (run == true)
            {
                gs.Enabled = false;
            }
            else
            {
                gs.Enabled = true;
            }
        }
//General Setting
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
                        gs.cmb_Competition.SelectedItem = ListContest.ElementAt(i).Competition.NameCompetition;
                        gs.txt_ContestName.Text = ListContest.ElementAt(i).NameContest;
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
        //Data general setting
        public void DataGeneralSetting()
        {
            Contest.IDRound = gs.IdRound;
            Contest.NameContest = gs.txt_ContestName.Text.Trim();
            Contest.Bonus = Convert.ToInt32(gs.txt_Bonus.Text);
            Contest.TimesTrue = Convert.ToInt32(gs.txt_NumStepPass.Text);
            Contest.TimesFalse = Convert.ToInt32(gs.txt_NumStepFail.Text);
            if (gs.chk_Question.Checked == true)
            {
                Contest.TimeShowQuestion = Convert.ToInt32(gs.txt_TimeQuestion.Text);
            }
            else
            {
                Contest.TimeShowQuestion = 0;
            }
            if (gs.chk_Answer.Checked == true)
            {
                Contest.TimeShowAnswer = Convert.ToInt32(gs.txt_TimeAnswer.Text);
            }
            else
            {
                Contest.TimeShowAnswer = 0;
            }
        }
        //Save General Setting
        public void EditGeneralSetting()
        {
            DataGeneralSetting();
            Contest.IDContest = contestID;
            if (ContestBL.EditGeneralSetting(Contest) == true)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ps);
                LoadPhaseSetting();
                btn_Back.Visible = true;
                i = i + 1;
                lbl_Status.Text = i.ToString() + "/5";

                if (run == true)
                {
                    ps.btn_AddPhase.Enabled = false;
                    foreach (Add_Phase Add_Phase in ps.flp_Phase.Controls)
                    {
                        Add_Phase.Enabled = false;
                    }
                }
                else
                {
                    ps.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong vòng thi " + gs.cmb_Round.SelectedItem.ToString() + " của cuộc thi " + gs.cmb_Competition.SelectedItem.ToString() + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//PHASE SETTING
        int PhaseTag = 0;
        //Load Phase Setting
        public void LoadPhaseSetting()
        {
            ps.flp_Phase.Controls.Clear();
            List<Phase> ListPhase;
            ListPhase = PhaseBL.GetPhase();
            if (ListPhase != null)
            {
                for (int j = 0; j < ListPhase.Count; j++)
                {
                    if (ListPhase.ElementAt(j).IDContest == contestID)
                    {
                        Add_Phase AddPhase = new Add_Phase();
                        PhaseTag++;
                        AddPhase.Tag = PhaseTag;
                        AddPhase.ID_Phase = PhaseTag;
                        AddPhase.onDelete += AddPhase_onDelete;

                        AddPhase.lbl_IDPhase.Text = ListPhase.ElementAt(j).IDPhase.ToString();
                        AddPhase.txt_PhaseName.Text = ListPhase.ElementAt(j).NamePhase;
                        AddPhase.txt_Time.Text = ListPhase.ElementAt(j).TimePhase.ToString();
                        AddPhase.txt_Score.Text = ListPhase.ElementAt(j).ScorePhase.ToString();
                        AddPhase.txt_Minus.Text = ListPhase.ElementAt(j).MinusPhase.ToString();
                        AddPhase.txt_Sequence.Text = ListPhase.ElementAt(j).Sequence.ToString();
                        ps.flp_Phase.Controls.Add(AddPhase);
                    }
                }
            }
        }
        //Eventhanlder click Del button
        void AddPhase_onDelete(object sender, EventArgs e)
        {
            Add_Phase AddPhase = new Add_Phase();
            int phaseID = (e as MyEventArgs).IDPhase;
            foreach (Add_Phase item in ps.flp_Phase.Controls)
            {
                if (item.ID_Phase == phaseID)
                {
                    Phase.IDPhase = Convert.ToInt32(item.lbl_IDPhase.Text.Trim());
                    PhaseQuestionBL.DeletePhaseQuestionbyIDPhase(Phase);
                    PhaseBL.DeletePhasebyIDPhase(Phase);
                    ps.flp_Phase.Controls.Remove(item);
                }

            }
        }
        //Edit phase Setting
        public void EditPhaseSetting()
        {
            Boolean check = false;
            foreach (Add_Phase item in ps.flp_Phase.Controls)
            {
                int number;
                if (int.TryParse(item.lbl_IDPhase.Text, out number))
                {
                    Phase.IDPhase = Convert.ToInt32(item.lbl_IDPhase.Text.Trim());
                    Phase.IDContest = contestID;
                    Phase.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Phase.NamePhase = item.txt_PhaseName.Text.Trim();
                    Phase.ScorePhase = Convert.ToInt32(item.txt_Score.Text.Trim());
                    Phase.MinusPhase = Convert.ToInt32(item.txt_Minus.Text.Trim());
                    Phase.TimePhase = Convert.ToInt32(item.txt_Time.Text.Trim());
                    //PhaseBL.EditPhasebyID(Phase);
                    if (PhaseBL.EditPhasebyID(Phase) == true)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else
                {
                    Phase.IDContest = contestID;
                    Phase.NamePhase = item.txt_PhaseName.Text.Trim();
                    Phase.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Phase.ScorePhase = Convert.ToInt32(item.txt_Score.Text.Trim());
                    Phase.MinusPhase = Convert.ToInt32(item.txt_Minus.Text.Trim());
                    Phase.TimePhase = Convert.ToInt32(item.txt_Time.Text.Trim());
                    //PhaseBL.AddPhase(Phase);
                    if (PhaseBL.AddPhase(Phase) == true)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            if (check == true)
            {
                QuestionSetting qs = new QuestionSetting(contestID);
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(qs);
                btn_Back.Visible = true;
                i++;
                lbl_Status.Text = i.ToString() + "/5";
                if (run == true)
                {
                    qs.btn_DeleteQuestion.Enabled = false;
                    qs.btn_ImportQuestion.Enabled = false;
                }
                else
                {
                    qs.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Thiết đặt giai đoạn bị lỗi. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
//TEAM SETTING
        int TeamTag = 0;
        //Load Team Setting
        public void LoadTeamSetting()
        {
            ts.flp_Team.Controls.Clear();
            List<Player> ListPlayer;
            ListPlayer = PlayerBL.GetPlayer();
            if (ListPlayer != null)
            {
                for (int j = 0; j < ListPlayer.Count; j++)
                {
                    if (ListPlayer.ElementAt(j).IDContest == contestID)
                    {
                        Add_Team AddTeam = new Add_Team();
                        TeamTag++;
                        AddTeam.Tag = TeamTag;
                        AddTeam.ID_Team = TeamTag;
                        AddTeam.onDelete += AddTeam_onDelete;

                        AddTeam.lbl_IDPlayer.Text = ListPlayer.ElementAt(j).IDPlayer.ToString();
                        AddTeam.txt_Sequence.Text = ListPlayer.ElementAt(j).Sequence.ToString();
                        AddTeam.txt_TeamName.Text = ListPlayer.ElementAt(j).PlayerName.ToString();
                        AddTeam.txt_TeamScore.Text = ListPlayer.ElementAt(j).PlayerScore.ToString();
                        AddTeam.btn_Paint.BackColor = Color.FromArgb(Convert.ToInt32(ListPlayer.ElementAt(j).Color));
                        AddTeam.pnl_ColorCoat.BackColor = Color.FromArgb(Convert.ToInt32(ListPlayer.ElementAt(j).Color));
                        ts.flp_Team.Controls.Add(AddTeam);
                    }
                }
            }
        }
        //Edit team setting
        public void EditTeamSetting()
        {
            bool check = false;
            foreach (Add_Team item in ts.flp_Team.Controls)
            {
                int number;
                if (int.TryParse(item.lbl_IDPlayer.Text, out number))
                {
                    Player.IDPlayer = Convert.ToInt32(item.lbl_IDPlayer.Text.Trim());
                    Player.IDContest = contestID;
                    Player.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Player.PlayerName = item.txt_TeamName.Text.Trim();
                    Player.PlayerScore = Convert.ToInt32(item.txt_TeamScore.Text.Trim());
                    Player.Color = item.btn_Paint.BackColor.ToArgb().ToString();
                    if (PlayerBL.EditPlayerbyID(Player) == true)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                else
                {
                    Player.IDContest = contestID;
                    Player.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                    Player.PlayerName = item.txt_TeamName.Text.Trim();
                    Player.PlayerScore = Convert.ToInt32(item.txt_TeamScore.Text.Trim());
                    Player.Color = item.btn_Paint.BackColor.ToArgb().ToString();
                    if (PlayerBL.AddPlayer(Player) == true)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            if (check == true)
            {
                //Competition_Setting cs = new Competition_Setting(ts.CountTeam());
                cs.AmountPlayer = ts.CountTeam();
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(cs);
///////
                LoadCompetitionSetting();
                btn_Next.Visible = false;
                btn_Save.Visible = true;
                btn_Back.Visible = true;
                i++;
                lbl_Status.Text = i.ToString() + "/5";
                if (run == true)
                {
                    cs.Enabled = false;
                }
                else
                {
                    cs.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Thiết đặt đội bị lỗi. Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Eventhanlder click Del button to Delete team
        void AddTeam_onDelete(object sender, EventArgs e)
        {
            Add_Team AddTeam = new Add_Team();
            int teamID = (e as MyEventArgs).IDTeam;
            foreach (Add_Team item in ts.flp_Team.Controls)
            {
                if (item.ID_Team == teamID)
                {
                    Player.IDPlayer = Convert.ToInt32(item.lbl_IDPlayer.Text.Trim());
                    if (PlayerBL.DeletePlayerbyID(Player))
                    {
                        ts.flp_Team.Controls.Remove(item);
                    }
                    else
                    {
                        MessageBox.Show("cant delete");
                    }

                }

            }
        }
//Click save to finish setup
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cs.txt_ChallengeScore.Text.Trim() != "" && cs.txt_NumTeam.Text.Trim() != "" && cs.txt_TimeForSupport.Text.Trim() != "")
            {
                Contest.IDContest = contestID;
                Contest.ChallengceScore = Convert.ToInt32(cs.txt_ChallengeScore.Text.Trim());
                Contest.NumberChallenge = Convert.ToInt32(cs.txt_NumTeam.Text.Trim());
                Contest.TimeSupport = Convert.ToInt32(cs.txt_TimeForSupport.Text.Trim());

                ContestBL.EditContestbyID(Contest);
                this.Close();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cho phần thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
//Competition Setting
        //load general Setting
        public void LoadCompetitionSetting()
        {
            List<Contest> ListContest;
            ListContest = ContestBL.GetAllSetup();
            if (ListContest != null)
            {
                for (int j = 0; j < ListContest.Count; j++)
                {
                    if (ListContest.ElementAt(j).IDContest == contestID)
                    {
                        //General Setting
                        cs.txt_NumTeam.Text = ListContest.ElementAt(j).NumberChallenge.ToString();
                        cs.txt_ChallengeScore.Text = ListContest.ElementAt(j).ChallengceScore.ToString();
                        cs.txt_TimeForSupport.Text = ListContest.ElementAt(j).TimeSupport.ToString();
                    }
                }
            }
        }
    }
}
