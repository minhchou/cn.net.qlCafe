using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_User
    {
        Connection cn = new Connection();

        // kiểm ra user name và pass khi đăng nhập
        public bool Kiemtrauser(Class_tb_User user)
        {
            string sql = "select count(*) from tb_User where Username ='" + user.USERNAME + "' and Password = '" + user.PASSWORD + "'";
            return cn.KiemtraUsername(sql);
        }
    }
}
