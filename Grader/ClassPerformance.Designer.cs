namespace Grader
{
    partial class frmClassPerformance
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
            this.gridClassPerformance = new System.Windows.Forms.DataGridView();
            this.butgoback = new System.Windows.Forms.Button();
            this.lblgradebreakdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassPerformance)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClassPerformance
            // 
            this.gridClassPerformance.AllowUserToAddRows = false;
            this.gridClassPerformance.AllowUserToDeleteRows = false;
            this.gridClassPerformance.AllowUserToResizeColumns = false;
            this.gridClassPerformance.AllowUserToResizeRows = false;
            this.gridClassPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClassPerformance.Location = new System.Drawing.Point(13, 72);
            this.gridClassPerformance.Name = "gridClassPerformance";
            this.gridClassPerformance.RowHeadersVisible = false;
            this.gridClassPerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClassPerformance.Size = new System.Drawing.Size(404, 204);
            this.gridClassPerformance.TabIndex = 0;
            this.gridClassPerformance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClassPerformance_CellClick);
            // 
            // butgoback
            // 
            this.butgoback.Location = new System.Drawing.Point(12, 12);
            this.butgoback.Name = "butgoback";
            this.butgoback.Size = new System.Drawing.Size(60, 23);
            this.butgoback.TabIndex = 3;
            this.butgoback.Text = "Go back";
            this.butgoback.UseVisualStyleBackColor = true;
            this.butgoback.Click += new System.EventHandler(this.butgoback_Click);
            // 
            // lblgradebreakdown
            // 
            this.lblgradebreakdown.AutoSize = true;
            this.lblgradebreakdown.Font = new System.Drawing.Font("Swis721 Cn BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradebreakdown.ForeColor = System.Drawing.Color.DarkRed;
            this.lblgradebreakdown.Location = new System.Drawing.Point(152, 50);
            this.lblgradebreakdown.Name = "lblgradebreakdown";
            this.lblgradebreakdown.Size = new System.Drawing.Size(122, 19);
            this.lblgradebreakdown.TabIndex = 4;
            this.lblgradebreakdown.Text = "Grade Breakdown";
            // 
            // frmClassPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(788, 288);
            this.Controls.Add(this.lblgradebreakdown);
            this.Controls.Add(this.butgoback);
            this.Controls.Add(this.gridClassPerformance);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassPerformance";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClassPerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassPerformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClassPerformance;
        private System.Windows.Forms.Button butgoback;
        private System.Windows.Forms.Label lblgradebreakdown;
    }
}