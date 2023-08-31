using System.Data.SqlClient;
using System;

namespace ToDoList.Classes
{
    public class SqlConnectionClass
    {
        private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=toDoList;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            return connection;
        }

        public static void OpenConnection()
        {
            try
            {
                SqlConnection connection = GetConnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error opening connection : " + ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                SqlConnection connection = GetConnection();
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
        }
    }
}