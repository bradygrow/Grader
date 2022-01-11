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
    public partial class frmClassShowing : Form
    {
        int offeringid;
        String cname; //eg database
        String cnum; //eg itec340
        public frmClassShowing()
        {
            InitializeComponent();
        }

        public frmClassShowing(int offeringid, String Coursename, String Coursenum)
        {
            this.offeringid = offeringid;
            this.cname = Coursename;
            this.cnum = Coursenum;
            InitializeComponent();
        }

        private void butgoback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassShowing_Load(object sender, EventArgs e)
        {
            NewGraderInfoService.CourseOffering offering = Program.NewGraderClient.getCourseOffering(offeringid, Program.Security_Token);

            gridStudents.DataSource = offering.courseOfferingStudents;
            gridTasks.DataSource = offering.courseOfferingTasks;

            
            gridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void gridTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridTasks.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = gridTasks.Rows[index];
            offeringid = Convert.ToInt32(selectedrow.Cells["TASKID"].Value);
            NewGraderInfoService.Task task = Program.NewGraderClient.getTask(offeringid, Program.Security_Token);
            gridTaskBreakdown.DataSource = task.TaskRubricParts;
            gridTaskBreakdown.Columns[0].Visible = false;

            
            gridTaskBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
