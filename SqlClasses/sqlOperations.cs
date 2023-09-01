using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Classes;

namespace ToDoList.SqlClasses
{
    public class sqlOperations
    {
        public static void addListValue(DateTime date, string title, string description, bool check)
        {
            try
            {
                SqlConnectionClass.OpenConnection();
                string insertQuery = "INSERT INTO dbo.List (Date, Title, Description, [Check]) " +
                             "VALUES (@date, @title, @description, @check)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, SqlConnectionClass.GetConnection()))
                {

                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@check", check);
          


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
               
                SqlConnectionClass.CloseConnection();
            }

        }
    }
}
