using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomManagementModels;

namespace ClassroomManagementData
{
    public class SqlDbData
    {
        static string connectionString
        = "Data Source =LAPTOP-QQJD4TKI\\SQLEXPRESS; Initial Catalog = Classroom; Integrated Security = True;";

        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }

        public static List<User> GetUsers()
        {
            string selectStatement = "SELECT prof, roomNum FROM users";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                string prof = reader["prof"].ToString();
                string roomNum = reader["roomNum"].ToString();

                User readUser = new User();
                readUser.prof = prof;
                readUser.roomNum = roomNum;

                users.Add(readUser);
            }

            sqlConnection.Close();

            return users;
        }

        public static int AddUser(string prof, string roomNum)
        {
            int success;

            string insertStatement = "INSERT INTO users VALUES (@prof, @roomNum)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@prof", prof);
            insertCommand.Parameters.AddWithValue("@roomNum", roomNum);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public static void UpdateUser(string prof, string roomNum)
        {
            var updateStatment = $"UPDATE users SET roomNum = @roomNum WHERE prof = @prof";
            SqlCommand updateCommand = new SqlCommand(updateStatment, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@roomNum", roomNum);
            updateCommand.Parameters.AddWithValue("@prof", prof);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void DeleteUser(string prof)
        {
            string deleteStatement = $"DELETE FROM users WHERE prof = @prof";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement , sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@prof", prof);

            deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }

    }
}
