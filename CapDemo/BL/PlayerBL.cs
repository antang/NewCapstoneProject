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
            string query = "SELECT [Player_ID],[Contest_ID],[Player_Name],[Player_Score],[Color],[Player_Sequence]"
                        +  " FROM [Player]";
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
                    Player.Sequence = Convert.ToInt32(item["Player_Sequence"].ToString());

                    PlayerList.Add(Player);
                    //i++;
                }
            }
            return PlayerList;
        }
        //select Player by id player
        public List<Player> GetPlayerByIDplayer(Player player)
        {
            List<Player> PlayerList = new List<Player>();
            string query = "SELECT [Player_ID],[Contest_ID],[Player_Name],[Player_Score],[Color],[Player_Sequence]"
                        + " FROM [Player]"
                        + " WHERE  [Player_ID] = '"+player.IDPlayer+"'";
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Player Player = new Player();
                    Player.IDPlayer = Convert.ToInt32(item["Player_ID"].ToString());
                    Player.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Player.PlayerName = item["Player_Name"].ToString();
                    Player.PlayerScore = Convert.ToInt32(item["Player_Score"].ToString());
                    Player.Color = item["Color"].ToString();
                    Player.Sequence = Convert.ToInt32(item["Player_Sequence"].ToString());

                    PlayerList.Add(Player);
                }
            }
            return PlayerList;
        }

        // get player by id contest
        public List<Player> GetPlayerByIDContest(Player player)
        {
            List<Player> PlayerList = new List<Player>();
            string query = "SELECT pl.[Player_ID],pl.[Contest_ID],pl.[Player_Name],pl.[Player_Score],pl.[Color],pl.[Player_Sequence]"
                        + " FROM [Player]pl"
                        + " INNER JOIN Contest  c ON c.Contest_ID = pl.Contest_ID"
                        //+ " INNER JOIN Phase ph ON ph.Contest_ID = c.Contest_ID"
                        + " WHERE pl.[Contest_ID] = '" + player.IDContest + "' ORDER BY [Player_Sequence] ASC";
            //ORDER BY [Player_Sequence] ASC
            DataTable dt = DA.SelectDatabase(query);
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Player Player = new Player();
                    Player.IDPlayer = Convert.ToInt32(item["Player_ID"].ToString());
                    Player.IDContest = Convert.ToInt32(item["Contest_ID"].ToString());
                    Player.PlayerName = item["Player_Name"].ToString();
                    Player.PlayerScore = Convert.ToInt32(item["Player_Score"].ToString());
                    Player.Color = item["Color"].ToString();
                    Player.Sequence = Convert.ToInt32(item["Player_Sequence"].ToString());

                    PlayerList.Add(Player);
                }
            }
            return PlayerList;
        }
        //Insert Player
        public bool AddPlayer(Player Player)
        {
            string query = "INSERT INTO [Player]([Contest_ID],[Player_Sequence],[Player_Name],[Player_Score],[Color])"
                           + " VALUES ('" + Player.IDContest + "','" + Player.Sequence + "','" + Player.PlayerName + "',"
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
        //               + " FROM [Player]"
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
            string query = "UPDATE [Player] SET "
                         + "[Contest_ID] ='" + Player.IDContest + "',[Player_Name] ='" + Player.PlayerName + "',[Player_Score] ='" + Player.PlayerScore + "',[Color] ='" + Player.Color + "',[Player_Sequence] ='" + Player.Sequence + "'"
                         + " WHERE Player_ID = '" + Player.IDPlayer + "'";
            return DA.UpdateDatabase(query);
        }
        //Delete Player
        public bool DeletePlayerbyID(Player Player)
        {
            string query = "DELETE FROM [Player]"
                         + " WHERE [Player_ID] = '" + Player.IDPlayer + "'";
            return DA.DeleteDatabase(query);
        }
        public bool DeletePlayerbyIDContest(Player Player)
        {
            string query = "DELETE FROM [Player]"
                         + " WHERE [Contest_ID] = '" + Player.IDContest + "'";
            return DA.DeleteDatabase(query);
        }
    }
}
