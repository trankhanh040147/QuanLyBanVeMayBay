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
    public partial class CapNhatChuyenBay : Form
    {
        public CapNhatChuyenBay()
        {
            InitializeComponent();
        }
        private DbChuyenBay dbcb = new DbChuyenBay();

        private void btnLuuLai_Click(object sender, EventArgs e)
        {

            //Trường hợp mã chuyến bay có trong CSDL
            if(dbcb.checkChuyenBay(this.txtChuyenbay.Text.Trim())==true)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn cập nhật chuyến bay lại không?", "Chuyến bay đã tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    ChuyenBay cb = new ChuyenBay();
                    string err = "";
                    cb.MaDuongBay = txtMaDuongBay.Text.Trim();
                    cb.MaMayBay = txtMaMayBay.Text.Trim();
                    cb.DiemDi = txtDiemDi.Text;
                    cb.DiemDen = txtDiemDen.Text;
                    cb.NgayDi = dtpNgaydi.Value;
                    cb.NgayDen = dtpNgayden.Value;
                    cb.GioBay = dtpGioBay.Value.TimeOfDay;
                    cb.GhiChu = txtGhiChu.Text;
                    if (!dbcb.updateChuyenBay(ref err, cb))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }
            }
            //Trường hợp mã chuyến bay không có trong CSDL
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn thêm một chuyến bay mới không?", "Chuyến bay chưa tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    ChuyenBay cb = new ChuyenBay();
                    string err = "";
                    cb.MaChuyenBay = txtChuyenbay.Text.Trim();
                    cb.MaDuongBay = txtMaDuongBay.Text.Trim();
                    cb.MaMayBay = txtMaMayBay.Text.Trim();
                    cb.DiemDi = txtDiemDi.Text;
                    cb.DiemDen = txtDiemDen.Text;
                    cb.NgayDi = dtpNgaydi.Value;
                    cb.NgayDen = dtpNgayden.Value;
                    cb.GioBay = dtpGioBay.Value.TimeOfDay;
                    cb.GhiChu = txtGhiChu.Text;
                    if (!dbcb.insertChuyenBay(ref err, cb))
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
            this.txtChuyenbay.Clear(); 
            this.txtMaDuongBay.Clear();
            this.txtMaMayBay.Clear();
            this.txtDiemDi.Clear();
            this.txtDiemDen.Clear();
            this.txtGhiChu.Clear();
            this.txtChuyenbay.Focus();
        }

        private void txtChuyenbay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtMaDuongBay.Focus();
        }

        private void txtMaDuongBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtMaMayBay.Focus();
        }

        private void txtMaMayBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtDiemDi.Focus();
        }

        private void txtDiemDi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtDiemDen.Focus();
        }

        private void txtDiemDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtGhiChu.Focus();
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btnLuuLai.Focus();
        }
    }
}
