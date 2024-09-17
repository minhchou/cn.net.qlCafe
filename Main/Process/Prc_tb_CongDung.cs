using QL_CAFE.DataAccess;
using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.Main.Process
{
    class Prc_tb_CongDung
    {
        SQL_tb_CongDung SQL_CongDung = new SQL_tb_CongDung();
        public void ThemMoi_CD(Class_tb_CongDung cd)
        {
            if (!SQL_CongDung.KiemTra_CongDung(cd.MACONGDUNG))
            {
                SQL_CongDung.ThemMoi_CongDung(cd);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Sua_CD(Class_tb_CongDung cd)
        {
            SQL_CongDung.Sua_CongDung(cd);
        }
        public void Xoa_CD(Class_tb_CongDung cd)
        {
            SQL_CongDung.Xoa_CongDung(cd);
        }
    }
}
