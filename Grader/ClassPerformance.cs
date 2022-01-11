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
    public partial class frmClassPerformance : Form
    {
        string sid;
        int offeringid;
        public frmClassPerformance()
        {
            InitializeComponent();
        }

        public frmClassPerformance(string sid, int classofferingid)
        {
            this.sid = sid;
            this.offeringid = classofferingid;
            InitializeComponent();
        }

        private void butgoback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClassPerformance_Load(object sender, EventArgs e)
        {
            NewGraderInfoService.StudentClassPerformance classPerformance = Program.NewGraderClient.getStudentClassPerformance(sid, offeringid, Program.Security_Token);
            gridClassPerformance.DataSource = classPerformance.studentGrades;
            gridClassPerformance.Columns[0].Visible = false;
        }

        private void gridClassPerformance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridClassPerformance.CurrentRow == null)
            {
                // nothing and dont crash
            }
            else { 
            String x = gridClassPerformance.CurrentRow.Cells[1].Value.ToString();
            int taskid = Convert.ToInt32(x);
            frmTaskBreakdown taskbreadown = new frmTaskBreakdown(sid, taskid);
            taskbreadown.Show();
        }
        }
    }
}
