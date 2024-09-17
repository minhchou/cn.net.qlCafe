namespace QL_CAFE.Form_Main
{
    partial class fr_NDL_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_NDL_SanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.XoaHinh = new System.Windows.Forms.Button();
            this.ThemHinh = new System.Windows.Forms.Button();
            this.imghinhanh = new System.Windows.Forms.PictureBox();
            this.cbcd = new System.Windows.Forms.ComboBox();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdgb = new System.Windows.Forms.TextBox();
            this.txtdgn = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbimgpath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.msds = new System.Windows.Forms.DataGridView();
            this.load_pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imghinhanh)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 50);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(272, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.load_pic);
            this.panel2.Controls.Add(this.txtngay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.XoaHinh);
            this.panel2.Controls.Add(this.ThemHinh);
            this.panel2.Controls.Add(this.imghinhanh);
            this.panel2.Controls.Add(this.cbcd);
            this.panel2.Controls.Add(this.cbloai);
            this.panel2.Controls.Add(this.txtsl);
            this.panel2.Controls.Add(this.txtdgb);
            this.panel2.Controls.Add(this.txtdgn);
            this.panel2.Controls.Add(this.txtten);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbcd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.lbimgpath);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 443);
            this.panel2.TabIndex = 14;
            // 
            // txtngay
            // 
            this.txtngay.CustomFormat = "dd/MM/yyyy";
            this.txtngay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(119, 259);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(236, 27);
            this.txtngay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Đăng";
            // 
            // XoaHinh
            // 
            this.XoaHinh.Location = new System.Drawing.Point(297, 374);
            this.XoaHinh.Name = "XoaHinh";
            this.XoaHinh.Size = new System.Drawing.Size(78, 30);
            this.XoaHinh.TabIndex = 9;
            this.XoaHinh.Text = "Xóa Hình";
            this.XoaHinh.UseVisualStyleBackColor = true;
            // 
            // ThemHinh
            // 
            this.ThemHinh.Location = new System.Drawing.Point(297, 338);
            this.ThemHinh.Name = "ThemHinh";
            this.ThemHinh.Size = new System.Drawing.Size(78, 30);
            this.ThemHinh.TabIndex = 8;
            this.ThemHinh.Text = "Thêm Hình";
            this.ThemHinh.UseVisualStyleBackColor = true;
            this.ThemHinh.Click += new System.EventHandler(this.ThemHinh_Click);
            // 
            // imghinhanh
            // 
            this.imghinhanh.Location = new System.Drawing.Point(167, 315);
            this.imghinhanh.Name = "imghinhanh";
            this.imghinhanh.Size = new System.Drawing.Size(124, 110);
            this.imghinhanh.TabIndex = 6;
            this.imghinhanh.TabStop = false;
            // 
            // cbcd
            // 
            this.cbcd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcd.FormattingEnabled = true;
            this.cbcd.Location = new System.Drawing.Point(117, 118);
            this.cbcd.Name = "cbcd";
            this.cbcd.Size = new System.Drawing.Size(108, 27);
            this.cbcd.TabIndex = 3;
            this.cbcd.SelectedIndexChanged += new System.EventHandler(this.cbcd_SelectedIndexChanged);
            // 
            // cbloai
            // 
            this.cbloai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(117, 85);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(108, 27);
            this.cbloai.TabIndex = 2;
            this.cbloai.SelectedIndexChanged += new System.EventHandler(this.cbloai_SelectedIndexChanged);
            // 
            // txtsl
            // 
            this.txtsl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsl.Enabled = false;
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(166, 226);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(189, 27);
            this.txtsl.TabIndex = 6;
            // 
            // txtdgb
            // 
            this.txtdgb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdgb.Enabled = false;
            this.txtdgb.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdgb.Location = new System.Drawing.Point(117, 193);
            this.txtdgb.Name = "txtdgb";
            this.txtdgb.Size = new System.Drawing.Size(238, 27);
            this.txtdgb.TabIndex = 5;
            // 
            // txtdgn
            // 
            this.txtdgn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdgn.Enabled = false;
            this.txtdgn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdgn.Location = new System.Drawing.Point(117, 160);
            this.txtdgn.Name = "txtdgn";
            this.txtdgn.Size = new System.Drawing.Size(238, 27);
            this.txtdgn.TabIndex = 4;
            // 
            // txtten
            // 
            this.txtten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(117, 52);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(238, 27);
            this.txtten.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(196, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Hình Ảnh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số Lượng Hiện Có";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Load Image";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Đơn Giá Bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn Giá Nhập";
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(117, 16);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(238, 27);
            this.txtma.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Loại";
            // 
            // lbcd
            // 
            this.lbcd.AutoSize = true;
            this.lbcd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcd.Location = new System.Drawing.Point(231, 121);
            this.lbcd.Name = "lbcd";
            this.lbcd.Size = new System.Drawing.Size(27, 19);
            this.lbcd.TabIndex = 2;
            this.lbcd.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã Công Dụng";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(231, 88);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(27, 19);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "---";
            // 
            // lbimgpath
            // 
            this.lbimgpath.AutoSize = true;
            this.lbimgpath.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimgpath.Location = new System.Drawing.Point(12, 0);
            this.lbimgpath.Name = "lbimgpath";
            this.lbimgpath.Size = new System.Drawing.Size(94, 19);
            this.lbimgpath.TabIndex = 2;
            this.lbimgpath.Text = "C:\\\\temp.jpg";
            this.lbimgpath.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.Exit);
            this.panel3.Controls.Add(this.btxoa);
            this.panel3.Controls.Add(this.btsua);
            this.panel3.Controls.Add(this.btluu);
            this.panel3.Controls.Add(this.btmoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(378, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 43);
            this.panel3.TabIndex = 15;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.Location = new System.Drawing.Point(383, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(78, 40);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.Image")));
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(295, 0);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(89, 43);
            this.btxoa.TabIndex = 13;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Image = ((System.Drawing.Image)(resources.GetObject("btsua.Image")));
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(214, 0);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(81, 43);
            this.btsua.TabIndex = 12;
            this.btsua.Text = "Sửa";
            this.btsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btluu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Image = ((System.Drawing.Image)(resources.GetObject("btluu.Image")));
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(129, 0);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 43);
            this.btluu.TabIndex = 11;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btmoi
            // 
            this.btmoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btmoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmoi.Image = ((System.Drawing.Image)(resources.GetObject("btmoi.Image")));
            this.btmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmoi.Location = new System.Drawing.Point(0, 0);
            this.btmoi.Name = "btmoi";
            this.btmoi.Size = new System.Drawing.Size(129, 43);
            this.btmoi.TabIndex = 10;
            this.btmoi.Text = "Thêm Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click);
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(378, 50);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(463, 400);
            this.msds.TabIndex = 17;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // load_pic
            // 
            this.load_pic.Location = new System.Drawing.Point(16, 316);
            this.load_pic.Name = "load_pic";
            this.load_pic.Size = new System.Drawing.Size(126, 109);
            this.load_pic.TabIndex = 10;
            this.load_pic.TabStop = false;
            // 
            // fr_NDL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 493);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_NDL_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Dữ Liệu Sản Phẩm";
            this.Load += new System.EventHandler(this.fr_NDL_SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imghinhanh)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button XoaHinh;
        private System.Windows.Forms.Button ThemHinh;
        private System.Windows.Forms.PictureBox imghinhanh;
        private System.Windows.Forms.ComboBox cbcd;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdgb;
        private System.Windows.Forms.TextBox txtdgn;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbimgpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox load_pic;
    }
}