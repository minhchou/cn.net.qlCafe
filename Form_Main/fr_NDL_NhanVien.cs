using QL_CAFE.DataAccess;
using QL_CAFE.Main.Class;
using QL_CAFE.Main.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.Form_Main
{
    public partial class fr_NDL_NhanVien : Form
    {
        public fr_NDL_NhanVien()
        {
            InitializeComponent();
        }
        // Khởi tạo biến cần thiết 
        Prc_tb_NhanVien thucthi = new Prc_tb_NhanVien();
        Connection cn = new Connection();
        Class_tb_NhanVien ck = new Class_tb_NhanVien();

        bool themmoi;// check true false 
        int dong = 0;


        private void fr_NDL_NhanVien_Load(object sender, EventArgs e)
        {
            thucthi.loadmaque(cbmaque);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        // HÀM SET TẤT CẢ NULL
        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            cbgt.Text = "Nam";
            txtngaysinh.Text = DateTime.Now.ToShortTimeString();
            txtdt.Text = "";
            txtdc.Text = "";
            cbmaque.Text = "";
        }
        // Hàm Locked Text 
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            cbgt.Enabled = false;
            txtngaysinh.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;
            cbmaque.Enabled = false;
            // Button
            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        // Hàm Unlocked Text 
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            cbgt.Enabled = true;
            txtngaysinh.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            cbmaque.Enabled = true;
            // Button
            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            // Căn giữa
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Nhân Viên";
            msds.Columns[0].Frozen = true; // cố định cột đầu tiên
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;
            msds.Columns[1].HeaderText = "Tên Nhân Viên";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Giới Tính";
            msds.Columns[3].Width = 200;
            msds.Columns[4].HeaderText = "Ngày Sinh";
            msds.Columns[4].Width = 200;
            msds.Columns[5].HeaderText = "Mã Quê";
            msds.Columns[5].Width = 200;
            msds.Columns[6].HeaderText = "SĐT";
            msds.Columns[6].Width = 200;
        }
        
        //    Tất cả các văn bản trong cột tiêu đề được căn giữa.
        //   Cột đầu tiên có tiêu đề là "Mã Nhân Viên".
        //   Cột đầu tiên được cố định.
        //  Văn bản trong cột đầu tiên được căn giữa.
        
        // Hiển thị  lên GridView
        public void hienthi()
        {
            string sql = "SELECT manv, tennv, diachi, gioitinh, ngaysinh, maque, sdt FROM tb_Nhanvien";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        // THÊM MỚI NHÂN VIÊN
        private void btmoi_Click_1(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }
        // SỬA NHÂN VIÊN
        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }
        // XÓA NHÂN VIÊN
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MANV = txtma.Text;

                    thucthi.xoanv(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
        // LƯU THÔNG TIN
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbmaque.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ck.MANV = txtma.Text;
                            ck.TENNV = txtten.Text;
                            ck.GIOITINH = cbgt.Text;
                            ck.NGAYSINH = txtngaysinh.Text;
                            ck.SDT = txtdt.Text;
                            ck.DIACHI = txtdc.Text;
                            ck.MAQUE = cbmaque.Text;

                            thucthi.themmoinv(ck);
                            locktext();
                            hienthi();
                            MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        try
                        {
                            ck.MANV = txtma.Text;
                            ck.TENNV = txtten.Text;
                            ck.GIOITINH = cbgt.Text;
                            ck.NGAYSINH = txtngaysinh.Text;
                            ck.SDT = txtdt.Text;
                            ck.DIACHI = txtdc.Text;
                            ck.MAQUE = cbmaque.Text;

                            thucthi.suanv(ck);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    txtma.Enabled = true;
                    locktext();
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Mã Quê Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbmaque.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbgt.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtngaysinh.Text = msds.Rows[dong].Cells[4].Value.ToString();
            cbmaque.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtdt.Text = msds.Rows[dong].Cells[6].Value.ToString();
            locktext();
        }

        private void cbmaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbtenque.Text = thucthi.loadtenque(lbtenque.Text, cbmaque.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát cửa sổ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }

        

        

        

        

    }
}
