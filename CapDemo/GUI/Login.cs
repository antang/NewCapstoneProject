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
            UserBL userbl = new UserBL();
            List<DO.User> UserList;
            UserList = userbl.GetUser();
            AES aes = new AES();
            if (UserList != null)
                for (int i = 0; i < UserList.Count; i++)
                {
                    if (txt_UserName.Text == UserList.ElementAt(i).UserName)
                    {
                        if (aes.EncryptText(txt_Password.Text, "") == UserList.ElementAt(i).PassWord)
                        {
                            UserName = txt_UserName.Text;
                            this.Close();
                            th = new Thread(openComposing);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản. Vui lòng đăng nhập lại.","Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void openComposing(object obj)
        {
            GameShowControl gsc = new GameShowControl(UserName);
            Application.Run(gsc);
        }
        //Press enter key
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserBL userbl = new UserBL();
                List<DO.User> UserList;
                UserList = userbl.GetUser();
                AES aes = new AES();
                if (UserList != null)
                    for (int i = 0; i < UserList.Count; i++)
                    {
                        if (txt_UserName.Text == UserList.ElementAt(i).UserName)
                        {
                            if (aes.EncryptText(txt_Password.Text, "") == UserList.ElementAt(i).PassWord)
                            {
                                UserName = txt_UserName.Text;
                                this.Close();
                                th = new Thread(openComposing);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
            }
        }
        //Press enter key
        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserBL userbl = new UserBL();
                List<DO.User> UserList;
                UserList = userbl.GetUser();
                AES aes = new AES();
                if (UserList != null)
                    for (int i = 0; i < UserList.Count; i++)
                    {
                        if (txt_UserName.Text == UserList.ElementAt(i).UserName)
                        {
                            if (aes.EncryptText(txt_Password.Text, "") == UserList.ElementAt(i).PassWord)
                            {
                                UserName = txt_UserName.Text;
                                this.Close();
                                th = new Thread(openComposing);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tài khoản. Vui lòng đăng nhập lại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
            }
        }
    }
}
