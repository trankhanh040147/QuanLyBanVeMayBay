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
    public partial class DanhSachMayBay : Form
    {
        //Cờ của tìm kiếm thông thường
        const byte TK_MA = 0;
        const byte TK_TEN = 2;
        const byte TK_HANG = 1;
        //Cờ của reset button
        const byte RES_TKTT = 1;
        const byte RES_TKNC = 2;
        const byte RES_TKTQ = 3;
        byte RES_flag = 0;
        //Cờ của tìm kiếm nâng cao
        const byte ATK_KICHTHUOC = 0;
        const byte ATK_SOGHEL1 = 1;
        const byte ATK_SOGHEL2 = 2;
        const byte ATK_TONG = 3;
        public DanhSachMayBay()
        {
            InitializeComponent();
        }

        private DbMaybay db = new DbMaybay();
        private DataSet ds = new DataSet();
        private void DanhSachMayBay_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        private void DataBind()
        {
            ds = db.getMayBays();
            dgvMayBay.DataSource = ds.Tables[0];
            txtTim.DataBindings.Add("Text", ds.Tables[0], "Mã Máy Bay");
        }

        private void rdbTenMayBay_CheckedChanged(object sender, EventArgs e)
        {
            txtMaMayBay.Enabled = false;
            txtTenMayBay.Enabled = true;
            txtHangSX.Enabled = false;
            btnTimThongThuong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn xóa máy bay khỏi CSDL?", "Xóa",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                MayBay mb = new MayBay();
                string err = "";
                mb.MaMayBay = txtTim.Text;
                if (!db.deleteMayBay(ref err, mb))
                    MessageBox.Show("Loi");
                else
                {
                    MessageBox.Show("Thành công!!!"); 
                }
            }
            DataBind();
        }

        private void rdbMaMayBay_CheckedChanged(object sender, EventArgs e)
        {
            txtMaMayBay.Enabled = true;
            txtTenMayBay.Enabled = false;
            txtHangSX.Enabled = false;
            btnTimThongThuong.Enabled = true;
        }

        private void rdbHangSX_CheckedChanged(object sender, EventArgs e)
        {
            txtMaMayBay.Enabled = false;
            txtTenMayBay.Enabled = false;
            txtHangSX.Enabled = true;
            btnTimThongThuong.Enabled = true;
        }

        private void btnTimThongThuong_Click(object sender, EventArgs e)
        {
            MayBay mb = new MayBay();
            string err = "";
            try
            {
                if (rdbMaMayBay.Checked == true)
                {
                    mb.MaMayBay = txtMaMayBay.Text;
                    ds = db.normal_Search_MayBay(ref err, TK_MA, mb);
                }
                else if (rdbTenMayBay.Checked == true)
                {
                    mb.TenMayBay = txtTenMayBay.Text;
                    ds = db.normal_Search_MayBay(ref err, TK_TEN, mb);
                }
                else if (rdbHangSX.Checked == true)
                {
                    mb.HangSanXuat = txtHangSX.Text;
                    ds = db.normal_Search_MayBay(ref err, TK_HANG, mb);
                }
                
                RES_flag = RES_TKTT;
                dgvMayBay.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show(err);
            }
        }

        private void btnTimDaNang_Click(object sender, EventArgs e)
        {
            MayBay mb = new MayBay();
            string err = "";
            int start = Convert.ToInt32(txtFrom.Text);
            int end = Convert.ToInt32(txtTo.Text);

            if (rdbKichThuoc.Checked == true)
            {
                ds = db.advanced_Search_MayBay(ref err, ATK_KICHTHUOC, start, end);
            }
            else if (rdbSoGheLoai1.Checked == true)
            {
                ds = db.advanced_Search_MayBay(ref err, ATK_SOGHEL1, start, end);
            }
            else if (rdbSoGheLoai2.Checked == true)
            {
                ds = db.advanced_Search_MayBay(ref err, ATK_SOGHEL2, start, end);
            }
            else if (rdbTongSoGhe.Checked == true)
            {
                ds = db.advanced_Search_MayBay(ref err, ATK_TONG, start, end);
            }
            RES_flag = RES_TKNC;
            dgvMayBay.DataSource = ds.Tables[0];

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataBind();
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            string err = "";
            MayBay mb = new MayBay();
            mb.MaMayBay = txtTim.Text;
            mb.TenMayBay = txtTim.Text;
            mb.HangSanXuat = txtTim.Text;

            ds = db.general_search_MayBay(ref err, mb);

            dgvMayBay.DataSource = ds.Tables[0];
        }
    }
}
