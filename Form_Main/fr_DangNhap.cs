using QL_CAFE.DataAccess;
using QL_CAFE.Main.Class;
using QL_CAFE.Main.Process;
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
    public partial class fr_DangNhap : Form
    {
        public fr_DangNhap()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        Prc_tb_User thucthi = new Prc_tb_User(); 
        Class_tb_User ck = new Class_tb_User();

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát Chương Trình", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
        // click Login then CHECKED USER AND 
        private void cmddn_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            try
            {
                ck.USERNAME = user;
                ck.PASSWORD = pass;
                if (!thucthi.kiemtrauser(user, pass))
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fr_Main fr = new fr_Main();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fr_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
