using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CapDemo.DA
{
    class DatabaseAccess
    {

        public SQLiteConnection con;
        public SQLiteDataAdapter adapter;
        public SQLiteCommand cmd;
        //public SQLiteConnection con;
        //public SQLiteDataAdapter adapter;
        //public SQLiteCommand cmd;
        //CapDemo.Properties.Settings setting;

        string connection;
        public DatabaseAccess()
        {
            //setting = new Properties.Settings();
            //connection = "Data Source=" + setting.Sever + ";Initial Catalog=" + setting.DB + ";User ID=" + setting.UserName + ";Password=" + setting.PassWord;
            string s = Directory.GetCurrentDirectory() + "\\Capstone.db";
            connection = @"Data Source = "+s+"; Version=3";
            //setting.DB = "dkjl";
            //setting.Save();
        }
        //select from database
        public DataTable SelectDatabase(string query)
        {
            try
            {
                con = new SQLiteConnection(connection);
                con.Open();
                adapter = new SQLiteDataAdapter(query, con);
                DataTable dtb = new DataTable();
                adapter.Fill(dtb);
                con.Close();
                return dtb;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n"+connection + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //Insert new catalogue to database
        public bool InsertDatabase(string query)
        {
            try
            {
                con = new SQLiteConnection(connection);
                cmd = new SQLiteCommand(query, con);
                con.Open();
                int i= cmd.ExecuteNonQuery();
                con.Close();
                //return true;
                if (i >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
               
                //MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Update infomation of catalouge in database
        public bool UpdateDatabase(string query)
        {
            try
            {
                con = new SQLiteConnection(connection);
                cmd = new SQLiteCommand(query, con);
                con.Open();
                int i= cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
               
                //MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Delete catalogue in database
        public bool DeleteDatabase(string query)
        {
            try
            {
                con = new SQLiteConnection(connection);
                cmd = new SQLiteCommand(query, con);
                con.Open();
                int i=cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
               
                //MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Row count
        public int MaxID(string query)
        {
            try
            {
                con = new SQLiteConnection(connection);
                cmd = new SQLiteCommand(query, con);
                con.Open();
                object val = cmd.ExecuteScalar();
                int max = int.Parse(val.ToString());
                return max;
            }
            catch (Exception)
            {
                
                    //MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
