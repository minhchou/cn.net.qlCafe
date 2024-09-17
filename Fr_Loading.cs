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
    public partial class Fr_Loading : Form
    {
        public Fr_Loading()
        {
            InitializeComponent();
        }
        Connection db = new Connection();

        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }

        private void Fr_Loading_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 634)
            {
                string txtserver = string.Empty, txtdb = string.Empty;
                if (File.Exists("Sinfo.txt"))
                {
                    var lines = File.ReadAllLines("Sinfo.txt");
                    foreach (var line in lines)
                    {
                        if (line.Contains("SV"))
                        {
                            txtserver = line;
                        }
                        if (line.Contains("DB"))
                        {
                            txtdb = line;
                        }
                    }
                    if (!string.IsNullOrEmpty(txtserver) && !string.IsNullOrEmpty(txtdb))
                    {
                        fr_DangNhap fr_login = new fr_DangNhap();
                        fr_login.Show();
                    }
                    else
                    {
                        Form1 fr_connection = new Form1();
                        fr_connection.Show();
                    }
                }
                else
                {
                    Form1 fr_connection = new Form1();
                    fr_connection.Show();
                }
                timer1.Stop();
                this.Hide();
            }
            
            
            
        }

        

        
    }
}
