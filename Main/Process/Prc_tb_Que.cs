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
    class Prc_tb_Que
    {
        SQL_tb_Que quequansql = new SQL_tb_Que();
        // THÊM MỚI QUÊ QUÁN
        public void ThemMoiQueQuan(Class_tb_Que quequan)
        {
            if (!quequansql.Equals(quequan.MAQUE))
            {
                quequansql.ThemMoiQueQuan(quequan);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại, Vui Lòng nhập Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // SỬA QUÊ QUÁN
        public void SuaQueQuan(Class_tb_Que quequan)
        {
            quequansql.Sua_QueQuan(quequan);
        }
        // XÓA QUE QUÁN
        public void XoaQueQuan(Class_tb_Que quequan)
        {
            quequansql.Xoa_QueQuan(quequan);
        }
    }
}
