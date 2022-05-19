using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT_Task.Views
{
    public partial class ViewInfoPC : Form
    {
        
        public ViewInfoPC()
        {
            InitializeComponent();
        }
        private void SysTablePC (object sender, EventArgs eventArgs)
        {

        }        
        void ComboboxDepartment()
        {
            string mySqlConnecSring;
            mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
            using (MySqlConnection connec = new MySqlConnection(mySqlConnecSring))
            {
                connec.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM Department", connec);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                cbDepartment.ValueMember = "DepartmentID";
                cbDepartment.DisplayMember = "Department";
                cbDepartment.DataSource = dtbl;
                //dgvPC.DataSource = dtbl;
                DataRow topitem = dtbl.NewRow();
                topitem[0] = 0;
                topitem[1] = "-Select-";
                dtbl.Rows.InsertAt(topitem, 0);
                cbDepartment.DataSource = dtbl;

            };
        }
        void PcDgv()
        {
            string mySqlConnecSring;
            mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
            using (MySqlConnection connec = new MySqlConnection(mySqlConnecSring))
            {
                connec.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM pc", connec);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPC.DataSource = dtbl;
            };
        }
        
        private void ViewInfoPC_Load(object sender, EventArgs e)
        {
            ComboboxDepartment();
            PcDgv();
        }

        private void dgvPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string mySqlConnecSring;
            mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
            if (dgvPC.CurrentRow !=null)
            {
                using (MySqlConnection mySqlCo = new MySqlConnection(mySqlConnecSring))
                {
                    mySqlCo.Open();
                    DataGridViewRow dgvRow = dgvPC.CurrentRow;
                    //dgvPC.DataSource = dtbl;
                }
            }
        }
    }
}
