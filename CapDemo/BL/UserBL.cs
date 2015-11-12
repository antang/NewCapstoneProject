using CapDemo.DA;
using CapDemo.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        //SELECT USER 
        public List<User> GetUser()
        {
            List<User> UserList = new List<User>();
            string query = "SELECT [User_ID] ,[Username],[Password]"
                         + " FROM [Capstone].[dbo].[User]";

            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    User User = new User();
                    User.UserName = item["Username"].ToString();
                    User.PassWord = EncryptText(item["Password"].ToString(),"");
                    UserList.Add(User);
                }
            }
            return UserList;
        }

        //ADD USER
        public bool AddUser(User User)
        {
            string query = "INSERT INTO User (Username, Password)"
                        + " VALUES ('" + User.UserName + "','" + User.PassWord + "')";
            return DA.InsertDatabase(query);
        }

        //EDIT USER
        public bool EditUser(User User)
        {
            string query = "UPDATE User"
                        + " SET Username='"+User.UserName+"', Password='"+User.PassWord+"'"
                        + " WHERE User_ID='"+User.UserID+"'";
            return DA.InsertDatabase(query);
        }

        //DELETE USER
        public bool DeleteUser(User User)
        {
            string query = "DELETE FROM User"
                        + " WHERE User_ID='" + User.UserID + "'";
            return DA.InsertDatabase(query);
        }

        //ENCRIPT ALGLORITH
        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        //ENCRIPT TEXT
        public string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }

    }
}
