using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace AppSDelivery
{
    public class MySQLConn
    {
        string usr;
        string pass;

        public MySQLConn(string user, string password)
        {
            usr = user;
            pass = password;
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        
        public bool TryConnection(out string Error)
        {
            builder.Server = "sql3.freemysqlhosting.net";
            builder.Database = "sql3360291";
            builder.UserID = "sql3360291";
            builder.Password = "991004ajgep";
            
            try
            {
                MySqlConnection ms = new MySqlConnection(builder.ToString());
                ms.Open();
                Error = "";
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
        }

        public bool Login()
        {
            string dato1 = "Select * FROM Registros Where usuario ="+usr;
            MySqlCommand consult = new MySqlCommand(dato1);
            return true;
        }

        /**private void Conexion()
        {
            string connectionString = "datasource=sql3.freemysqlhosting.net;port=3306;username=sql3360291;password=991004ajgep;database=sql3360291";
            string query = "SELECT * FROM Registros";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            if (databaseConnection != null)
            {
                
            }
            else
            {
                
            }
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }**/
    }
}
