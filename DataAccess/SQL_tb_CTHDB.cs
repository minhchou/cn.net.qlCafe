using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_CTHDB
    {
        Connection cn = new Connection();
        public bool KiemTra_CTHDB(string mahdb, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDB] where mahdb=N'" + mahdb + "'and masp=N'" + masp + "'");
        }
        public void ThemMoi_CTHDB(Class_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDB(mahdb, masp, tensp, soluong, thanhtien, khuyenmai) VALUES (N'" + cthdb.MAHDB + "',N'" + cthdb.MASP + "',N'" + cthdb.TENSP + "',N'" + cthdb.SOLUONG + "',N'" + cthdb.THANHTIEN + "',N'" + cthdb.KHUYENMAI + "')");
        }
        public void Xoa_CTHDB(Class_tb_CTHDB cthdb)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDB] WHERE  mahdb=N'" + cthdb.MAHDB + "' and masp=N'" + cthdb.MASP + "' ");
        }

        public void Sua_CTHDB(Class_tb_CTHDB cthdb)
        {
            string sql = (@"UPDATE tb_CTHDB SET soluong =N'" + cthdb.SOLUONG + "', khuyenmai = N'" + cthdb.KHUYENMAI + "', thanhtien = N'" + cthdb.THANHTIEN + "' where  [mahdb]=N'" + cthdb.MAHDB + "' and masp=N'" + cthdb.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void Load_MaSP(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT masp FROM tb_Sanpham", 0);
        }
        public string Load_TenHang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [tensp] From [tb_Sanpham] where masp= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void Load_MaHDB(ComboBox mahdb)
        {
            cn.LoadLenCombobox(mahdb, "SELECT sohdb FROM tb_HDB", 0);
        }
        //load đơn giá bán
        public string Load_DGB(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [giaban] From [tb_Sanpham] where masp= N'" + masp + "'");
            return dg;
        }
    }
}
