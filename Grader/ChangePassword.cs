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
    public partial class frmChangePass : Form
    {
        private frmMainApp parent = null;
        public frmChangePass()
        {
            InitializeComponent();
        }

        public frmChangePass(frmMainApp parentref)
        {
            this.parent = parentref;
            InitializeComponent();

        }

        private void butchangepass_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text.Equals(txtoldpass.Text))
            {
                lblerror.Visible = true;
            }
            else
            {
                
                String returnedstring = Program.NewGraderClient.changeInstructorPassword(txtoldpass.Text, txtnewpass.Text, Program.Security_Token);
                if (returnedstring.StartsWith("SUCCESS"))
                {
                    Program.NewGraderClient.changeInstructorPassword(txtoldpass.Text, txtnewpass.Text, Program.Security_Token);
                    this.Close();
                } 
            }
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
          //
        }
    }
}
