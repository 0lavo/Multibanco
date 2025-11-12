using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

//MultibancoDB -- Mydatabase name
//L0-22P7\\MSSQLSERVER1 -- My server name

namespace Multibanco.Model.dao
{
    internal class UserDao
    {
        private string connectionString = "Server=L0-22P7\\MSSQLSERVER1;Database=MultibancoDB;Integrated Security=true;TrustServerCertificate=true;";

        // username, password 

        public User readUser(string username, string password)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int nId = Convert.ToInt32(reader["id"]);
                                string nUsername = reader["username"].ToString();
                                string nPassword = reader["password"].ToString();

                                return new User(nId,nUsername,nPassword);
                            }
                        }
                    }
                }
            } catch (SqlException ex)
            {
                MessageBox.Show("Database access error");
            }

            return null;
        }
        
    }
}

/*
public void connectionTest()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Deu certo");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error:  {ex.Message}");
            }
        }
 */
