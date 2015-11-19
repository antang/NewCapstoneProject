using CapDemo.DA;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapDemo.BL
{
    class UserBL
    {
        DatabaseAccess DA;
        public UserBL()
        {
            DA = new DatabaseAccess();
        }
        //select catalogue table
        public List<User> GetUser()
        {
            List<User> UserList = new List<User>();
            string query = "SELECT [User_ID],[Username],[Password]"
                        + " FROM [Capstone].[dbo].[User]";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    User User = new User();
                    User.UserID = Convert.ToInt32(item["User_ID"]);
                    User.UserName = item["Username"].ToString();
                    User.PassWord = item["Password"].ToString();
                    UserList.Add(User);
                    i++;
                }
            }
            return UserList;
        }
    }
}
