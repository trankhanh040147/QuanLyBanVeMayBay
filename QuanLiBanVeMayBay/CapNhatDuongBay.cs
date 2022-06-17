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
    public partial class CapNhatDuongBay : Form
    {
        public CapNhatDuongBay()
        {
            InitializeComponent();
        }
        private DbDuongBay dbdb = new DbDuongBay();
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Trường hợp mã đường bay có trong CSDL
            if (dbdb.checkDuongBay(this.txtMaDuongBay.Text.Trim()) == true)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn cập nhật đường bay lại không?", "Đường bay đã tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    DuongBay db = new DuongBay();
                    string err = "";
                    db.ViTri = txtViTri.Text;
                    db.ChieuDai = int.Parse(txtChieuDai.Text);
                    db.ChieuRong = int.Parse(txtChieuRong.Text);
                    db.TinhTrang = chkDangSuDung.Checked.ToString();
                    if (!dbdb.updateDuongBay(ref err, db))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }
            }
            //Trường hợp mã đường bay không có trong CSDL
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn thêm một đường bay mới không?", "Đường bay chưa tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    DuongBay db = new DuongBay();
                    string err = "";
                    db.MaDuongBay = txtMaDuongBay.Text.Trim();
                    db.ViTri = txtViTri.Text;
                    db.ChieuDai = int.Parse(txtChieuDai.Text);
                    db.ChieuRong = int.Parse(txtChieuRong.Text);
                    db.TinhTrang = chkDangSuDung.Checked.ToString();
                    if (!dbdb.insertDuongBay(ref err, db))
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
            this.txtMaDuongBay.Clear();
            this.txtChieuDai.Clear();
            this.txtChieuRong.Clear(); 
            this.txtViTri.Clear();
            this.chkDangSuDung.Checked = false;
            this.txtMaDuongBay.Focus();
        }

        private void txtMaDuongBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtViTri.Focus();
        }

        private void txtViTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtChieuDai.Focus();
        }

        private void txtChieuDai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtChieuRong.Focus();
        }

        private void txtChieuRong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.chkDangSuDung.Focus();
        }

        private void chkDangSuDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btnLuuLai.Focus();
        }
    }
}
