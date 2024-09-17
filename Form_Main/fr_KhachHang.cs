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
    public partial class fr_KhachHang : Form
    {
        public fr_KhachHang()
        {
            InitializeComponent();
        }
        Prc_tb_Khachhang thucthi = new Prc_tb_Khachhang();
        Connection cn = new Connection();
        Class_tb_Khachhang ck = new Class_tb_Khachhang();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
        }
        public void Locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            //button
            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void Unlocktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            //button
            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        //GRID VIEW
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã KH";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên KH";
            msds.Columns[1].Width = 200;
        }

        public void hienthi()
        {
            string sql = "SELECT     makh, tenkh  FROM tb_Khachhang";
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
        private void fr_KhachHang_Load(object sender, EventArgs e)
        {
            Locktext();
            hienthi();
            khoitaoluoi();
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            Unlocktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Unlocktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAKH = txtma.Text;

                    thucthi.xoakh(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }

        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            Locktext();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if(txtten.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ck.MAKH = txtma.Text;
                            ck.TENKH = txtten.Text;

                            thucthi.themmoikh(ck);
                            Locktext();
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
                            ck.MAKH = txtma.Text;
                            ck.TENKH = txtten.Text;

                            thucthi.suakh(ck);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    txtma.Enabled = true;
                    Locktext();
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Tên Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtten.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
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
