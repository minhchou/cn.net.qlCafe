namespace QL_CAFE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmddn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtdb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "KẾT NỐI SERVER";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmddn);
            this.panel2.Location = new System.Drawing.Point(27, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 50);
            this.panel2.TabIndex = 1;
            // 
            // cmddn
            // 
            this.cmddn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmddn.Location = new System.Drawing.Point(0, 0);
            this.cmddn.Name = "cmddn";
            this.cmddn.Size = new System.Drawing.Size(113, 50);
            this.cmddn.TabIndex = 83;
            this.cmddn.Text = "OK";
            this.cmddn.UseVisualStyleBackColor = true;
            this.cmddn.Click += new System.EventHandler(this.cmddn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdthoat);
            this.panel3.Location = new System.Drawing.Point(193, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 50);
            this.panel3.TabIndex = 2;
            // 
            // cmdthoat
            // 
            this.cmdthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdthoat.Location = new System.Drawing.Point(0, 0);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(128, 50);
            this.cmdthoat.TabIndex = 83;
            this.cmdthoat.Text = "Exit";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Tên Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tên CSDL";
            // 
            // txtserver
            // 
            this.txtserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.Location = new System.Drawing.Point(112, 76);
            this.txtserver.Multiline = true;
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(214, 27);
            this.txtserver.TabIndex = 81;
            // 
            // txtdb
            // 
            this.txtdb.Enabled = false;
            this.txtdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdb.Location = new System.Drawing.Point(112, 115);
            this.txtdb.Multiline = true;
            this.txtdb.Name = "txtdb";
            this.txtdb.Size = new System.Drawing.Size(214, 27);
            this.txtdb.TabIndex = 82;
            this.txtdb.Text = "QL_Quancaphe";
            this.txtdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 224);
            this.Controls.Add(this.txtdb);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Connection Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmddn;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtdb;
    }
}

