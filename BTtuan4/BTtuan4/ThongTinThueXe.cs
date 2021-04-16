using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtuan4
{
    public class ThongTinThueXe
    {
        private string makh;
        private string hoten;
        private int soluong;
        private double dongia;
        private bool tinhtrang;
        private double thanhtien;
        public ThongTinThueXe() { }
        public ThongTinThueXe(string makh, string hoten, int soluong, double dongia, bool tinhtrang, double thanhtien)
        {
            this.makh = makh;
            this.hoten = hoten;
            this.soluong = soluong;
            this.dongia = dongia;
            this.tinhtrang = tinhtrang;
            this.thanhtien = thanhtien;
        }

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public double Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public bool Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
       
        public double Thanhtien()
        {
            Double tt=0;
            if (Tinhtrang==true)
            {
                tt = (soluong * dongia) * 0.97;
            }
            else
                tt = (soluong * dongia) * 1.05;
            return tt;
        }
    }
}
