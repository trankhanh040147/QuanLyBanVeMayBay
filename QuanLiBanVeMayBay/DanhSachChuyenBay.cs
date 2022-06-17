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
    public partial class DanhSachChuyenBay : Form
    {
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

        public DanhSachChuyenBay()
        {
            InitializeComponent();
        }

        private void DanhSachChuyenBay_Load(object sender, EventArgs e)
        {
            CapNhatQuyen(this.QuyenCRUD);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
