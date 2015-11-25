using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapDemo.DA
{
    class DatabaseAccess
    {
        public SqlConnection con;
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        CapDemo.Properties.Settings setting;

        string connection;
        public DatabaseAccess()
        {
            setting = new Properties.Settings();
            connection = "Data Source=" + setting.Sever + ";Initial Catalog=" + setting.DB + ";User ID=" + setting.UserName + ";Password=" + setting.PassWord;
        }
        //select from database
        public DataTable SelectDatabase(string query)
        {
            try
            {
                con = new SqlConnection(connection);
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                adapter.Fill(dtb);
                con.Close();
                return dtb;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //Insert new catalogue to database
        public bool InsertDatabase(string query)
        {
            try
            {
                con = new SqlConnection(connection);
                cmd = new SqlCommand(query, con);
                con.Open();
                int i= cmd.ExecuteNonQuery();
                con.Close();
                if (i>=0)
                {

                    return true;
                }
                else
                {
                    return false; 
                }
                
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Update infomation of catalouge in database
        public bool UpdateDatabase(string query)
        {
            try
            {
                con = new SqlConnection(connection);
                cmd = new SqlCommand(query, con);
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
            catch (Exception ex)
            {
               
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Delete catalogue in database
        public bool DeleteDatabase(string query)
        {
            try
            {
                con = new SqlConnection(connection);
                cmd = new SqlCommand(query, con);
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
            catch (Exception ex)
            {
               
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //Row count
        public int MaxID(string query)
        {
            try
            {
                con = new SqlConnection(connection);
                cmd = new SqlCommand(query, con);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
    }
}
