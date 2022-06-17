using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Sử dụng dữ liệu từ tầng DataAccess
using DataAccessLayer;
using System.Data.Entity;

namespace BussinessLogicLayer
{
    internal class DbThongTinChiTienVe
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        
        //Lấy danh sách tất cả thông tin chi tiết vé
        public DataSet getThongTins()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã vé");
            dt.Columns.Add("Mã chuyến bay");
            dt.Columns.Add("Loại vé");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Số lượng còn");
            dt.Columns.Add("Giá");
            var dsThongTin = dbs.ThongTinChiTietVes.Select(p => p);
            foreach (var i in dsThongTin)
            {
                dt.Rows.Add(i.MaVe, i.MaChuyenBay, i.LoaiVe, i.SoLuong, i.SoLuongCon, i.Gia);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Thêm một thông tin chi tiết vé mới
        public bool insertThongTinVe(ref string err, ThongTinChiTietVe tt)
        {
            try
            {
                dbs.ThongTinChiTietVes.Add(tt);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin chi tiết vé bằng mã vé
        public bool updateThongTin(ref string err, ThongTinChiTietVe tt_update)
        {

            try
            {
                ThongTinChiTietVe tt = dbs.ThongTinChiTietVes.FirstOrDefault(p => p.MaVe == tt_update.MaVe);
                if (tt != null)
                {
                    tt.MaChuyenBay = tt_update.MaChuyenBay;
                    tt.LoaiVe = tt_update.LoaiVe;
                    tt.SoLuong = tt_update.SoLuong;
                    tt.SoLuongCon = tt_update.SoLuongCon;
                    tt.Gia = tt_update.Gia;
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

        //Xóa thông in chi tiết bằng mã vé
        public bool deleteThongTin(ref string err, ThongTinChiTietVe tt_delete)
        {
            try
            {
                var tt = dbs.ThongTinChiTietVes.FirstOrDefault(p => p.MaVe == tt_delete.MaVe);
                if (tt != null)
                {
                    dbs.ThongTinChiTietVes.Remove(tt);
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
