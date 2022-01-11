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
    public partial class frmTaskBreakdown : Form
    {   
        int taskid;
        String sid;
        public frmTaskBreakdown()
        {
            InitializeComponent();
        }

        public frmTaskBreakdown(String sid, int taskid)
        {
            this.taskid = taskid;
            this.sid = sid;
            InitializeComponent();

        }

        private void frmTaskBreakdown_Load(object sender, EventArgs e)
        {
            NewGraderInfoService.StudentTaskGrade newtask = Program.NewGraderClient.getStudentTaskGrade(sid, taskid, Program.Security_Token);
            gridTasks.DataSource = newtask.studentGradeRubricGrades;
            gridTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void butgoback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
