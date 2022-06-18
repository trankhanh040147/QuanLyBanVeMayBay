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
    internal class DbHangHoa
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        

        //Lấy tất cả hàng hóa
        public DataSet getHangHoas()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Hàng hóa");
            dt.Columns.Add("Mã vé bán");
            dt.Columns.Add("Trọng lượng");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Tên hàng hóa");

            var dsHangHoa = dbs.HangHoas.Select(p => p);
            foreach (var i in dsHangHoa)
            {
                dt.Rows.Add(i.MaHangHoa, i.MaVeBan, i.TrongLuong, i.Loai, i.TenHangHoa);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Thêm một hàng hóa mới
        public bool insertHangHoa(ref string err, HangHoa hh)
        {
            try
            {
                dbs.HangHoas.Add(hh);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin hàng hóa bằng mã hàng hóa
        public bool updateHangHoa(ref string err, HangHoa hh_update)
        {

            try
            {
                HangHoa hh = dbs.HangHoas.FirstOrDefault(p => p.MaHangHoa == hh_update.MaHangHoa);
                if (hh != null)
                {
                    hh.MaVeBan = hh_update.MaVeBan;
                    hh.TrongLuong = hh_update.TrongLuong;
                    hh.Loai = hh_update.Loai;
                    hh.TenHangHoa = hh_update.TenHangHoa;
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

        //Xóa hàng hóa bằng mã hàng hóa
        public bool deleteHangHoa(ref string err, HangHoa hh_delete)
        {
            try
            {
                var hh = dbs.HangHoas.FirstOrDefault(p=>p.MaHangHoa==hh_delete.MaHangHoa);
                if (hh != null)
                {
                    dbs.HangHoas.Remove(hh);
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
