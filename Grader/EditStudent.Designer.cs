namespace Grader
{
    partial class frmEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStudent));
            this.butsave = new System.Windows.Forms.Button();
            this.txtNewFirst = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtnewlast = new System.Windows.Forms.TextBox();
            this.txtnewmiddle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewnick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnewusername = new System.Windows.Forms.TextBox();
            this.richtxtnotes = new System.Windows.Forms.RichTextBox();
            this.lblnotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butsave
            // 
            this.butsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsave.Location = new System.Drawing.Point(89, 395);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(75, 23);
            this.butsave.TabIndex = 7;
            this.butsave.Text = "SAVE";
            this.butsave.UseVisualStyleBackColor = true;
            this.butsave.Click += new System.EventHandler(this.butlsave_Click);
            // 
            // txtNewFirst
            // 
            this.txtNewFirst.Location = new System.Drawing.Point(30, 38);
            this.txtNewFirst.MaxLength = 25;
            this.txtNewFirst.Name = "txtNewFirst";
            this.txtNewFirst.Size = new System.Drawing.Size(191, 20);
            this.txtNewFirst.TabIndex = 8;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(30, 19);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(49, 14);
            this.lblFirst.TabIndex = 9;
            this.lblFirst.Text = "First:";
            // 
            // txtnewlast
            // 
            this.txtnewlast.Location = new System.Drawing.Point(30, 82);
            this.txtnewlast.MaxLength = 25;
            this.txtnewlast.Name = "txtnewlast";
            this.txtnewlast.Size = new System.Drawing.Size(191, 20);
            this.txtnewlast.TabIndex = 10;
            // 
            // txtnewmiddle
            // 
            this.txtnewmiddle.Location = new System.Drawing.Point(30, 128);
            this.txtnewmiddle.MaxLength = 1;
            this.txtnewmiddle.Name = "txtnewmiddle";
            this.txtnewmiddle.Size = new System.Drawing.Size(191, 20);
            this.txtnewmiddle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Middle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nickname:";
            // 
            // txtnewnick
            // 
            this.txtnewnick.Location = new System.Drawing.Point(30, 178);
            this.txtnewnick.MaxLength = 25;
            this.txtnewnick.Name = "txtnewnick";
            this.txtnewnick.Size = new System.Drawing.Size(191, 20);
            this.txtnewnick.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Username:";
            // 
            // txtnewusername
            // 
            this.txtnewusername.Location = new System.Drawing.Point(30, 221);
            this.txtnewusername.MaxLength = 25;
            this.txtnewusername.Name = "txtnewusername";
            this.txtnewusername.Size = new System.Drawing.Size(191, 20);
            this.txtnewusername.TabIndex = 16;
            // 
            // richtxtnotes
            // 
            this.richtxtnotes.Location = new System.Drawing.Point(30, 261);
            this.richtxtnotes.MaxLength = 200;
            this.richtxtnotes.Name = "richtxtnotes";
            this.richtxtnotes.Size = new System.Drawing.Size(191, 128);
            this.richtxtnotes.TabIndex = 18;
            this.richtxtnotes.Text = "";
            // 
            // lblnotes
            // 
            this.lblnotes.AutoSize = true;
            this.lblnotes.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotes.Location = new System.Drawing.Point(30, 244);
            this.lblnotes.Name = "lblnotes";
            this.lblnotes.Size = new System.Drawing.Size(49, 14);
            this.lblnotes.TabIndex = 19;
            this.lblnotes.Text = "Notes:";
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 430);
            this.Controls.Add(this.lblnotes);
            this.Controls.Add(this.richtxtnotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnewusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnewnick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnewmiddle);
            this.Controls.Add(this.txtnewlast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtNewFirst);
            this.Controls.Add(this.butsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button butsave;
        private System.Windows.Forms.TextBox txtNewFirst;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtnewlast;
        private System.Windows.Forms.TextBox txtnewmiddle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnewnick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnewusername;
        private System.Windows.Forms.RichTextBox richtxtnotes;
        private System.Windows.Forms.Label lblnotes;
    }
}