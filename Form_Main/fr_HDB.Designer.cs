﻿namespace QL_CAFE.Form_Main
{
    partial class fr_HDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_HDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btmoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbncc = new System.Windows.Forms.Label();
            this.lbnv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msds = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 50);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(252, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN BÁN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btxoa);
            this.panel2.Controls.Add(this.btsua);
            this.panel2.Controls.Add(this.btluu);
            this.panel2.Controls.Add(this.btmoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 43);
            this.panel2.TabIndex = 14;
            // 
            // btxoa
            // 
            this.btxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = ((System.Drawing.Image)(resources.GetObject("btxoa.Image")));
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(307, 0);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(90, 43);
            this.btxoa.TabIndex = 8;
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
            this.btsua.Location = new System.Drawing.Point(220, 0);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(87, 43);
            this.btsua.TabIndex = 7;
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
            this.btluu.Size = new System.Drawing.Size(91, 43);
            this.btluu.TabIndex = 6;
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
            this.btmoi.TabIndex = 5;
            this.btmoi.Text = "Thêm Mới";
            this.btmoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmoi.UseVisualStyleBackColor = true;
            this.btmoi.Click += new System.EventHandler(this.btmoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txttt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbncc);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbncc);
            this.groupBox1.Controls.Add(this.lbnv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtngay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 127);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HÓA ĐƠN";
            // 
            // txttt
            // 
            this.txttt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttt.Enabled = false;
            this.txttt.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(437, 90);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(224, 27);
            this.txttt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Thành Tiền";
            // 
            // cbncc
            // 
            this.cbncc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(437, 59);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(108, 27);
            this.cbncc.TabIndex = 2;
            this.cbncc.SelectedIndexChanged += new System.EventHandler(this.cbncc_SelectedIndexChanged);
            // 
            // cbnv
            // 
            this.cbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(95, 59);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(108, 27);
            this.cbnv.TabIndex = 1;
            this.cbnv.SelectedIndexChanged += new System.EventHandler(this.cbnv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khách Hàng";
            // 
            // lbncc
            // 
            this.lbncc.AutoSize = true;
            this.lbncc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbncc.Location = new System.Drawing.Point(551, 62);
            this.lbncc.Name = "lbncc";
            this.lbncc.Size = new System.Drawing.Size(27, 19);
            this.lbncc.TabIndex = 9;
            this.lbncc.Text = "---";
            // 
            // lbnv
            // 
            this.lbnv.AutoSize = true;
            this.lbnv.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnv.Location = new System.Drawing.Point(209, 62);
            this.lbnv.Name = "lbnv";
            this.lbnv.Size = new System.Drawing.Size(27, 19);
            this.lbnv.TabIndex = 10;
            this.lbnv.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhân Viên";
            // 
            // txtngay
            // 
            this.txtngay.CustomFormat = "MM/dd/yyyy";
            this.txtngay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtngay.Location = new System.Drawing.Point(95, 92);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(227, 27);
            this.txtngay.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày Bán";
            // 
            // txtma
            // 
            this.txtma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(95, 26);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(602, 27);
            this.txtma.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số HĐB";
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(0, 50);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(710, 249);
            this.msds.TabIndex = 20;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            this.msds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellDoubleClick);
            // 
            // fr_HDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 469);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_HDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.fr_HDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbncc;
        private System.Windows.Forms.Label lbnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView msds;
    }
}