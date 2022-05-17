using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IT_Task.Services;
using System.IO;
namespace IT_Task
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void extendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnStripTestMariaDB_Click(object sender, EventArgs e)
        {
            var conectMariaDB = new ConectMariaDB();
            
           


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
        private void MnSaveToText_Click(object sender, EventArgs e)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\Test.txt");
                //Write a line of text
                sw.WriteLine("IT Tasks");
                //Write a second line of text
                sw.WriteLine("Xin chào các bạn");
                //Close the file
                sw.Close();
                MessageBox.Show("Write Done!");
            }
            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void Mnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void MnInfoPc_Click(object sender, EventArgs e)
        {
            Views.ViewInfoPC viewInfoPC = new Views.ViewInfoPC()
            {
                
            };
            viewInfoPC.Show();
            panelMain.Show();


        }
    }
}
