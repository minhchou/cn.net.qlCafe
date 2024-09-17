using QL_CAFE.Main.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class SQL_tb_NhanVien
    {
        Connection cn = new Connection();
        // Kiểm tra Nhân Viên
        public bool Kiem_Tra_NhanVien(string manv)
        {
            return cn.kiemtra("SELECT COUNT(*) FROM [tb_Nhanvien] WHERE manv=N'" + manv + "'");
        }
        // Thêm mới Nhân Viên
        public void Them_Moi_NhanVien(Class_tb_NhanVien nv)
        {
            string sql = @"INSERT INTO tb_Nhanvien
                      (manv, tennv, diachi, gioitinh, ngaysinh, maque, sdt)
                        VALUES   (N'" + nv.MANV + "',N'" + nv.TENNV + "',N'" + nv.DIACHI + "',N'" + nv.GIOITINH + "',N'" + nv.NGAYSINH + "',N'" + nv.MAQUE + "',N'" + nv.SDT + "')";
            cn.ExcuteNonQuery(sql);
        }
        // Sửa Nhân Viên
        public void Sua_NhanVien(Class_tb_NhanVien nv)
        {
            string sql = (@"UPDATE    tb_Nhanvien
                    SET tennv =N'" + nv.TENNV + "', gioitinh =N'" + nv.GIOITINH + "', ngaysinh =N'" + nv.NGAYSINH + "', sdt =N'" + nv.SDT + "', diachi =N'" + nv.DIACHI + "',maque =N'" + nv.MAQUE + "'  where manv=N'" + nv.MANV + "'");
            cn.ExcuteNonQuery(sql);
        }
        // Xóa Nhân Viên
        public void Xoa_NhanVien(Class_tb_NhanVien nv)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nhanvien] WHERE manv=N'" + nv.MANV + "'");
        }

        // LOAD MÃ QUÊ
        public void Load_Ma_Que(ComboBox MaQue)
        {
            cn.LoadLenCombobox(MaQue, "SELECT maque FROM tb_Que", 0);// trả về giá trị cột đầu tiên
        }

        public string Load_Ten_Que(string tenq, string maq)
        {
            tenq = cn.LoadLable("SELECT [tenque] From [tb_Que] where maque= N'" + maq + "'");
            return tenq;
        }
        
    }
}
