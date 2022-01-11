namespace Grader
{
    partial class frmSearchDataView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.butgoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AllowUserToResizeColumns = false;
            this.gridSearchResults.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory;
            this.gridSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(13, 86);
            this.gridSearchResults.MultiSelect = false;
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridSearchResults.RowHeadersVisible = false;
            this.gridSearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSearchResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchResults.Size = new System.Drawing.Size(503, 270);
            this.gridSearchResults.TabIndex = 0;
            this.gridSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearchResults_CellClick);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Font = new System.Drawing.Font("Swis721 Cn BT", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearchResults.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSearchResults.Location = new System.Drawing.Point(211, 54);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(105, 19);
            this.lblSearchResults.TabIndex = 1;
            this.lblSearchResults.Text = "Search Results";
            // 
            // butgoback
            // 
            this.butgoback.Location = new System.Drawing.Point(13, 12);
            this.butgoback.Name = "butgoback";
            this.butgoback.Size = new System.Drawing.Size(60, 23);
            this.butgoback.TabIndex = 2;
            this.butgoback.Text = "Go back";
            this.butgoback.UseVisualStyleBackColor = true;
            this.butgoback.Click += new System.EventHandler(this.butgoback_Click);
            // 
            // frmSearchDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.butgoback);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.gridSearchResults);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSearchDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSearchResults;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Button butgoback;
    }
}