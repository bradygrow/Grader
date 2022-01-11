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
    public partial class frmEditStudent : Form
    {
        frmStudent student;
        String sid;
        NewGraderInfoService.Student studentobject;
        public frmEditStudent()
        {
            InitializeComponent();
        }

        public frmEditStudent(frmStudent Student, NewGraderInfoService.Student stuobj, String SID)
        {
            this.student = Student;
            this.sid = SID;
            this.studentobject = stuobj;
            InitializeComponent();
        }

        private void butlsave_Click(object sender, EventArgs e)
        {
            string newfirst = txtNewFirst.Text;
            string newlast = txtnewlast.Text;
            string newmiddle = txtnewmiddle.Text;
            string newnick = txtnewnick.Text;
            string newusername = txtnewusername.Text;
           if(newfirst.Length == 0)
            {
                //dont change anything
            }
            else
            {

                student.lblstudentfirst.Text = newfirst;
                studentobject.firstname = newfirst;
            }

           if(newlast.Length == 0)
            {
                //
            } else
            {
                student.lblstudentlast.Text = newlast;
                studentobject.lastname = newlast;
            }

           if(newmiddle.Length == 0)
            {
//
            }
            else
            {
                student.lblstudentmiddle.Text = newmiddle;
                studentobject.middleinitial = newmiddle;
            }

            if(newnick.Length == 0)
            {

            }
            else
            {
                student.lblstudentnickname.Text = newnick;
                studentobject.nickname = newnick;
            }
            
            if(newusername.Length == 0)
            {

            }
            else
            {
                student.lblstudentusername.Text = newusername;
                studentobject.username = newusername;
            }

           
           
            if(newmiddle.Length > 1)
            {
                MessageBox.Show("Middle can only be ONE character long!");
            }
            else
            {
                Program.NewGraderClient.saveStudent("UPDATE", studentobject, Program.Security_Token);
                Grader.Properties.Settings.Default.Save();
                this.Close();
            }
            
        }
    }
}
