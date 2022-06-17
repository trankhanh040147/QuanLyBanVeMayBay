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
    public partial class DanhSachDuongBay : Form
    {
        public bool QuyenCRUD;
        public DanhSachDuongBay()
        {
            InitializeComponent();
        }
        public DanhSachDuongBay(bool quyenCRUD)
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

        private void DanhSachDuongBay_Load(object sender, EventArgs e)
        {
            CapNhatQuyen(this.QuyenCRUD);
        }
    }
}
