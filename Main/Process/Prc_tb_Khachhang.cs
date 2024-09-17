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
    class Prc_tb_Khachhang
    {
        SQL_tb_Khachhang khsql = new SQL_tb_Khachhang();
        public void themmoikh(Class_tb_Khachhang kh)
        {
            if (!khsql.Checked_TenKhachHang(kh.MAKH))
            {
                khsql.Them_KhachHang(kh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakh(Class_tb_Khachhang kh)
        {
            khsql.Sua_KhachHang(kh);
        }
        public void xoakh(Class_tb_Khachhang kh)
        {
            khsql.Xoa_KhachHang(kh);
        }
    }
}
