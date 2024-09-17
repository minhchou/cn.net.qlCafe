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
    class Prc_tb_NhanVien
    {
        SQL_tb_NhanVien nvsql = new SQL_tb_NhanVien();
        public void themmoinv(Class_tb_NhanVien nv)
        {
            if (!nvsql.Kiem_Tra_NhanVien(nv.MANV))
            {
                nvsql.Them_Moi_NhanVien(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Sửa Nhân Viên
        public void suanv(Class_tb_NhanVien nv)
        {
            nvsql.Sua_NhanVien(nv);
        }
        //Xóa Nhân Viên
        public void xoanv(Class_tb_NhanVien nv)
        {
            nvsql.Xoa_NhanVien(nv);
        }
        public void loadmaque(ComboBox cbq)
        {
            nvsql.Load_Ma_Que(cbq);
        }
        public string loadtenque(string TenQue, string MaQue)
        {
            TenQue = nvsql.Load_Ten_Que(TenQue, MaQue);
            return TenQue;
        }

    }
}
