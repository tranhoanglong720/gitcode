using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3
{
    public partial class frmBai18 : Form
    {
       
        public frmBai18()
        {
            InitializeComponent();
        }


        private void frmBai18_Load(object sender, EventArgs e)
        {                           
        }        
        private void btndsngaunhien_Click(object sender, EventArgs e)
        {
            String[] ho = { "nguyễn", "trần", "đinh", "gia", "ngô", "le", "hà", "lâm", "vương" };
            String[] tenlot = { "thị", "hoàng anh", "huy gia", "cao đồng", "van", "duy", "thanh", "anh" };
            String[] ten = { "lan", "huong", "tuan", "hùng", "cuong", "vi", "loan", "nam", "tú", "nga", "phát", "kiệt", "triều", "hạ", "hải","son" };
            StringBuilder HoTen;
            String h = "",l="",t="";           
            Random x = new Random();
            for(int i=0;i<10; i++)
            {
                HoTen = new StringBuilder();
                h = ho[x.Next(0, ho.Length)];
                HoTen.Append(h);
                l = tenlot[x.Next(0, tenlot.Length)];
                HoTen.Append(" ");
                HoTen.Append(l);               
                t = ten[x.Next(0, ten.Length)];
                HoTen.Append(" ");
                HoTen.Append(t);
                lstdanhsach.Items.Add(HoTen.ToString());
            }
        }

        private void btnxoadangchon_Click(object sender, EventArgs e)
        {
            int i = 0;
          while(lstdanhsach.SelectedItems.Count>0)
            {
                i = lstdanhsach.SelectedIndices[0];
                lstdanhsach.Items.RemoveAt(i);
            }
        }

        private void btnxoatenson_Click(object sender, EventArgs e)
        {          
            String Ten = "son";
            String HoVaTen;
            for(int i=0;i<lstdanhsach.Items.Count;i++)
            {
                lstdanhsach.SetSelected(i, false);
                HoVaTen = lstdanhsach.Items[i].ToString();
                if (HoVaTen.StartsWith(Ten))
                {
                    lstdanhsach.Items.RemoveAt(i);
                }
            }
        }

        private void btnxoahole_Click(object sender, EventArgs e)
        {
            String Ho = "le";
            String HoVaTen;
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                lstdanhsach.SetSelected(i, false);
                HoVaTen = lstdanhsach.Items[i].ToString();
                if (HoVaTen.Equals("le"))
                {
                    lstdanhsach.Items.RemoveAt(i);
                }
            }
        }
        string doichuhoa(string chuoi)
        {
            string str="";
            for(int i=0;i<chuoi.Length;i++)
            {
                str += chuoi.ToString().ToUpper();
            }
            return str;
        }
        
        private void btntangchu_Click(object sender, EventArgs e)
        {
            string hotenchuaxuli = "";
            string hoten = "";
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                hotenchuaxuli = lstdanhsach.Items[i].ToString();
                hoten = doichuhoa(hotenchuaxuli);
                lstdanhsach.Items.RemoveAt(i);
                lstdanhsach.Items.Insert(i, hoten);
                lstdanhsach.Refresh();
            }
        }
        string doihoadautu(string chuoitho)
        {
            string str = "";
            for (int i = 1; i < chuoitho.Length;i++)
            {
                if (chuoitho[i - 1] == ' ' && chuoitho[i] != ' ')
                    str += chuoitho.ToString().ToUpper();
                else
                    str += chuoitho[i];
            }
            str = chuoitho[0].ToString().ToUpper() + str;
            return str;
        }
        private void btnhoadautu_Click(object sender, EventArgs e)
        {
            string hotenchuaxuli = "";
            string hoten = "";
            for(int i=0;i<lstdanhsach.Items.Count;i++)
            {
                hotenchuaxuli = lstdanhsach.Items[i].ToString();
                hoten = doihoadautu(hotenchuaxuli);
                lstdanhsach.Items.RemoveAt(i);
                lstdanhsach.Items.Insert(i, hoten);
                lstdanhsach.Refresh();
            }
            
        }

        private void btnxoatatca_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                lstdanhsach.Items.RemoveAt(i);
            }
        }
        string doichuthuong(string chuoi)
        {
            string str = "";
            for (int i = 0; i < chuoi.Length; i++)
            {
                str += chuoi.ToString().ToLower();
            }
            return str;
        }   
        private void btngiamchu_Click(object sender, EventArgs e)
        {
            string hotenchuaxuli = "";
            string hoten = "";
            for (int i = 0; i < lstdanhsach.Items.Count; i++)
            {
                hotenchuaxuli = lstdanhsach.Items[i].ToString();
                hoten = doichuthuong(hotenchuaxuli);
                lstdanhsach.Items.RemoveAt(i);
                lstdanhsach.Items.Insert(i, hoten);
                lstdanhsach.Refresh();
            }
        }
    }
}
