
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace IT_Task.Services
{
   class ConectMariaDB 
    {
        public static void TestConnectDB(object sender, EventArgs eventArgs)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string Mysqlconnecstring;
            Mysqlconnecstring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";

            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection
                {
                    ConnectionString = Mysqlconnecstring
                };
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connecting DB OK");
                }
                connection.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
