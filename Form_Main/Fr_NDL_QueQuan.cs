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
    public partial class Fr_NDL_QueQuan : Form
    {
        public Fr_NDL_QueQuan()
        {
            InitializeComponent();
        }
        Prc_tb_Que thucthi = new Prc_tb_Que();
        Connection cn = new Connection();
        Class_tb_Que ck = new Class_tb_Que();
        bool themmoi;
        int dong = 0;

        // LOAD
        private void Fr_NDL_QueQuan_Load(object sender, EventArgs e)
        {
            locktext();
            hienthi();
            khoitaoluoi();
        }
        //set null 2 thuộc tính
        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
        }
        // locked text and btn
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }

        //unlock text and btn
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }

        //Grid View khởi tạo 
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Quê";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 150;
            msds.Columns[1].HeaderText = "Tên Quê";
            msds.Columns[1].Width = 200;
        }

        //Hàm Hiển Thị
        public void hienthi()
        {
            string sql = "SELECT maque, tenque FROM tb_Que";
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
            finally // giải phóng tài nguyên 
            {
                con.Close();
            }
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }
        // LƯU AND THÊM
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (txtten.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ck.MAQUE = txtma.Text;
                            ck.TENQUE = txtten.Text;
                            thucthi.ThemMoiQueQuan(ck);
                            locktext();
                            hienthi();
                            MessageBox.Show("Đã Lưu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        try
                        {
                            ck.MAQUE = txtma.Text;
                            ck.TENQUE = txtten.Text;
                            thucthi.SuaQueQuan(ck);
                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }
        // XÓA QUÊ QUÁN
        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa đoạn dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAQUE = txtma.Text;

                    thucthi.XoaQueQuan(ck);
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
        
        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            locktext();
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
