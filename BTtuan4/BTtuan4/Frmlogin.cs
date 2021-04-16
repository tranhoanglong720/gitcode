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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }
        int dem = 0;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
            if (txttaikhoan.Text.Equals("ABC") && txtmatkhau.Text.Equals("123"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                dem++;
            if(dem>=3)
            {
                MessageBox.Show("Quá");
                this.Close();
            }
        }
    }
}
