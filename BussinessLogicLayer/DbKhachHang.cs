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
    public class DbKhachHang
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        
        //Lấy tất cả khách hàng
        public DataSet getKhachHangs()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Tên lót khách hàng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("CMND");

            var dsKhachHang = dbs.KhachHangs.Select(p => p);
            foreach (var i in dsKhachHang)
            {
                dt.Rows.Add(i.MaKhachHang, i.HoKhachHang, i.TenKhachHang,
                    i.TenLotKhachHang, i.SoDienThoai, i.DiaChi, i.CMND);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Check mã khách hàng có tồn tại trong cơ sở dữ liệu không
        public bool checkKhachHang(string MaKH)
        {
            var dsKhachHang = dbs.KhachHangs.Where(p => p.MaKhachHang == MaKH).Select(p => p);
            int count = 0;
            foreach (var i in dsKhachHang)
            {
                count += 1;
            }
            if (count > 0)
                return true;
            return false;
        }

        //Lấy khách hàng theo id khách hàng hoặc tên khách hàng hoặc địa chỉ khách hàng
        public DataSet searchKhachHang(ref string err, int flag, KhachHang kh_search)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Tên lót khách hàng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("CMND");


            //Lựa chọn phương thức tìm kiếm
            switch(flag)
            {
                case 0:
                    //Tìm theo mã khách hàng
                    if (kh_search.MaKhachHang != null)
                    {
                        try
                        {
                            var dsKhachHang = dbs.KhachHangs
                                .Where(r => r.MaKhachHang.Equals(kh_search.MaKhachHang))
                                .Select(r => r);
                            //Thêm các bộ vào các cột 
                            foreach (var i in dsKhachHang)
                            {
                                dt.Rows.Add(i.MaKhachHang, i.HoKhachHang, i.TenKhachHang,
                                    i.TenLotKhachHang, i.SoDienThoai, i.DiaChi, i.CMND);
                            }
                            ds.Tables.Add(dt);
                            return ds;
                        }
                        catch (Exception ex)
                        {
                            err = ex.Message;
                            return ds;
                        }
                    }
                    break;
                case 1:
                    //Tìm theo tên khách hàng
                    if (kh_search.TenKhachHang != null)
                    {
                        try
                        {
                            var dsKhachHang = dbs.KhachHangs
                                .Where(r => r.TenKhachHang.Contains(kh_search.TenKhachHang))
                                .Select(r => r);
                            foreach (var i in dsKhachHang)
                            {
                                dt.Rows.Add(i.MaKhachHang, i.HoKhachHang, i.TenKhachHang,
                                    i.TenLotKhachHang, i.SoDienThoai, i.DiaChi, i.CMND);
                            }
                            ds.Tables.Add(dt);
                            return ds;
                        }
                        catch (Exception ex)
                        {
                            err = ex.Message;
                            return ds;
                        }
                    }
                    break;
                case 2:
                     //Tìm theo địa chỉ
                    if (kh_search.DiaChi != null)
                    {
                        try
                        {
                            var dsKhachHang = dbs.KhachHangs
                                .Where(r => r.DiaChi.Contains(kh_search.DiaChi))
                                .Select(r => r);
                            foreach (var i in dsKhachHang)
                            {
                                dt.Rows.Add(i.MaKhachHang, i.HoKhachHang, i.TenKhachHang,
                                    i.TenLotKhachHang, i.SoDienThoai, i.DiaChi, i.CMND);
                            }
                            ds.Tables.Add(dt);
                            return ds;
                        }
                        catch (Exception ex)
                        {
                            err = ex.Message;
                            return ds;
                        }
                    }
                    break;
            }            
            return ds;
        }
        //Thêm một khách hàng mới
        public bool insertKhachHang(ref string err, KhachHang kh)
        {
            try
            {
                dbs.KhachHangs.Add(kh);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        } 

        //Cập nhật thông tin khách hàng bằng id khách hàng
        public bool updateKhachHang(ref string err, KhachHang kh_update)
        {

            try
            {
                KhachHang kh = dbs.KhachHangs.FirstOrDefault(p => p.MaKhachHang == kh_update.MaKhachHang);
                if (kh != null)
                {
                    kh.HoKhachHang = kh_update.HoKhachHang;
                    kh.TenKhachHang = kh_update.TenKhachHang;
                    kh.TenLotKhachHang = kh_update.TenLotKhachHang;
                    kh.SoDienThoai = kh_update.SoDienThoai;
                    kh.DiaChi = kh_update.DiaChi;
                    kh.CMND = kh_update.CMND;
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

        //Xóa khách hàng bằng id khách hàng
        public bool deleteKhachHang(ref string err, KhachHang kh_delete)
        {
            try
            {
                KhachHang kh = dbs.KhachHangs.FirstOrDefault(p => p.MaKhachHang == kh_delete.MaKhachHang);
                if (kh != null)
                {
                    dbs.KhachHangs.Remove(kh);
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
