using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_SanPham
    {
        Connection cn = new Connection();
        public bool kiemtraHang(string mahang)
        {
            return cn.kiemtra("select count(*) from [tb_Sanpham] where masp=N'" + mahang + "'");
        }
        public void ThemMoi_SanPham(Class_tb_SanPham sanpham)
        {
            SqlConnection con = cn.getcon();
            try
            {

                con.Open();
                string sql = @"INSERT INTO tb_Sanpham(masp, tensp, maloai, gianhap, giaban, soluong, macongdung, hinhanh) VALUES (N'" + sanpham.MASP + "',N'" + sanpham.TENSP + "',N'" + sanpham.MALOAI + "',N'" + sanpham.GIANHAP + "',N'" + sanpham.GIABAN + "',N'" + sanpham.SOLUONG + "',N'" + sanpham.MACONGDUNG + "',@hinhanh)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)sanpham.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void Xoa_SanPham(Class_tb_SanPham sanpham)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Sanpham] WHERE  masp=N'" + sanpham.MASP + "'");
        }

        public void Sua_SanPham(Class_tb_SanPham sanpham)
        {
            SqlConnection con = cn.getcon();
            try
            {
                con.Open();
                string sql = @"UPDATE tb_Sanpham SET tensp =N'" + sanpham.TENSP + "', maloai =N'" + sanpham.MALOAI + "', giaban =N'" + sanpham.GIABAN + "', soluong =N'" + sanpham.SOLUONG + "', macongdung =N'" + sanpham.MACONGDUNG + "',hinhanh =@hinhanh where masp=N'" + sanpham.MASP + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@hinhanh", (object)sanpham.HINHANH));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //load loại
        public void Load_MaLoai(ComboBox maloai)
        {
            cn.LoadLenCombobox(maloai, "SELECT maloai FROM tb_Loai", 0);
        }
        public string Load_TenLoai(string tenloai, string maloai)
        {
            tenloai = cn.LoadLable("SELECT [tenloai] From [tb_Loai] where maloai= N'" + maloai + "'");
            return tenloai;
        }
        //load công dụng
        public void Load_CongDung(ComboBox macd)
        {
            cn.LoadLenCombobox(macd, "SELECT macongdung FROM tb_Congdung", 0);
        }
        public string Load_TenCongDung(string tenm, string mam)
        {
            tenm = cn.LoadLable("SELECT [tencongdung] From [tb_Congdung] where macongdung= N'" + mam + "'");
            return tenm;
        }

    }
}
