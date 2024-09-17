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
    class Prc_tb_SanPham
    {
        SQL_tb_SanPham spsql = new SQL_tb_SanPham();
        public void ThemSP(Class_tb_SanPham sp)
        {
            if (!spsql.Equals(sp.MASP))
            {
                spsql.ThemMoi_SanPham(sp);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void SuaSP(Class_tb_SanPham sp)
        {
            spsql.Sua_SanPham(sp);
        }
        public void XoaSP(Class_tb_SanPham sp)
        {
            spsql.Xoa_SanPham(sp);
        }

        //load LOẠI
        public void Load_MLoai(ComboBox cbl)
        {
            spsql.Load_MaLoai(cbl);
        }
        //TÊN LOẠI
        public string Load_TLoai(string Tenloai, string Maloai)
        {
            Tenloai = spsql.Load_TenLoai(Tenloai, Maloai);
            return Tenloai;
        }

        // LOAD MÃ VÀ TÊN CÔNG DỤNG 
        public void Load_MaCD(ComboBox cbcd)
        {
            spsql.Load_CongDung(cbcd);
        }
        public string Load_TenCD(string Tencd, string Macd)
        {
            Tencd = spsql.Load_TenCongDung(Tencd, Macd);
            return Tencd;
        }
    }
}
