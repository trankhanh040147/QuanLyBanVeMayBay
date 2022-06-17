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

        public bool QuyenCRUD;
        public DanhSachMayBay()
        {
            InitializeComponent();
        }

        public DanhSachMayBay(bool quyenCRUD)
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

        /* mẫu */
        private DbMaybay db = new DbMaybay();
        private DataSet ds = new DataSet();
        private void DanhSachMayBay_Load(object sender, EventArgs e)
        {
            DataBind();
            CapNhatQuyen(this.QuyenCRUD);
        }
        private void DataBind()
        {
            ds = db.getMayBays();
            dgvMayBay.DataSource = ds.Tables[0];
        }

        private void rdbTenMayBay_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
