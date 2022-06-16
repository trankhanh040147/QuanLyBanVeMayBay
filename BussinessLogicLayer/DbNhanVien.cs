using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Sử dụng dữ liệu từ tầng DataAccess
using DataAccessLayer;

namespace BussinessLogicLayer
{
    internal class DbNhanVien
    {

        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        static void Main(string[] args)
        {

            Console.WriteLine("Doneee.......");
        }
        
        //Lấy danh sách tất cả nhân viên
        public DataSet getNhanViens()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Họ nhân viên");
            dt.Columns.Add("Tên lót nhân viên");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Chức vụ");
            dt.Columns.Add("Tên đăng nhập");
            dt.Columns.Add("Mật khẩu");

            var dsNhanVien = dbs.NhanViens.Select(p => p);
            foreach (var i in dsNhanVien)
            {
                dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                      i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
            }
            ds.Tables.Add(dt);
            return ds;
        }
        
        //Tìm kiếm nhân viên theo mã khách hàng hoặc tên khách hàng hoặc địa chỉ khách hàng
        public DataSet search_NhanVien(KhachHang kh, int flag)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Họ nhân viên");
            dt.Columns.Add("Tên lót nhân viên");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Chức vụ");
            dt.Columns.Add("Tên đăng nhập");
            dt.Columns.Add("Mật khẩu");

            //Lựa chọn phương thức tìm kiếm
            switch(flag)
            {
                case 0://Tim bang ma khach hang
                    var dsVB = dbs.VeBans.Where(p => p.MaKhachHang == kh.MaKhachHang).Select(p => p);
                    var dsNV = dbs.NhanViens.Where(t => t.VeBans.Equals(dsVB)).Select(t => t);
                    foreach (var i in dsNV)
                    {
                        dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                              i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                    }
                    break;
                case 1://tim bang ten khach hang
                    var dsKH1 = dbs.KhachHangs.Where(p => p.TenKhachHang.Contains(kh.TenKhachHang)).Select(p=>p);
                    var dsVB1 = dbs.VeBans.Where(t => t.MaKhachHang.Equals(dsKH1)).Select(t => t);
                    var dsNV1 = dbs.NhanViens.Where(x => x.VeBans.Equals(dsVB1)).Select(x => x);
                    foreach (var i in dsNV1)
                    {
                        dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                              i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                    }
                    break;
                case 2://Tim theo dia chi
                    var dsKH2 = dbs.KhachHangs.Where(p => p.DiaChi.Contains(kh.DiaChi)).Select(p => p);
                    var dsVB2 = dbs.VeBans.Where(t => t.MaKhachHang.Equals(dsKH2)).Select(t => t);
                    var dsNV2 = dbs.NhanViens.Where(x => x.VeBans.Equals(dsVB2)).Select(x => x);
                    foreach (var i in dsNV2)
                    {
                        dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                              i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                    }
                    break;
            }
            ds.Tables.Add(dt);
            return ds;
        }


        //Thêm một nhân viên mới
        public bool insertNhanVien(ref string err, NhanVien nv)
        {
            try
            {
                dbs.NhanViens.Add(nv);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin nhân viên bằng mã nhân viên
        public bool updateNhanVien(ref string err, NhanVien nv_update)
        {

            try
            {
                NhanVien nv = dbs.NhanViens.FirstOrDefault(p => p.MaNhanVien == nv_update.MaNhanVien);
                if (nv != null)
                {
                    nv.TenNhanVien = nv_update.TenNhanVien;
                    nv.HoNhanVien = nv_update.HoNhanVien;
                    nv.TenLotNhanVien = nv_update.TenLotNhanVien;
                    nv.DiaChi = nv_update.DiaChi;
                    nv.SoDienThoai = nv_update.SoDienThoai;
                    nv.ChucVu = nv_update.ChucVu;
                    nv.TenDangNhap = nv_update.TenDangNhap;
                    nv.MatKhau = nv_update.MatKhau;
                    dbs.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
            return false;
        }

        //Xóa nhân viên bằng mã nhân viên
        public bool deleteNhanVien(ref string err, NhanVien nv_delete)
        {
            try
            {
                NhanVien nv = dbs.NhanViens.FirstOrDefault(p => p.MaNhanVien == nv_delete.MaNhanVien);
                if (nv != null)
                {
                    dbs.NhanViens.Remove(nv);
                    dbs.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }
    }
}

