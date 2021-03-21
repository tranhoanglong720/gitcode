using System;
using System.Windows.Forms;

namespace Csharp1
{
    public partial class FrmPtBac2 : Form
    {
        public FrmPtBac2()
        {
            InitializeComponent();
        }

        private void FrmPtBac2_Load(object sender, EventArgs e)
        {
         
                 
        }
        private void txtnhapa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtnhapa.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi Định Dạng", "Thông báo");
            }
            btnxoa.Enabled = true;
            
        }

        private void txtnhapb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double b = double.Parse(txtnhapb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi Định Dạng", "Thông báo");
            }
        }

        private void txtnhapc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(txtnhapc.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi Định Dạng", "Thông báo");
            }
            btnTinh.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtnhapa.Clear();
            txtnhapb.Clear();
            txtnhapc.Clear();
            txtnhapa.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtnhapa.Text);
            double b = double.Parse(txtnhapb.Text);
            double c = double.Parse(txtnhapc.Text);
            double kq, delta, x1, x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtketqua.Text = "Phương Trình Vô Số Nghiệm";

                    }
                    else
                        txtketqua.Text = "Phương Trình Vô Nghiệm";
                }
                else
                {
                    kq = -c / b;
                    txtketqua.Text = kq.ToString();
                }
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    txtketqua.Text = "Phương Trình Vô Nghiệm";
                else if (delta == 0)
                {
                    txtketqua.Text = "Phương Trình Có 1 Nghiệm" + ((-b) / (2 * a));
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta) / (2 * a));
                    x2 = (-b - Math.Sqrt(delta) / (2 * a));
                    txtketqua.Text = "Phương Trình Có 2 Nghiệm" + "X1=" + x1 + "X2=" + x2;
                }
            }


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
