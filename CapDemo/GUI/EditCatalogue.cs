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
    public partial class EditCatalogue : Form
    {
        private int IDCat;
        private string NameCat;

        public EditCatalogue()
        {
            InitializeComponent();
        }

        public EditCatalogue(int pIDCat, string pNameCat)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.IDCat = pIDCat;
            this.NameCat = pNameCat;
        }

        private void btn_SaveEditCatalogue_Click(object sender, EventArgs e)
        {
            CatalogueBL CatBL = new CatalogueBL();
            Catalogue Cat = new Catalogue();
            Cat.IDCatalogue = IDCat;
            Cat.NameCatalogue = txt_NameCatalogue.Text;
            CatBL.EditCataloguebyID(Cat);
            this.Close();
        }

        private void btn_CancelEditCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCatalogue_Load(object sender, EventArgs e)
        {
            txt_NameCatalogue.Text = NameCat;
        }
    }
}
