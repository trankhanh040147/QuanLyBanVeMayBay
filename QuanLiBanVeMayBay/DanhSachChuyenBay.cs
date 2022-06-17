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
    public partial class DanhSachChuyenBay : Form
    {
        //Tim Kiem Thong Thuong
        const byte TK_MA = 0;
        const byte TK_GIO = 1;
        const byte TK_NGAYDEN = 2;
        const byte TK_NGAYDI = 3;

        //Tim Kiem Nang Cao
        const byte ATK_GIO = 0;
        const byte ATK_NGAYDI = 1;
        const byte ATK_NGAYDEN = 2;

        //Reset
        const byte RES_TKTT = 1;
        const byte RES_TKNC = 2;
        const byte RES_TKTQ = 3;
        byte RES_flag = 0;

        public bool QuyenCRUD;

        public DanhSachChuyenBay(bool quyenCRUD)
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
        DbChuyenBay db = new DbChuyenBay();
        DataSet ds = new DataSet();
        DataSet reset_ds = new DataSet();
        private void DataBind()
        {
            ds = db.getChuyenBays();
            dgvChuyenBay.DataSource = ds.Tables[0];
        }
        private void DanhSachChuyenBay_Load(object sender, EventArgs e)
        {
            CapNhatQuyen(this.QuyenCRUD);
            DataBind();
        }

        private void rdbGioBay_CheckedChanged(object sender, EventArgs e)
        {
            dtpGioBay.Enabled = true;
            dtpNgaydi.Enabled = false;
            dtpNgayden.Enabled = false;
            txtMachuyenbay.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void btnTimKiemThongThuong_Click(object sender, EventArgs e)
        {
            ChuyenBay cb = new ChuyenBay();
            string err = "";
            try
            {
                if (rdbGioBay.Checked == true)
                {
                    cb.GioBay = dtpGioBay.Value.TimeOfDay;
                    ds = db.searchChuyenBay(ref err, TK_GIO, cb);
                }
                else if (rdbNgayDi.Checked == true)
                {
                    cb.NgayDi = dtpNgaydi.Value;
                    ds = db.searchChuyenBay(ref err, TK_NGAYDI, cb);
                }
                else if (rdbNgayDen.Checked == true)
                {
                    cb.NgayDen = dtpNgayden.Value;
                    ds = db.searchChuyenBay(ref err, TK_NGAYDEN, cb);
                }
                else if (rdbMachuyenbay.Checked == true)
                {
                    cb.MaChuyenBay = txtMachuyenbay.Text;
                    ds = db.searchChuyenBay(ref err, TK_MA, cb);
                }
                RES_flag = RES_TKTT;
                dgvChuyenBay.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void rdbNgayDi_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgaydi.Enabled = true;
            dtpGioBay.Enabled = false;
            dtpNgayden.Enabled = false;
            txtMachuyenbay.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void rdbNgayDen_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayden.Enabled = true;
            dtpGioBay.Enabled = false;
            dtpNgaydi.Enabled = false;
            txtMachuyenbay.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
        }

        private void rdbMachuyenbay_CheckedChanged(object sender, EventArgs e)
        {
            txtMachuyenbay.Enabled = true;
            dtpNgayden.Enabled = false;
            dtpGioBay.Enabled = false;
            dtpNgaydi.Enabled = false;
            btnTimKiemThongThuong.Enabled = true;
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

        private void rdbKhoanggiobay_CheckedChanged(object sender, EventArgs e)
        {
            dtpGioFrom.Enabled = true;
            dtpGioTo.Enabled = true;
            dtpTgFrom.Enabled = false;
            dtpTgTo.Enabled = false;
            btnTimDaNang.Enabled = true;
        }

        private void rdbKhoangtgdi_CheckedChanged(object sender, EventArgs e)
        {
            dtpGioFrom.Enabled = false;
            dtpGioTo.Enabled = false;
            dtpTgFrom.Enabled = true;
            dtpTgTo.Enabled = true;
            btnTimDaNang.Enabled = true;
        }

        private void rdbKhoangtgden_CheckedChanged(object sender, EventArgs e)
        {
            dtpGioFrom.Enabled = false;
            dtpGioTo.Enabled = false;
            dtpTgFrom.Enabled = true;
            dtpTgTo.Enabled = true;
            btnTimDaNang.Enabled = true;
        }

        private void btnTimDaNang_Click(object sender, EventArgs e)
        {
            ChuyenBay cb = new ChuyenBay();
            string err = "";
            TimeSpan start_hour = new TimeSpan();
            TimeSpan end_hour = new TimeSpan();
            DateTime start_day = new DateTime();
            DateTime end_day = new DateTime();
            try
            {
                if (rdbKhoanggiobay.Checked == true)
                {
                    start_hour = dtpGioFrom.Value.TimeOfDay;
                    end_hour = dtpGioTo.Value.TimeOfDay;
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_GIO, start_hour, end_hour, start_day, end_day);
                }
                else if (rdbKhoangtgdi.Checked == true)
                {
                    start_day = dtpTgFrom.Value;
                    end_day = dtpTgTo.Value;
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_NGAYDI, start_hour, end_hour, start_day, end_day);
                }
                else if (rdbKhoangtgden.Checked == true)
                {
                    start_day = dtpTgFrom.Value;
                    end_day = dtpTgTo.Value;
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_NGAYDEN, start_hour, end_hour, start_day, end_day);
                }
                RES_flag = RES_TKNC;
                dgvChuyenBay.DataSource = ds.Tables[0];
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            string err = "";
            ChuyenBay cb = new ChuyenBay();
            cb.MaMayBay = txtTim.Text;
            cb.MaDuongBay = txtTim.Text;
            cb.MaChuyenBay = txtTim.Text;
            cb.GhiChu = txtTim.Text;
            cb.DiemDen = txtTim.Text;
            cb.DiemDi = txtTim.Text;
            try
            {
                ds = db.general_Search_ChuyenBay(ref err, cb);

                dgvChuyenBay.DataSource = ds.Tables[0];

                RES_flag = RES_TKTQ;
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
            
        }
    }
}
