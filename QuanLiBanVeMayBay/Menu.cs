using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay
{
    public partial class Menu : Form
    {
        public bool QuyenAD; // Quyền của tài khoản, nếu = True là quyền AD, False là quyền của nhân viên

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(bool quyenAD)
        {
            InitializeComponent();
            this.QuyenAD = quyenAD;
        }

        public void DieuChinhQuyen(bool quyenAD)
        {
            if (!quyenAD) //Nếu không có quyền AD thì ẩn những chức năng này đi
            {
                btnCapnhatDuongbay.Enabled = false;
                btnCapnhathethongChuyenbay.Enabled = false;
                btnCapnhatMaybay.Enabled = false;
                btnCapnhatNhanvien.Enabled = false;
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
            DanhSachKhachHang formDanhSachKhachHang = new DanhSachKhachHang(true);
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

        private void Menu_Load(object sender, EventArgs e)
        {
            DieuChinhQuyen(this.QuyenAD);
        }

        private void btnDatVeMayBay_Click(object sender, EventArgs e)
        {
            DatVeMayBay formDatVeMayBay = new DatVeMayBay();
            formDatVeMayBay.Show();
        }
    }
}
