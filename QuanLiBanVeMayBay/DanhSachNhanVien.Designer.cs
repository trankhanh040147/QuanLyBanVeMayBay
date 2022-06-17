
namespace QuanLyBanVeMayBay
{
    partial class DanhSachNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTImKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChiNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.rdbDiaChiNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbTenNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbMaNhanVien = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnTim = new MaterialSkin.Controls.MaterialButton();
            this.txtTim = new MaterialSkin.Controls.MaterialTextBox();
            this.panelCRUD = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(296, 0);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(1116, 748);
            this.dgvNhanVien.TabIndex = 2;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.btnTImKiem);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 748);
            this.panel3.TabIndex = 1;
            // 
            // btnTImKiem
            // 
            this.btnTImKiem.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTImKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTImKiem.Image = global::QuanLyBanVeMayBay.Properties.Resources.Search42;
            this.btnTImKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTImKiem.Location = new System.Drawing.Point(12, 423);
            this.btnTImKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTImKiem.Name = "btnTImKiem";
            this.btnTImKiem.Size = new System.Drawing.Size(250, 50);
            this.btnTImKiem.TabIndex = 12;
            this.btnTImKiem.Text = "Tìm kiếm";
            this.btnTImKiem.UseVisualStyleBackColor = true;
            this.btnTImKiem.Click += new System.EventHandler(this.btnTImKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChiNhanVien);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.rdbDiaChiNhanVien);
            this.groupBox1.Controls.Add(this.rdbTenNhanVien);
            this.groupBox1.Controls.Add(this.rdbMaNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 371);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtDiaChiNhanVien
            // 
            this.txtDiaChiNhanVien.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDiaChiNhanVien.Location = new System.Drawing.Point(36, 313);
            this.txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            this.txtDiaChiNhanVien.Size = new System.Drawing.Size(195, 30);
            this.txtDiaChiNhanVien.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTenNhanVien.Location = new System.Drawing.Point(36, 213);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(195, 30);
            this.txtTenNhanVien.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(36, 112);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(195, 30);
            this.txtMaNhanVien.TabIndex = 7;
            // 
            // rdbDiaChiNhanVien
            // 
            this.rdbDiaChiNhanVien.AutoSize = true;
            this.rdbDiaChiNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiaChiNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbDiaChiNhanVien.Location = new System.Drawing.Point(36, 270);
            this.rdbDiaChiNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDiaChiNhanVien.Name = "rdbDiaChiNhanVien";
            this.rdbDiaChiNhanVien.Size = new System.Drawing.Size(177, 27);
            this.rdbDiaChiNhanVien.TabIndex = 4;
            this.rdbDiaChiNhanVien.TabStop = true;
            this.rdbDiaChiNhanVien.Text = "Địa chỉ nhân viên";
            this.rdbDiaChiNhanVien.UseVisualStyleBackColor = true;
            this.rdbDiaChiNhanVien.CheckedChanged += new System.EventHandler(this.rdbDiaChiNhanVien_CheckedChanged);
            // 
            // rdbTenNhanVien
            // 
            this.rdbTenNhanVien.AutoSize = true;
            this.rdbTenNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbTenNhanVien.Location = new System.Drawing.Point(36, 168);
            this.rdbTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTenNhanVien.Name = "rdbTenNhanVien";
            this.rdbTenNhanVien.Size = new System.Drawing.Size(151, 27);
            this.rdbTenNhanVien.TabIndex = 5;
            this.rdbTenNhanVien.TabStop = true;
            this.rdbTenNhanVien.Text = "Tên nhân viên";
            this.rdbTenNhanVien.UseVisualStyleBackColor = true;
            this.rdbTenNhanVien.CheckedChanged += new System.EventHandler(this.rdbTenNhanVien_CheckedChanged);
            // 
            // rdbMaNhanVien
            // 
            this.rdbMaNhanVien.AutoSize = true;
            this.rdbMaNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaNhanVien.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbMaNhanVien.Location = new System.Drawing.Point(36, 68);
            this.rdbMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMaNhanVien.Name = "rdbMaNhanVien";
            this.rdbMaNhanVien.Size = new System.Drawing.Size(146, 27);
            this.rdbMaNhanVien.TabIndex = 6;
            this.rdbMaNhanVien.TabStop = true;
            this.rdbMaNhanVien.Text = "Mã nhân viên";
            this.rdbMaNhanVien.UseVisualStyleBackColor = true;
            this.rdbMaNhanVien.CheckedChanged += new System.EventHandler(this.rdbMaNhanVien_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(296, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 123);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 123);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Image = global::QuanLyBanVeMayBay.Properties.Resources.Staff1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(269, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.txtTim);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(296, 123);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1116, 62);
            this.panel4.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = false;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReset.Depth = 0;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.HighEmphasis = true;
            this.btnReset.Icon = null;
            this.btnReset.Location = new System.Drawing.Point(682, 7);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReset.Size = new System.Drawing.Size(120, 44);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReset.UseAccentColor = false;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTim
            // 
            this.btnTim.AutoSize = false;
            this.btnTim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTim.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnTim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTim.Depth = 0;
            this.btnTim.HighEmphasis = true;
            this.btnTim.Icon = null;
            this.btnTim.Location = new System.Drawing.Point(521, 7);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnTim.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTim.Name = "btnTim";
            this.btnTim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTim.Size = new System.Drawing.Size(120, 44);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTim.UseAccentColor = false;
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            this.txtTim.AnimateReadOnly = false;
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.Depth = 0;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtTim.LeadingIcon = null;
            this.txtTim.Location = new System.Drawing.Point(38, 11);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.MaxLength = 50;
            this.txtTim.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTim.Multiline = false;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(457, 36);
            this.txtTim.TabIndex = 0;
            this.txtTim.Text = "Nhập thông tin vào đây";
            this.txtTim.TrailingIcon = null;
            this.txtTim.UseTallSize = false;
            // 
            // panelCRUD
            // 
            this.panelCRUD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCRUD.Controls.Add(this.btnReload);
            this.panelCRUD.Controls.Add(this.btnXoa);
            this.panelCRUD.Controls.Add(this.btnSua);
            this.panelCRUD.Controls.Add(this.btnThem);
            this.panelCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCRUD.Location = new System.Drawing.Point(296, 185);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.Size = new System.Drawing.Size(1116, 46);
            this.panelCRUD.TabIndex = 17;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Image = global::QuanLyBanVeMayBay.Properties.Resources.reload2;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(466, 8);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(112, 31);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyBanVeMayBay.Properties.Resources.remove2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(316, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 31);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "  Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyBanVeMayBay.Properties.Resources.edit2;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(168, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 31);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "  Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyBanVeMayBay.Properties.Resources.add2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "  Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 748);
            this.Controls.Add(this.panelCRUD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DanhSachNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDiaChiNhanVien;
        private System.Windows.Forms.RadioButton rdbTenNhanVien;
        private System.Windows.Forms.RadioButton rdbMaNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton btnTim;
        private MaterialSkin.Controls.MaterialTextBox txtTim;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private System.Windows.Forms.Panel panelCRUD;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtDiaChiNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnTImKiem;
    }
}