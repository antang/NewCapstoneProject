using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.DO
{
    class User
    {
        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
