﻿using CapDemo.DA;
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
        //select User table
        public List<User> GetUser()
        {
            List<User> UserList = new List<User>();
            string query = "SELECT u.[User_ID],u.[Username],u.[Password]"
                        + " FROM [User] u";
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
                    User.Sequence = i;
                    UserList.Add(User);
                    i++;
                }
            }
            return UserList;
        }

        //Insert user
        public bool AddUser(User User)
        {
            string query = "INSERT INTO [User]([Username],[Password])"
                           + "VALUES ('" + User.UserName.Replace("'", "''") + "','" + User.PassWord + "')";
            if (ExistUser(User) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }

        //Check User Exist
        public bool ExistUser(User User)
        {
            string query = "SELECT u.[User_ID],u.[Username],u.[Password]"
                        + " FROM [User] u";
            DataTable dt = DA.SelectDatabase(query);
            int i = 0;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["Username"].ToString().ToUpper() == User.UserName.ToUpper())
	                {
                        i++;
	                }
                }
            }
            if (i==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Edit User
        public bool EditUserbyID(User User)
        {
            string query= " UPDATE [User]"
                        + " SET [Username] = '" + User.UserName.Replace("'", "''") + "',[Password] = '" + User.PassWord + "'"
                        + " WHERE [User_ID] = '" + User.UserID + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete User
        public bool DeleteUserbyID(User User)
        {
            string query = "DELETE FROM User"
                         + " WHERE User_ID = '" + User.UserID + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
