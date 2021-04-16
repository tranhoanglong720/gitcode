using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BTtuan4
{
    public class QuanLyThueXe
    {
        ArrayList ds = new ArrayList();
       public bool ThemXe(ThongTinThueXe objXe)
        {
            if (ds.Contains(objXe))
                return false;
            else
            {
                ds.Add(objXe);
                return true;
            }
        }
        public ArrayList LayToanBoDanhSach()
        {
            return ds;
        }
        public bool Xoa(ThongTinThueXe objXe)
        {
            if (objXe != null)
            {
                ds.Remove(objXe);
                return true;
            }
            else
                return false;
        }
        public double TongTien(ThongTinThueXe objxe)
        {
            
            return objxe.Thanhtien();
            
        }
    }
}
