using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTtuan4
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
            Frmlogin frm = new Frmlogin();
            Thongtin user = new Thongtin(frm.txttaikhoan.Text, frm.txtmatkhau.Text);
                if(frm.ShowDialog()==DialogResult.OK)            
                Application.Run(new Frmchinh(user));          
        }
    }
}
