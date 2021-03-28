using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan2Csharp
{
    public partial class frmCombobox : Form
    {
        public frmCombobox()
        {
            InitializeComponent();
        }

        private void cboso_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstdanhsach.Items.Add(cboso.SelectedItem);
        }

        private void frmCombobox_Load(object sender, EventArgs e)
        {

        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            cboso.Items.Add(txtnhap.Text.ToString());
            txtnhap.Clear();
            txtnhap.Focus();
        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                long so = long.Parse(txtnhap.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhap sai", "Thông báo");
            }
        }
        long tong()
        {
            long s = 0;
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                s += Convert.ToInt64(lstdanhsach.Items[i].ToString());
            }
            return s;
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            cboso.Enabled = false;

            MessageBox.Show("Tổng các ước số: " + tong(), "Thông báo");

        }
        int soluong()
        {
            int dem = 0;
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                if (Convert.ToInt64(lstdanhsach.Items[i].ToString()) % 2 == 0)
                {
                    dem = dem+1;
                }
            }
            return dem;
        }
        private void btnchan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("So luong so chan: " + soluong(), "Thông báo");
        }
        int ktsonguyento(int i)
        {
            int dem = 0;                                                  
                    for (int j = 2; j < Convert.ToInt64(lstdanhsach.Items[i].ToString()); j++)
                    {
                        if (Convert.ToInt64(lstdanhsach.Items[i].ToString()) % j == 0)
                        {
                            dem = dem + 1;
                        }
                    }                      
            return dem;
        }

        private void btnsonguyento_Click(object sender, EventArgs e)
        {
            int sl = 0;
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {

                if(ktsonguyento(i)==0&& Convert.ToInt64(lstdanhsach.Items[i].ToString())>1)
                {
                    sl = sl + 1;
                }
            }
                MessageBox.Show("So luong so nguyen to: " +sl, "Thong bao");
        }
    }
}

