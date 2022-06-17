using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using DataAccessLayer;
using BussinessLogicLayer;

namespace QuanLyBanVeMayBay
{
    public partial class DanhSachNhanVien : Form
    {
        public bool QuyenCRUD;
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public DanhSachNhanVien()
        {
            InitializeComponent();
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        public DanhSachNhanVien(bool quyenCRUD)
        {
            InitializeComponent();
            this.QuyenCRUD = quyenCRUD;
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
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
        DbNhanVien dbnv = new DbNhanVien();
        DataSet ds = new DataSet();

        //Cờ cho nút tìm kiếm thông thường
        const byte TK_MA = 0;
        const byte TK_TEN = 1;
        const byte TK_DIACHI = 2;

        //Cờ cho nút Reset
        const byte RES_TKTT = 1;
        const byte RES_TKTQ = 2;
        byte RES_flag = 0;
        private void DataBind()
        {
            ds = dbnv.getNhanViens();
            dgvNhanVien.DataSource = ds.Tables[0];
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            CapNhatQuyen(this.QuyenCRUD);
            DataBind();
        }

        private void btnTImKiem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            string err = "";
            try
            {
                if (rdbMaNhanVien.Checked == true)
                {
                    nv.MaNhanVien = txtMaNhanVien.Text;
                    ds = dbnv.search_NhanVien(ref err, TK_MA, nv);
                }
                else if (rdbTenNhanVien.Checked == true)
                {
                    nv.TenNhanVien = txtTenNhanVien.Text;
                    ds = dbnv.search_NhanVien(ref err, TK_TEN, nv);
                }
                else if (rdbDiaChiNhanVien.Checked == true)
                {
                    nv.DiaChi = txtDiaChiNhanVien.Text;
                    ds = dbnv.search_NhanVien(ref err, TK_DIACHI, nv);
                }                
                RES_flag = RES_TKTT;
                dgvNhanVien.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void rdbMaNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            rdbTenNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            rdbDiaChiNhanVien.Enabled = false;
            txtDiaChiNhanVien.Enabled = false;
            btnTImKiem.Enabled = true;
        }

        private void rdbTenNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Enabled = true;
            rdbMaNhanVien.Enabled = false;
            txtMaNhanVien.Enabled = false;
            rdbDiaChiNhanVien.Enabled = false;
            txtDiaChiNhanVien.Enabled = false;
            btnTImKiem.Enabled = true;
        }

        private void rdbDiaChiNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txtDiaChiNhanVien.Enabled = true;
            rdbMaNhanVien.Enabled = false;
            txtMaNhanVien.Enabled = false;
            rdbTenNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            btnTImKiem.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (RES_flag == RES_TKTT)
            {
                btnTImKiem_Click(sender, e);
            }
            else if (RES_flag == RES_TKTQ)
            {
                btnTim_Click(sender, e);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa nhân viên khỏi CSDL?", "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                NhanVien nv = new NhanVien();
                string err = "";
                nv.MaNhanVien = txtTim.Text;
                if (!dbnv.deleteNhanVien(ref err, nv))
                    MessageBox.Show("Xóa thất bại!!!");
                else
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
            DataBind();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string err = "";
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtTim.Text;
            nv.TenNhanVien = txtTim.Text;
            nv.HoNhanVien = txtTim.Text;
            nv.TenLotNhanVien = txtTim.Text;
            nv.SoDienThoai = txtTim.Text;
            nv.DiaChi = txtTim.Text;
            nv.ChucVu = txtTim.Text;
            try
            {
                ds = dbnv.general_Search_NhanVien(ref err, nv);

                dgvNhanVien.DataSource = ds.Tables[0];

                RES_flag = RES_TKTQ;
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
