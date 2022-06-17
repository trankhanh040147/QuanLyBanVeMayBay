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
    public class DbNhanVien
    {

        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        
        
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


        //Check mã nhân viên có tồn tại trong cơ sở dữ liệu không
        public bool checkNhanVien(string MaNV)
        {
            var dsNhanVien = dbs.NhanViens.Where(p => p.MaNhanVien == MaNV).Select(p => p);
            int count = 0;
            foreach (var i in dsNhanVien)
            {
                count += 1;
            }
            if (count > 0)
                return true;
            return false;
        }

        //Tìm kiếm nhân viên theo mã nhân viên hoặc nhân viên hoặc địa nhân viên
        public DataSet search_NhanVien(ref string err, int flag, NhanVien nv_search)
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
                case 0://TÌm theo mã nhân viên
                    try
                    {
                        var dsNV = dbs.NhanViens.Where(t => t.MaNhanVien.Contains(nv_search.MaNhanVien)).Select(t => t);
                        foreach (var i in dsNV)
                        {
                            dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                                  i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                        }
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    break;
                case 1://Tìm theo tên nhân viên
                    try
                    {
                        var dsNV1 = dbs.NhanViens.Where(t => t.TenNhanVien.Contains(nv_search.TenNhanVien)).Select(t => t);
                        foreach (var i in dsNV1)
                        {
                            dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                                  i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                        }
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    
                    break;
                case 2://Tìm theo địa chỉ
                    try
                    {
                        var dsNV2 = dbs.NhanViens.Where(t => t.DiaChi.Contains(nv_search.DiaChi)).Select(t => t);
                        foreach (var i in dsNV2)
                        {
                            dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                                  i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                        }
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    
                    break;
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Tìm kiếm tổng quát - tìm kiếm theo tất cả thuộc tính 
        public DataSet general_Search_NhanVien(ref string err, NhanVien nv_search)
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

            try
            {
                //Tìm theo mã nhân viên
                var dsNhanVien = dbs.NhanViens
                        .Where(r => r.MaNhanVien.Contains(nv_search.MaNhanVien))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo tên nhân viên
                dsNhanVien = dbs.NhanViens
                        .Where(r => r.TenNhanVien.Contains(nv_search.TenNhanVien))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo họ nhân viên
                dsNhanVien = dbs.NhanViens
                        .Where(r => r.HoNhanVien.Contains(nv_search.HoNhanVien))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo tên lót nhân viên
                dsNhanVien = dbs.NhanViens
                         .Where(r => r.TenLotNhanVien.Contains(nv_search.TenLotNhanVien))
                         .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo địa chỉ
                dsNhanVien = dbs.NhanViens
                        .Where(r => r.DiaChi.Contains(nv_search.DiaChi))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo số điện thoại
                dsNhanVien = dbs.NhanViens
                        .Where(r => r.SoDienThoai.Contains(nv_search.SoDienThoai))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Tìm theo chức vụ
                dsNhanVien = dbs.NhanViens
                        .Where(r => r.ChucVu.Contains(nv_search.ChucVu))
                        .Select(r => r);
                foreach (var i in dsNhanVien)
                {
                    dt.Rows.Add(i.MaNhanVien, i.TenNhanVien, i.HoNhanVien, i.TenLotNhanVien,
                               i.DiaChi, i.SoDienThoai, i.ChucVu, i.TenDangNhap, i.MatKhau);
                }
                //Thêm vào dataset
                ds.Tables.Add(dt);
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return ds;
            }
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

