namespace Grader
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.butchangepass = new System.Windows.Forms.Button();
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.lbloldpass = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butchangepass
            // 
            this.butchangepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butchangepass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butchangepass.Location = new System.Drawing.Point(15, 136);
            this.butchangepass.Name = "butchangepass";
            this.butchangepass.Size = new System.Drawing.Size(151, 23);
            this.butchangepass.TabIndex = 8;
            this.butchangepass.Text = "CHANGE PASSWORD";
            this.butchangepass.UseVisualStyleBackColor = true;
            this.butchangepass.Click += new System.EventHandler(this.butchangepass_Click);
            // 
            // txtoldpass
            // 
            this.txtoldpass.Location = new System.Drawing.Point(15, 49);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.Size = new System.Drawing.Size(151, 20);
            this.txtoldpass.TabIndex = 9;
            // 
            // lbloldpass
            // 
            this.lbloldpass.AutoSize = true;
            this.lbloldpass.Font = new System.Drawing.Font("Monospac821 BT", 8.25F);
            this.lbloldpass.Location = new System.Drawing.Point(12, 32);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(98, 14);
            this.lbloldpass.TabIndex = 10;
            this.lbloldpass.Text = "Old password:";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(15, 100);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(151, 20);
            this.txtnewpass.TabIndex = 11;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Font = new System.Drawing.Font("Monospac821 BT", 8.25F);
            this.lblnewpassword.Location = new System.Drawing.Point(12, 83);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(98, 14);
            this.lblnewpassword.TabIndex = 12;
            this.lblnewpassword.Text = "New password:";
            // 
            // lblerror
            // 
            this.lblerror.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerror.Location = new System.Drawing.Point(12, 179);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(168, 15);
            this.lblerror.TabIndex = 13;
            this.lblerror.Text = "Error Changing Password";
            this.lblerror.Visible = false;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 203);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.lbloldpass);
            this.Controls.Add(this.txtoldpass);
            this.Controls.Add(this.butchangepass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button butchangepass;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.Label lbloldpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblerror;
    }
}