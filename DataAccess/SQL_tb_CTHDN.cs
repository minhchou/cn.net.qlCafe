using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_CTHDN
    {
        Connection cn = new Connection();
        public bool KiemTra_CTHDN(string mahdn, string masp)
        {
            return cn.kiemtra("select count(*) from [tb_CTHDN] where mahdn=N'" + mahdn + "'and masp=N'" + masp + "'");
        }
        public void themmoicthdb(Class_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_CTHDN(mahdn, masp, soluong, dongia, thanhtien, khuyenmai) VALUES   (N'" + cthdn.MAHDN + "',N'" + cthdn.MASP + "',N'" + cthdn.SOLUONG + "',N'" + cthdn.DONGIA + "',N'" + cthdn.THANHTIEN + "',N'" + cthdn.KHUYENMAI + "')");
        }
        public void Xoa_CTHDN(Class_tb_CTHDN cthdn)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_CTHDN] WHERE  mahdn=N'" + cthdn.MAHDN + "' and masp=N'" + cthdn.MASP + "' ");
        }

        public void Sua_CTHDN(Class_tb_CTHDN cthdn)
        {
            string sql = (@"UPDATE tb_CTHDN SET soluong =N'" + cthdn.SOLUONG + "', khuyenmai = N'" + cthdn.KHUYENMAI + "', thanhtien = N'" + cthdn.THANHTIEN + "' where  mhdb=N'" + cthdn.MAHDN + "' and masp=N'" + cthdn.MASP + "'");
            cn.ExcuteNonQuery(sql);
        }
        //load sp
        public void Load_MaSP(ComboBox masp)
        {
            cn.LoadLenCombobox(masp, "SELECT masp FROM tb_Sanpham", 0);
        }
        public string Load_TenHang(string tenhang, string masp)
        {
            tenhang = cn.LoadLable("SELECT [masp] From [tb_Sanpham] where masp= N'" + masp + "'");
            return tenhang;
        }
        //load THD
        public void Load_MaHD(ComboBox mahdn)
        {
            cn.LoadLenCombobox(mahdn, "SELECT mahdn FROM tb_HDN", 0);
        }
        //load đơn giá bán
        public string Load_DGB(string dg, string masp)
        {
            dg = cn.LoadLable("SELECT [gianhap] From [tb_Sanpham] where masp= N'" + masp + "'");
            return dg;
        }
    }
}
