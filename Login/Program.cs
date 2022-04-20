using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_dangnhap formLogin = new form_dangnhap();
            Application.Run(formLogin);
            if(formLogin.IsLogin == true)
            {
                Application.Run(new formTest(formLogin.FullName));
                //chay form can hien thi
            }
        }
    }
}
