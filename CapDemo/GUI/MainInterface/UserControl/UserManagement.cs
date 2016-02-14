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
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        //Add new account
        private void lbl_Create_Click(object sender, EventArgs e)
        {
            Create_AccountManagement cam = new Create_AccountManagement();
            cam.ShowDialog();
            LoadUser();
        }
        //Load form
        private void UserManagement_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadUser();

        }
        //Load user table
        public void LoadUser()
        {
            UserBL UserBL = new UserBL();
            List<DO.User> UserList;
            UserList = UserBL.GetUser();
            if (UserList != null)
                dgv_UserManagement.DataSource = UserList;

            dgv_UserManagement.Columns["UserID"].Visible = false;
            dgv_UserManagement.Columns["PassWord"].Visible = false;
            dgv_UserManagement.Columns["Role"].Visible = false;
            dgv_UserManagement.Columns["Sequence"].HeaderText = "STT";
            dgv_UserManagement.Columns["UserName"].HeaderText = "Tên Tài khoản";
            dgv_UserManagement.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void txt_SearchCatalogue_TextChanged(object sender, EventArgs e)
        {
            UserBL UserBL = new UserBL();
            List<DO.User> ListUser = UserBL.GetUser();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(ListUser);

            dgv_UserManagement.DataSource = dt;
            dt.DefaultView.RowFilter = string.Format("UserName LIKE '%{0}%' or Sequence LIKE '%{0}%'", txt_SearchCatalogue.Text);

            dgv_UserManagement.Columns["UserID"].Visible = false;
            dgv_UserManagement.Columns["PassWord"].Visible = false;
            dgv_UserManagement.Columns["Role"].Visible = false;
            dgv_UserManagement.Columns["Sequence"].HeaderText = "STT";
            dgv_UserManagement.Columns["UserName"].HeaderText = "Tên Tài khoản";
            dgv_UserManagement.Columns["Sequence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
