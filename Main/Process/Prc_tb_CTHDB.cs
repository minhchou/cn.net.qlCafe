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
    class Prc_tb_CTHDB
    {
        SQL_tb_CTHDB SQL_CTHDB = new SQL_tb_CTHDB();
        public void ThemMoiCTHDB(Class_tb_CTHDB cthdb)
        {
            if (!SQL_CTHDB.KiemTra_CTHDB(cthdb.MAHDB, cthdb.MASP))
            {
                SQL_CTHDB.ThemMoi_CTHDB(cthdb);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaCTHDB(Class_tb_CTHDB cthdb)
        {
            SQL_CTHDB.Sua_CTHDB(cthdb);
        }
        public void XoaCTHDB(Class_tb_CTHDB cthdb)
        {
            SQL_CTHDB.Xoa_CTHDB(cthdb);
        }
        //load hóa đơn
        public void LoadMaHD(ComboBox cbhd)
        {
            SQL_CTHDB.Load_MaHDB(cbhd);
        }
        //load hóa đơn
        public void LoadMaSP(ComboBox cbsp)
        {
            SQL_CTHDB.Load_MaSP(cbsp);
        }
        public string LoadTenSP(string Tensp, string Masp)
        {
            Tensp = SQL_CTHDB.Load_TenHang(Tensp, Masp);
            return Tensp;
        }

        public string LoadDG(string dg, string Masp)
        {
            dg = SQL_CTHDB.Load_DGB(dg, Masp);
            return dg;
        }
    }
}
