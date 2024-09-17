using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CAFE.DataAccess
{
    class Connection
    {
        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }
        public string Database { get; set; }

        public Connection()
        {
            
            try
            {
                StreamReader read = new StreamReader("Sinfo.txt");
                while (!read.EndOfStream)
                {
                    
                    this.Server = (read.ReadLine().Split(':')[1]);
                    this.Database = (read.ReadLine().Split(':')[1]);
                }
                read.Close();
            }
            catch
            {

            }
        }
        
        //Data Source=DESKTOP-637MHOH\SQLSEVER;Initial Catalog=QL_Quancaphe;Integrated Security=True
        public SqlConnection getcon()
        {
            //return new SqlConnection(strCon);
            return new SqlConnection("Data Source=" + this.Server + ";Initial Catalog =" + this.Database + "; Integrated Security=SSPI;");
        }
        
        // tạo data table
        public DataTable taobang(string sql)
        {
            con = getcon();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        // kiểm tra đăng nhập
        public bool KiemtraUsername(string strsql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(strsql, con);
            int tontai = (int)(sqlcom.ExecuteScalar());
            con.Close();
            if (tontai > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // hàm trả về row từ đó đem đi check các điều kiện hoặc đặt cờ flag 
        public void ExcuteNonQuery(string sql)
        {
            con = getcon();
            sqlcom = new SqlCommand(sql, con);
            con.Open();
            sqlcom.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

        // hàm kiểm tra truyền theo chuỗi SQL đã set connection trước đó
        // n > 0 true = có ; n <= 0 False = haven't
        public bool kiemtra(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Load combo_box tách riêng 
        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(SQL, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            con.Close();
        }

        // LOAD CÁC LABLE lên cho đồng bộ
        public string LoadLable(string sql)
        {
            string ketqua = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            con.Close();
            return ketqua;
        }
        
    }
}
