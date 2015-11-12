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
        //Confirm Delete
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //Delete Catalogue and Delete Question
            if (rad_DelCatQuest.Checked == true)
            {
                Catalogue Cat = new Catalogue();
                CatalogueBL CatBL = new CatalogueBL();
                Cat.IDCatalogue = IDCat;
                CatBL.DeleteAnswerByIDCatalogue(Cat);
                CatBL.DeleteQuestionbyIDCatalogue(Cat);
                CatBL.DeleteCataloguebyID(Cat);
                this.Close();
            }
            //Delete Catalogue and Move Question in this Catalogue to Catalogue Unknow
            if (rad_DelCat.Checked == true)
            {
                Catalogue Cat = new Catalogue();
                CatalogueBL CatBL = new CatalogueBL();
                Cat.IDCatalogue = IDCat;
                CatBL.MoveAnserToUnknow(Cat);
                CatBL.MoveQuestionToUnknow(Cat);
                CatBL.DeleteCataloguebyID(Cat);
                this.Close();
            }
        }
        //Cancel Delete
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
