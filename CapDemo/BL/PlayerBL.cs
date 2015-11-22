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
            string query = "SELECT r.[Player_ID],r.[Player_Name]"
                        + " FROM [Capstone].[dbo].[Player] r";
            DataTable dt = DA.SelectDatabase(query);
            int i = 1;
            if (dt!= null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Player Player = new Player();
                    Player.IDPlayer = Convert.ToInt32(item["Player_ID"]);
                    Player.PlayerName = item["Player_Name"].ToString();
                    PlayerList.Add(Player);
                    i++;
                }
            }
            return PlayerList;
        }

        //Insert Player
        public bool AddPlayer(Player Player)
        {
            string query = "INSERT INTO [Capstone].[dbo].[Player]([Player_Name])"
                           + "VALUES ('" + Player.PlayerName + "')";
            if (ExistPlayer(Player) == true)
            {
                return false;
            }
            else
            {
                return DA.InsertDatabase(query);
            }
        }

        //Check Player Exist
        public bool ExistPlayer(Player Player)
        {
            string query = "SELECT [Player_ID],[Player_Name]"
                       + " FROM [Capstone].[dbo].[Player]"
                       + " WHERE [Player_Name] = '" + Player.PlayerName.ToUpper() + "'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
