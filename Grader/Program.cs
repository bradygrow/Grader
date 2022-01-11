using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NewGraderInfoService.NewGraderInfoServiceSoapClient NewGraderClient;
        public static String Security_Token = null;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NewGraderClient = new NewGraderInfoService.NewGraderInfoServiceSoapClient("NewGraderInfoServiceSoap");
             
            Application.Run(new frmMainApp());
        }
    }
}
