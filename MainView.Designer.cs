
namespace IT_Task
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnInfoPc = new System.Windows.Forms.ToolStripMenuItem();
            this.statsPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deployToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandwidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkTrafficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnStripTestMariaDB = new System.Windows.Forms.ToolStripMenuItem();
            this.MnSaveToText = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.extendToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnInfoPc,
            this.statsPCToolStripMenuItem,
            this.deployToolStripMenuItem,
            this.MnLogout});
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.computerToolStripMenuItem.Text = "Computer";
            // 
            // MnInfoPc
            // 
            this.MnInfoPc.Name = "MnInfoPc";
            this.MnInfoPc.Size = new System.Drawing.Size(180, 22);
            this.MnInfoPc.Text = "Info PC";
            this.MnInfoPc.Click += new System.EventHandler(this.MnInfoPc_Click);
            // 
            // statsPCToolStripMenuItem
            // 
            this.statsPCToolStripMenuItem.Name = "statsPCToolStripMenuItem";
            this.statsPCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statsPCToolStripMenuItem.Text = "Stats PC";
            // 
            // deployToolStripMenuItem
            // 
            this.deployToolStripMenuItem.Name = "deployToolStripMenuItem";
            this.deployToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deployToolStripMenuItem.Text = "Deploy";
            // 
            // MnLogout
            // 
            this.MnLogout.Name = "MnLogout";
            this.MnLogout.Size = new System.Drawing.Size(180, 22);
            this.MnLogout.Text = "Logout";
            this.MnLogout.Click += new System.EventHandler(this.Mnlogout_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bandwidthToolStripMenuItem,
            this.networkTrafficToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // bandwidthToolStripMenuItem
            // 
            this.bandwidthToolStripMenuItem.Name = "bandwidthToolStripMenuItem";
            this.bandwidthToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.bandwidthToolStripMenuItem.Text = "Bandwidth";
            // 
            // networkTrafficToolStripMenuItem
            // 
            this.networkTrafficToolStripMenuItem.Name = "networkTrafficToolStripMenuItem";
            this.networkTrafficToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.networkTrafficToolStripMenuItem.Text = "Network traffic";
            // 
            // extendToolStripMenuItem
            // 
            this.extendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnStripTestMariaDB,
            this.MnSaveToText});
            this.extendToolStripMenuItem.Name = "extendToolStripMenuItem";
            this.extendToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.extendToolStripMenuItem.Text = "Extend";
            this.extendToolStripMenuItem.Click += new System.EventHandler(this.extendToolStripMenuItem_Click);
            // 
            // MnStripTestMariaDB
            // 
            this.MnStripTestMariaDB.Name = "MnStripTestMariaDB";
            this.MnStripTestMariaDB.Size = new System.Drawing.Size(142, 22);
            this.MnStripTestMariaDB.Text = "Test MariaDB";
            this.MnStripTestMariaDB.Click += new System.EventHandler(this.MnStripTestMariaDB_Click);
            // 
            // MnSaveToText
            // 
            this.MnSaveToText.Name = "MnSaveToText";
            this.MnSaveToText.Size = new System.Drawing.Size(142, 22);
            this.MnSaveToText.Text = "Save To Text";
            this.MnSaveToText.Click += new System.EventHandler(this.MnSaveToText_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyTestDB";
            this.notifyIcon1.Visible = true;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1151, 519);
            this.panelMain.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 543);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "MainView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnInfoPc;
        private System.Windows.Forms.ToolStripMenuItem statsPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deployToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandwidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkTrafficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnStripTestMariaDB;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnLogout;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem MnSaveToText;
        private System.Windows.Forms.Panel panelMain;
    }
}