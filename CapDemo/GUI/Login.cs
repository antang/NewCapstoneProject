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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UserBL userbl = new UserBL();
            List<DO.User> UserList;
            UserList = userbl.GetUser();
            AES aes = new AES();
            if (UserList != null)
                for (int i = 0; i < UserList.Count; i++)
                {
                    if (txtUser_Name.Text == UserList.ElementAt(i).UserName )
                    {
                        if (aes.EncryptText(txtPassword.Text,"") == UserList.ElementAt(i).PassWord)
                        {
                            MessageBox.Show("Pass");
                        }else
	                    {
                            MessageBox.Show("Fail");
	                    }
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    User user = new User();
        //    user.UserName = txtUser_Name.Text;
        //    user.PassWord = AES.Encrypt(txtPassword.Text, "");


        //    CatalogueBL catabl = new CatalogueBL();
        //    catabl.AddCatalogue(cata);
        }
    }
}
