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
    class Prc_tb_HDN
    {
        SQL_tb_HDN hdnsql = new SQL_tb_HDN();
        public void ThemMoiHDN(Class_tb_HDN hdn)
        {
            if (!hdnsql.kiemtraHDN(hdn.MAHDN))
            {
                hdnsql.ThemMoi_HDN(hdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaHDN(Class_tb_HDN hdn)
        {
            hdnsql.Sua_HDN(hdn);
        }
        public void XoaHDN(Class_tb_HDN hdn)
        {
            hdnsql.Xoa_HDN(hdn);
        }
        //load nv
        public void LoadMaNV(ComboBox cbnv)
        {
            hdnsql.Load_MaNV(cbnv);
        }
        public string LoadTenNV(string Tennv, string Manv)
        {
            Tennv = hdnsql.Load_TenNV(Tennv, Manv);
            return Tennv;
        }
        //load nhà cung cấp
        public void LoadMaNCC(ComboBox cbncc)
        {
            hdnsql.Load_MaNCC(cbncc);
        }
        public string LoadTenNCC(string Tenncc, string Mancc)
        {
            Tenncc = hdnsql.Load_TenNCC(Tenncc, Mancc);
            return Tenncc;
        }
    }
}
