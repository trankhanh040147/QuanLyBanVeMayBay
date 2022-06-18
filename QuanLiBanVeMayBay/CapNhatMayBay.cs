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
    public partial class CapNhatMayBay : Form
    {
        public CapNhatMayBay()
        {
            InitializeComponent();
        }
        private DbMaybay dbmb = new DbMaybay();
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            //Trường hợp mã máy bay có trong CSDL
            if (dbmb.checkMayBay(this.txtMaMayBay.Text.Trim()) == true)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn cập nhật máy bay lại không?", "Máy bay đã tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    MayBay mb = new MayBay();
                    string err = "";
                    mb.TenMayBay = txtTenMayBay.Text;
                    mb.HangSanXuat = txtHangSanXuat.Text;
                    mb.KichThuoc = int.Parse(txtKichThuoc.Text);   
                    mb.SoGheL1 = int.Parse(txtSoGheLoai1.Text);
                    mb.SoGheL2 = int.Parse(txtSoGheLoai2.Text);
                    mb.Tong = int.Parse(txtTong.Text);
                    if (!dbmb.updateMayBay(ref err, mb))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }
            }
            //Trường hợp mã máy bay không có trong CSDL
            else
            {
                DialogResult tl = MessageBox.Show("Bạn muốn thêm một máy bay mới không?", "Máy bay chưa tồn tại",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    MayBay mb = new MayBay();
                    string err = "";
                    mb.MaMayBay = txtMaMayBay.Text.Trim();
                    mb.TenMayBay = txtTenMayBay.Text;
                    mb.HangSanXuat = txtHangSanXuat.Text;
                    mb.KichThuoc = int.Parse(txtKichThuoc.Text);
                    mb.SoGheL1 = int.Parse(txtSoGheLoai1.Text);
                    mb.SoGheL2 = int.Parse(txtSoGheLoai2.Text);
                    mb.Tong = int.Parse(txtTong.Text);
                    if (!dbmb.insertMayBay(ref err, mb))
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
            this.txtMaMayBay.Clear();
            this.txtTenMayBay.Clear();
            this.txtHangSanXuat.Clear();
            this.txtKichThuoc.Clear();
            this.txtSoGheLoai1.Clear();
            this.txtSoGheLoai2.Clear();
            this.txtTong.Clear();
            this.txtMaMayBay.Focus();
        }

        private void txtMaMayBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtTenMayBay.Focus();
        }

        private void txtTenMayBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtHangSanXuat.Focus();
        }

        private void txtHangSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtKichThuoc.Focus();
        }

        private void txtKichThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtSoGheLoai1.Focus();

        }

        private void txtSoGheLoai1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtSoGheLoai2.Focus();
        }

        private void txtSoGheLoai2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.txtTong.Focus();
        }

        private void txtTong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.btnLuuLai.Focus();
        }
    }
}
