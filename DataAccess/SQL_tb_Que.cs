using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_Que
    {
        Connection cn = new Connection();
        public bool KiemTraMaQueQuan(string maque)
        {
            return cn.kiemtra("select count(*) from [tb_que] where tenque=N'" + maque + "'");
        }
        public void ThemMoiQueQuan(Class_tb_Que quequan)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Que
                      (maque, tenque) VALUES   (N'" + quequan.MAQUE + "',N'" + quequan.TENQUE + "')");
        }
        public void Xoa_QueQuan(Class_tb_Que quequan)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_que] WHERE [maque] = N'" + quequan.MAQUE + "'");
        }

        public void Sua_QueQuan(Class_tb_Que quequan)
        {
            string sql = (@"UPDATE tb_Que SET tenque =N'" + quequan.TENQUE + "' where  maque =N'" + quequan.MAQUE + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
