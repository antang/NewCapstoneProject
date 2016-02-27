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
    public partial class ChangePassword : Form
    {
        private int UserID;
        private string UserName;
        string Pass;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int UserID, string UserName, string Pass)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.UserID = UserID;
            this.UserName = UserName;
            this.Pass = Pass;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
        }
        //Save change password
        private void btn_Change_Click(object sender, EventArgs e)
        {
            ChangePass();
        }
        //Close form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePass();
            }
        }

        private void txt_NewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePass();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangePass();
            }
        }
        //Change Pass
        public void ChangePass()
        {
            User user = new User();
            UserBL userbl = new UserBL();
            List<DO.User> UserList;
            UserList = userbl.GetUser();
            AES aes = new AES();
            if (txt_Password.Text.Trim() == "" || txt_NewPass.Text.Trim() == "" || txt_ConfirmPass.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin không được rỗng. Vui lòng nhập thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (aes.EncryptText(txt_Password.Text, "") != Pass)
                {
                    MessageBox.Show("Sai mật khẩu chính vui lòng nhập lại mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_NewPass.Text != txt_ConfirmPass.Text)
                    {
                        MessageBox.Show("Mật khẩu xác nhận không phù hợp với mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        user.PassWord = aes.EncryptText(txt_ConfirmPass.Text, "");
                        user.UserID = UserID;
                        user.UserName = UserName;
                        userbl.EditUserbyID(user);

                        //notifyIcon1.Icon = SystemIcons.Information;
                        //notifyIcon1.BalloonTipText = "Chỉnh Sửa mật khẩu thành công.";
                        //notifyIcon1.ShowBalloonTip(2000);
                        this.Close();
                    }
                }
            }
        }
    }
}
