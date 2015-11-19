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
        //SAVE EDIT CATALOGUE
        private void btn_SaveEditCatalogue_Click(object sender, EventArgs e)
        {
            
            if (txt_NameCatalogue.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên chủ đề!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    CatalogueBL CatBL = new CatalogueBL();
                    Catalogue Cat = new Catalogue();
                    Cat.IDCatalogue = IDCat;
                    Cat.NameCatalogue = txt_NameCatalogue.Text.Trim();
                    if (CatBL.EditCataloguebyID(Cat) == true)
                    {
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Chỉnh sửa chủ đề thành công";
                        notifyIcon1.ShowBalloonTip(5000);
                        this.Close();
                    }
                    else
                    {
                        notifyIcon1.Icon = SystemIcons.Warning;
                        notifyIcon1.BalloonTipText = "Chỉnh sửa chủ đề không thành công";
                        notifyIcon1.ShowBalloonTip(5000);
                        this.Close();
                    }
            }
        }
        //EXIT FORM
        private void btn_CancelEditCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //LOAD FORM
        private void EditCatalogue_Load(object sender, EventArgs e)
        {
            txt_NameCatalogue.Text = NameCat;
        }
    }
}
