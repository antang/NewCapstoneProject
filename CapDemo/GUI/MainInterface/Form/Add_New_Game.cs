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
        Competition_Setting cs = new Competition_Setting();

        int add = 0;
        private void Add_New_Game_Load(object sender, EventArgs e)
        {
            //Load general setting
            pnl_CreateSetup.Controls.Add(gs);
            btn_Back.Visible = false;
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
                        pnl_CreateSetup.Controls.Clear();
                        pnl_CreateSetup.Controls.Add(ts);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập thông tin cho giai đoạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng thêm tối thiểu là 1 chủ đề.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (i == 3)
            {
                //Load Competition setup
                if (ts.MoreOneTeam() ==true)
                {
                    if (ts.checkPhaseEmpty()==false)
                    {
                        //MessageBox.Show(""+ ts.checkDuplicateColor());
                        if (ts.checkDuplicateColor()==false)
                        {
                            pnl_CreateSetup.Controls.Clear();
                            pnl_CreateSetup.Controls.Add(cs);
                            btn_Next.Visible = false;
                            btn_Save.Visible = true;
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("Màu hoặc tên của đội bị trùng nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (i == 3)
            {
                btn_Next.Visible = true;
                btn_Save.Visible = false;
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ts);

            }
            else if (i == 2)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(ps);

            }
            else if (i == 1)
            {
                pnl_CreateSetup.Controls.Clear();
                pnl_CreateSetup.Controls.Add(gs);
                btn_Back.Visible = false;

            }
        }
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cs.checkFormEmpty()==false)
            {
                if (Convert.ToInt32(cs.txt_NumTeam.Text) > ts.CountTeam()-1)
                {
                    MessageBox.Show("Số lượng đội bị thác đấu phải nhỏ hơn số lượng tổng các đội.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //competition
                    Competition.NameCompetition = gs.txt_CompetitionName.Text.Trim();
                    //contest
                    Contest.NameContest = gs.txt_ContestName.Text.Trim();
                    Contest.Bonus =Convert.ToInt32(gs.txt_Bonus.Text);
                    Contest.TimesTrue = Convert.ToInt32(gs.txt_NumStepPass.Text);
                    Contest.TimesFalse = Convert.ToInt32(gs.txt_NumStepFail.Text);
                    if (gs.chk_Question.Checked ==true)
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
                    
                    //contest
                    //Contest.RequestTime = Convert.ToInt32(cs.txt_TimeForSupport.Text);
                    //Contest.NumberChallenge = Convert.ToInt32(cs.txt_NumTeam.Text);
                    //Contest.ChallengceScore = Convert.ToInt32(cs.txt_ChallengeScore.Text);

                    if (CompetitionBL.AddCompetition(Competition)==true)
                    {
                        //round
                        Round.NameRound = gs.txt_RoundName.Text.Trim();
                        //Get ID Competition
                        List<Competition> ListCompetition;
                        ListCompetition = CompetitionBL.GetCompetition();
                        if (ListCompetition != null)
                        {
                            for (int i = 0; i < ListCompetition.Count; i++)
                            {
                                if (ListCompetition.ElementAt(i).NameCompetition == gs.txt_CompetitionName.Text.Trim())
                                {
                                    Round.IDCompetition = ListCompetition.ElementAt(i).IDCompetition;
                                }
                            }
                        }

                        if (RoundBL.AddRound(Round)==true)
                        {
                            //Get id Round
                            List<Round> ListRound;
                            ListRound = RoundBL.GetRound();
                            if (ListRound != null)
                            {
                                for (int i = 0; i < ListRound.Count; i++)
                                {
                                    if (ListRound.ElementAt(i).NameRound == gs.txt_RoundName.Text.Trim())
                                    {
                                        Contest.IDRound = ListRound.ElementAt(i).IDRound;
                                    }
                                }
                            }
                            if (ContestBL.AddContest(Contest)==true)
                            {

                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            //Get id Round
                            List<Round> ListRound;
                            ListRound = RoundBL.GetRound();
                            if (ListRound != null)
                            {
                                for (int i = 0; i < ListRound.Count; i++)
                                {
                                    if (ListRound.ElementAt(i).NameRound == gs.txt_RoundName.Text.Trim())
                                    {
                                        Contest.IDRound = ListRound.ElementAt(i).IDRound;
                                    }
                                }
                            }
                            if (ContestBL.AddContest(Contest) == true)
                            {
                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        //round
                        Round.NameRound = gs.txt_RoundName.Text.Trim();
                        //Get ID Competition
                        List<Competition> ListCompetition;
                        ListCompetition = CompetitionBL.GetCompetition();
                        if (ListCompetition != null)
                        {
                            for (int i = 0; i < ListCompetition.Count; i++)
                            {
                                if (ListCompetition.ElementAt(i).NameCompetition == gs.txt_CompetitionName.Text.Trim())
                                {
                                    Round.IDCompetition = ListCompetition.ElementAt(i).IDCompetition;
                                }
                            }
                        }

                        if (RoundBL.AddRound(Round) == true)
                        {
                            //Get id Round
                            List<Round> ListRound;
                            ListRound = RoundBL.GetRound();
                            if (ListRound != null)
                            {
                                for (int i = 0; i < ListRound.Count; i++)
                                {
                                    if (ListRound.ElementAt(i).NameRound == gs.txt_RoundName.Text.Trim())
                                    {
                                        Contest.IDRound = ListRound.ElementAt(i).IDRound;
                                    }
                                }
                            }
                            if (ContestBL.AddContest(Contest) == true)
                            {

                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            //Get id Round
                            List<Round> ListRound;
                            ListRound = RoundBL.GetRound();
                            if (ListRound != null)
                            {
                                for (int i = 0; i < ListRound.Count; i++)
                                {
                                    if (ListRound.ElementAt(i).NameRound == gs.txt_RoundName.Text.Trim())
                                    {
                                        Contest.IDRound = ListRound.ElementAt(i).IDRound;
                                    }
                                }
                            }
                            if (ContestBL.AddContest(Contest) == true)
                            {
                                PhaseAndPlayer();
                                this.Close();
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("phần thi đã tồn tại trong vòng "+gs.txt_RoundName.Text+" của cuộc thi "+gs.txt_CompetitionName.Text+".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void PhaseAndPlayer(){

            string AllPhase = ps.getPhase();
            string AllPlayer = ts.getPlayer();
            //Get ID contest
            List<Contest> ListContest;
            ListContest = ContestBL.GetContest();
            if (ListContest != null)
            {
                for (int i = 0; i < ListContest.Count; i++)
                {
                    if (ListContest.ElementAt(i).NameContest == gs.txt_ContestName.Text.Trim())
                    {
                        //Get each id contet for phase, player
                        Phase.IDContest = ListContest.ElementAt(i).IDContest;
                        Player.IDContest = ListContest.ElementAt(i).IDContest;
                    }
                }
            }
            //phase
            string[] OnePhase = AllPhase.Split(new string[] { "</Phase!@>" }, StringSplitOptions.None);
            for (int i = 0; i < OnePhase.Length - 1; i++)
            {
                string[] ItemPhase = OnePhase[i].Split(new string[] { "</ItemPhase>" }, StringSplitOptions.None);
                //Get ID catalogue
                List<Catalogue> ListCatalogue;
                ListCatalogue = CatalogueBL.GetCatalogue();
                if (ListCatalogue != null)
                {
                    for (int j = 0; j < ListCatalogue.Count; j++)
                    {
                        if (ListCatalogue.ElementAt(j).NameCatalogue == ItemPhase[0].ToString())
                        {
                            Phase.IDCatalogue = ListCatalogue.ElementAt(j).IDCatalogue;
                        }
                    }
                }

                // get Each item in phase
                Phase.NamePhase = ItemPhase[0].ToString();
                Phase.ScorePhase = Convert.ToInt32(ItemPhase[1].ToString());
                Phase.MinusPhase = Convert.ToInt32(ItemPhase[2].ToString());
                Phase.TimePhase = Convert.ToInt32(ItemPhase[3].ToString());
                //save phase
                PhaseBL.AddPhase(Phase);
            }

            string[] OnePlayer = AllPlayer.Split(new string[] { "</Player!@>" }, StringSplitOptions.None);
            for (int i = 0; i < OnePlayer.Length - 1; i++)
            {
                string[] ItemPlayer = OnePlayer[i].Split(new string[] { "</ItemPlayer>" }, StringSplitOptions.None);
                //Get each item in player
                Player.PlayerName = ItemPlayer[0].ToString();
                Player.PlayerScore = Convert.ToInt32(ItemPlayer[1].ToString());
                Player.Color = ItemPlayer[2].ToString();
                //save player
                PlayerBL.AddPlayer(Player);
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

        //public void DataEditCompetition()
        //{
        //    ////competition
        //    //Competition.NameCompetition = gs.txt_CompetitionName.Text.Trim();
        //    //List<Competition> ListCompetition;
        //    //ListCompetition = CompetitionBL.GetCompetition();
        //    //if (ListCompetition != null)
        //    //{
        //    //    for (int j = 0; j < ListCompetition.Count; j++)
        //    //    {
        //    //        if (ListCompetition.ElementAt(j).NameCompetition == gs.txt_CompetitionName.Text.Trim())
        //    //        {
        //    //            Competition.IDCompetition = ListCompetition.ElementAt(j).IDCompetition;
        //    //            Round.IDCompetition = ListCompetition.ElementAt(j).IDCompetition;
        //    //        }
        //    //    }
        //    //}
        //    ////Round
        //    //Round.NameRound = gs.txt_RoundName.Text.Trim();
        //    //List<Round> ListRound;
        //    //ListRound = RoundBL.GetRound();
        //    //if (ListRound != null)
        //    //{
        //    //    for (int j = 0; j < ListRound.Count; j++)
        //    //    {
        //    //        if (ListRound.ElementAt(j).NameRound == gs.txt_RoundName.Text.Trim())
        //    //        {
        //    //            //Round.IDCompetition = ListRound.ElementAt(j).IDCompetition;
        //    //            Round.IDRound = ListRound.ElementAt(j).IDRound;
        //    //            Contest.IDRound = ListRound.ElementAt(j).IDRound;
        //    //        }
        //    //    }
        //    //}
        //    //contest
        //    Contest.IDContest = IdContest;
        //    Contest.IDRound = IdRound;
        //    Contest.NameContest = gs.txt_ContestName.Text.Trim();
        //    Contest.Bonus = Convert.ToInt32(gs.txt_Bonus.Text);
        //    Contest.TimesTrue = Convert.ToInt32(gs.txt_NumStepPass.Text);
        //    Contest.TimesFalse = Convert.ToInt32(gs.txt_NumStepFail.Text);
        //    if (gs.chk_Question.Checked == true)
        //    {
        //        Contest.TimeShowQuestion = Convert.ToInt32(gs.txt_TimeQuestion.Text);
        //    }
        //    else
        //    {
        //        Contest.TimeShowQuestion = 0;
        //    }
        //    if (gs.chk_Answer.Checked == true)
        //    {
        //        Contest.TimeShowAnswer = Convert.ToInt32(gs.txt_TimeAnswer.Text);
        //    }
        //    else
        //    {
        //        Contest.TimeShowAnswer = 0;
        //    }
        //}
        int IdCompetition;
        int IdRound;
        int IdContest;
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

        public void DeleteContest()
        {
            Contest.IDContest = ContestBL.MaxIDContest();
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
                        btn_Back.Visible = true;
                        i = i + 1;
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
                        btn_Back.Visible = true;
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
                        btn_Back.Visible = true;
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
                        btn_Back.Visible = true;
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

        //edit competition
        //public void EditCompetition()
        //{
        //    DataEditCompetition();

        //    //save competition
        //    if (CompetitionBL.EditCompetitionbyID(Competition) == true)
        //    {
        //        if (RoundBL.EditRoundbyID(Round) == true)
        //        {
        //            if (ContestBL.EditContestbyID(Contest) == true)
        //            {
        //                pnl_CreateSetup.Controls.Clear();
        //                pnl_CreateSetup.Controls.Add(ps);
        //                btn_Back.Visible = true;
        //                i = i + 1;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            if (ContestBL.EditContestbyID(Contest) == true)
        //            {
        //                pnl_CreateSetup.Controls.Clear();
        //                pnl_CreateSetup.Controls.Add(ps);
        //                btn_Back.Visible = true;
        //                i = i + 1;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (RoundBL.EditRoundbyID(Round) == true)
        //        {
        //            if (ContestBL.EditContestbyID(Contest) == true)
        //            {
        //                pnl_CreateSetup.Controls.Clear();
        //                pnl_CreateSetup.Controls.Add(ps);
        //                btn_Back.Visible = true;
        //                i = i + 1;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            if (ContestBL.EditContestbyID(Contest) == true)
        //            {
        //                pnl_CreateSetup.Controls.Clear();
        //                pnl_CreateSetup.Controls.Add(ps);
        //                btn_Back.Visible = true;
        //                i = i + 1;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Phần thi " + gs.txt_ContestName.Text + " đã tồn tại trong " + gs.txt_RoundName.Text + " của cuộc thi " + gs.txt_CompetitionName.Text + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}
    }
}
