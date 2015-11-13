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
            
            if (txt_NameCatalogue.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chủ đề!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CatalogueBL CatBL = new CatalogueBL();
                Catalogue Cat = new Catalogue();
                Cat.IDCatalogue = IDCat;
                Cat.NameCatalogue = txt_NameCatalogue.Text;
                if (CatBL.EditCataloguebyID(Cat) == true)
                {
                    
                    this.Close();
                }
                else
                {

                }
            }
            
            
            this.Close();
        }

        private void btn_CancelEditCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCatalogue_Load(object sender, EventArgs e)
        {
            txt_NameCatalogue.Text = NameCat;
            //notifyIcon1.Text = "My applicaiton";
            //notifyIcon1.Visible = true;
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipText = "I am a NotifyIcon Balloon";
            //notifyIcon1.BalloonTipTitle = "Welcome Message";
            //notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
