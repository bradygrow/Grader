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
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }

        private void frmMainApp_Load(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog();
            if (Program.Security_Token == null)
            {
                Application.Exit();
            }
            else
            {
                lblteachername.Text = LoginForm.txtUsername.Text;
                gridRecentClasses.DataSource = Program.NewGraderClient.getCourseOfferingsList("RECENT", Program.Security_Token);
                txtsearchbar.Height = 22;

                gridRecentClasses.Columns[0].Visible = false;
                gridRecentClasses.Columns[4].Visible = false;
                gridRecentClasses.Columns[6].Visible = false;
                gridRecentClasses.Columns[7].Visible = false;
                gridRecentClasses.Columns[8].Visible = false;
                gridRecentClasses.Columns[9].Visible = false;

                gridRecentClasses.Sort(gridRecentClasses.Columns["SEMESTER"], ListSortDirection.Descending);
                gridRecentClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        
            

        private void butsearch_Click(object sender, EventArgs e)
        {//pull up a menu with the datatable and then on that click go to the student page using SID of selected row
            if(txtsearchbar.Text.Length == 0)
            {
                //nothing happens!
            }
            else
            {
                gridSearchResults.DataSource = Program.NewGraderClient.findStudent(txtsearchbar.Text, Program.Security_Token);
                gridSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            if(txtsearchbar.Text.Length == 9 && txtsearchbar.Text.StartsWith("900"))
            {
                String search = txtsearchbar.Text;
                char temp = txtsearchbar.Text[3];
                char[] searcharray = txtsearchbar.Text.ToCharArray();
                if(searcharray[4]== temp && searcharray[5] == temp && searcharray[6] == temp && searcharray[7] == temp && searcharray[8] == temp)
                {
                    frmStudent newStudent = new frmStudent(txtsearchbar.Text);
                    gridSearchResults.DataSource = Program.NewGraderClient.findStudent(txtsearchbar.Text, Program.Security_Token);
                    gridSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    newStudent.Show();
                } else
                {
                    gridSearchResults.DataSource = Program.NewGraderClient.findStudent(txtsearchbar.Text, Program.Security_Token);
                    gridSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                gridSearchResults.DataSource = Program.NewGraderClient.findStudent(txtsearchbar.Text, Program.Security_Token);
                gridSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void gridSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSearchResults.CurrentRow.Cells[0].Value.ToString() == null)
            {
                //
            }
            else
            {
                String SID = gridSearchResults.CurrentRow.Cells[0].Value.ToString();
                frmStudent newStudent = new frmStudent(SID);
                String name;
                String first = gridSearchResults.CurrentRow.Cells[2].Value.ToString();
                String last = gridSearchResults.CurrentRow.Cells[3].Value.ToString();
                name = last + ", " + first;
                newStudent.Text = name;
                newStudent.Show();
            }
        }

        private void gridRecentClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int offeringid;
            String Coursename = gridRecentClasses.CurrentRow.Cells[2].Value.ToString();
            String Coursenum = gridRecentClasses.CurrentRow.Cells[1].Value.ToString();
            String Semester = gridRecentClasses.CurrentRow.Cells[3].Value.ToString();
            int index = gridRecentClasses.SelectedCells[0].RowIndex;
            DataGridViewRow selectedrow = gridRecentClasses.Rows[index];
            offeringid = Convert.ToInt32(selectedrow.Cells["OFFERINGID"].Value);
            frmClassShowing classpage = new frmClassShowing(offeringid, Coursename, Coursenum);
            classpage.Text = Coursenum + " - " + Coursename + " - " + Semester;
            classpage.Show();
        }

        private void butlogout_Click(object sender, EventArgs e)
        {
            DialogResult Message = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo);
            switch(Message)
            {
                case DialogResult.Yes:
                    String attemptlogout = Program.NewGraderClient.logOut(Program.Security_Token);
                    if (attemptlogout.StartsWith("SUCCESS"))
                    {
                        Application.Exit();
                       
                    }           
                    break;
                case DialogResult.No:
                    break;
                    
            } 
        }

        private void but_Click(object sender, EventArgs e)
        {
            frmChangePass passwordchangeform = new frmChangePass();
            passwordchangeform.ShowDialog();
            
        }
    }
}
