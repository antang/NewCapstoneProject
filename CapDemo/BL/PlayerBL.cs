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
    class PlayerBL
    {
        DatabaseAccess DA;
        public PlayerBL()
        {
            DA = new DatabaseAccess();
        }
        //select Player table
        public List<Player> GetPlayer()
        {
            List<Player> PlayerList = new List<Player>();
            string query = "SELECT [Player_ID],[Contest_ID],[Player_Name],[Player_Score],[Color]"
                        +  " FROM [Capstone].[dbo].[Player]";
            DataTable dt = DA.SelectDatabase(query);
            //int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Player Player = new Player();
                    Player.IDPlayer = Convert.ToInt32(item["Player_ID"].ToString());
                    Player.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Player.PlayerName = item["Player_Name"].ToString();
                    Player.PlayerScore = Convert.ToInt32(item["Player_Score"].ToString());
                    Player.Color = item["Color"].ToString();

                    PlayerList.Add(Player);
                    //i++;
                }
            }
            return PlayerList;
        }

        //Insert Player
        public bool AddPlayer(Player Player)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Player]([Contest_ID],[Player_Name],[Player_Score],[Color])"
                           + " VALUES ('" + Player.IDContest + "','" + Player.PlayerName + "',"
                           + "'" + Player.PlayerScore + "','" + Player.Color + "')";

            if (DA.InsertDatabase(query))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Check Player Exist
        //public bool ExistPlayer(Player Player)
        //{
        //    string query = "SELECT [Player_ID],[Player_Name]"
        //               + " FROM [Capstone].[dbo].[Player]"
        //               + " WHERE [Player_Name] = '" + Player.PlayerName.ToUpper() + "'";
        //    DataTable dt = DA.SelectDatabase(query);
        //    if (dt.Rows.Count != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Edit Player
        public bool EditPlayerbyID(Player Player)
        {
            string query = "UPDATE Player SET Player_Name ='" + Player.PlayerName + "'"
                         + " WHERE Player_ID = '" + Player.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Player
        public bool DeletePlayerbyID(Player Player)
        {
            string query = "DELETE FROM Player"
                         + " WHERE Player_ID = '" + Player.IDPlayer + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
