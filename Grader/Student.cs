using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grader
{
    public partial class frmStudent : Form
    {
        String stuID;
        int offeringid;
        NewGraderInfoService.Student currentstu;
        
        public frmStudent()
        {
            InitializeComponent();
        }

        public frmStudent(String SID)
        {
            this.stuID = SID;
            InitializeComponent();

        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            NewGraderInfoService.Student currentstudent = Program.NewGraderClient.getStudent(stuID, Program.Security_Token);
            if (this.Text.Equals("Student"))
            {
                this.Text = currentstudent.lastname + ", " + currentstudent.firstname;
            }
                currentstu = currentstudent;
                gridClasses.DataSource = currentstudent.studentEnrollments;
                cbclasslist.DataSource = currentstudent.studentEnrollments;
                cbclasslist.DisplayMember = "OFFERINGNICKNAME";
                cbclasslist.ValueMember = "COURSENUM";
                //gridClasses.Columns[0].Visible = false; //SID line
                //gridClasses.Columns[4].Visible = false; //Enrollment Notes line
                lblstudentusername.Text = currentstudent.username;
                lblstudentfirst.Text = currentstudent.firstname;
                lblstudentlast.Text = currentstudent.lastname;
                lblstudentmiddle.Text = currentstudent.middleinitial;

                // if (currentstudent.nickname.Length == 0 || currentstudent.nickname == null)
                // {
                //     lblstudentnickname.Text = "N/A";
                // }
                //gridClasses.Columns

                lblstudentnickname.Text = currentstudent.nickname;
                lblstudentsid.Text = currentstudent.SID;
                gridClasses.Columns[0].HeaderCell.Value = "Class ID";
                gridClasses.Columns[8].Visible = false;
                gridClasses.Columns[9].Visible = false;

                gridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridClassPerformance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            





        }

        private void gridClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //
        }
        
        private void gbattendance_Enter(object sender, EventArgs e)
        {
            // = 
        }

        private void gridClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridClasses.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = gridClasses.Rows[index];
            offeringid = Convert.ToInt32(selectedrow.Cells["OFFERINGID"].Value);
           

            
            
            NewGraderInfoService.StudentClassPerformance classPerformance = Program.NewGraderClient.getStudentClassPerformance(stuID, offeringid, Program.Security_Token);
            
            gridClassPerformance.DataSource = classPerformance.studentGradeSummary;
            gridClassPerformance.Columns[0].HeaderCell.Value = "Task ID";
            gridClassPerformance.Columns[2].Visible = false;

            gridAttendance.DataSource = classPerformance.studentAttendance;
            
            gridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridAttendanceSummary.DataSource = classPerformance.stuAttendanceSummary;
            gridAttendanceSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAttendanceSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridAttendanceSummary.Columns[3].HeaderCell.Value = "";
            // gridAttendance.Columns[1].HeaderCell.Value = "Class ID";
            // gridAttendance.Columns[0].Visible = false;
            gridAttendance.Columns[1].Visible = false;
           // gridAttendance.Columns[0].Visible = false;

          

            gridTasks.DataSource = classPerformance.studentGrades;
            gridTasks.Columns[5].Visible = false;
            //Grader.Properties.Settings.Default.lname = "jim";

        }

        private void lblleftfirst_Click(object sender, EventArgs e)
        {
            //
        }

        private void butgoback_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void butsearch_Click(object sender, EventArgs e)
        {

            String COURSENUM = (String)cbclasslist.SelectedValue;

            for (int i = 0; i < gridClasses.Rows.Count; i++)
            {
             
                if (gridClasses.Rows[i].Cells[3].Value.ToString().Equals(COURSENUM))
                {
                    int index = gridClasses.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedrow = gridClasses.Rows[index];
                    offeringid = Convert.ToInt32(selectedrow.Cells["OFFERINGID"].Value);

                    NewGraderInfoService.StudentClassPerformance classPerformance = Program.NewGraderClient.getStudentClassPerformance(stuID, offeringid, Program.Security_Token);

                    gridClassPerformance.DataSource = classPerformance.studentGradeSummary;
                    gridClassPerformance.Columns[0].HeaderCell.Value = "Task ID";
                    gridClassPerformance.Columns[2].Visible = false;

                    gridAttendance.DataSource = classPerformance.studentAttendance;

                    gridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    gridAttendanceSummary.DataSource = classPerformance.stuAttendanceSummary;
                    gridAttendanceSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gridAttendanceSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    gridAttendanceSummary.Columns[3].HeaderCell.Value = "";
                    // gridAttendance.Columns[1].HeaderCell.Value = "Class ID";
                    // gridAttendance.Columns[0].Visible = false;
                    gridAttendance.Columns[1].Visible = false;
                    // gridAttendance.Columns[0].Visible = false;



                    gridTasks.DataSource = classPerformance.studentGrades;
                    gridTasks.Columns[5].Visible = false;
                    //Grader.Properties.Settings.Default.lname = "jim";

                }

            }
        }

        private void gridClassPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void gridClassPerformance_Click(object sender, EventArgs e)
        {
            //
        }

        private void gridTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void gridTasks_Click(object sender, EventArgs e)
        {
            int taskid;
            int index = gridTasks.SelectedCells[0].RowIndex;
            if (index != 0)
            {
                DataGridViewRow selectedrow = gridTasks.Rows[index];
                taskid = Convert.ToInt32(selectedrow.Cells["TASKID"].Value);
                frmTaskBreakdown taskBreakdown = new frmTaskBreakdown(stuID, taskid);
                taskBreakdown.ShowDialog();
            }
            
        }

        private void but_Click(object sender, EventArgs e)
        {
            frmEditStudent studentedit = new frmEditStudent(this, currentstu, stuID);
            studentedit.Show();
        }

        /* private void cbterm_SelectedIndexChanged(object sender, EventArgs e)
         {
             NewGraderInfoService.StudentClassPerformance classPerformance = Program.NewGraderClient.getStudentClassPerformance(stuID, offeringid, Program.Security_Token);
         }
         */
    }
}
