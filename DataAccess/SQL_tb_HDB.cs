using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_HDB
    {
        Connection cn = new Connection();
        public bool KiemTra_HDB(string mahdb)
        {
            return cn.kiemtra("select count(*) from [tb_HDB] where mahdb=N'" + mahdb + "'");
        }
        public void ThemMoi_HDB(Class_tb_HDB hdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_HDB
                      (mahdb,ngayban, manv, makh, tongtien) VALUES   (N'" + hdb.MAHDB + "',N'" + hdb.NGAYBAN + "',N'" + hdb.MANV + "',N'" + hdb.MAKH + "',N'" + hdb.TONGTIEN + "')");
        }
        public void Xoa_HDB(Class_tb_HDB hdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_HDB] WHERE [mahdb] = N'" + hdb.MAHDB + "'");
        }

        public void Sua_HDB(Class_tb_HDB hdb)
        {
            string sql = (@"UPDATE tb_HDB
            SET manv =N'" + hdb.MANV + "',ngayban =N'" + hdb.NGAYBAN + "',makh =N'" + hdb.MAKH + "' where  mahdb =N'" + hdb.MAHDB + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load nhân viên
        public void Load_MaNV(ComboBox manv)
        {
            cn.LoadLenCombobox(manv, "SELECT manv FROM tb_Nhanvien", 0);
        }
        public string Load_TenNV(string tennv, string manv)
        {
            tennv = cn.LoadLable("SELECT [tennv] From [tb_Nhanvien] where manv= N'" + manv + "'");
            return tennv;
        }
        //load mã khách hàng
        public void Load_MaKhach(ComboBox makh)
        {
            cn.LoadLenCombobox(makh, "SELECT makh FROM tb_Khachhang", 0);
        }
        public string Load_TenKhachHang(string tenk, string mak)
        {
            tenk = cn.LoadLable("SELECT [tenkh] From [tb_Khachhang] where makh= N'" + mak + "'");
            return tenk;
        }

    }
}
