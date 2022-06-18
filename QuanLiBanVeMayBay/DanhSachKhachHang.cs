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
    public partial class DanhSachKhachHang : Form
    {

        public bool QuyenCRUD;
        public DanhSachKhachHang(bool quyenCRUD)
        {
            this.QuyenCRUD = quyenCRUD;
            InitializeComponent();
        }
        public void CapNhatQuyen(bool quyenCRUD)
        {
            if (!quyenCRUD)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        DbKhachHang db = new DbKhachHang();
        DataSet ds = new DataSet();

        //Cờ của tìm kiếm thông thường
        const byte TK_MA = 0;
        const byte TK_TEN = 1;
        const byte TK_DIACHI = 2;
        //Cờ của phím reload
        const byte RES_TKTT = 1;
        const byte RES_TKTQ = 3;
        byte RES_flag = 0;

        private void DataBind()
        {
            ds = db.getKhachHangs();
            dgvKhachHang.DataSource = ds.Tables[0];
            txtTim.DataBindings.Clear();
            txtTim.DataBindings.Add("Text", ds.Tables[0], "Mã khách hàng");
        }      

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            CapNhatQuyen(this.QuyenCRUD);
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTim.ResetText();
            txtTim.Text = "Nhập thông tin vào đây";
            DataBind();
        }

        private void rdbMaKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = true;
            txtDiaChiKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = false;
            btnTimKiem.Enabled = true;
        }

        private void rdbTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            txtDiaChiKhachHang.Enabled = false;
            txtTenKhachHang.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void rdbDiaChiKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = false;
            txtDiaChiKhachHang.Enabled = true;
            txtTenKhachHang.Enabled = false;
            btnTimKiem.Enabled = true;
        }
        //Tìm kiếm thông thường
        private void btnTImKiem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            string err = "";

            try
            {
                if (rdbMaKhachHang.Checked == true)
                {
                    kh.MaKhachHang = txtMaKhachHang.Text;
                    ds = db.searchKhachHang(ref err, TK_MA, kh);
                }
                else if (rdbTenKhachHang.Checked == true)
                {
                    kh.TenKhachHang = txtTenKhachHang.Text;
                    ds = db.searchKhachHang(ref err, TK_TEN, kh);
                }
                else if (rdbDiaChiKhachHang.Checked == true)
                {
                    kh.DiaChi = txtDiaChiKhachHang.Text;
                    ds = db.searchKhachHang(ref err, TK_DIACHI, kh);
                }
                RES_flag = RES_TKTT;
                dgvKhachHang.DataSource = ds.Tables[0];
                txtTim.DataBindings.Clear();
                txtTim.DataBindings.Add("Text", ds.Tables[0], "Mã khách hàng");
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (RES_flag == RES_TKTT)
            {
                btnTImKiem_Click(sender, e);
            }            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKhachHang = txtTim.Text;
            kh.HoKhachHang = txtTim.Text;
            kh.TenKhachHang = txtTim.Text;
            kh.TenLotKhachHang = txtTim.Text;
            kh.SoDienThoai = txtTim.Text;
            kh.DiaChi = txtTim.Text;
            kh.CMND = txtTim.Text;
            string err = "";

            ds = db.general_search_KhachHang(ref err, kh);
            dgvKhachHang.DataSource = ds.Tables[0];
            txtTim.DataBindings.Clear();
            txtTim.DataBindings.Add("Text", ds.Tables[0], "Mã khách hàng");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                DialogResult tl = MessageBox.Show("Bạn muốn xóa khách hàng khỏi CSDL?", "Xóa",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKhachHang = txtTim.Text;
                    if (!db.deleteKhachHang(ref err, kh))
                        MessageBox.Show("Xóa thất bại!!!");
                    else
                    {
                        MessageBox.Show("Xóa thành công!!!");
                        btnReload_Click(sender, e);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CapNhatKhachHang cnkh = new CapNhatKhachHang();
            cnkh.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CapNhatKhachHang cnkh = new CapNhatKhachHang();
            cnkh.Show();
        }
    }
}
