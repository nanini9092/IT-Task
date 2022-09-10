
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
            this.txtClientIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamePC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbShowCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCountPrinter = new System.Windows.Forms.Button();
            this.btCountPC = new System.Windows.Forms.Button();
            this.btEpExecl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNamepcID,
            this.txtClientIP,
            this.txtNamePC,
            this.txtDept,
            this.txtType});
            this.dgvPC.Location = new System.Drawing.Point(31, 12);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.RowTemplate.Height = 25;
            this.dgvPC.Size = new System.Drawing.Size(677, 731);
            this.dgvPC.TabIndex = 0;
            this.dgvPC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPC_CellValueChanged);
            // 
            // txtNamepcID
            // 
            this.txtNamepcID.DataPropertyName = "ID";
            this.txtNamepcID.HeaderText = "ID";
            this.txtNamepcID.Name = "txtNamepcID";
            // 
            // txtClientIP
            // 
            this.txtClientIP.DataPropertyName = "ClientIP";
            this.txtClientIP.HeaderText = "Client IP";
            this.txtClientIP.Name = "txtClientIP";
            // 
            // txtNamePC
            // 
            this.txtNamePC.DataPropertyName = "NamePC";
            this.txtNamePC.HeaderText = "Name PC";
            this.txtNamePC.Name = "txtNamePC";
            // 
            // txtDept
            // 
            this.txtDept.DataPropertyName = "Dept";
            this.txtDept.HeaderText = "Department";
            this.txtDept.Name = "txtDept";
            // 
            // txtType
            // 
            this.txtType.DataPropertyName = "Type";
            this.txtType.HeaderText = "Type";
            this.txtType.Name = "txtType";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btEpExecl);
            this.groupBox1.Controls.Add(this.btCountPrinter);
            this.groupBox1.Controls.Add(this.btCountPC);
            this.groupBox1.Location = new System.Drawing.Point(714, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 731);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbShowCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 625);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // lbShowCount
            // 
            this.lbShowCount.AutoSize = true;
            this.lbShowCount.Location = new System.Drawing.Point(70, 34);
            this.lbShowCount.Name = "lbShowCount";
            this.lbShowCount.Size = new System.Drawing.Size(87, 15);
            this.lbShowCount.TabIndex = 1;
            this.lbShowCount.Text = "Number Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Số :";
            // 
            // btCountPrinter
            // 
            this.btCountPrinter.Location = new System.Drawing.Point(27, 84);
            this.btCountPrinter.Name = "btCountPrinter";
            this.btCountPrinter.Size = new System.Drawing.Size(112, 23);
            this.btCountPrinter.TabIndex = 0;
            this.btCountPrinter.Text = "Count Printer";
            this.btCountPrinter.UseVisualStyleBackColor = true;
            this.btCountPrinter.Click += new System.EventHandler(this.btCountPrinter_Click);
            // 
            // btCountPC
            // 
            this.btCountPC.Location = new System.Drawing.Point(27, 34);
            this.btCountPC.Name = "btCountPC";
            this.btCountPC.Size = new System.Drawing.Size(112, 23);
            this.btCountPC.TabIndex = 0;
            this.btCountPC.Text = "Count PC";
            this.btCountPC.UseVisualStyleBackColor = true;
            this.btCountPC.Click += new System.EventHandler(this.btCountPC_Click);
            // 
            // btEpExecl
            // 
            this.btEpExecl.Location = new System.Drawing.Point(27, 132);
            this.btEpExecl.Name = "btEpExecl";
            this.btEpExecl.Size = new System.Drawing.Size(112, 23);
            this.btEpExecl.TabIndex = 0;
            this.btEpExecl.Text = "Export Excel";
            this.btEpExecl.UseVisualStyleBackColor = true;
            this.btEpExecl.Click += new System.EventHandler(this.btEpExecl_Click);
            // 
            // ViewInfoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 755);
            this.Controls.Add(this.dgvPC);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewInfoPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewInfoPC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewInfoPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCountPC;
        private System.Windows.Forms.Button btCountPrinter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamepcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClientIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNamePC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtType;
        private System.Windows.Forms.Label lbShowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btEpExecl;
    }
}