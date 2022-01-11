namespace Grader
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbloginpic = new System.Windows.Forms.PictureBox();
            this.lblgradebook = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.lbllogininfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbloginpic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(31, 301);
            this.txtUsername.MaximumSize = new System.Drawing.Size(183, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(183, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.MouseHover += new System.EventHandler(this.txtUsername_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(31, 330);
            this.txtPassword.MaximumSize = new System.Drawing.Size(183, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // pbloginpic
            // 
            this.pbloginpic.Image = ((System.Drawing.Image)(resources.GetObject("pbloginpic.Image")));
            this.pbloginpic.Location = new System.Drawing.Point(31, 71);
            this.pbloginpic.Name = "pbloginpic";
            this.pbloginpic.Size = new System.Drawing.Size(183, 214);
            this.pbloginpic.TabIndex = 2;
            this.pbloginpic.TabStop = false;
            // 
            // lblgradebook
            // 
            this.lblgradebook.AutoSize = true;
            this.lblgradebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradebook.ForeColor = System.Drawing.Color.Black;
            this.lblgradebook.Location = new System.Drawing.Point(29, 21);
            this.lblgradebook.Name = "lblgradebook";
            this.lblgradebook.Size = new System.Drawing.Size(188, 37);
            this.lblgradebook.TabIndex = 3;
            this.lblgradebook.Text = "GradeBook";
            // 
            // butLogin
            // 
            this.butLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butLogin.Location = new System.Drawing.Point(83, 359);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "LOGIN";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            this.butLogin.Enter += new System.EventHandler(this.butLogin_Enter);
            this.butLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butLogin_MouseClick);
            // 
            // lbllogininfo
            // 
            this.lbllogininfo.AutoSize = true;
            this.lbllogininfo.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogininfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbllogininfo.Location = new System.Drawing.Point(31, 401);
            this.lbllogininfo.Name = "lbllogininfo";
            this.lbllogininfo.Size = new System.Drawing.Size(181, 29);
            this.lbllogininfo.TabIndex = 5;
            this.lbllogininfo.Text = "Login Failed";
            this.lbllogininfo.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(239, 453);
            this.Controls.Add(this.lbllogininfo);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.lblgradebook);
            this.Controls.Add(this.pbloginpic);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmLogin_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbloginpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbloginpic;
        private System.Windows.Forms.Label lblgradebook;
        public System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label lbllogininfo;
        public System.Windows.Forms.TextBox txtUsername;
    }
}

