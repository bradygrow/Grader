namespace Grader
{
    partial class frmClassShowing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.gbstudents = new System.Windows.Forms.GroupBox();
            this.gbtasks = new System.Windows.Forms.GroupBox();
            this.lblclassesandgrades = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridTaskBreakdown = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.gbstudents.SuspendLayout();
            this.gbtasks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskBreakdown)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeColumns = false;
            this.gridStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Ivory;
            this.gridStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStudents.GridColor = System.Drawing.Color.LightCoral;
            this.gridStudents.Location = new System.Drawing.Point(3, 16);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridStudents.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(977, 221);
            this.gridStudents.TabIndex = 9;
            // 
            // gridTasks
            // 
            this.gridTasks.AllowUserToAddRows = false;
            this.gridTasks.AllowUserToDeleteRows = false;
            this.gridTasks.AllowUserToResizeColumns = false;
            this.gridTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Ivory;
            this.gridTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gridTasks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.GridColor = System.Drawing.Color.LightCoral;
            this.gridTasks.Location = new System.Drawing.Point(3, 16);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTasks.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gridTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTasks.Size = new System.Drawing.Size(461, 229);
            this.gridTasks.TabIndex = 10;
            this.gridTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTasks_CellClick);
            // 
            // gbstudents
            // 
            this.gbstudents.Controls.Add(this.gridStudents);
            this.gbstudents.Location = new System.Drawing.Point(12, 12);
            this.gbstudents.Name = "gbstudents";
            this.gbstudents.Size = new System.Drawing.Size(983, 240);
            this.gbstudents.TabIndex = 11;
            this.gbstudents.TabStop = false;
            // 
            // gbtasks
            // 
            this.gbtasks.Controls.Add(this.gridTasks);
            this.gbtasks.Location = new System.Drawing.Point(12, 272);
            this.gbtasks.Name = "gbtasks";
            this.gbtasks.Size = new System.Drawing.Size(467, 248);
            this.gbtasks.TabIndex = 13;
            this.gbtasks.TabStop = false;
            // 
            // lblclassesandgrades
            // 
            this.lblclassesandgrades.AutoSize = true;
            this.lblclassesandgrades.BackColor = System.Drawing.Color.Transparent;
            this.lblclassesandgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblclassesandgrades.Location = new System.Drawing.Point(18, 5);
            this.lblclassesandgrades.Name = "lblclassesandgrades";
            this.lblclassesandgrades.Size = new System.Drawing.Size(82, 20);
            this.lblclassesandgrades.TabIndex = 12;
            this.lblclassesandgrades.Text = "Students";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTasks.Location = new System.Drawing.Point(18, 265);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(56, 20);
            this.lblTasks.TabIndex = 14;
            this.lblTasks.Text = "Tasks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridTaskBreakdown);
            this.groupBox1.Location = new System.Drawing.Point(485, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 248);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // gridTaskBreakdown
            // 
            this.gridTaskBreakdown.AllowUserToAddRows = false;
            this.gridTaskBreakdown.AllowUserToDeleteRows = false;
            this.gridTaskBreakdown.AllowUserToResizeColumns = false;
            this.gridTaskBreakdown.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Ivory;
            this.gridTaskBreakdown.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gridTaskBreakdown.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTaskBreakdown.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridTaskBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTaskBreakdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTaskBreakdown.GridColor = System.Drawing.Color.LightCoral;
            this.gridTaskBreakdown.Location = new System.Drawing.Point(3, 16);
            this.gridTaskBreakdown.Name = "gridTaskBreakdown";
            this.gridTaskBreakdown.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTaskBreakdown.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.gridTaskBreakdown.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridTaskBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTaskBreakdown.Size = new System.Drawing.Size(504, 229);
            this.gridTaskBreakdown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(491, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Task Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "had this project continued, this page would\'ve been updated more.";
            // 
            // frmClassShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1007, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblclassesandgrades);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbtasks);
            this.Controls.Add(this.gbstudents);
            this.Name = "frmClassShowing";
            this.Text = "ClassShowing";
            this.Load += new System.EventHandler(this.frmClassShowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.gbstudents.ResumeLayout(false);
            this.gbtasks.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTaskBreakdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.GroupBox gbstudents;
        private System.Windows.Forms.GroupBox gbtasks;
        private System.Windows.Forms.Label lblclassesandgrades;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridTaskBreakdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}