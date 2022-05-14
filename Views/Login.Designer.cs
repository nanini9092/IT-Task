
namespace IT_Task
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(153, 87);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(234, 87);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Log ADM";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtUse
            // 
            this.txtUse.AcceptsTab = true;
            this.txtUse.Location = new System.Drawing.Point(118, 12);
            this.txtUse.Name = "txtUse";
            this.txtUse.Size = new System.Drawing.Size(221, 23);
            this.txtUse.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.AcceptsTab = true;
            this.txtPass.Location = new System.Drawing.Point(118, 41);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(221, 23);
            this.txtPass.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 118);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.TextBox txtPass;
    }
}

