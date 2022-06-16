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
    internal class DbChuyenBay
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        static void Main(string[] args)
        {

            Console.WriteLine("Doneee.......");
        }
        public DataSet getChuyenBays()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã chuyến bay");
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Ngày đến");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Ngày đi");
            dt.Columns.Add("Giờ bay");
            dt.Columns.Add("Điểm đến");
            dt.Columns.Add("Điểm đi");

            var dsChuyenBay = dbs.ChuyenBays.Select(p => p);
            foreach (var i in dsChuyenBay)
            {
                dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                    i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
            }
            ds.Tables.Add(dt);
            return ds;
        }
        //Tìm kiếm thông thường - Lấy chuyến bay theo mã chuyến bay hoặc giờ bay hoặc ngày đi hoặc ngày đến
        public DataSet searchChuyenBay(ref string err, ChuyenBay cb_search)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã chuyến bay");
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Ngày đến");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Ngày đi");
            dt.Columns.Add("Giờ bay");
            dt.Columns.Add("Điểm đến");
            dt.Columns.Add("Điểm đi");
            //Tìm theo mã chuyến bay
            if (cb_search.MaChuyenBay != null)
            {
                try
                {
                    var dsChuyenBay = dbs.ChuyenBays
                        .Where(r => r.MaChuyenBay.Equals(cb_search.MaChuyenBay))
                        .Select(r => r);
                    //Thêm các bộ vào các cột 
                    foreach (var i in dsChuyenBay)
                    {
                        dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                            i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
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
            //Tìm theo giờ bay
            else if (cb_search.GioBay != null)
            {
                try
                {
                    var dsChuyenBay = dbs.ChuyenBays
                        .Where(r => r.GioBay == cb_search.GioBay)
                        .Select(r => r);
                    foreach (var i in dsChuyenBay)
                    {
                        dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                            i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
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
            //Tìm theo ngày đi
            else if (cb_search.NgayDi != null)
            {
                try
                {
                    var dsChuyenBay = dbs.ChuyenBays
                        .Where(r => r.NgayDi==cb_search.NgayDi)
                        .Select(r => r);
                    foreach (var i in dsChuyenBay)
                    {
                        dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                            i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
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
            //Tìm theo ngày đến
            else if (cb_search.NgayDen != null)
            {
                try
                {
                    var dsChuyenBay = dbs.ChuyenBays
                        .Where(r => r.NgayDen == cb_search.NgayDen)
                        .Select(r => r);
                    foreach (var i in dsChuyenBay)
                    {
                        dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                            i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
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
            return ds;
        }

        //Tìm kiếm nâng cao - Lấy chuyến bay theo khoảng giờ bay hoặc khoảng ngày đi hoặc khoảng ngày đến
        public DataSet advanced_Search_ChuyenBay(ref string err, TimeSpan start_hour, TimeSpan end_hour, DateTime start_date, DateTime end_date)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã chuyến bay");
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Ngày đến");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Ngày đi");
            dt.Columns.Add("Giờ bay");
            dt.Columns.Add("Điểm đến");
            dt.Columns.Add("Điểm đi");
            int flag = -1;
            switch (flag)
            {
                case 0://Tìm theo giờ bay
                    try
                    {
                        var dsChuyenBay = dbs.ChuyenBays
                                .Where(r => r.GioBay >= start_hour && r.GioBay <= end_hour)
                                .Select(r => r);
                        foreach (var i in dsChuyenBay)
                        {
                            dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                                i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    break;
                case 1://Tìm  theo ngày đi
                    try
                    {
                        var dsChuyenBay = dbs.ChuyenBays
                                .Where(r => r.NgayDi >= start_date && r.NgayDi <= end_date)
                                .Select(r => r);
                        foreach (var i in dsChuyenBay)
                        {
                            dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                                i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    break;
                case 2: //Tìm theo ngày đến
                    try
                    {
                        var dsChuyenBay = dbs.ChuyenBays
                                  .Where(r => r.NgayDen >= start_date && r.NgayDen <= end_date)
                                  .Select(r => r);
                        foreach (var i in dsChuyenBay)
                        {
                            dt.Rows.Add(i.MaChuyenBay, i.MaDuongBay, i.MaMayBay,
                                i.NgayDen, i.GhiChu, i.NgayDi, i.GioBay, i.DiemDen, i.DiemDi);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                    break;
            }
            return ds;
        }



        //Thêm một chuyến bay mới
        public bool insertChuyenBay(ref string err, ChuyenBay cb)
        {
            try
            {
                dbs.ChuyenBays.Add(cb);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin chuyến bay bằng mã chuyến bay
        public bool updateChuyenBay(ref string err, ChuyenBay cb_update)
        {

            try
            {
                ChuyenBay cb = dbs.ChuyenBays.FirstOrDefault(p => p.MaChuyenBay == cb_update.MaChuyenBay);
                if (cb != null)
                {
                    cb.MaDuongBay = cb_update.MaDuongBay;
                    cb.MaMayBay = cb_update.MaMayBay;
                    cb.NgayDen = cb_update.NgayDen;
                    cb.GhiChu = cb_update.GhiChu;
                    cb.NgayDi = cb_update.NgayDi;
                    cb.GioBay = cb_update.GioBay;
                    cb.DiemDi = cb_update.DiemDi;
                    cb.DiemDen = cb_update.DiemDen;
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

        //Xóa chuyến bay bằng mã chuyến bay
        public bool deleteChuyenBay(ref string err, ChuyenBay cb_delete)
        {
            try
            {
                ChuyenBay cb = dbs.ChuyenBays.FirstOrDefault(p => p.MaChuyenBay == cb_delete.MaChuyenBay);
                if (cb != null)
                {
                    dbs.ChuyenBays.Remove(cb);
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