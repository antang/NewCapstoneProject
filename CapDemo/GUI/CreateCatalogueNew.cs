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
            if (txt_NameCatalogue.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên chủ đề!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CatalogueBL CatBL = new CatalogueBL();
                Catalogue Cat = new Catalogue();
                Cat.NameCatalogue = txt_NameCatalogue.Text;
                if (CatBL.AddCatalogue(Cat) ==true)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "I am a NotifyIcon Balloon";
                    notifyIcon1.BalloonTipTitle = "Welcome Message";
                    notifyIcon1.ShowBalloonTip(1000);
                    this.Close();
                }
                else
                {

                } 
                
            }
        }

        private void btn_CancelCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
