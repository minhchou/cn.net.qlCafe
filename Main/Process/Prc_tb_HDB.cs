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
    class Prc_tb_HDB
    {
        SQL_tb_HDB SQL_HDB = new SQL_tb_HDB();
        public void ThemMoiHDB(Class_tb_HDB hdb)
        {
            if (!SQL_HDB.KiemTra_HDB(hdb.MAHDB))
            {
                SQL_HDB.ThemMoi_HDB(hdb);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaHDB(Class_tb_HDB hdb)
        {
            SQL_HDB.Sua_HDB(hdb);
        }
        public void XoaHDB(Class_tb_HDB hdb)
        {
            SQL_HDB.Xoa_HDB(hdb);
        }
        //load nv
        public void LoadMaNV(ComboBox cbnv)
        {
            SQL_HDB.Load_MaNV(cbnv);
        }
        public string LoadTenNV(string Tennv, string Manv)
        {
            Tennv = SQL_HDB.Load_TenNV(Tennv, Manv);
            return Tennv;
        }
        //load khách hàng
        public void LoadMaKH(ComboBox cbkh)
        {
            SQL_HDB.Load_MaKhach(cbkh);
        }
        public string LoadTenKH(string Tenkh, string Makh)
        {
            Tenkh = SQL_HDB.Load_TenKhachHang(Tenkh, Makh);
            return Tenkh;
        }

    }
}
