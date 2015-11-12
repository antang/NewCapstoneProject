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
    public partial class CreateCatalogueNew : Form
    {
        public CreateCatalogueNew()
        {
            InitializeComponent();
        }

        private void btn_SaveCatalogue_Click(object sender, EventArgs e)
        {
            CatalogueBL CatBL = new CatalogueBL();
            Catalogue Cat = new Catalogue();
            Cat.NameCatalogue = txt_NameCatalogue.Text;
            CatBL.AddCatalogue(Cat);
            this.Close();

        }

        private void btn_CancelCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
