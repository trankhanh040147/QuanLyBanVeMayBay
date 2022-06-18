using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BussinessLogicLayer;

namespace QuanLyBanVeMayBay
{
    public partial class Menu : Form
    {
        public bool QuyenAD; // Quyền của tài khoản, nếu = True là quyền AD, False là quyền của nhân viên
        public string TenDangNhap;
        QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(bool quyenAD,string tendangnhap)
        {
            InitializeComponent();
            this.QuyenAD = quyenAD;
            this.TenDangNhap = tendangnhap;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var nv = dbs.NhanViens
                .FirstOrDefault(p => p.TenDangNhap == TenDangNhap);
            DieuChinhQuyen(this.QuyenAD);
            txtNguoiDangDangNhap.Text = nv.TenNhanVien;
            txtQuyenHan.Text = nv.ChucVu;
        }

        public void DieuChinhQuyen(bool quyenAD)
        {
            if (!quyenAD) //Nếu không có quyền AD thì ẩn những chức năng này đi
            {
                btnCapnhatDuongbay.Enabled = false;
                btnCapNhatChuyenBay.Enabled = false;
                btnCapnhatMaybay.Enabled = false;
                btnCapNhatNhanVien.Enabled = false;
                btnTimkiemNhanvien.Enabled = false;
            }
        }

        private void btnTimkiemNhanvien_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien formDanhSachNhanVien = new DanhSachNhanVien(false) ;
            formDanhSachNhanVien.Show();
        }

        private void btnTimkiemChuyenbay_Click(object sender, EventArgs e)
        {
            DanhSachChuyenBay formDanhSachChuyenBay = new DanhSachChuyenBay(false);
            formDanhSachChuyenBay.Show();
        }

        private void btnTimkiemKhachhang_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang formDanhSachKhachHang = new DanhSachKhachHang(false);
            formDanhSachKhachHang.Show();
        }

        private void btnCapnhatMaybay_Click(object sender, EventArgs e)
        {
            DanhSachMayBay formDanhSachMayBay = new DanhSachMayBay(true);
            formDanhSachMayBay.Show();
        }

        private void btnCapnhatDuongbay_Click(object sender, EventArgs e)
        {
            DanhSachDuongBay formDanhSachDuongBay = new DanhSachDuongBay(true);
            formDanhSachDuongBay.Show();
        }

        private void btnCapnhatNhanvien_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien formDanhSachNhanVien = new DanhSachNhanVien(true);
            formDanhSachNhanVien.Show();
        }

        private void btnCapnhathethongChuyenbay_Click(object sender, EventArgs e)
        {
            DanhSachChuyenBay formDanhSachChuyenBay = new DanhSachChuyenBay(true);
            formDanhSachChuyenBay.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiemMayBay_Click(object sender, EventArgs e)
        {
            DanhSachMayBay formDanhSachMayBay = new DanhSachMayBay(false);
            formDanhSachMayBay.Show();
        }

        private void btnTimKiemDuongbay_Click(object sender, EventArgs e)
        {
            DanhSachDuongBay formDanhSachDuongBay = new DanhSachDuongBay(false);
            formDanhSachDuongBay.Show();
        }

        private void btnCapNhatChuyenBay_Click(object sender, EventArgs e)
        {
            DanhSachChuyenBay formDanhSachChuyenBay = new DanhSachChuyenBay(true);
            formDanhSachChuyenBay.Show();
        }

        private void btnCapNhatNhanVien_Click_1(object sender, EventArgs e)
        {
            DanhSachNhanVien formDanhSachNhanVien = new DanhSachNhanVien(true);
            formDanhSachNhanVien.Show();
        }

        private void btnCapNhatKhachHang_Click(object sender, EventArgs e)
        {
            DanhSachKhachHang formDanhSachKhachHang = new DanhSachKhachHang(true);
            formDanhSachKhachHang.Show();
        }

        private void btnCapNhatVeMayBay_Click(object sender, EventArgs e)
        {
            DanhSachVeBan vb = new DanhSachVeBan();
            vb.Show();
        }
        private void btnDatVeMayBay_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Environment.Exit(1);
            }

        }

        private void btnDatVeMayBay_Click_1(object sender, EventArgs e)
        {
            DatVeMayBay dv = new DatVeMayBay(TenDangNhap);
            dv.Show();
        }
    }
}
