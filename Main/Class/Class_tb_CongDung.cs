using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.Main.Class
{
    class Class_tb_CongDung
    {
        private string macongdung;
        private string tencongdung;

        public string MACONGDUNG
        {
            get
            {
                return macongdung;
            }
            set
            {
                macongdung = value;
                if (macongdung == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENCONGDUNG
        {
            get
            {
                return tencongdung;
            }
            set
            {
                tencongdung = value;
            }
        }
    }
}
