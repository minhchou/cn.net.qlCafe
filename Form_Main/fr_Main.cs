using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.Form_Main
{
    public partial class fr_Main : Form
    {
        public fr_Main()
        {
            InitializeComponent();
        }
        // Kiểm tra Form tồn tại 
        private Form Check_Exsist_Fr(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }
        // FORM NHẬP DỮ LIỆU NHÂN VIÊN
        private void NhanVien_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_NDL_NhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NDL_NhanVien fr = new fr_NDL_NhanVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        // FORM NHẬP DỮ LIỆU QUÊ QUÁN
        private void QueQuan_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(Fr_NDL_QueQuan));
            if (frm != null)
                frm.Activate();
            else
            {
                Fr_NDL_QueQuan fr = new Fr_NDL_QueQuan();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        // BACK TO FORM ĐĂNG NHẬP
        private void DangNhap_Click(object sender, EventArgs e)
        {
            fr_DangNhap fr = new fr_DangNhap();
            this.Hide();
            fr.Show();
        }

        private void KhachHang_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_KhachHang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_KhachHang fr = new fr_KhachHang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void NhaCungCap_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_NhaCungCap));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NhaCungCap fr = new fr_NhaCungCap();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void LoaiToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_NDL_Loai));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NDL_Loai fr = new fr_NDL_Loai();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void CongDung_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_CongDung));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_CongDung fr = new fr_CongDung();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void ChiTietCafe_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_NDL_SanPham));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NDL_SanPham fr = new fr_NDL_SanPham();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void NhapHang_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDN fr = new fr_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void XuatHang_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDB fr = new fr_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void TimKiem_HoaDon_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_TK_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_HDB fr = new fr_TK_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void TimKiem_SanPham_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_TK_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_SP fr = new fr_TK_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void ThongKe_HoaDon_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_ThongKe_HoaDonBan));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_ThongKe_HoaDonBan fr = new fr_ThongKe_HoaDonBan();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void ThongKe_KhachHang_ToolStrip_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_ThongKe_KH));
            if (frm != null)
                frm.Activate();
            else
            {
				fr_ThongKe_KH fr = new fr_ThongKe_KH();
                fr.MdiParent = this;
                fr.Show();
            }
        }


        private void helpsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_Help));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Help fr = new fr_Help();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void ThongKe_SanPham_Click(object sender, EventArgs e)
        {
            Form frm = Check_Exsist_Fr(typeof(fr_ThongKe_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_ThongKe_SP fr = new fr_ThongKe_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void fr_Main_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_ToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

		
	}
}
