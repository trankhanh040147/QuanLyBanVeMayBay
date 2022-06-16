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
    internal class DbDuongBay
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        static void Main(string[] args)
        {

            Console.WriteLine("Doneee.......");
        }
        public DataSet getDuongBays()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Vị trí");
            dt.Columns.Add("Chiều dài");
            dt.Columns.Add("Chiều rộng");
            dt.Columns.Add("Tình trạng");
            var dsDuongBay = dbs.DuongBays.Select(p => p);
            foreach (var i in dsDuongBay)
            {
                dt.Rows.Add(i.MaDuongBay, i.ViTri,
                    i.ChieuDai, i.ChieuRong, i.TinhTrang);
            }
            ds.Tables.Add(dt);
            return ds;
        }
        //Tìm kiếm thông thường - Lấy đường bay theo mã đường bay hoặc vị trí cùng với tình trạng sử dụng
        public DataSet normal_search_DuongBay(ref string err, DuongBay db_search)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();

            //Thêm các cột vào dt
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Vị trí");
            dt.Columns.Add("Chiều dài");
            dt.Columns.Add("Chiều rộng");
            dt.Columns.Add("Tình trạng");

            //Tìm theo mã đường bay
            if (db_search.MaDuongBay != null)
            {
                try
                {
                    var dsDuongBay = dbs.DuongBays
                        .Where(r => r.MaDuongBay == db_search.MaDuongBay && r.TinhTrang.Contains(db_search.TinhTrang))
                        .Select(r => r);
                    //Thêm các bộ vào các cột 
                    foreach (var i in dsDuongBay)
                    {
                        dt.Rows.Add(i.MaDuongBay, i.ViTri,
                            i.ChieuDai, i.ChieuRong, i.TinhTrang);
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
            //Tìm theo vị trí đường bay
            else if (db_search.ViTri != null)
            {
                try
                {
                    var dsDuongBay = dbs.DuongBays
                        .Where(r => r.ViTri.Contains(db_search.ViTri) && r.TinhTrang.Contains(db_search.TinhTrang))
                        .Select(r => r);
                    foreach (var i in dsDuongBay)
                    {
                        dt.Rows.Add(i.MaDuongBay, i.ViTri,
                            i.ChieuDai, i.ChieuRong, i.TinhTrang);
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

        //Tìm kiếm nâng cao - Lấy đường bay theo chiều dài hoặc chiều rộng cùng với tình trạng sử dụng
        public DataSet advanced_Search_ChuyenBay(ref string err, DuongBay db_search, int start, int end)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã đường bay");
            dt.Columns.Add("Vị trí");
            dt.Columns.Add("Chiều dài");
            dt.Columns.Add("Chiều rộng");
            dt.Columns.Add("Tình trạng");
            int flag = -1;
            switch (flag)
            {
                case 0://Tìm theo chiều dài
                    try
                    {
                        var dsDuongBay = dbs.DuongBays
                                .Where(r => r.ChieuDai >= start && r.ChieuDai <= end && r.TinhTrang.Contains(db_search.TinhTrang))
                                .Select(r => r);
                        foreach (var i in dsDuongBay)
                        {
                            dt.Rows.Add(i.MaDuongBay, i.ViTri,
                                i.ChieuDai, i.ChieuRong, i.TinhTrang);
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
                case 1://Tìm theo chiều rộng
                    try
                    {
                        var dsDuongBay = dbs.DuongBays
                                .Where(r => r.ChieuRong >= start && r.ChieuRong <= end && r.TinhTrang.Contains(db_search.TinhTrang))
                                .Select(r => r);
                        foreach (var i in dsDuongBay)
                        {
                            dt.Rows.Add(i.MaDuongBay, i.ViTri,
                                i.ChieuDai, i.ChieuRong, i.TinhTrang);
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


        //Thêm một đường bay mới
        public bool insertDuongBay(ref string err, DuongBay db)
        {
            try
            {
                dbs.DuongBays.Add(db);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin đường bay bằng mã đường bay
        public bool updateDuongBay(ref string err, DuongBay db_update)
        {

            try
            {
                DuongBay db = dbs.DuongBays.FirstOrDefault(p => p.MaDuongBay == db_update.MaDuongBay);
                if (db !=null)
                {
                    db.ViTri = db_update.ViTri;
                    db.ChieuDai = db_update.ChieuDai;
                    db.ChieuRong = db_update.ChieuRong;
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

        //Xóa đường bay bằng mã đường bay
        public bool deleteDuongBay(ref string err, DuongBay db_delete)
        {
            try
            {
                DuongBay db = dbs.DuongBays.FirstOrDefault(p => p.MaDuongBay == db_delete.MaDuongBay);
                if (db != null)
                {
                    dbs.DuongBays.Remove(db);
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
