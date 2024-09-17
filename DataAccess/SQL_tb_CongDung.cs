using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_CongDung
    {
        Connection cn = new Connection();
        public bool KiemTra_CongDung(string macongdung)
        {
            return cn.kiemtra("select count(*) from [tb_Congdung] where macongdung=N'" + macongdung + "'");
        }
        public void ThemMoi_CongDung(Class_tb_CongDung cd)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Congdung(macongdung, tencongdung) VALUES(N'" + cd.MACONGDUNG + "',N'" + cd.TENCONGDUNG + "')");
        }
        public void Xoa_CongDung(Class_tb_CongDung cd)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Congdung] WHERE [macongdung] = N'" + cd.MACONGDUNG + "'");
        }

        public void Sua_CongDung(Class_tb_CongDung cd)
        {
            string sql = (@"UPDATE tb_Congdung SET tencongdung =N'" + cd.MACONGDUNG + "' where  macongdung =N'" + cd.TENCONGDUNG + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
