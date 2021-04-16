using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace BTtuan4
{
    public partial class FrmThuexe : Form
    {
        public FrmThuexe()
        {
            InitializeComponent();
        }

       
        private void FrmThuexe_Load(object sender, EventArgs e)
        {
            CreatColumn(lvwDanhsach);
        }
     void CreatColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Ma Kh", 80);
            lvw.Columns.Add("HoTen", 150);
            lvw.Columns.Add("So Luong", 80);
            lvw.Columns.Add("Don Gia", 80);
            lvw.Columns.Add("Tình Trạng", 80);
            lvw.Columns.Add("Thành Tiền", 80);
        }
        private ThongTinThueXe TaoOjXe()
        {
            ThongTinThueXe xe = new ThongTinThueXe();
            
            xe.Makh = txtMakh.Text;
            xe.Hoten = txtHoten.Text;
            xe.Soluong = Convert.ToInt32(txtSoluong.Text);
            xe.Dongia = Convert.ToInt64(txtDongia.Text);

            if (ckgiam.Checked == true)
                xe.Tinhtrang = true;
            else
                xe.Tinhtrang = false;
            return xe;
        }
        private void btntinh_Click(object sender, EventArgs e)
        {

            ThongTinThueXe xe = TaoOjXe();
            QuanLyThueXe qlXe = new QuanLyThueXe();
            qlXe.ThemXe(xe);       
            LoadDSxeToListView(qlXe.LayToanBoDanhSach(), lvwDanhsach);                               
        }
        void LoadDSxeToListView(ArrayList ds,ListView lvw)
        {
            lvw.Items.Clear();
            ListViewItem lvwItem;
            float TienPhaiTra;
            foreach(ThongTinThueXe xe in ds)
            {
                lvwItem = new ListViewItem();
                lvwItem.Text = xe.Makh;
                lvwItem.SubItems.Add(xe.Hoten);
                lvwItem.SubItems.Add(xe.Soluong.ToString());
                lvwItem.SubItems.Add(xe.Dongia.ToString());
                if (xe.Tinhtrang)

                    lvwItem.SubItems.Add("Đúng Hạn");
                else
                    lvwItem.SubItems.Add("Trễ Hạn");
                
                lvwItem.SubItems.Add(xe.Thanhtien().ToString());
                lvwItem.Tag = xe;
                lvw.Items.Add(lvwItem);
            }
        }
    }
}
