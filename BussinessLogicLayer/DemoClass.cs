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
    public class DemoClass
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
    }
}
