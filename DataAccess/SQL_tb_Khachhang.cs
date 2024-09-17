using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_Khachhang
    {
        Connection cn = new Connection();
        public bool Checked_TenKhachHang(string tenkh)
        {
            return cn.kiemtra("select count(*) from [tb_Khachhang] where tenkh=N'" + tenkh + "'");
        }
        public void Them_KhachHang(Class_tb_Khachhang kh)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Khachhang(makh, tenkh) VALUES   (N'" + kh.MAKH + "',N'" + kh.TENKH + "')");
        }
        public void Xoa_KhachHang(Class_tb_Khachhang kh)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Khachhang] WHERE [makh] = N'" + kh.MAKH + "'");
        }

        public void Sua_KhachHang(Class_tb_Khachhang kh)
        {
            string sql = (@"UPDATE tb_Khachhang SET tenkh =N'" + kh.TENKH + "' where  makh =N'" + kh.MAKH + "'");
            cn.ExcuteNonQuery(sql);
        }

    }
}
