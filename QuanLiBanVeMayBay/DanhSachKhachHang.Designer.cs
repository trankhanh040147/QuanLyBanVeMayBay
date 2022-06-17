
namespace QuanLyBanVeMayBay
{
    partial class DanhSachKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChiKhachHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.rdbDiaChiKhachHang = new System.Windows.Forms.RadioButton();
            this.rdbTenKhachHang = new System.Windows.Forms.RadioButton();
            this.rdbMaKhachHang = new System.Windows.Forms.RadioButton();
            this.PanelFunction = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReset = new MaterialSkin.Controls.MaterialButton();
            this.btnTim = new MaterialSkin.Controls.MaterialButton();
            this.txtTim = new MaterialSkin.Controls.MaterialTextBox();
            this.panelCRUD = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelFunction.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(296, 231);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(1139, 591);
            this.dgvKhachHang.TabIndex = 6;
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
            this.panel1.Size = new System.Drawing.Size(1139, 123);
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
            this.label1.Text = "Danh sách khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.PanelFunction);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 822);
            this.panel3.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = global::QuanLyBanVeMayBay.Properties.Resources.Search42;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(28, 745);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(250, 50);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTImKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChiKhachHang);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.rdbDiaChiKhachHang);
            this.groupBox1.Controls.Add(this.rdbTenKhachHang);
            this.groupBox1.Controls.Add(this.rdbMaKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(28, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 353);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtDiaChiKhachHang
            // 
            this.txtDiaChiKhachHang.Enabled = false;
            this.txtDiaChiKhachHang.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDiaChiKhachHang.Location = new System.Drawing.Point(22, 297);
            this.txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            this.txtDiaChiKhachHang.Size = new System.Drawing.Size(195, 30);
            this.txtDiaChiKhachHang.TabIndex = 11;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTenKhachHang.Location = new System.Drawing.Point(22, 197);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(195, 30);
            this.txtTenKhachHang.TabIndex = 12;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Enabled = false;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(22, 96);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(195, 30);
            this.txtMaKhachHang.TabIndex = 13;
            // 
            // rdbDiaChiKhachHang
            // 
            this.rdbDiaChiKhachHang.AutoSize = true;
            this.rdbDiaChiKhachHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiaChiKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbDiaChiKhachHang.Location = new System.Drawing.Point(22, 254);
            this.rdbDiaChiKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDiaChiKhachHang.Name = "rdbDiaChiKhachHang";
            this.rdbDiaChiKhachHang.Size = new System.Drawing.Size(195, 27);
            this.rdbDiaChiKhachHang.TabIndex = 8;
            this.rdbDiaChiKhachHang.TabStop = true;
            this.rdbDiaChiKhachHang.Text = "Địa chỉ khách hàng";
            this.rdbDiaChiKhachHang.UseVisualStyleBackColor = true;
            this.rdbDiaChiKhachHang.CheckedChanged += new System.EventHandler(this.rdbDiaChiKhachHang_CheckedChanged);
            // 
            // rdbTenKhachHang
            // 
            this.rdbTenKhachHang.AutoSize = true;
            this.rdbTenKhachHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbTenKhachHang.Location = new System.Drawing.Point(22, 152);
            this.rdbTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTenKhachHang.Name = "rdbTenKhachHang";
            this.rdbTenKhachHang.Size = new System.Drawing.Size(169, 27);
            this.rdbTenKhachHang.TabIndex = 9;
            this.rdbTenKhachHang.TabStop = true;
            this.rdbTenKhachHang.Text = "Tên khách hàng";
            this.rdbTenKhachHang.UseVisualStyleBackColor = true;
            this.rdbTenKhachHang.CheckedChanged += new System.EventHandler(this.rdbTenKhachHang_CheckedChanged);
            // 
            // rdbMaKhachHang
            // 
            this.rdbMaKhachHang.AutoSize = true;
            this.rdbMaKhachHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaKhachHang.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbMaKhachHang.Location = new System.Drawing.Point(22, 52);
            this.rdbMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMaKhachHang.Name = "rdbMaKhachHang";
            this.rdbMaKhachHang.Size = new System.Drawing.Size(164, 27);
            this.rdbMaKhachHang.TabIndex = 10;
            this.rdbMaKhachHang.TabStop = true;
            this.rdbMaKhachHang.Text = "Mã khách hàng";
            this.rdbMaKhachHang.UseVisualStyleBackColor = true;
            this.rdbMaKhachHang.CheckedChanged += new System.EventHandler(this.rdbMaKhachHang_CheckedChanged);
            // 
            // PanelFunction
            // 
            this.PanelFunction.Controls.Add(this.progressBar2);
            this.PanelFunction.Controls.Add(this.textBox3);
            this.PanelFunction.Controls.Add(this.textBox2);
            this.PanelFunction.Controls.Add(this.textBox1);
            this.PanelFunction.Controls.Add(this.label3);
            this.PanelFunction.Controls.Add(this.progressBar1);
            this.PanelFunction.Controls.Add(this.label2);
            this.PanelFunction.Location = new System.Drawing.Point(4, 7);
            this.PanelFunction.Margin = new System.Windows.Forms.Padding(4);
            this.PanelFunction.Name = "PanelFunction";
            this.PanelFunction.Size = new System.Drawing.Size(292, 341);
            this.PanelFunction.TabIndex = 0;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Gainsboro;
            this.progressBar2.Location = new System.Drawing.Point(24, 329);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(240, 4);
            this.progressBar2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(46, 266);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 60);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "• Tìm kiếm thông tin khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(46, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 60);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "• Tìm kiếm thông tin khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(63, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "ADMIN + Nhân viên";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Image = global::QuanLyBanVeMayBay.Properties.Resources.Function111;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(4, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chức năng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.progressBar1.Location = new System.Drawing.Point(24, 115);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(240, 4);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Image = global::QuanLyBanVeMayBay.Properties.Resources.Authorization;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quyền sử dụng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel4.Size = new System.Drawing.Size(1139, 62);
            this.panel4.TabIndex = 8;
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
            this.btnReset.Location = new System.Drawing.Point(681, 7);
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
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.AnimateReadOnly = false;
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.Depth = 0;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtTim.LeadingIcon = null;
            this.txtTim.Location = new System.Drawing.Point(44, 11);
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
            this.panelCRUD.Size = new System.Drawing.Size(1139, 46);
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
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 822);
            this.Controls.Add(this.panelCRUD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "DanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelFunction.ResumeLayout(false);
            this.PanelFunction.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelFunction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton btnTim;
        private MaterialSkin.Controls.MaterialTextBox txtTim;
        private MaterialSkin.Controls.MaterialButton btnReset;
        private System.Windows.Forms.Panel panelCRUD;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChiKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.RadioButton rdbDiaChiKhachHang;
        private System.Windows.Forms.RadioButton rdbTenKhachHang;
        private System.Windows.Forms.RadioButton rdbMaKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
    }
}