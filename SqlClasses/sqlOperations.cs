using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static List<List<string>> getFromDate(DateTime date)
        {
            List<List<string>> infoList = new List<List<string>>();
            SqlDataReader reader = null;
            try
            {
                SqlConnectionClass.OpenConnection();

                string query = "SELECT * FROM dbo.List WHERE Date = @selectedDate AND [Check] ='false'";
                using (SqlCommand cmd = new SqlCommand(query, SqlConnectionClass.GetConnection()))
                {



                    cmd.Parameters.AddWithValue("@selectedDate", date);

                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                            infoList.Add(new List<string> { reader["Title"].ToString(), reader["Description"].ToString() });
                        }
                            
                        
                    }
                    else
                    {
                        
                    }
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close(); 
                }


                SqlConnectionClass.CloseConnection();

                
            }
            return infoList;
        }

        public static void updateCheckBox (int id)
        {
            try
            {
                SqlConnectionClass.OpenConnection();

                string query = "UPDATE List SET [Check] = 'true' WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, SqlConnectionClass.GetConnection()))
                {



                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                SqlConnectionClass.CloseConnection();
            }

        }

        public static int getID(DateTime date, string title, string description)
        {
            int generatedID = 0;
            try
            {
                SqlConnectionClass.OpenConnection();

                string query = "SELECT id FROM dbo.List WHERE Date = @selectedDate AND Title = @title AND Description = @description";
                using (SqlCommand cmd = new SqlCommand(query, SqlConnectionClass.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@selectedDate", date);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@description", description);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            generatedID = reader.GetInt32(0);
                        }
                    }
                }
                SqlConnectionClass.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            return generatedID;
            
        }

    }
}
