using QL_CAFE.DataAccess;
using QL_CAFE.Form_Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Connection db = new Connection();
        public string Server { get; set; }
        private void cmddn_Click(object sender, EventArgs e)
        { 
            try
            {
                if (File.Exists("Sinfo.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("Sinfo.txt"))
                    {
                        writer.WriteLine("SV=:" + txtserver.Text);
                        writer.WriteLine("DB=:" + txtdb.Text);
                    }
                    MessageBox.Show("Đã Thiết Lập xong", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter("Sinfo.txt"))
                    {
                        writer.WriteLine("SV=:" + txtserver.Text);
                        writer.WriteLine("DB=:" + txtdb.Text);
                    }
                    MessageBox.Show("Đã Thiết Lập xong", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                MessageBox.Show("Kết Nối Thành Công Tới Sever " + txtserver.Text + ". Vui lòng đợi giây lát để chuyển sang Tab tiếp theo. Cảm ơn", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fr_DangNhap fr_log = new fr_DangNhap();
                this.Hide();
                fr_log.Show();
            }
            catch
            {
                MessageBox.Show("Không thiết lập được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Sinfo.txt"))
            {
                var lines = File.ReadAllLines("Sinfo.txt");
                foreach (var line in lines)
                {
                    if (line.Contains("SV"))
                    {
                        txtserver.Text = line; 
                    }
                    if (line.Contains("DB"))
                    {
                        txtdb.Text = line;
                    }
                }
                if (!string.IsNullOrEmpty(txtserver.Text) && !string.IsNullOrEmpty(txtdb.Text))
                {
                    fr_DangNhap fr_log = new fr_DangNhap();
                    this.Hide();
                    fr_log.Show();
                }
            } 
        }
    }
}
