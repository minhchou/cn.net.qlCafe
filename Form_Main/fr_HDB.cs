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
    public partial class fr_HDB : Form
    {
        public fr_HDB()
        {
            InitializeComponent();
        }

        Prc_tb_HDB thucthi = new Prc_tb_HDB();
        Connection cn = new Connection();
        Class_tb_HDB ck = new Class_tb_HDB();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtngay.Text = DateTime.Now.ToShortTimeString();
            cbncc.Text = "";
            cbnv.Text = "";
            txttt.Text = "0";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtngay.Enabled = false;
            cbncc.Enabled = false;
            cbnv.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtngay.Enabled = true;
            cbncc.Enabled = true;
            cbnv.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDB";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Nhân Viên";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Ngày Bán";
            msds.Columns[2].Width = 200;
            msds.Columns[3].HeaderText = "Khách Hàng";
            msds.Columns[3].Width = 100;
            msds.Columns[4].HeaderText = "Tổng Tiền";
            msds.Columns[4].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT mahdb,manv,ngayban,makh,tongtien FROM tb_HDB";
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
        private void fr_HDB_Load(object sender, EventArgs e)
        {
            thucthi.LoadMaKH(cbncc);
            thucthi.LoadMaNV(cbnv);
            hienthi();
            khoitaoluoi();
            locktext();
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
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAHDB = txtma.Text;

                    thucthi.XoaHDB(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
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
            cbnv.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[2].Value.ToString();
            cbncc.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnv.Text = thucthi.LoadTenNV(lbnv.Text, cbnv.Text);
        }

        private void cbncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbncc.Text = thucthi.LoadTenKH(lbncc.Text, cbncc.Text);
        }

        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            fr_ChiTietHDB fr = new fr_ChiTietHDB();
            fr.SOHDB = msds.Rows[dong].Cells[0].Value.ToString();
            this.Close();
            fr.Show();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbnv.Text != "")
                {
                    if (cbncc.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                ck.MAHDB = txtma.Text;
                                ck.MANV = cbnv.Text;
                                ck.NGAYBAN = txtngay.Text;
                                ck.MAKH = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.ThemMoiHDB(ck);
                                locktext();
                                hienthi();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_ChiTietHDB fr = new fr_ChiTietHDB();
                                fr.SOHDB = txtma.Text;
                                this.Close();
                                fr.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                ck.MAHDB = txtma.Text;
                                ck.MANV = cbnv.Text;
                                ck.NGAYBAN = txtngay.Text;
                                ck.MAKH = cbncc.Text;
                                ck.TONGTIEN = txttt.Text;

                                thucthi.SuaHDB(ck);
                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fr_ChiTietHDB fr = new fr_ChiTietHDB();
                                fr.SOHDB = txtma.Text;
                                this.Close();
                                fr.Show();
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
                        MessageBox.Show("Mã Nhà Cung Cấp Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        cbncc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbnv.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã HDB Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        


    }
}
