using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTtuan4
{
    public partial class Frmchinh : Form
    {
        public Frmchinh()
        {
            InitializeComponent();
            
        }
        public Frmchinh(Thongtin user)
        {
            InitializeComponent();
            this.Text = "Ban đăng nhập" + user.Tk + "Pass" + user.Mk;
        }

        private void Frmchinh_Load(object sender, EventArgs e)
        {

        }
        bool KiemtratontaiForm(string strTenForm)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name.Equals(strTenForm))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void mnuchucnangthuexe_Click(object sender, EventArgs e)
        {
            if(KiemtratontaiForm("frmThuexe")==false)
            {
                FrmThuexe frm = new FrmThuexe();
                frm.MdiParent = this;
                frm.Name = "FrmThuexe";
                frm.Show();
            }
        }
    }
}
