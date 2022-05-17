
namespace IT_Task.Views
{
    partial class ViewInfoPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.txtNamepcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamePc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDepartment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtPropertycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btShowlistPC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNamepcID,
            this.txtNamePc,
            this.txtIP,
            this.cbDepartment,
            this.txtPropertycode});
            this.dgvPC.Location = new System.Drawing.Point(12, 12);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.RowTemplate.Height = 25;
            this.dgvPC.Size = new System.Drawing.Size(677, 408);
            this.dgvPC.TabIndex = 0;
            this.dgvPC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPC_CellContentClick);
            // 
            // txtNamepcID
            // 
            this.txtNamepcID.DataPropertyName = "NamepcID";
            this.txtNamepcID.HeaderText = "ID";
            this.txtNamepcID.Name = "txtNamepcID";
            // 
            // txtNamePc
            // 
            this.txtNamePc.DataPropertyName = "NamePc";
            this.txtNamePc.HeaderText = "Name Pc";
            this.txtNamePc.Name = "txtNamePc";
            // 
            // txtIP
            // 
            this.txtIP.DataPropertyName = "IP";
            this.txtIP.HeaderText = "IP";
            this.txtIP.Name = "txtIP";
            // 
            // cbDepartment
            // 
            this.cbDepartment.DataPropertyName = "Department";
            this.cbDepartment.HeaderText = "Department";
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtPropertycode
            // 
            this.txtPropertycode.DataPropertyName = "Propertycode";
            this.txtPropertycode.HeaderText = "Property Code";
            this.txtPropertycode.Name = "txtPropertycode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btShowlistPC);
            this.groupBox1.Location = new System.Drawing.Point(714, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // btShowlistPC
            // 
            this.btShowlistPC.Location = new System.Drawing.Point(27, 34);
            this.btShowlistPC.Name = "btShowlistPC";
            this.btShowlistPC.Size = new System.Drawing.Size(112, 23);
            this.btShowlistPC.TabIndex = 0;
            this.btShowlistPC.Text = "Show List PC";
            this.btShowlistPC.UseVisualStyleBackColor = true;
            this.btShowlistPC.Click += new System.EventHandler(this.btShowlistPC_Click);
            // 
            // ViewInfoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.dgvPC);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewInfoPC";
            this.Text = "ViewInfoPC";
            this.Load += new System.EventHandler(this.ViewInfoPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btShowlistPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamepcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamePc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIP;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPropertycode;
    }
}