﻿using QL_CAFE.DataAccess;
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
using COMExcel = Microsoft.Office.Interop.Excel;
namespace QL_CAFE.Form_Main
{
    public partial class fr_ChiTietHDB : Form
    {
        public fr_ChiTietHDB()
        {
            InitializeComponent();
        }

        Prc_tb_CTHDB thucthi = new Prc_tb_CTHDB();
        Connection cn = new Connection();
        Class_tb_CTHDB ck = new Class_tb_CTHDB();
        bool themmoi;
        int dong = 0;

        private string sohdb;
        public string SOHDB
        {
            get
            {
                return sohdb;
            }
            set
            {
                sohdb = value;
            }
        }
        public void setnull()
        {
            txtsl.Text = "0";
            txtdg.Text = "0";
            txtgg.Text = "0";
            txttt.Text = "0";
            cbhang.Text = "";
        }
        public void locktext()
        {
            txtsl.Enabled = false;
            txtgg.Enabled = false;
            cbhang.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtsl.Enabled = true;
            txtgg.Enabled = true;
            cbhang.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDN";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;
            msds.Columns[1].HeaderText = "Mã Sản Phẩm";
            msds.Columns[1].Width = 100;
            msds.Columns[2].HeaderText = "Số Lượng";
            msds.Columns[2].Width = 80;
            msds.Columns[3].HeaderText = "Khuyến Mãi";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Thành Tiền";
            msds.Columns[4].Width = 80;
        }
        public void hienthi()
        {
            string sql = "SELECT mahdb, masp, soluong, khuyenmai, thanhtien FROM tb_CTHDB";
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

        private void fr_ChiTietHDB_Load(object sender, EventArgs e)
        {
            cbhd.Text = sohdb;
            thucthi.LoadMaSP(cbhang);
            hienthi();
            khoitaoluoi();
            locktext();
        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            string sql = "SELECT mahdb, masp, soluong, khuyenmai, thanhtien FROM tb_CTHDB where mahdb='" + sohdb + "'";
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

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAHDB = cbhd.Text;
                    ck.MASP = cbhang.Text;

                    thucthi.XoaCTHDB(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }



        private void btluu_Click(object sender, EventArgs e)
        {
            if (cbhang.Text != "")
            {
                if (themmoi == true)
                {
                    try
                    {
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);

                        ck.MAHDB = cbhd.Text;
                        ck.MASP = cbhang.Text;
                        ck.KHUYENMAI = txtgg.Text;
                        ck.THANHTIEN = tt.ToString();
                        ck.SOLUONG = txtsl.Text;

                        thucthi.ThemMoiCTHDB(ck);
                        XuatHoaDon.Focus();
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
                        // tổng tiền
                        float tt = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                        ck.MAHDB = cbhd.Text;
                        ck.MASP = cbhang.Text;
                        ck.KHUYENMAI = txtgg.Text;
                        ck.THANHTIEN = tt.ToString();
                        ck.SOLUONG = txtsl.Text;

                        thucthi.SuaCTHDB(ck);
                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                // convert giá nhập trên bảng trước
                float gn = float.Parse(txtdg.Text);
                // tính giá bán 
                float gb = (gn * 110) / 100;
                //update lại số lượng trong bảng sản phẩm trừ lại số lượng kho
                string upsl = "UPDATE tb_Sanpham SET soluong =soluong - '" + txtsl.Text + "' where masp='" + cbhang.Text + "'";
                //update lại tổng tiền
                string uptt = "update tb_HDB set tongtien=(SELECT sum(thanhtien) FROM tb_CTHDB) where mahdb='" + cbhd.Text + "'";
                cn.ExcuteNonQuery(uptt);
                cn.ExcuteNonQuery(upsl);
                locktext();
                hienthi();
                //tổng tiền txt
                float t1 = (float.Parse(txtsl.Text) * float.Parse(txtdg.Text)) - float.Parse(txtgg.Text);
                txttt.Text = t1.ToString();
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cbhang.Focus();
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            cbhd.Text = msds.Rows[dong].Cells[0].Value.ToString();
            cbhang.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtgg.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txttt.Text = msds.Rows[dong].Cells[4].Value.ToString();
            locktext();
        }

        private void btquaylai_Click(object sender, EventArgs e)
        {
            fr_HDB fr = new fr_HDB();
            this.Close();
            fr.Show();
        }

        private void cbhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbhang.Text = thucthi.LoadTenSP(lbhang.Text, cbhang.Text);
            txtdg.Text = thucthi.LoadDG(txttt.Text, cbhang.Text);
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void XuatHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            string sql_tongtien;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang, tblTongTien;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Việt Nam";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0374852925";

            exRange.Range["C1:E1"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C1:E1"].MergeCells = true;
            exRange.Range["C1:E1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C1:E1"].Value = "Cafe Phúc Cường Thịnh";
            exRange.Range["C1:E1"].Font.Bold = true;

            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = @"SELECT tb_HDB.mahdb,  tb_Khachhang.tenkh,
                      tb_HDB.ngayban,tb_Nhanvien.tennv
                      FROM  tb_CTHDB INNER JOIN
                      tb_HDB ON tb_CTHDB.mahdb = tb_HDB.mahdb INNER JOIN
                      tb_Khachhang ON tb_HDB.makh = tb_Khachhang.makh INNER JOIN
                      tb_Nhanvien ON tb_HDB.manv = tb_Nhanvien.manv where tb_HDB.mahdb='" + cbhd.Text + "'";
            tblThongtinHD = cn.taobang(sql);
            //tblThongtinHD = cn.taobang(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;

            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;

            //Lấy thông tin các mặt hàng
            sql = @"SELECT tb_Sanpham.tensp, tb_CTHDB.soluong, tb_Sanpham.giaban, tb_CTHDB.khuyenmai, tb_CTHDB.thanhtien 
                    FROM tb_CTHDB 
                    INNER JOIN tb_Sanpham ON tb_CTHDB.masp = tb_Sanpham.masp 
                    where tb_CTHDB.mahdb='" + cbhd.Text + "'";
            tblThongtinHang = cn.taobang(sql);

            sql_tongtien = @"SELECT sum(thanhtien) 
                            FROM tb_CTHDB 
                            where mahdb= '" + cbhd.Text + "'";
            tblTongTien = cn.taobang(sql_tongtien);

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            int tongtien = 0;
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                
            }
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Tổng tiền là: " + tblTongTien.Rows[0][0].ToString();
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][2]);
            exRange.Range["A1:C1"].Value = "Hồ Chí Minh, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][3];
            exSheet.Name = "Hóa Đơn Bán";
            exApp.Visible = true;
        }


        



    }
}
