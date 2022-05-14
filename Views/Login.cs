using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Task
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUse.Focus();
        }
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!(txtUse.Text == string.Empty))
                {
                    if (!(txtPass.Text == string.Empty))
                    {
                        String str = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
                        String query = "SELECT * FROM `use` WHERE usename = '" + txtUse.Text + "'and password = '" + this.txtPass.Text + "'";
                        MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(str);
                        //MessageBox.Show("Conect");
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query,con);
                        MySql.Data.MySqlClient.MySqlDataReader dbr;
                        con.Open();
                        //MessageBox.Show("open");
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count++;
                        }
                        if (count == 1)
                        {
                            this.Hide();
                            MainView mainView = new MainView();
                            mainView.ShowDialog();
                        }
                        else if (count >1)
                        {
                            MessageBox.Show("Duplicate username and password", "Login page");
                        }    
                        else
                        {
                            MessageBox.Show("Username and password incorrect", "Login again!");
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Password Empty");
                    }
                }
                else
                {
                    MessageBox.Show("UseName Empty");
                }

            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

    }
}
