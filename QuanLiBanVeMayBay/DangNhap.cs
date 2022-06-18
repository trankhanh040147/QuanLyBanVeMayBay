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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DbNhanVien db = new DbNhanVien();
        public bool KiemTraQuyen(string tendangnhap, string matkhau)
        {
            QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
            
            // Code kiểm tra tài có quyền AD hay không
            var nv_search = dbs.NhanViens
                    .FirstOrDefault(p => p.TenDangNhap == tendangnhap && p.MatKhau == matkhau);
            if (nv_search.ChucVu.Contains("Quan tri"))                  
                return true;//Quyền tài khoản AD
            return false; //Quyền tài khoản nhân viên
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.checkNhanVien_thongtindangnhap(txtTenDangNhap.Text, txtMatKhau.Text))
                {
                    Menu formMenu = new Menu(this.KiemTraQuyen(txtTenDangNhap.Text, txtMatKhau.Text),txtTenDangNhap.Text);
                    this.Hide();
                    formMenu.Closed += (s, args) => this.Close();
                    formMenu.Show();
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!",
                        "Lỗi đăng nhập",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMatKhau.ResetText();
            txtTenDangNhap.ResetText();
            txtTenDangNhap.Focus();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
