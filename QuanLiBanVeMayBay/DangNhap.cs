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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public bool KiemTraQuyen(string tendangnhap, string matkhau)
        {
            if (true) //Kiểm tra điều kiện tài khoản AD
            {

                // Code kiểm tra tài có quyền AD hay không

                return true;//Quyền tài khoản AD
            }

            return false; //Quyền tài khoản nhân viên
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (true)
                {
                Menu formMenu = new Menu(this.KiemTraQuyen(txtTenDangNhap.Text, txtMatKhau.Text));
                this.Hide();
                formMenu.Closed += (s, args) => this.Close();
                formMenu.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ!",
                    "Lỗi đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMatKhau.ResetText();
            txtTenDangNhap.ResetText();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thoát chương trình",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
