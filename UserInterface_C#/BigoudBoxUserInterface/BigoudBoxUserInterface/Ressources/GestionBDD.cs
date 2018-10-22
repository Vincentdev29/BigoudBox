using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BigoudBoxUserInterface
{
    static class GestionBDD
    {
        static private MySqlConnection mySqlConnection;
        static private string connString = "server=127.0.0.1;uid=user;pwd=;database=bigoudbox_db;Charset=utf8";

        static public void InitConnector()
        {
            try
            {
                mySqlConnection = new MySqlConnection(connString);
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        static public void OpenConnection()
        {
            mySqlConnection.Open();
        }

        static public void CloseConnection()
        {
            mySqlConnection.Close();
        }

        static private MySqlCommand InitQuery(string storedProcedureName)
        {
            MySqlCommand mySqlCommand = new MySqlCommand
            {
                CommandText = storedProcedureName,
                CommandType = CommandType.StoredProcedure
            };
            OpenConnection();
            mySqlCommand.Connection = mySqlConnection;
            return mySqlCommand;
        }

        static public List<string> GetSeance(string day)
        {
            List<string> seances = new List<string>();

            //BDD
            object stdout = new object();
            try
            {
                MySqlCommand mySqlCommand = InitQuery("get_seances_from_db");
                mySqlCommand.Parameters.AddWithValue("@currDay", day);
                mySqlCommand.Parameters["@currDay"].Direction = ParameterDirection.Input;
                mySqlCommand.ExecuteNonQuery();
                stdout = mySqlCommand.Parameters["@"].Value;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(("Error " + ex.Number + "has occured") + ex.Message);
            }
            CloseConnection();
            
            foreach(string i in stdout.ToString().Split(';'))
            {
                seances.Add(i);
            }

            return seances;
        }

        static public void AddEntre()
        {

        }
    }
}
