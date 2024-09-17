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
    class Prc_tb_CTHDN
    {
        SQL_tb_CTHDN cthdnsql = new SQL_tb_CTHDN();
        public void ThemMoiCTHDN(Class_tb_CTHDN cthdn)
        {
            if (!cthdnsql.KiemTra_CTHDN(cthdn.MAHDN, cthdn.MASP))
            {
                cthdnsql.themmoicthdb(cthdn);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaCTHDN(Class_tb_CTHDN cthdn)
        {
            cthdnsql.Sua_CTHDN(cthdn);
        }
        public void XoaCTHDN(Class_tb_CTHDN cthdn)
        {
            cthdnsql.Xoa_CTHDN(cthdn);
        }
        //load hóa đơn
        public void LoadMaHD(ComboBox cbhd)
        {
            cthdnsql.Load_MaHD(cbhd);
        }
        //load hóa đơn
        public void LoadMaSP(ComboBox cbsp)
        {
            cthdnsql.Load_MaSP(cbsp);
        }
        public string LoadTenSP(string Tensp, string Masp)
        {
            Tensp = cthdnsql.Load_TenHang(Tensp, Masp);
            return Tensp;
        }
    }
}
