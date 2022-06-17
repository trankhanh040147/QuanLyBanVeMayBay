using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer;
using DataAccessLayer;
namespace QuanLyBanVeMayBay
{
    public partial class CapNhatKhachHang : Form
    {
        public CapNhatKhachHang()
        {
            InitializeComponent();
        }
        private DbKhachHang dbkh = new DbKhachHang();

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Trường hợp mã khách hàng có trong CSDL
            if (dbkh.checkKhachHang(this.txtMaKhachHang.Text.Trim()) == true)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn cập nhật khách hàng lại không?", "Khách hàng đã tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    string err = "";
                    kh.HoKhachHang = txtHoKhachHang.Text;
                    kh.TenLotKhachHang = txtTenLotKhachHang.Text;
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    kh.SoDienThoai = txtSoDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.CMND = txtCMND.Text;
                    if (!dbkh.insertKhachHang(ref err, kh))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }
            }
            //Trường hợp mã khách hàng không có trong CSDL
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn thêm một khách hàng mới không?", "Khách hàng chưa tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    string err = "";
                    kh.MaKhachHang = txtMaKhachHang.Text.Trim();
                    kh.HoKhachHang = txtHoKhachHang.Text;
                    kh.TenLotKhachHang = txtTenLotKhachHang.Text;
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    kh.SoDienThoai = txtSoDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.CMND = txtCMND.Text;
                    if (!dbkh.updateKhachHang(ref err, kh))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMaKhachHang.Clear();
            this.txtHoKhachHang.Clear();
            this.txtTenLotKhachHang.Clear();
            this.txtTenKhachHang.Clear();
            this.txtSoDienThoai.Clear();
            this.txtCMND.Clear();
            this.txtDiaChi.Clear();
            this.txtMaKhachHang.Focus();
        }

        private void txtMaKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtHoKhachHang.Focus();

        }

        private void txtHoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtTenLotKhachHang.Focus();
        }

        private void txtTenLotKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtTenKhachHang.Focus();

        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtSoDienThoai.Focus();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtCMND.Focus();
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtDiaChi.Focus();
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btnLuuLai.Focus();
        }
    }
}
