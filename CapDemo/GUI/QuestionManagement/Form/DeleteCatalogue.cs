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

namespace CapDemo.GUI
{
    public partial class DeleteCatalogue : Form
    {
        private int IDCat;
        private string NameCat;

        public DeleteCatalogue()
        {
            InitializeComponent();
        }

        public DeleteCatalogue(int pIDCat, string pNamecat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = pIDCat;
            this.NameCat = pNamecat;
        }
        //Confirm Delete catalogue
        int IDCatUnknow;
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //Delete Catalogue and Delete Question
            if (rad_DelCatQuest.Checked == true)
            {
                Catalogue Cat = new Catalogue();
                CatalogueBL CatBL = new CatalogueBL();
                List<Question> ListQuestion;
                QuestionBL questionBL = new QuestionBL();
                Question question = new Question();
                PhaseQuestionBL phasequestionBL = new PhaseQuestionBL();
                Cat.IDCatalogue = IDCat;
                
                ListQuestion = questionBL.GetQuestionByCatalogue(Cat);
                if (ListQuestion!= null)
                {
                    for (int i = 0; i < ListQuestion.Count; i++)
                    {
                        question.IDQuestion = ListQuestion.ElementAt(i).IDQuestion;
                        phasequestionBL.DeletePhaseQuestionbyIDQuestion(question);
                    }
                }

                CatBL.DeleteAnswerByIDCatalogue(Cat);
                CatBL.DeleteQuestionbyIDCatalogue(Cat);
                if (CatBL.DeleteCataloguebyID(Cat)==true)
                {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Xóa chủ đề và các câu hỏi thuộc chủ đề này thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
                else
                {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Xóa chủ đề không thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
            }
            //Delete Catalogue and Move Question in this Catalogue to Catalogue Unknow
            if (rad_DelCat.Checked == true)
            {
                Catalogue Cat = new Catalogue();
                CatalogueBL CatBL = new CatalogueBL();
                Cat.IDCatalogue = IDCat;
                List<DO.Catalogue> CatList;
                CatList = CatBL.GetCatalogue();
                if (CatList != null)
                    for (int i = 0; i < CatList.Count; i++)
                    {
                        if (CatList.ElementAt(i).NameCatalogue.ToLower() == "unknow")
                        {
                            IDCatUnknow = Convert.ToInt32(CatList.ElementAt(i).IDCatalogue);
                        }
                    }
                CatBL.MoveAnswerToUnknow(Cat, IDCatUnknow);
                CatBL.MoveQuestionToUnknow(Cat, IDCatUnknow);
                if ( CatBL.DeleteCataloguebyID(Cat)==true)
                {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Xóa chủ đề thành công. Các câu hỏi trong chủ đề đã xóa sẽ chuyển đến chủ đề \"Unknow\"";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
                else
                {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Xóa chủ đề không thành công";
                    notifyIcon1.ShowBalloonTip(2000);
                    this.Close();
                }
            }
        }
        //Cancel Delete
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
