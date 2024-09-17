namespace QL_CAFE.Form_Main
{
    partial class fr_TK_HDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_TK_HDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.txtthongtin = new System.Windows.Forms.TextBox();
            this.msds = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(762, 50);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(233, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btn_Reset);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.op3);
            this.panel3.Controls.Add(this.op1);
            this.panel3.Controls.Add(this.op2);
            this.panel3.Controls.Add(this.txtthongtin);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 83);
            this.panel3.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(661, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // op3
            // 
            this.op3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op3.AutoSize = true;
            this.op3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.Location = new System.Drawing.Point(517, 49);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(123, 23);
            this.op3.TabIndex = 3;
            this.op3.TabStop = true;
            this.op3.Text = "Mã Nhân Viên";
            this.op3.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            this.op1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.Location = new System.Drawing.Point(236, 52);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(144, 23);
            this.op1.TabIndex = 3;
            this.op1.TabStop = true;
            this.op1.Text = "Mã Hóa Đơn Bán";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            this.op2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.Location = new System.Drawing.Point(398, 51);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(92, 23);
            this.op2.TabIndex = 3;
            this.op2.TabStop = true;
            this.op2.Text = "Ngày Bán";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.CheckedChanged += new System.EventHandler(this.op2_CheckedChanged);
            // 
            // txtthongtin
            // 
            this.txtthongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtthongtin.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongtin.Location = new System.Drawing.Point(236, 14);
            this.txtthongtin.Name = "txtthongtin";
            this.txtthongtin.Size = new System.Drawing.Size(405, 27);
            this.txtthongtin.TabIndex = 2;
            this.txtthongtin.TextChanged += new System.EventHandler(this.txtthongtin_TextChanged);
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(0, 50);
            this.msds.Name = "msds";
            this.msds.Size = new System.Drawing.Size(762, 348);
            this.msds.TabIndex = 19;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(89, 14);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(129, 57);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Bỏ chọn tất cả";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // fr_TK_HDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 481);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_TK_HDB";
            this.Text = "Tìm Kiếm Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.fr_TK_HDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.TextBox txtthongtin;
        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Reset;
    }
}