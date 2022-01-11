namespace Grader
{
    partial class frmMainApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainApp));
            this.gbname = new System.Windows.Forms.GroupBox();
            this.lblteachername = new System.Windows.Forms.Label();
            this.gridRecentClasses = new System.Windows.Forms.DataGridView();
            this.gbsearch = new System.Windows.Forms.GroupBox();
            this.lblsearchidentify = new System.Windows.Forms.Label();
            this.txtsearchbar = new System.Windows.Forms.TextBox();
            this.butsearch = new System.Windows.Forms.Button();
            this.lblleftuser = new System.Windows.Forms.Label();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.butlogout = new System.Windows.Forms.Button();
            this.but = new System.Windows.Forms.Button();
            this.gbutilities = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butaddclass = new System.Windows.Forms.Button();
            this.lblloggedin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentClasses)).BeginInit();
            this.gbsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            this.gbutilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbname
            // 
            this.gbname.Controls.Add(this.lblloggedin);
            this.gbname.Controls.Add(this.lblteachername);
            this.gbname.Location = new System.Drawing.Point(112, 12);
            this.gbname.Name = "gbname";
            this.gbname.Size = new System.Drawing.Size(241, 85);
            this.gbname.TabIndex = 0;
            this.gbname.TabStop = false;
            // 
            // lblteachername
            // 
            this.lblteachername.AutoSize = true;
            this.lblteachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblteachername.Location = new System.Drawing.Point(6, 39);
            this.lblteachername.Name = "lblteachername";
            this.lblteachername.Size = new System.Drawing.Size(235, 20);
            this.lblteachername.TabIndex = 1;
            this.lblteachername.Text = "username here when logged";
            // 
            // gridRecentClasses
            // 
            this.gridRecentClasses.AllowUserToAddRows = false;
            this.gridRecentClasses.AllowUserToDeleteRows = false;
            this.gridRecentClasses.AllowUserToResizeColumns = false;
            this.gridRecentClasses.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Ivory;
            this.gridRecentClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridRecentClasses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRecentClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridRecentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRecentClasses.GridColor = System.Drawing.Color.LightCoral;
            this.gridRecentClasses.Location = new System.Drawing.Point(12, 460);
            this.gridRecentClasses.MultiSelect = false;
            this.gridRecentClasses.Name = "gridRecentClasses";
            this.gridRecentClasses.ReadOnly = true;
            this.gridRecentClasses.RowHeadersVisible = false;
            this.gridRecentClasses.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridRecentClasses.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridRecentClasses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridRecentClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRecentClasses.Size = new System.Drawing.Size(610, 199);
            this.gridRecentClasses.TabIndex = 1;
            this.gridRecentClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRecentClasses_CellClick);
            // 
            // gbsearch
            // 
            this.gbsearch.Controls.Add(this.lblsearchidentify);
            this.gbsearch.Controls.Add(this.txtsearchbar);
            this.gbsearch.Controls.Add(this.butsearch);
            this.gbsearch.Location = new System.Drawing.Point(12, 103);
            this.gbsearch.Name = "gbsearch";
            this.gbsearch.Size = new System.Drawing.Size(341, 96);
            this.gbsearch.TabIndex = 2;
            this.gbsearch.TabStop = false;
            // 
            // lblsearchidentify
            // 
            this.lblsearchidentify.AutoSize = true;
            this.lblsearchidentify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchidentify.ForeColor = System.Drawing.Color.Black;
            this.lblsearchidentify.Location = new System.Drawing.Point(6, 22);
            this.lblsearchidentify.Name = "lblsearchidentify";
            this.lblsearchidentify.Size = new System.Drawing.Size(331, 15);
            this.lblsearchidentify.TabIndex = 7;
            this.lblsearchidentify.Text = "Search by SID, Username, First, Last, or Nickname";
            // 
            // txtsearchbar
            // 
            this.txtsearchbar.Location = new System.Drawing.Point(9, 56);
            this.txtsearchbar.Name = "txtsearchbar";
            this.txtsearchbar.Size = new System.Drawing.Size(203, 20);
            this.txtsearchbar.TabIndex = 6;
            // 
            // butsearch
            // 
            this.butsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butsearch.Location = new System.Drawing.Point(234, 54);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(94, 23);
            this.butsearch.TabIndex = 5;
            this.butsearch.Text = "SEARCH";
            this.butsearch.UseVisualStyleBackColor = true;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // lblleftuser
            // 
            this.lblleftuser.AutoSize = true;
            this.lblleftuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblleftuser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblleftuser.Location = new System.Drawing.Point(8, 437);
            this.lblleftuser.Name = "lblleftuser";
            this.lblleftuser.Size = new System.Drawing.Size(135, 20);
            this.lblleftuser.TabIndex = 3;
            this.lblleftuser.Text = "Recent Classes";
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AllowUserToResizeColumns = false;
            this.gridSearchResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Ivory;
            this.gridSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridSearchResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.GridColor = System.Drawing.Color.LightCoral;
            this.gridSearchResults.Location = new System.Drawing.Point(12, 225);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridSearchResults.RowHeadersVisible = false;
            this.gridSearchResults.RowHeadersWidth = 51;
            this.gridSearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSearchResults.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchResults.Size = new System.Drawing.Size(610, 209);
            this.gridSearchResults.TabIndex = 4;
            this.gridSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearchResults_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(8, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Results";
            // 
            // butlogout
            // 
            this.butlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butlogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.butlogout.Location = new System.Drawing.Point(6, 135);
            this.butlogout.Name = "butlogout";
            this.butlogout.Size = new System.Drawing.Size(251, 43);
            this.butlogout.TabIndex = 6;
            this.butlogout.Text = "LOGOUT";
            this.butlogout.UseVisualStyleBackColor = true;
            this.butlogout.Click += new System.EventHandler(this.butlogout_Click);
            // 
            // but
            // 
            this.but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but.ForeColor = System.Drawing.Color.Black;
            this.but.Location = new System.Drawing.Point(6, 74);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(251, 43);
            this.but.TabIndex = 0;
            this.but.Text = "Change Password";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // gbutilities
            // 
            this.gbutilities.Controls.Add(this.butaddclass);
            this.gbutilities.Controls.Add(this.butlogout);
            this.gbutilities.Controls.Add(this.but);
            this.gbutilities.Location = new System.Drawing.Point(359, 12);
            this.gbutilities.Name = "gbutilities";
            this.gbutilities.Size = new System.Drawing.Size(263, 187);
            this.gbutilities.TabIndex = 7;
            this.gbutilities.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(365, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Utilities";
            // 
            // butaddclass
            // 
            this.butaddclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butaddclass.ForeColor = System.Drawing.Color.Black;
            this.butaddclass.Location = new System.Drawing.Point(6, 16);
            this.butaddclass.Name = "butaddclass";
            this.butaddclass.Size = new System.Drawing.Size(251, 43);
            this.butaddclass.TabIndex = 7;
            this.butaddclass.Text = "Delete Class";
            this.butaddclass.UseVisualStyleBackColor = true;
            // 
            // lblloggedin
            // 
            this.lblloggedin.AutoSize = true;
            this.lblloggedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblloggedin.Location = new System.Drawing.Point(6, -3);
            this.lblloggedin.Name = "lblloggedin";
            this.lblloggedin.Size = new System.Drawing.Size(117, 20);
            this.lblloggedin.TabIndex = 10;
            this.lblloggedin.Text = "Logged in as:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(646, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbutilities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbsearch);
            this.Controls.Add(this.gridSearchResults);
            this.Controls.Add(this.lblleftuser);
            this.Controls.Add(this.gridRecentClasses);
            this.Controls.Add(this.gbname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradebook";
            this.Load += new System.EventHandler(this.frmMainApp_Load);
            this.gbname.ResumeLayout(false);
            this.gbname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRecentClasses)).EndInit();
            this.gbsearch.ResumeLayout(false);
            this.gbsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            this.gbutilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbname;
        private System.Windows.Forms.Label lblteachername;
        public System.Windows.Forms.DataGridView gridRecentClasses;
        private System.Windows.Forms.GroupBox gbsearch;
        public System.Windows.Forms.Button butsearch;
        public System.Windows.Forms.TextBox txtsearchbar;
        private System.Windows.Forms.Label lblsearchidentify;
        private System.Windows.Forms.Label lblleftuser;
        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button butlogout;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.GroupBox gbutilities;
        private System.Windows.Forms.Button butaddclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblloggedin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}