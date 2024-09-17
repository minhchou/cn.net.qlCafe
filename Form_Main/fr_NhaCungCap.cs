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
    public partial class fr_NhaCungCap : Form
    {
        public fr_NhaCungCap()
        {
            InitializeComponent();
        }

        Prc_tb_NCC thucthi = new Prc_tb_NCC();
        Connection cn = new Connection();
        Class_tb_NCC ck = new Class_tb_NCC();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdt.Text = "";
            txtdc.Text = "";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            msds.Columns[1].Width = 200;
            msds.Columns[2].HeaderText = "Địa Chỉ";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Điện Thoại";
            msds.Columns[3].Width = 200;

        }
        public void hienthi()
        {
            string sql = "SELECT     mancc, tenncc, diachi, sdt FROM tb_NCC";
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

        private void fr_NhaCungCap_Load(object sender, EventArgs e)
        {
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MANCC = txtma.Text;

                    thucthi.Xoa_NhaCungCap(ck);
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

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát cửa sổ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        ck.MANCC = txtma.Text;
                        ck.TENNCC = txtten.Text;
                        ck.DIACHI = txtdc.Text;
                        ck.DIENTHOAI = txtdt.Text;
                        thucthi.ThemMoi_NhaCungCap(ck);
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
                        ck.MANCC = txtma.Text;
                        ck.TENNCC = txtten.Text;
                        ck.DIACHI = txtdc.Text;
                        ck.DIENTHOAI = txtdt.Text;

                        thucthi.Sua_NhaCungCap(ck);
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
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtdc.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtdt.Text = msds.Rows[dong].Cells[3].Value.ToString();
            locktext();
        }


        


    }
}
