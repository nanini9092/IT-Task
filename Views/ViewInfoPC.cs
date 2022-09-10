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
        /*void ComboboxDepartment()
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
        }*/
        void PcDgv()
        {
            string mySqlConnecSring;
            mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
            using (MySqlConnection connec = new MySqlConnection(mySqlConnecSring))
            {connec.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM general", connec);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvPC.DataSource = dtbl;
                var countRow = dgvPC.RowCount.ToString();
                lbShowCount.Text = countRow;
            };
        }
        
        private void ViewInfoPC_Load(object sender, EventArgs e)
        {
            //ComboboxDepartment();
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

        public void CountRowDgv(object sent,EventArgs eventArgs)
        {
            var countRow = dgvPC.RowCount.ToString();
            lbShowCount.Text = countRow;
        }
        private void btCountPC_Click(object sender, EventArgs e)
        {

            if (this.dgvPC.CurrentRow != null)
            {
                this.dgvPC.DataSource = null;
                string mySqlConnecSring;
                mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
                using (MySqlConnection connec = new MySqlConnection(mySqlConnecSring))
                {
                    connec.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM general WHERE Type LIKE 'PC'", connec);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvPC.DataSource = dtbl;
                    //lbl_row.Text = dataGridView1.RowCount.ToString();
                    var countRow = dgvPC.RowCount.ToString();
                    lbShowCount.Text = countRow;
                };
            }
        }

        private void btCountPrinter_Click(object sender, EventArgs e)
        {

            if (this.dgvPC.CurrentRow != null)
            {
                this.dgvPC.DataSource = null;
                string mySqlConnecSring;
                mySqlConnecSring = "Server=IT-HUUQUYEN; port=3368;Database=itstacks;uid=root;pwd=qvl^IT321";
                using (MySqlConnection connec = new MySqlConnection(mySqlConnecSring))
                {
                    connec.Open();
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT * FROM general WHERE Type LIKE 'Printer'", connec);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvPC.DataSource = dtbl;
                    var countRow = dgvPC.RowCount.ToString();
                    lbShowCount.Text = countRow;
                };
            }
        }

        private void btEpExecl_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgvPC.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvPC.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvPC.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvPC.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvPC.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();

        }
    }
}
