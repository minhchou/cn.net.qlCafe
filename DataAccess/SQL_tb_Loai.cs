using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_Loai
    {
        Connection cn = new Connection();
        public bool KiemTra_Loai(string maloai)
        {
            return cn.kiemtra("select count(*) from [tb_Loai] where maloai=N'" + maloai + "'");
        }
        public void ThemMoi_Loai(Class_tb_Loai Loai)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Loai(maloai, tenloai) VALUES   (N'" + Loai.MALOAI + "',N'" + Loai.TENLOAI + "')");
        }
        public void Xoa_Loai(Class_tb_Loai Loai)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Loai] WHERE [maloai] = N'" + Loai.MALOAI + "'");
        }

        public void Sua_Loai(Class_tb_Loai Loai)
        {
            string sql = (@"UPDATE tb_Loai
            SET tenloai =N'" + Loai.TENLOAI + "' where  maloai =N'" + Loai.MALOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
