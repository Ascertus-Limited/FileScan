namespace FileScan
{
    partial class Credentials
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chWindowsAuth = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbSqlPassword = new System.Windows.Forms.TextBox();
            this.tbSqlUsername = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chWindowsAuth);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbDatabase);
            this.tabPage2.Controls.Add(this.tbSqlPassword);
            this.tabPage2.Controls.Add(this.tbSqlUsername);
            this.tabPage2.Controls.Add(this.tbServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chWindowsAuth
            // 
            this.chWindowsAuth.AutoSize = true;
            this.chWindowsAuth.Location = new System.Drawing.Point(241, 156);
            this.chWindowsAuth.Name = "chWindowsAuth";
            this.chWindowsAuth.Size = new System.Drawing.Size(157, 19);
            this.chWindowsAuth.TabIndex = 42;
            this.chWindowsAuth.Text = "Windows Authentication";
            this.chWindowsAuth.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Database";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Server";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDatabase.Location = new System.Drawing.Point(241, 127);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(220, 23);
            this.tbDatabase.TabIndex = 37;
            // 
            // tbSqlPassword
            // 
            this.tbSqlPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSqlPassword.Location = new System.Drawing.Point(241, 96);
            this.tbSqlPassword.Name = "tbSqlPassword";
            this.tbSqlPassword.Size = new System.Drawing.Size(220, 23);
            this.tbSqlPassword.TabIndex = 36;
            this.tbSqlPassword.UseSystemPasswordChar = true;
            // 
            // tbSqlUsername
            // 
            this.tbSqlUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSqlUsername.Location = new System.Drawing.Point(241, 65);
            this.tbSqlUsername.Name = "tbSqlUsername";
            this.tbSqlUsername.Size = new System.Drawing.Size(220, 23);
            this.tbSqlUsername.TabIndex = 35;
            // 
            // tbServer
            // 
            this.tbServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbServer.Location = new System.Drawing.Point(241, 34);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(220, 23);
            this.tbServer.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(631, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(712, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Credentials";
            this.Text = "Credentials";
            this.Load += new System.EventHandler(this.Credentials_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chWindowsAuth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbSqlPassword;
        private System.Windows.Forms.TextBox tbSqlUsername;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}