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

