﻿namespace QL_CAFE.Form_Main
{
	partial class fr_ThongKe_KH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_ThongKe_KH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuatbaocao = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.d2);
            this.panel1.Controls.Add(this.d1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ngày Kết Thúc ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ngày Bắt Đầu";
            // 
            // d2
            // 
            this.d2.CustomFormat = "MM/dd/yyyy";
            this.d2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d2.Location = new System.Drawing.Point(159, 53);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(128, 27);
            this.d2.TabIndex = 30;
            // 
            // d1
            // 
            this.d1.CustomFormat = "MM/dd/yyyy";
            this.d1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.d1.Location = new System.Drawing.Point(159, 20);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(128, 27);
            this.d1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xuatbaocao);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 85);
            this.panel2.TabIndex = 4;
            // 
            // xuatbaocao
            // 
            this.xuatbaocao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatbaocao.Image = ((System.Drawing.Image)(resources.GetObject("xuatbaocao.Image")));
            this.xuatbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xuatbaocao.Location = new System.Drawing.Point(19, 13);
            this.xuatbaocao.Name = "xuatbaocao";
            this.xuatbaocao.Size = new System.Drawing.Size(117, 54);
            this.xuatbaocao.TabIndex = 36;
            this.xuatbaocao.Text = "Xuất BC";
            this.xuatbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.xuatbaocao.UseVisualStyleBackColor = true;
            this.xuatbaocao.Click += new System.EventHandler(this.xuatbaocao_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exit.Location = new System.Drawing.Point(226, 18);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(77, 45);
            this.exit.TabIndex = 34;
            this.exit.Text = "Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // fr_ThongKe_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_ThongKe_KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Khách Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker d2;
		private System.Windows.Forms.DateTimePicker d1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button xuatbaocao;
		private System.Windows.Forms.Button exit;
	}
}