using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoiderGame
{
    class DBConnection
    {
        private static SqlConnection conn;
        private static void OpenConnection()
        {
            AvoiderGameDataSet ds = new AvoiderGameDataSet();
            string connection = "Server = 89.76.149.59,1209; Initial Catalog = AvoiderGame; Integrated Security = false; MultipleActiveResultSets=true;" +
                "User Id=JohnEgbert; Password =YourPassword; ";
            SqlConnection conn2 = new SqlConnection(connection);
            conn = conn2;
            conn.Open();
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static SqlDataReader GetAllPlayers()
        {
            OpenConnection();
            SqlCommand sql = new SqlCommand("Select * from Players", conn);
            return sql.ExecuteReader();
        }

        public static void UpdateScore(Player player, long score)
        {
            OpenConnection();
            SqlCommand sql = new SqlCommand($"Update Players set Score = {score} where Name = '{player.GetName()}'", conn);
            sql.ExecuteNonQuery();
            DBConnection.CloseConnection();

        }

        public static void AddPlayerToDB(Player player)
        {
            OpenConnection();
            SqlCommand sql = new SqlCommand($"insert into Players (Name, Velocity, Size, HP, Score)" +
                $" values('{player.GetName()}', {player.GetVel()}, {player.GetSize()}, {player.getMaxHp()}, 0)", conn);
            sql.ExecuteNonQuery();
            DBConnection.CloseConnection();

        }

        public static void DeletePlayerFromDB(Player player)
        {
            if(player != null)
            {
                SqlCommand sql = new SqlCommand($"delete from Players where Name = '{player.GetName()}'", conn);
                sql.ExecuteNonQuery();
            }
        }

        public static bool DoesNameExist(string name)
        {
            OpenConnection();
            SqlCommand sql = new SqlCommand($"select count(Name) from Players where Name = '{name}'", conn);
            int rows = (int)sql.ExecuteScalar();
            return rows > 0;
        }

		public static int NumOfPlayers()
		{
			OpenConnection();
			SqlCommand sql = new SqlCommand($"select count(*) from Players", conn);
			return (int)sql.ExecuteScalar();
		}
    }
}
