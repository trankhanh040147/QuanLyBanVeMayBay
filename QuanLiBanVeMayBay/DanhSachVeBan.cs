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
    public partial class DanhSachVeBan : Form
    {

        //Cờ của tìm kiếm thông thường
        const byte TK_MAVE = 0;
        const byte TK_MAVEBAN = 1;
        const byte TK_MANHANVIEN = 2;
        const byte TK_MAKHACHHANG = 3;
        //Cờ của tìm kiếm nâng cao 
        const byte ATK_SOLUONG = 0;
        const byte ATK_TONGTIEN = 1;
        const byte ATK_TGBAN = 2;
        const byte ATK_TGTHANHTOAN = 3;
        //Cờ của phím reload
        const byte RES_TKTT = 1;
        const byte RES_TKNC = 2;
        const byte RES_TKTQ = 3;
        byte RES_flag = 0;
        public DanhSachVeBan()
        {
            InitializeComponent();
        }
        DbVeBan db = new DbVeBan();
        DataSet ds = new DataSet();

        private void DataBind()
        {
            ds = db.getVeBans();
            dgvVeBan.DataSource = ds.Tables[0];
            txtTim.DataBindings.Clear();
            txtTim.DataBindings.Add("text", ds.Tables[0], "Mã vé bán");
        }
        private void grbKhoangThoiGian_Enter(object sender, EventArgs e)
        {

        }

        private void DanhSachVeBan_Load(object sender, EventArgs e)
        {
            txtTim.ForeColor = Color.LightGray;
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
            DataBind();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
          
        }



        private void txtTim_MouseClick(object sender, MouseEventArgs e)
        {
            txtTim.ResetText();
            txtTim.ForeColor = Color.Black;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTim.ResetText();
            txtTim.Text = "Nhập thông tin vào đây";
            DataBind();
        }

        private void rdbMaVe_CheckedChanged(object sender, EventArgs e)
        {
            txtMaVe.Enabled = true;
            txtMaVeBan.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaKhachHang.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void rdbMaVeban_CheckedChanged(object sender, EventArgs e)
        {
            txtMaVe.Enabled = false;
            txtMaVeBan.Enabled = true;
            txtMaNhanVien.Enabled = false;
            txtMaKhachHang.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void rdbMaNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txtMaVe.Enabled = false;
            txtMaVeBan.Enabled = false;
            txtMaNhanVien.Enabled = true;
            txtMaKhachHang.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void rdbMaKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txtMaVe.Enabled = false;
            txtMaVeBan.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaKhachHang.Enabled = true;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void btnTimKiemThongThuong_Click(object sender, EventArgs e)
        {
            VeBan vb = new VeBan();
            string err = "";
            try
            {
                if (rdbMaVe.Checked == true)
                {
                    vb.MaVe = txtMaVe.Text;
                    ds = db.normal_Search_VeBan(ref err, TK_MAVE, vb);
                }
                else if (rdbMaVeban.Checked == true)
                {
                    vb.MaVeBan = txtMaVeBan.Text;
                    ds = db.normal_Search_VeBan(ref err, TK_MAVEBAN, vb);
                }
                else if (rdbMaNhanVien.Checked == true)
                {
                    vb.MaNhanVien = txtMaNhanVien.Text;
                    ds = db.normal_Search_VeBan(ref err, TK_MANHANVIEN, vb);
                }
                else if (rdbMaKhachHang.Checked == true)
                {
                    vb.MaKhachHang = txtMaKhachHang.Text;
                    ds = db.normal_Search_VeBan(ref err, TK_MAKHACHHANG, vb);
                }

                RES_flag = RES_TKTT;
                dgvVeBan.DataSource = ds.Tables[0]; 
                txtTim.DataBindings.Clear();
                txtTim.DataBindings.Add("text", ds.Tables[0], "Mã vé bán");
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
                btnTimKiemThongThuong_Click(sender, e);
            }
            else if (RES_flag == RES_TKNC)
            {
                btnTimDaNang_Click(sender, e);
            }
            else if (RES_flag == RES_TKTQ)
            {
                btnTim_Click(sender, e);
            }
        }

        private void btnTimDaNang_Click(object sender, EventArgs e)
        {
            VeBan vb = new VeBan();
            string err = "";
            int start = 0;
            int end = 0;
            DateTime start_date = new DateTime();
            DateTime end_date = new DateTime();

            if (rdbSLveban.Checked == true)
            {
                start = Convert.ToInt32(txtFrom1.Text);
                end = Convert.ToInt32(txtTo1.Text);
                ds = db.advanced_Search_VeBan(ref err, ATK_SOLUONG, start, end, start_date, end_date);
            }
            else if (rdbTongTien.Checked == true)
            {
                start = Convert.ToInt32(txtFrom1.Text);
                end = Convert.ToInt32(txtTo1.Text);
                ds = db.advanced_Search_VeBan(ref err, ATK_TONGTIEN, start, end, start_date, end_date);
            }
            else if (rdbThoiGianBan.Checked == true)
            {
                start_date = dtpFrom.Value;
                end_date = dtpTo.Value;
                ds = db.advanced_Search_VeBan(ref err, ATK_TGBAN, start, end, start_date, end_date);
            }
            else if (rdbThoiGianThanhToan.Checked == true)
            {
                start_date = dtpFrom.Value;
                end_date = dtpTo.Value;
                ds = db.advanced_Search_VeBan(ref err, ATK_TGTHANHTOAN, start, end, start_date, end_date);
            }
            RES_flag = RES_TKNC;
            dgvVeBan.DataSource = ds.Tables[0];
            txtTim.DataBindings.Clear();
            txtTim.DataBindings.Add("text", ds.Tables[0], "Mã vé bán");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string err = "";
            VeBan vb = new VeBan();
            vb.MaVe = txtTim.Text;
            vb.MaVeBan = txtTim.Text;
            vb.MaKhachHang = txtTim.Text;
            vb.MaNhanVien = txtTim.Text;

            ds = db.general_Search_VeBan(ref err, vb);

            RES_flag = RES_TKTQ;
            dgvVeBan.DataSource = ds.Tables[0];
            txtTim.DataBindings.Clear();
            txtTim.DataBindings.Add("text", ds.Tables[0], "Mã vé bán");
        }

        private void rdbSLveban_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom1.Enabled = true;
            txtTo1.Enabled = true;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            btnTimDaNang.Enabled = true;
        }

        private void rdbTongTien_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom1.Enabled = true;
            txtTo1.Enabled = true;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            btnTimDaNang.Enabled = true;
        }

        private void rdbThoiGianBan_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom1.Enabled = false;
            txtTo1.Enabled = false;
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            btnTimDaNang.Enabled = true;
        }

        private void rdbThoiGianThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom1.Enabled = false;
            txtTo1.Enabled = false;
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            btnTimDaNang.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa vé bán khỏi CSDL?", "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                VeBan vb = new VeBan();
                string err = "";
                vb.MaVeBan = txtTim.Text;
                if (!db.deleteVeBan(ref err, vb))
                    MessageBox.Show("Xóa thất bại!!!");
                else
                {
                    MessageBox.Show("Xóa thành công!!!");
                    btnReload_Click(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
