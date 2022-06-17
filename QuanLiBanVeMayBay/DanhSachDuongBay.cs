using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using BussinessLogicLayer;
using DataAccessLayer;

namespace QuanLyBanVeMayBay
{
    public partial class DanhSachDuongBay : Form
    {
        DbDuongBay db = new DbDuongBay();
        DataSet ds = new DataSet();

        //Cờ của tìm kiếm thông thường
        const byte TK_MA = 0;
        const byte TK_VITRI = 1;
        const byte TK_TINHTRANG = 2;
        //Cờ của tìm kiếm nâng cao
        const byte ATK_CHIEUDAI = 0;
        const byte ATK_CHIEURONG = 1;
        const byte ATK_TINHTRANG = 2;
        //Cờ của phím reload
        const byte RES_TKTT = 1;
        const byte RES_TKNC = 2;
        const byte RES_TKTQ = 3;
        byte RES_flag = 0;
        


        private void DataBind()
        {
            ds = db.getDuongBays();
            dgvDuongBay.DataSource = ds.Tables[0];
            txtTim.DataBindings.Add("Text", ds.Tables[0], "Mã đường bay");
        }

        public DanhSachDuongBay()
        {
            InitializeComponent();
        }

        private void DanhSachDuongBay_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void rdbMaDuongBay_CheckedChanged(object sender, EventArgs e)
        {
            btnTimThongThuong.Enabled = true;
            txtMaDuongBay.Enabled = true;
            txtViTri.Enabled = false;
        }
        //Tìm kiếm thông thường
        private void btnTimThongThuong_Click(object sender, EventArgs e)
        {
            DuongBay temp_db = new DuongBay();
            string err = "";
            try
            {
                if (chkDangSuDung1.Checked == true)
                {
                    temp_db.TinhTrang = "Dang su dung";
                }
                else
                    temp_db.TinhTrang = "Ranh";

                if (rdbMaDuongBay.Checked == true)
                {
                    temp_db.MaDuongBay = txtMaDuongBay.Text;
                    ds = db.normal_search_DuongBay(ref err, TK_MA, temp_db);
                }
                else if (rdbVitri.Checked == true)
                {
                    temp_db.ViTri = txtViTri.Text;
                    ds = db.normal_search_DuongBay(ref err, TK_VITRI, temp_db);
                }
                else
                {
                    ds = db.normal_search_DuongBay(ref err, TK_TINHTRANG, temp_db);
                }
                
                RES_flag = RES_TKTT;
                dgvDuongBay.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void rdbVitri_CheckedChanged(object sender, EventArgs e)
        {
            btnTimThongThuong.Enabled = true;
            txtViTri.Enabled = true;
            txtMaDuongBay.Enabled = false;
        }

        private void rdbChieuDai_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom.Enabled = true;
            txtTo.Enabled = true;
            btnTimDaNang.Enabled = true;
            chkDangSuDung2.Enabled = true;
        }

        private void rdbChieuRong_CheckedChanged(object sender, EventArgs e)
        {
            txtFrom.Enabled = true;
            txtTo.Enabled = true;
            btnTimDaNang.Enabled = true;
            chkDangSuDung2.Enabled = true;
        }

        private void chkDangSuDung1_CheckedChanged(object sender, EventArgs e)
        {
            btnTimThongThuong.Enabled = true;
        }

        private void chkDangSuDung2_CheckedChanged(object sender, EventArgs e)
        {
            btnTimThongThuong.Enabled = true;
        }
        //Tìm kiếm đa năng
        private void btnTimDaNang_Click(object sender, EventArgs e)
        {
            DuongBay temp_db = new DuongBay();
            string err = "";
            int start = 0;
            int end = 0;
            if (txtFrom.Text != "")
            {
                start = Convert.ToInt32(txtFrom.Text);
            }
            if (txtTo.Text != "")
            {
                end = Convert.ToInt32(txtTo.Text);
            }

            try
            {
                if (chkDangSuDung2.Checked == true )
                {
                    temp_db.TinhTrang = "Dang su dung";
                }
                else
                    temp_db.TinhTrang = "Ranh";

                if (rdbChieuDai.Checked == true && start != 0 && end != 0)
                {
                    
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_CHIEUDAI, temp_db, start, end);
                }
                else if (rdbChieuRong.Checked == true && start != 0 && end != 0)
                {
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_CHIEURONG, temp_db, start, end);
                }
                else
                {
                    ds = db.advanced_Search_ChuyenBay(ref err, ATK_TINHTRANG, temp_db, 0, 0);
                }
                RES_flag = RES_TKNC;
                dgvDuongBay.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string err = "";
            DuongBay temp_db = new DuongBay();
            temp_db.MaDuongBay = txtTim.Text;
            temp_db.ViTri = txtTim.Text;           
            temp_db.TinhTrang = txtTim.Text;
            try
            {
                ds = db.general_search_DuongBay(ref err, temp_db);

                dgvDuongBay.DataSource = ds.Tables[0];

                RES_flag = RES_TKTQ;
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
                btnTimThongThuong_Click(sender, e);
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
    }
}
