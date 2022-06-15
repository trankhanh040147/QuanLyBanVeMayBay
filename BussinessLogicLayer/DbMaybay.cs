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
    public class DbMaybay
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Doneee.......");
        }
        public DataSet getMayBays()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Tên máy bay");
            dt.Columns.Add("Hãng sản xuất");
            dt.Columns.Add("Kích thước");
            dt.Columns.Add("Số ghế lầu 1");
            dt.Columns.Add("Số ghế lầu 2");
            dt.Columns.Add("Tổng số ghế");

            var dsMayBay = dbs.MayBays.Select(p => p);
            foreach (var i in dsMayBay)
            {
                dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                    i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
            }
            ds.Tables.Add(dt);
            return ds;
        }
        //Lấy khách hàng theo id máy bay hoặc tên máy bay hoặc hãng sãn xuất
        public DataSet normal_Search_MayBay(ref string err, MayBay mb_search)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Tên máy bay");
            dt.Columns.Add("Hãng sản xuất");
            dt.Columns.Add("Kích thước");
            dt.Columns.Add("Số ghế lầu 1");
            dt.Columns.Add("Số ghế lầu 2");
            dt.Columns.Add("Tổng số ghế");
            if (mb_search.MaMayBay != null)
            {
                try
                {
                    var dsMayBay = dbs.MayBays
                        .Where(r => r.MaMayBay.Equals(mb_search.MaMayBay))
                        .Select(r => r);
                    //Thêm các bộ vào các cột 
                    foreach (var i in dsMayBay)
                    {
                        dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                            i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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
            else if (mb_search.HangSanXuat != null)
            {
                try
                {
                    var dsMayBay = dbs.MayBays
                        .Where(r => r.HangSanXuat.Contains(mb_search.HangSanXuat))
                        .Select(r => r);
                    //Thêm các bộ vào các cột 
                    foreach (var i in dsMayBay)
                    {
                        dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                            i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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
            else if (mb_search.TenMayBay != null)
            {
                try
                {
                    var dsMayBay = dbs.MayBays
                        .Where(r => r.TenMayBay.Contains(mb_search.TenMayBay))
                        .Select(r => r);
                    //Thêm các bộ vào các cột 
                    foreach (var i in dsMayBay)
                    {
                        dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                            i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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
        
        //Tìm kiếm nâng cao
        public DataSet advanced_Search_MayBay(ref string err, int start, int end)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã máy bay");
            dt.Columns.Add("Tên máy bay");
            dt.Columns.Add("Hãng sản xuất");
            dt.Columns.Add("Kích thước");
            dt.Columns.Add("Số ghế lầu 1");
            dt.Columns.Add("Số ghế lầu 2");
            dt.Columns.Add("Tổng số ghế");
            int flag = -1;
            switch (flag)
            {
                case 0:
                    try
                    {
                        var dsMayBay = dbs.MayBays
                                .Where(r => r.KichThuoc >= start && r.KichThuoc <= end)
                                .Select(r => r);
                        foreach (var i in dsMayBay)
                        {
                            dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                                i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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
                case 1:
                    try
                    {
                        var dsMayBay = dbs.MayBays
                                .Where(r => r.SoGheL1>= start && r.KichThuoc <= end)
                                .Select(r => r);
                        foreach (var i in dsMayBay)
                        {
                            dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                                i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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
                case 2:
                    try
                    {
                        var dsMayBay = dbs.MayBays
                                .Where(r => r.SoGheL2 >= start && r.KichThuoc <= end)
                                .Select(r => r);
                        foreach (var i in dsMayBay)
                        {
                            dt.Rows.Add(i.MaMayBay, i.TenMayBay, i.HangSanXuat,
                                i.KichThuoc, i.SoGheL1, i.SoGheL2, i.Tong);
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

        //Đếm số máy bay hiện có
        public int number_MayBay()
        {
            var dsMayBay = dbs.MayBays.Select(p => p);
            int number = 0;
            foreach (var i in dsMayBay)
            {
                number += number + 1;
            }
            return number;
        }

        //Thêm một khách hàng mới
        public bool insertMayBay(ref string err, MayBay mb)
        {
            try
            {
                dbs.MayBays.Add(mb);
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
        public bool updateMayBay(ref string err, MayBay mb_update)
        {

            try
            {
                MayBay mb = dbs.MayBays.FirstOrDefault(p => p.MaMayBay == mb_update.MaMayBay);
                if (mb != null)
                {
                    mb.TenMayBay = mb_update.TenMayBay;
                    mb.HangSanXuat = mb_update.HangSanXuat;
                    mb.KichThuoc = mb_update.KichThuoc;
                    mb.SoGheL1 = mb_update.SoGheL1;
                    mb.SoGheL2 = mb_update.SoGheL2;
                    mb.Tong = mb_update.Tong;
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
        public bool deleteMayBay(ref string err, MayBay mb_delete)
        {
            
            try
            {
                var mb = dbs.MayBays.OfType<MayBay>().Where(p => p.MaMayBay == mb_delete.MaMayBay).Include(t => t.ChuyenBays).FirstOrDefault();
                if (mb != null)
                {
                    dbs.MayBays.Remove(mb);
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
