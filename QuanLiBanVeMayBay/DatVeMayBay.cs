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
    public partial class DatVeMayBay : Form
    {
        public DatVeMayBay()
        {
            InitializeComponent();
        }

        private QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        private DbVeBan dbvb = new DbVeBan();
        private DbKhachHang dbkh = new DbKhachHang();
        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            VeBan vb = new VeBan();
            KhachHang kh = new KhachHang();
            //Kiểm tra Khách hàng đã có trong CSDL chưa
            var checkKH = dbs.KhachHangs.Find(txtCMND.Text);
            bool check;
            if (checkKH != null)
                check = true;
            else
                check = false;
            string err = "";
            if (check == false)
            {
                string HoTenKH = txtTenKhachHang.Text.Trim();
                kh.HoKhachHang = HoTenKH.Substring(0, HoTenKH.IndexOf(' '));
                kh.TenLotKhachHang = HoTenKH.Substring(HoTenKH.IndexOf(' ') + 1, HoTenKH.LastIndexOf(' ') - kh.HoKhachHang.Length - 1);
                kh.TenKhachHang = HoTenKH.Substring(HoTenKH.LastIndexOf(' ') + 1);
                kh.SoDienThoai = txtSoDienThoai.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.CMND = txtCMND.Text;
                if (dbkh.insertKhachHang(ref err, kh))
                {
                    var kh1 = dbs.KhachHangs.FirstOrDefault(p => p.CMND == txtCMND.Text);
                    var ThongTinVe = dbs.ThongTinChiTietVes.Where(p => p.LoaiVe.Contains(lstLoaiVe.SelectedItem.ToString())).FirstOrDefault();
                    var NhanVien = dbs.NhanViens.FirstOrDefault(p => p.TenNhanVien.Contains(lblNhanvienHoTro.Text));
                    if (kh1 == null)
                    {
                        vb.MaKhachHang = kh1.MaKhachHang;
                        vb.MaVe = ThongTinVe.MaVe;
                        vb.TongTien = int.Parse(txtTongTien.Text);
                        vb.ThoiGianBan = DateTime.Now;
                        vb.ThoiGianThanhToan = DateTime.Now;
                        vb.MaNhanVien = NhanVien.MaNhanVien;
                        vb.SoLuongHangHoa = int.Parse(txtSoHangHoa.Text);
                        vb.SLVeBan = int.Parse(txtSoVeDat.Text);
                        if (!dbvb.insertVeBan(ref err, vb))
                            MessageBox.Show("Thất bại!!!");
                        else
                        {
                            MessageBox.Show("Thành công!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Thất bại!!!");
                }
            }
            else
            {
                var kh1 = dbs.KhachHangs.FirstOrDefault(p => p.CMND == txtCMND.Text);
                var ThongTinVe = dbs.ThongTinChiTietVes.Where(p => p.LoaiVe.Contains(lstLoaiVe.SelectedItem.ToString())).FirstOrDefault();
                var NhanVien = dbs.NhanViens.FirstOrDefault(p=>p.TenNhanVien.Contains(lblNhanvienHoTro.Text));
                if (kh1 == null)
                {
                    vb.MaKhachHang = kh1.MaKhachHang;
                    vb.MaVe = ThongTinVe.MaVe;
                    vb.TongTien = int.Parse(txtTongTien.Text);
                    vb.ThoiGianBan = DateTime.Now;
                    vb.ThoiGianThanhToan = DateTime.Now;
                    vb.MaNhanVien = NhanVien.MaNhanVien;
                    vb.SoLuongHangHoa = int.Parse(txtSoHangHoa.Text);
                    vb.SLVeBan = int.Parse(txtSoVeDat.Text); 
                    if (!dbvb.insertVeBan(ref err, vb))
                        MessageBox.Show("Thất bại!!!");
                    else
                    {
                        MessageBox.Show("Thành công!!!");
                    }
                }

            }
        }

        private void btnTinhTongTien_Click(object sender, EventArgs e)
        {
            float KhuyenMai = float.Parse(cbKhuyenMai.SelectedItem.ToString());
            float GiaVe = float.Parse(txtGiaVe.Text);
            float SoVeDat = float.Parse(txtSoVeDat.Text);
            float VAT = float.Parse(txtThueVAT.Text);
            float TongTien = (GiaVe + GiaVe * VAT / 100 - GiaVe * KhuyenMai / 100)*SoVeDat;
            txtTongTien.Text = TongTien.ToString();
        }
        private void DatVeMayBay_Load(object sender, EventArgs e)
        {
            var dsChuyenBay = dbs.ChuyenBays.Select(p => p);
            foreach (var i in dsChuyenBay)
            {
                cbMaChuyenBay.Items.Add(i.MaChuyenBay);
            }
            lstLoaiVe.Items.Add("Loai 1");
            lstLoaiVe.Items.Add("Loai 2");
            cbKhuyenMai.Items.Add("5");
            cbKhuyenMai.Items.Add("7");
            cbKhuyenMai.Items.Add("10");
        }

        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ChuyenBay = dbs.ChuyenBays.FirstOrDefault(p => p.MaChuyenBay == cbMaChuyenBay.SelectedItem.ToString());
            var ThongTinVe = dbs.ThongTinChiTietVes.Where(p => p.MaChuyenBay.Equals(ChuyenBay)).Select(p => p);
            foreach (var i in ThongTinVe)
            {
                if (i.LoaiVe == "1")
                    txtVeLoai1ConLai.Text = i.SoLuongCon.ToString();
                else
                    txtVeLoai2ConLai.Text = i.SoLuongCon.ToString();
            }
            txtChuyenbay.Text = ChuyenBay.MaChuyenBay;
            txtMaDuongBay.Text = ChuyenBay.MaDuongBay;
            txtMaMayBay.Text = ChuyenBay.MaMayBay;
            txtNgayDi.Text = ChuyenBay.NgayDi.ToString();
            txtNgayDen.Text = ChuyenBay.NgayDen.ToString();
            txtGioDi.Text = ChuyenBay.GioBay.ToString();
            txtDiemDi.Text = ChuyenBay.DiemDi;
            txtDiemDen.Text = ChuyenBay.DiemDen;
            txtGhiChu.Text = ChuyenBay.GhiChu;
        }

        private void lstLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {

            var ThongTinVe = dbs.ThongTinChiTietVes.Where(p => p.LoaiVe.Contains(lstLoaiVe.SelectedItem.ToString())).FirstOrDefault();
            txtGiaVe.Text = ThongTinVe.Gia.ToString();
        }
    }
}
