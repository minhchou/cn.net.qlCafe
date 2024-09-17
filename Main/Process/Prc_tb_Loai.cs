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
    class Prc_tb_Loai
    {
        SQL_tb_Loai Sql_Loai = new SQL_tb_Loai();
        public void themoiloai(Class_tb_Loai Loai)
        {
            if (!Sql_Loai.Equals(Loai.MALOAI))
            {
                Sql_Loai.ThemMoi_Loai(Loai);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sualoai(Class_tb_Loai Loai)
        {
            Sql_Loai.Sua_Loai(Loai);
        }
        public void xoaloai(Class_tb_Loai Loai)
        {
            Sql_Loai.Xoa_Loai(Loai);
        }
    }
}
