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

namespace CapDemo.GUI
{
    public partial class Add_New_Game : Form
    {
        public Add_New_Game()
        {
            InitializeComponent();
        }
        General_Setting gs = new General_Setting();
        Phase_Setting ps = new Phase_Setting();
        Team_Setting ts = new Team_Setting();
        //Competition_Setting cs = new Competition_Setting();
        

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

        int add = 0;
        int AddPhase = 0;
        int AddPlayer = 0;
        private void Add_New_Game_Load(object sender, EventArgs e)
        {
            //Load general setting
            pnl_CreateSetup.Controls.Add(gs);
            btn_Back.Visible = false;
            lbl_Status.Text = i.ToString() + "/5";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
                    Next();  
        }
        int i = 1;
        public void Next()
        {
            
            if (i == 1)
            {
                //Load Phase setup
                if (gs.CheckFormEmpty()==false)
                {
                    if (add==0)
                    {
                        SaveCompetition();
                    }
                    else
                    {
                        DeleteContest();
                        SaveCompetition();
                    }
                   //end save general setting 
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if (i == 2)
            {
                //Load Team setup
                if (ps.MoreOnePhase()==true)
                {
                    if (ps.checkPhaseEmpty()==false)
                    {
                        if (ps.PhaseDuplicate()==false)
                        {
                            if (ps.InvalidSequence() == false)
                            {
                                if (AddPhase == 0)
                                {
                                    SavePhase();
                                }
                                else
                                {
                                    Deletephase();
                                    SavePhase();
                                }
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
                QuestionSetting qs = new QuestionSetting(IdContest);
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
            else if (i == 4)
            {
                //Load Competition setup
                if (ts.MoreOneTeam() == true)
                {
                    if (ts.checkTeamEmpty() == false)
                    {
                        //MessageBox.Show(""+ ts.checkDuplicateColor());
                        if (ts.checkDuplicateColor() == false)
                        {
                            if (AddPlayer == 0)
                            {
                                SavePlayer();
                            }
                            else
                            {

                            }
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Back();
        }
        //Method Back
        public void Back()
        {
            i = i - 1;
            if (i == 4)
            {
                btn_Next.Visible = true;
                btn_Save.Visible = false;
                //btn_Back.Visible = true;
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ts);

            }
            else if (i == 3)
            {
                QuestionSetting qs = new QuestionSetting(IdContest);
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(qs);
                //btn_Back.Visible = false;
            }
            else if (i == 2)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ps);
                btn_Back.Visible = false;

            }
            else if (i == 1)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(gs);
                btn_Back.Visible = false;
            }
        }
       
        //finish setting
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Competition_Setting cs = new Competition_Setting(ts.CountTeam());
            if (cs.checkFormEmpty() == true)
            {
                MessageBox.Show("Vui lòng nhập thông tin cho phần thi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Contest.IDContest = IdContest;
                Contest.ChallengceScore = Convert.ToInt32(cs.txt_ChallengeScore.Text.Trim());
                Contest.NumberChallenge = Convert.ToInt32(cs.txt_NumTeam.Text.Trim());
                Contest.RequestTime = Convert.ToInt32(cs.txt_TimeForSupport.Text.Trim());

                ContestBL.EditContestbyID(Contest);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            
        }
        //data competion
        public void DataAddCompetition()
        {
            //competition
            Competition.NameCompetition = gs.txt_CompetitionName.Text.Trim();
            //Round
            Round.NameRound = gs.txt_RoundName.Text.Trim();
            //contest
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

        int IdCompetition;
        int IdRound;
        public int IdContest;
        //Get ID competition
        public void GetIdCompetition()
        {
            List<Competition> ListCompetition;
            ListCompetition = CompetitionBL.GetCompetition();
            if (ListCompetition != null)
            {
                for (int j = 0; j < ListCompetition.Count; j++)
                {
                    if (ListCompetition.ElementAt(j).NameCompetition == gs.txt_CompetitionName.Text.Trim())
                    {
                        Round.IDCompetition = ListCompetition.ElementAt(j).IDCompetition;
                        IdCompetition = ListCompetition.ElementAt(j).IDCompetition;
                    }
                }
            }
        }
        //Gei id round
        public void GetIdRound()
        {
            List<Round> ListRound;
            ListRound = RoundBL.GetRound();
            if (ListRound != null)
            {
                for (int j = 0; j < ListRound.Count; j++)
                {
                    if (ListRound.ElementAt(j).NameRound == gs.txt_RoundName.Text.Trim() && ListRound.ElementAt(j).IDCompetition == IdCompetition)
                    {
                        Contest.IDRound = ListRound.ElementAt(j).IDRound;
                        IdRound = ListRound.ElementAt(j).IDRound;
                    }
                }
            }
        }
        //Get id contest
        public void GetIdContest()
        {
            //Get id contest
            List<Contest> ListContest;
            ListContest = ContestBL.GetContest();
            if (ListContest != null)
            {
                for (int j = 0; j < ListContest.Count; j++)
                {
                    if (ListContest.ElementAt(j).NameContest == gs.txt_ContestName.Text.Trim() && ListContest.ElementAt(j).IDRound ==  IdRound)
                    {
                        IdContest = ListContest.ElementAt(j).IDContest;
                    }
                }
            }
        }
        //Delete Contest
        public void DeleteContest()
        {
            //Contest.IDContest = ContestBL.MaxIDContest();
            Contest.IDContest = IdContest;
            ContestBL.DeleteContestbyID(Contest);
        }
        //add competition
        public void SaveCompetition()
        {
            DataAddCompetition();
            if (CompetitionBL.AddCompetition(Competition) == true)
            {
                GetIdCompetition();
                if (RoundBL.AddRound(Round) == true)
                {
                    GetIdRound();
                    if (ContestBL.AddContest(Contest) == true)
                    {
                        GetIdContest();
                        pnl_CreateSetup.Controls.Clear();
                        pnl_CreateSetup.Controls.Add(ps);
                        btn_Back.Visible = false;
                        i = i + 1;
                        lbl_Status.Text = i.ToString() + "/5";
                        //return true;
                        add++;
                    }
                    else
                    {
                        MessageBox.Show("Phần thi "+gs.txt_ContestName.Text+" đã tồn tại trong "+gs.txt_RoundName.Text+" của cuộc thi "+gs.txt_CompetitionName.Text+".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return false;
                    }
                }
                else
                {
                    GetIdRound();
                    if (ContestBL.AddContest(Contest) == true)
                    {
                        GetIdContest();
                        pnl_CreateSetup.Controls.Clear();
                        pnl_CreateSetup.Controls.Add(ps);
                        btn_Back.Visible = false;
                        i = i + 1;
                        add++;
                        //return true;
                    }
                    else
                    {
                        MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return false;
                    }
                }
            }
            else
            {
                GetIdCompetition();
                if (RoundBL.AddRound(Round) == true)
                {
                    GetIdRound();
                    if (ContestBL.AddContest(Contest) == true)
                    {
                        GetIdContest();
                        pnl_CreateSetup.Controls.Clear();
                        pnl_CreateSetup.Controls.Add(ps);
                        btn_Back.Visible = false;
                        i = i + 1;
                        add++;
                        //return true;
                    }
                    else
                    {
                        MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      
                        //return false;
                    }
                }
                else
                {
                    GetIdRound();
                    if (ContestBL.AddContest(Contest) == true)
                    {
                        GetIdContest();
                        pnl_CreateSetup.Controls.Clear();
                        pnl_CreateSetup.Controls.Add(ps);
                        btn_Back.Visible = false;
                        i = i + 1;
                        add++;
                        //return true;
                    }
                    else
                    {
                        MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // return false;
                    }
                }
            }
        }
        //public save phase
        public void SavePhase()
        {
            foreach ( Add_Phase item in ps.flp_Phase.Controls)
            {
                Phase.IDContest = IdContest;
                Phase.NamePhase = item.txt_PhaseName.Text.Trim();
                Phase.Sequence = Convert.ToInt32(item.txt_Sequence.Text.Trim());
                Phase.ScorePhase = Convert.ToInt32(item.txt_Score.Text.Trim());
                Phase.MinusPhase = Convert.ToInt32(item.txt_Minus.Text.Trim());
                Phase.TimePhase = Convert.ToInt32(item.txt_Time.Text.Trim());

                PhaseBL.AddPhase(Phase);
            }
            QuestionSetting qs = new QuestionSetting(IdContest);
            pnl_CreateSetup.Controls.Clear();
            pnl_CreateSetup.Controls.Add(qs);
            btn_Back.Visible = false;
            i++;
            lbl_Status.Text = i.ToString() + "/5";
            AddPhase++;
        }
        //delete phase
        public void Deletephase()
        {
            Phase.IDContest = IdContest;
            PhaseBL.DeletePhasebyID(Phase);
        }
        
        //Save player
        public void SavePlayer()
        {
            foreach (Add_Team item in ts.flp_Team.Controls)
            {
                Player.IDContest = IdContest;
                Player.PlayerName = item.txt_TeamName.Text.Trim();
                Player.PlayerScore = Convert.ToInt32(item.txt_TeamScore.Text);
                Player.Color = item.btn_Paint.BackColor.Name;
                Player.Sequence = Convert.ToInt32(item.txt_Sequence.Text);

                PlayerBL.AddPlayer(Player);
            }
            Competition_Setting cs = new Competition_Setting(ts.CountTeam());
            pnl_CreateSetup.Controls.Clear();
            pnl_CreateSetup.Controls.Add(cs);
            btn_Next.Visible = false;
            btn_Save.Visible = true;
            btn_Back.Visible = false;
            i++;
            lbl_Status.Text = i.ToString() + "/5";
            AddPlayer++;
        }
    }
}
