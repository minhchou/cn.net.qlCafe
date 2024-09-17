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
    class Prc_tb_NCC
    {
        SQL_tb_NCC nccsql = new SQL_tb_NCC();
        public void ThemMoi_NhaCungCap(Class_tb_NCC ncc)
        {
            if (!nccsql.KiemTra_NCC(ncc.MANCC))
            {
                nccsql.ThemMoi_NCC(ncc);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Sua_NhaCungCap(Class_tb_NCC ncc)
        {
            nccsql.Sua_NCC(ncc);
        }
        public void Xoa_NhaCungCap(Class_tb_NCC ncc)
        {
            nccsql.Xoa_NCC(ncc);
        }
    }
}
