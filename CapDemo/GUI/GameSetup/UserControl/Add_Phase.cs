using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapDemo.BL;

namespace CapDemo.GUI.User_Controls
{
    public partial class Add_Phase : UserControl
    {
        public Add_Phase()
        {
            InitializeComponent();
        }
        public event EventHandler onDelete;
        int iD_Phase;
        public int ID_Phase
        {
            get { return iD_Phase; }
            set { iD_Phase = value; }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            EventHandler delete = onDelete;

            if (delete != null)
            {
                MyEventArgs args = new MyEventArgs();
                args.IDPhase = iD_Phase;
                delete(this, args);
            }
        }
        private bool nonNumberEntered = false;
        //input score for phase
        private void txt_Score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_Score_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        //Load
        private void Add_Phase_Load(object sender, EventArgs e)
        {
            //CatalogueBL CatBL = new CatalogueBL();
            //List<DO.Catalogue> CatList;
            //CatList = CatBL.GetCatalogue();
            //if (CatList != null)
            //    for (int i = 0; i < CatList.Count; i++)
            //    {
            //        this.cmb_Catalogue.Items.Add(CatList.ElementAt(i).NameCatalogue);
            //    }
        }
        //Input minus score
        private void txt_Minus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_Minus_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void txt_Score_TextChanged(object sender, EventArgs e)
        {
            if (txt_Score.Text!="")
            {
                if (Convert.ToInt32(txt_Score.Text)==0)
                {
                    MessageBox.Show("Vui lòng nhập điểm cộng lớn hơn 0","Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txt_Score.Text = "";
                }
            }
        }
        //Limit input time
        private void txt_Time_TextChanged(object sender, EventArgs e)
        {
            if (txt_Time.Text != "")
            {
                if (Convert.ToInt32(txt_Time.Text) == 0)
                {
                    MessageBox.Show("Vui lòng nhập thời gian lớn hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Time.Text = "";
                }
            }
        }
        //time is only input by number
        private void txt_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }

        private void txt_Time_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

    }
}
