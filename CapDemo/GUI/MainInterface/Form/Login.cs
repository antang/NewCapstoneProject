using CapDemo.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.GUI
{
    public partial class Login : Form
    {
        Thread th;
        string UserName="";
        string Pass="";
        int UserID;
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void openComposing(object obj)
        {
            GameShowControl gsc = new GameShowControl(UserID,UserName,Pass);
            Application.Run(gsc);
        }
        //Press enter key
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
            SpaceEntered = false;
            if (e.KeyCode == Keys.Space)
            {
                SpaceEntered = true;
            }
        }
        //Press enter key
        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
            SpaceEntered = false;
            if (e.KeyCode == Keys.Space)
            {
                SpaceEntered = true;
            }
        }
        //Login Method
        public void login()
        {
            UserBL userbl = new UserBL();
            List<DO.User> UserList;
            UserList = userbl.GetUser();
            AES aes = new AES();
            if (txt_UserName.Text.Trim() == "" || txt_Password.Text.Trim() == "")
            {
                if (txt_UserName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool check = false;
                if (UserList != null)
                    for (int i = 0; i < UserList.Count; i++)
                    {
                        if (txt_UserName.Text == UserList.ElementAt(i).UserName && aes.EncryptText(txt_Password.Text, "") == UserList.ElementAt(i).PassWord)
                        {
                            check = true;
                            UserID = UserList.ElementAt(i).UserID;
                            Pass = UserList.ElementAt(i).PassWord;
                            UserName = UserList.ElementAt(i).UserName;
                        }
                    }
                if (check == true)
                {
                    this.Close();
                    th = new Thread(openComposing);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Sai mật tài khoản. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool SpaceEntered = false;
        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SpaceEntered == true)
            {
                e.Handled = true;
            } 
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SpaceEntered == true)
            {
                e.Handled = true;
            } 
        }
    }
}
