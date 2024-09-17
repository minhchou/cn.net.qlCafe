using QL_CAFE.DataAccess;
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
    public partial class fr_TK_HDB : Form
    {
        public fr_TK_HDB()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Hóa Đơn Bán";
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
            string sql = "SELECT mahdb,manv ,ngayban, makh,tongtien FROM tb_HDB";
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
        private void fr_TK_HDB_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT distinct tb_HDB.mahdb,tb_HDB.manv, tb_HDB.ngayban ,tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT distinct tb_HDB.mahdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb 
                               WHERE tb_HDB.mahdb= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            // bug
            if (op2.Checked)
            {
                string sql = @"SELECT distinct tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb 
                               WHERE tb_HDB.ngayban = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT tb_HDB.mahdb, tb_HDB.ngayban, tb_HDB.manv, tb_HDB.makh, tb_HDB.tongtien 
                               FROM tb_HDB 
                               INNER JOIN tb_CTHDB ON tb_HDB.mahdb = tb_CTHDB.mahdb 
                               WHERE tb_HDB.manv = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
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

        private void op2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtthongtin.Text = "";
            op1.Checked = false;
            op2.Checked = false;
            op3.Checked = false;
            hienthi();
            khoitaoluoi();

        }
    }
}
