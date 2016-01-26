using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.GUI;
using CapDemo.DO;
using CapDemo.BL;

namespace CapDemo
{
    public partial class QuestionSetting : UserControl
    {
        public QuestionSetting()
        {
            InitializeComponent();
        }

        public QuestionSetting(int IdContest)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IdContest = IdContest;
        }
        
        Phase Phase = new Phase();
        PhaseBL phaseBL = new PhaseBL();
        PhaseQuestionBL PhaseQuestionBL = new PhaseQuestionBL();
        private int IdContest;
        //load form
        private void QuestionSetting_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            List<Phase> ListPhase;
            ListPhase = phaseBL.GetPhase();
            if (ListPhase !=null)
            {
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    if (ListPhase.ElementAt(i).IDContest == IdContest)
                    {
                        lb_Phase.Items.Add(ListPhase.ElementAt(i).NamePhase);
                    }   
                }
            }
        }

        
        //import question for phase
        private void btn_ImportQuestion_Click(object sender, EventArgs e)
        {
            if (lb_Phase.SelectedItem==null)
            {
                MessageBox.Show("Vui lòng chọn giai đoạn","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idPhase = 0;
                Phase.IDContest = IdContest;
                List<Phase> ListPhase;
                ListPhase = phaseBL.GetPhaseByIDContest(Phase);
                if (ListPhase != null)
                {
                    for (int i = 0; i < ListPhase.Count; i++)
                    {
                        if (ListPhase.ElementAt(i).NamePhase == lb_Phase.SelectedItem.ToString())
                        {
                            idPhase = ListPhase.ElementAt(i).IDPhase;
                        }
                    }
                }

                GetQuestion getQuestion = new GetQuestion(idPhase,IdContest);
                getQuestion.ShowDialog();
                load();
            }
        }
        //load question
        public void load()
        {
            //int idPhase = 0;
            Phase.IDContest = IdContest;
            List<Phase> ListPhase;
            ListPhase = phaseBL.GetPhaseByIDContest(Phase);
            if (ListPhase != null)
            {
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    if (ListPhase.ElementAt(i).NamePhase == lb_Phase.SelectedItem.ToString())
                    {
                        Phase.IDPhase = ListPhase.ElementAt(i).IDPhase;
                    }
                }
            }
            //if (lb_Phase.Items.Count > 0)
            //{
            //    lb_Phase.SelectedIndex = 0;
            //}
            
            List<DO.Phase> PhaseList;
            //PhaseList = PhaseQuestionBL.getquestionByIDPhase(Phase);
            PhaseList = PhaseQuestionBL.getquestionRunGameS(Phase);
            if (PhaseList != null)
            {
                dgv_Question.DataSource = PhaseList;
            }
            
            dgv_Question.Columns["IDContest"].Visible = false;
            dgv_Question.Columns["IDPhase"].Visible = false;
            dgv_Question.Columns["NamePhase"].Visible = false;
            dgv_Question.Columns["ScorePhase"].Visible = false;
            dgv_Question.Columns["MinusPhase"].Visible = false;
            dgv_Question.Columns["TimePhase"].Visible = false;
            dgv_Question.Columns["Sequence"].Visible = false;
            dgv_Question.Columns["Status"].Visible = false;

            dgv_Question.Columns["IDQuestion"].Visible = false;

            dgv_Question.Columns["SequenceQuestion"].HeaderText = "STT";
            dgv_Question.Columns["NameQuestion"].HeaderText = "Tên Câu Hỏi";
            dgv_Question.Columns["TypeQuestion"].HeaderText = "Loại Câu hỏi";
            dgv_Question.Columns["StatusShow"].HeaderText = "Trạng thái";

            dgv_Question.Columns["SequenceQuestion"].ReadOnly = true;
            dgv_Question.Columns["NameQuestion"].ReadOnly = true;
            dgv_Question.Columns["TypeQuestion"].ReadOnly = true;
            dgv_Question.Columns["StatusShow"].ReadOnly = true;

            dgv_Question.Columns["SequenceQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["TypeQuestion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgv_Question.Columns["StatusShow"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        //Select listbox to show question
        private void lb_Phase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_Phase.SelectedItem != null)
            {
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên giai đoạn.");
            }

        }
        //Delete question
        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            int RowSelect = dgv_Question.SelectedRows.Count;

            if (RowSelect > 0 && lb_Phase.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muôn xóa câu hỏi này không?", "Xóa câu hỏi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Phase.IDContest = IdContest;
                    List<Phase> ListPhase;
                    ListPhase = phaseBL.GetPhaseByIDContest(Phase);
                    if (ListPhase != null)
                    {
                        for (int i = 0; i < ListPhase.Count; i++)
                        {
                            if (ListPhase.ElementAt(i).NamePhase == lb_Phase.SelectedItem.ToString())
                            {
                                Phase.IDPhase = ListPhase.ElementAt(i).IDPhase;
                            }
                        }
                    }
                    foreach (DataGridViewRow item in this.dgv_Question.SelectedRows)
                    {
                        Phase.IDQuestion = Convert.ToInt32(item.Cells["IDQuestion"].Value.ToString());
                        PhaseQuestionBL.DeleteQuestionbyID(Phase);
                    }
                    load();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để xóa.","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //count question each phase
        public bool countquestion()
        {
            Phase.IDContest = IdContest;
            List<Phase> ListPhase;
            //get contest
            //Contest contest = new Contest();
            //ContestBL contestBL = new ContestBL();
            //contest.IDContest = IdContest;
            //List<Contest> ListContest;
            //ListContest = contestBL.GetContestByID(contest);

            int check =0;
            ListPhase = phaseBL.GetPhaseByIDContest(Phase);
            if (ListPhase != null)
            {
                for (int i = 0; i < ListPhase.Count; i++)
                {
                    int count = 0;
                    Phase.IDPhase = ListPhase.ElementAt(i).IDPhase;

                    List<DO.Phase> QuestionListInPhase;
                    //QuestionListInPhase = PhaseQuestionBL.getquestionByIDPhase(Phase);
                    QuestionListInPhase = PhaseQuestionBL.getquestionRunGame(Phase);
                    if (QuestionListInPhase != null)
                    {
                        for (int j = 0; j < QuestionListInPhase.Count; j++)
                        {
                            count++;
                        }
                        if (count == 0 || count < 20 )
                        {
                            check++;
                        }
                    }
                }
            }
            if (check == 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
        
    }
}
