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
    public partial class FrmVéXemPhim : Form
    {
        public FrmVéXemPhim()
        {
            InitializeComponent();
        }
        void TaoDayGhe()
        {
            Button btn;
            for (int i = 1; i <= 15; i++)
            {
                btn = new Button();
                btn.Name = "btn" + i;
                btn.Text = i.ToString();
                btn.Height = 60;
                btn.Width = 100;
                btn.BackColor = Color.Gray;
                btn.Font = new Font(btn.Font.Name, 20f, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                if (i <= 5)
                    btn.Margin = new Padding(4, 8, 4, 4);
                else
                    btn.Margin = new Padding(4, 4, 4, 4);
                btn.Click += new EventHandler(TuiTuViet_Click);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void TuiTuViet_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Gray)
            {
                btn.BackColor = Color.Yellow;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.Gray;
            }
            txtthanhtien.Text = TinhTienDangChon().ToString();

        }
        const int Gia_A = 1000;
        const int Gia_B = 1500;
        const int Gia_C = 2000;
        long TinhTienDangChon()
        {
            int TongTien = 0;
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl.BackColor == Color.Yellow)
                {
                    if (Convert.ToInt32(ctrl.Text) <= 5)
                        TongTien += Gia_A;
                    else if (Convert.ToInt32(ctrl.Text) <= 10)
                        TongTien += Gia_B;
                    else
                        TongTien += Gia_C;
                }
            }
            return TongTien;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            TaoDayGhe();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            VangThanhXanh();
            MessageBox.Show("So Tiền Bạn Phải Trả: " + txtthanhtien.Text, "Thông Báo");
        }
        void VangThanhXanh()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is Button)
                {
                    if (ctrl.BackColor == Color.Yellow)
                        ctrl.BackColor = Color.Blue;
                    ctrl.Enabled = false;
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            VangThanhXam();
        }
        void VangThanhXam()
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {            
                    if (ctrl.BackColor == Color.Yellow)
                        ctrl.BackColor = Color.Gray;                                 
            }
            txtthanhtien.Text = TinhTienDangChon().ToString();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
