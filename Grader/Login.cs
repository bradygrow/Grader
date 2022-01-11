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
    public partial class frmLogin : Form
    {
        static string role = "TEACHER";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void butLogin_MouseClick(object sender, MouseEventArgs e)
        {
           // String attempt = Program.NewGraderClient.logIn("bgrow","growthchart", role);
            String attempt = Program.NewGraderClient.logIn(txtUsername.Text, txtPassword.Text, role);
            //put txtUsername.Text and txtPassword.Text back into method call before submit
            if (attempt.StartsWith("ERROR"))
            {

                lbllogininfo.Visible = true;
                txtUsername.Clear();
                txtPassword.Clear();
            } else
            {
                Program.Security_Token = attempt;

                this.Close();
                
            }
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            txtUsername.Focus();

        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
            txtPassword.Focus();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
           
            txtUsername.Text = "";
            lbllogininfo.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtPassword.Text = "";

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
        }

        private void frmLogin_Deactivate(object sender, EventArgs e)
        {
            if (Program.Security_Token == null)
            {
                Application.Exit();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //
            butLogin.Focus();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.Security_Token == null)
            {
                Application.Exit();
            } 
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                callanother();
            }
        }

        private void callanother()
        {
            butLogin_MouseClick(null, null);
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
            txtPassword.Text = "";
            lbllogininfo.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
            txtPassword.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void butLogin_Enter(object sender, EventArgs e)
        {
            //
             String attempt = Program.NewGraderClient.logIn("bgrow","growthchart", role);
            //String attempt = Program.NewGraderClient.logIn(txtUsername.Text, txtPassword.Text, role);
            //put txtUsername.Text and txtPassword.Text back into method call before submit
            if (attempt.StartsWith("ERROR"))
            {

                lbllogininfo.Visible = true;
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                Program.Security_Token = attempt;

                this.Close();

            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
