
namespace QuanLyBanVeMayBay
{
    partial class CapNhatMayBay
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
            this.txtTenMayBay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMayBay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoGheLoai1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoGheLoai2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenMayBay
            // 
            this.txtTenMayBay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenMayBay.Location = new System.Drawing.Point(239, 147);
            this.txtTenMayBay.Name = "txtTenMayBay";
            this.txtTenMayBay.Size = new System.Drawing.Size(330, 30);
            this.txtTenMayBay.TabIndex = 32;
            this.txtTenMayBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMayBay_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên máy bay";
            // 
            // txtMaMayBay
            // 
            this.txtMaMayBay.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaMayBay.Location = new System.Drawing.Point(239, 98);
            this.txtMaMayBay.Name = "txtMaMayBay";
            this.txtMaMayBay.Size = new System.Drawing.Size(220, 30);
            this.txtMaMayBay.TabIndex = 33;
            this.txtMaMayBay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaMayBay_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã máy bay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhật Thông Tin Chuyến Bay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 51);
            this.panel1.TabIndex = 18;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Info;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyBanVeMayBay.Properties.Resources.renew30;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(213, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(147, 38);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = " Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.BackColor = System.Drawing.SystemColors.Info;
            this.btnLuuLai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLai.Image = global::QuanLyBanVeMayBay.Properties.Resources.save30;
            this.btnLuuLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuLai.Location = new System.Drawing.Point(41, 11);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(144, 38);
            this.btnLuuLai.TabIndex = 17;
            this.btnLuuLai.Text = "  Lưu lại";
            this.btnLuuLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuLai.UseVisualStyleBackColor = false;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Số ghế loại 1";
            // 
            // txtSoGheLoai1
            // 
            this.txtSoGheLoai1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoGheLoai1.Location = new System.Drawing.Point(239, 301);
            this.txtSoGheLoai1.Name = "txtSoGheLoai1";
            this.txtSoGheLoai1.Size = new System.Drawing.Size(152, 30);
            this.txtSoGheLoai1.TabIndex = 36;
            this.txtSoGheLoai1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGheLoai1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(452, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Số ghế loại 2";
            // 
            // txtSoGheLoai2
            // 
            this.txtSoGheLoai2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoGheLoai2.Location = new System.Drawing.Point(587, 301);
            this.txtSoGheLoai2.Name = "txtSoGheLoai2";
            this.txtSoGheLoai2.Size = new System.Drawing.Size(152, 30);
            this.txtSoGheLoai2.TabIndex = 34;
            this.txtSoGheLoai2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoGheLoai2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hãng sản xuất";
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtHangSanXuat.Location = new System.Drawing.Point(239, 196);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(330, 30);
            this.txtHangSanXuat.TabIndex = 32;
            this.txtHangSanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHangSanXuat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kích thước";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtKichThuoc.Location = new System.Drawing.Point(239, 248);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(220, 30);
            this.txtKichThuoc.TabIndex = 36;
            this.txtKichThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKichThuoc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng";
            // 
            // txtTong
            // 
            this.txtTong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTong.Location = new System.Drawing.Point(239, 355);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(152, 30);
            this.txtTong.TabIndex = 36;
            this.txtTong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTong_KeyPress);
            // 
            // CapNhatMayBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 471);
            this.Controls.Add(this.txtSoGheLoai2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHangSanXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenMayBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaMayBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKichThuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoGheLoai1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuuLai);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CapNhatMayBay";
            this.Text = "CapNhatMayBay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenMayBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMayBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoGheLoai1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoGheLoai2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTong;
    }
}