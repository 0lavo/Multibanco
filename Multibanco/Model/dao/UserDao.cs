using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

//MultibancoDB -- Mydatabase name
//L0-22P7\\MSSQLSERVER1 -- College server name
//DESKTOP-0EK8KNN -- house server name

namespace Multibanco.Model.dao
{
    internal class UserDao
    {
        private string connectionString = "Server=DESKTOP-0EK8KNN;Database=MultibancoDB;Integrated Security=true;TrustServerCertificate=true;";

        // username, password 

        public User readUser(string username, string password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();
                string query = "SELECT * FROM Users WHERE username = @username AND password = @password";

                SqlCommand sqlCommand = new SqlCommand(query, conn);

                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    int nId = Convert.ToInt32(reader["id"]);
                    string nUsername = reader["username"].ToString();
                    string nPassword = reader["password"].ToString();
                    double nBalance = Convert.ToDouble(reader["balance"]);

                    return new User(nId, nUsername, nPassword,nBalance);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Database error");
                Application.Exit();
            }

            return null;
        }

        public User createUser(string username, string password) 
        {
            User user = readUser(username, password);

            if (user == null)
            {

                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);

                    conn.Open();
                    string query = "INSERT INTO Users VALUES (@username,@password,DEFAULT)";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);

                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    sqlCommand.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Database error");
                    Application.Exit();
                }

                user = readUser(username, password);

                return user;
            }

            return null;
        }
        
    }
}
