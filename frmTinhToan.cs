using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    public partial class frmTinhToan : Form
    {
        public frmTinhToan()
        {
            InitializeComponent();
        }

        private void txtnhapso1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double so1 = double.Parse(txtnhapso1.Text);
            }
            catch (FormatException)

            {
                MessageBox.Show("Nhap sai dinh dang", "Thông báo");
            }
        }
        private void txtnhapso2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double so2 = double.Parse(txtnhapso2.Text);
            }
            catch (FormatException)

            {
                MessageBox.Show("Nhap sai dinh dang", "Thông báo");
            }
        }
        private void radcong_CheckedChanged(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtnhapso1.Text);
            double so2 = double.Parse(txtnhapso2.Text);
            double kq = so1 + so2;
            txtketqua.Text = kq.ToString();
        }

        private void radnhan_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            double so1 = double.Parse(txtnhapso1.Text);
            double so2 = double.Parse(txtnhapso2.Text);
            double kq = 0;
            switch(rad.Name)
            {
                case "radnhan": 
                    kq = so1 * so2;
                    break;
                case "radChia":
                    kq = so1 / so2;
                    try
                    {
                        so2 = 0;
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Nhap sai dinh dang", "Thông báo");
                    }
                    break;
                case "radtru":
                    kq = so1 - so2;
                    break;
            }
            txtketqua.Text = kq.ToString();
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
