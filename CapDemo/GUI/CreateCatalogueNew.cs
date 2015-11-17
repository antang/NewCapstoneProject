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
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm chủ đề \"" + txt_NameCatalogue.Text + "\" thành công";
                    notifyIcon1.ShowBalloonTip(5000);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chủ đề này đã tồn tại trong hệ thống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                
            }
        }

        private void btn_CancelCatalogue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
