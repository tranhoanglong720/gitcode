using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtuan4
{
    public class Thongtin
    {
       private string tk;
       private string mk;
         public Thongtin()
        { }
        public Thongtin(string tk, string mk)
        {
            this.tk = tk;
            this.mk = mk;
        }

        public string Tk
        {
            get
            {
                return tk;
            }

            set
            {
                tk = value;
            }
        }

        public string Mk
        {
            get
            {
                return mk;
            }

            set
            {
                mk = value;
            }
        }
    }
}
