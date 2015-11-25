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
    public partial class Create_AccountManagement : Form
    {
        public Create_AccountManagement()
        {
            InitializeComponent();
        }
        //Add new account
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim()=="" || txt_Password.Text.Trim()=="")
            {
                if (txt_Username.Text.Trim() == "")
                {
                    MessageBox.Show("Tên Người dùng không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                User user = new User();
                UserBL UserBL = new UserBL();
                AES aes = new AES();
                user.UserName = txt_Username.Text.Trim();
                user.PassWord = aes.EncryptText(txt_Password.Text.Trim(), "").ToString();
                if (UserBL.AddUser(user) == true)
                {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.BalloonTipText = "Thêm tài khoản thành công.";
                    notifyIcon1.ShowBalloonTip(5000);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản này đã tồn tại trong hệ thống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        //Close form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Click enter
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==  Keys.Enter)
            {
                if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "")
                {
                    if (txt_Username.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên Người dùng không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    User user = new User();
                    UserBL UserBL = new UserBL();
                    AES aes = new AES();
                    user.UserName = txt_Username.Text.Trim();
                    user.PassWord = aes.EncryptText(txt_Password.Text.Trim(), "").ToString();
                    if (UserBL.AddUser(user) == true)
                    {
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Thêm tài khoản thành công.";
                        notifyIcon1.ShowBalloonTip(5000);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại trong hệ thống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            
        }
        //Click enter
        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "")
                {
                    if (txt_Username.Text.Trim() == "")
                    {
                        MessageBox.Show("Tên Người dùng không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không được rỗng.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    User user = new User();
                    UserBL UserBL = new UserBL();
                    AES aes = new AES();
                    user.UserName = txt_Username.Text.Trim();
                    user.PassWord = aes.EncryptText(txt_Password.Text.Trim(), "").ToString();
                    if (UserBL.AddUser(user) == true)
                    {
                        notifyIcon1.Icon = SystemIcons.Information;
                        notifyIcon1.BalloonTipText = "Thêm tài khoản thành công.";
                        notifyIcon1.ShowBalloonTip(5000);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản này đã tồn tại trong hệ thống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
