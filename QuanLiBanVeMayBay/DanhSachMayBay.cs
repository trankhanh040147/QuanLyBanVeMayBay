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
namespace QuanLyBanVeMayBay
{
    public partial class DanhSachMayBay : Form
    {
        
        public DanhSachMayBay()
        {
            InitializeComponent();
        }

        /* mẫu */
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
        }

        private void rdbTenMayBay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
