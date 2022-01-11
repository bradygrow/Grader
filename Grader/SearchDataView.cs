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
    public partial class frmSearchDataView : Form
    {
        string search; 
        public frmSearchDataView()
        {
            InitializeComponent();
        }
       

        public frmSearchDataView(String inputsearch)
        {

            this.search = inputsearch;
            InitializeComponent();
        }
        
        private void butgoback_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void frmSearchDataView_Load(object sender, EventArgs e)
        {
       
            gridSearchResults.DataSource = Program.NewGraderClient.findStudent(search, Program.Security_Token);
        }

        private void gridSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            String SID = gridSearchResults.CurrentRow.Cells[0].Value.ToString();
            frmStudent newStudent = new frmStudent(SID);
            newStudent.Show();
            
            
        }
    }
}
