using QL_CAFE.DataAccess;
using QL_CAFE.Main.Class;
using QL_CAFE.Main.Process;
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

namespace QL_CAFE.Form_Main
{
    public partial class fr_NDL_SanPham : Form
    {
        public fr_NDL_SanPham()
        {
            InitializeComponent();
        }

        Prc_tb_SanPham thucthi = new Prc_tb_SanPham();
        Connection cn = new Connection();
        Class_tb_SanPham ck = new Class_tb_SanPham();
        bool themmoi;
        int dong = 0;

        private byte[] hinhanh;
        public byte[] HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }


        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtsl.Text = "0";
            txtngay.Text = "";
            
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtngay.Enabled = false;
            txtdgn.Enabled = false;
            txtdgb.Enabled = false;
            txtsl.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtngay.Enabled = true;
            txtdgn.Enabled = true;
            txtdgb.Enabled = true;
            txtsl.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Sản Phẩm";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Sản Phẩm";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Loại";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Giá Nhập";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Giá Bán";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "số Lượng";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Công Dụng";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Ảnh";
            msds.Columns[7].Width = 200;


        }
        public void hienthi()
        {
            string sql = "SELECT masp, tensp, maloai, gianhap, giaban, soluong, macongdung, hinhanh FROM tb_Sanpham";
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

        byte[] ReadFile(string sPath)
        {

            byte[] data = null;

            //sử dụng FileInfo để lấy kích thước file.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Đọc file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Sử dụng BinaryReader để đọc file vào mảng byte.
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
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
                    ck.MASP = txtma.Text;

                    thucthi.XoaSP(ck);
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

        private void fr_NDL_SanPham_Load(object sender, EventArgs e)
        {
            imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                //Get image data from gridview column.
                byte[] imageData = hinhanh;

                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                imghinhanh.Image = newImage;
            }
            catch
            {

            }
            thucthi.Load_MLoai(cbloai);
            thucthi.Load_MaCD(cbcd);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbloai.Text = msds.Rows[dong].Cells[2].Value.ToString();

            txtdgn.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[5].Value.ToString();
            cbcd.Text = msds.Rows[dong].Cells[6].Value.ToString();
            lbimgpath.Text = msds.Rows[dong].Cells[7].Value.ToString();
            //Image img = Image.FromFile(lbimgpath.Text);
            //load_pic.Image = img;
            locktext();
        }

        private void ThemHinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Filter = "Image File (*.jpg;*.jpeg;*.bmp;*.gif;*.png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
                dlg.Title = "Chọn Hình";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    //Gán hình vào Picture box
                    imghinhanh.ImageLocation = dlg.FileName;
                    imghinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Gán đường dẫn ảnh vào lbimgpath
                    lbimgpath.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl.Text = thucthi.Load_TLoai(lbl.Text, cbloai.Text);
        }

        private void cbcd_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbcd.Text = thucthi.Load_TenCD(lbcd.Text, cbcd.Text);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbloai.Text != "")
                {
                    if (cbcd.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                byte[] imageData = ReadFile(lbimgpath.Text);
                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MALOAI = cbloai.Text;
                                ck.GIABAN = txtdgb.Text;
                                ck.GIANHAP = txtdgn.Text;
                                ck.SOLUONG = txtsl.Text;
                                ck.MACONGDUNG = cbcd.Text;
                                ck.HINHANH = imageData;

                                thucthi.ThemSP(ck);
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
                                byte[] imageData = ReadFile(lbimgpath.Text);
                                ck.MASP = txtma.Text;
                                ck.TENSP = txtten.Text;
                                ck.MALOAI = cbloai.Text;
                                ck.GIABAN = txtdgb.Text;
                                ck.GIANHAP = txtdgn.Text;
                                ck.SOLUONG = txtsl.Text;
                                ck.MACONGDUNG = cbcd.Text;
                                ck.HINHANH = imageData;

                                thucthi.SuaSP(ck);
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
                        MessageBox.Show("Mã Công Dụng Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        cbcd.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Loại Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbloai.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Sản Phẩm Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát cửa sổ", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
            }
        }






    }
}
