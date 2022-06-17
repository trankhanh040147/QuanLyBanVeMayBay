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
    public class DbVeBan
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
        
        //Lấy danh sách tất cả vé bán
        public DataSet getVeBans()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã vé bán");
            dt.Columns.Add("Mã vé");
            dt.Columns.Add("Số lượng vé bán");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Thời gian bán");
            dt.Columns.Add("Thời gian thanh toán");
            dt.Columns.Add("Số lượng hàng hóa");

            var dsVeBan = dbs.VeBans.Select(p => p);
            foreach (var i in dsVeBan)
            {
                dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                      i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Tính tổng số vé bán
        public int Total_VeBan()
        {
            var dsVeBan = dbs.VeBans.Select(p => p);
            int total=0;
            foreach (var i in dsVeBan)
            {
                total += total + i.SLVeBan;
            }
            return total;
        }

        //Tính tổng doanh thu
        public int Total_Sales()
        {
            var dsVeBan = dbs.VeBans.Select(p => p);
            int total = 0;
            foreach (var i in dsVeBan)
            {
                total += total + i.TongTien;
            }
            return total;
        }

        //Thêm một vé bán mới
        public bool insertVeBan(ref string err, VeBan vb)
        {
            try
            {
                dbs.VeBans.Add(vb);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin vé bán bằng mã vé bán
        public bool updateVeBan(ref string err, VeBan vb_update)
        {

            try
            {
                VeBan vb = dbs.VeBans.FirstOrDefault(p => p.MaVeBan == vb_update.MaVeBan);
                if (vb != null)
                {
                    vb.MaVe = vb_update.MaVe;
                    vb.SLVeBan = vb_update.SLVeBan;
                    vb.MaNhanVien = vb_update.MaNhanVien;
                    vb.MaKhachHang = vb_update.MaKhachHang;
                    vb.TongTien = vb_update.TongTien;
                    vb.ThoiGianBan = vb_update.ThoiGianBan;
                    vb.ThoiGianThanhToan = vb_update.ThoiGianThanhToan;
                    vb.SoLuongHangHoa = vb_update.SoLuongHangHoa;
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

        //Xóa vé bán bằng mã vé bán
        public bool deleteVeBan(ref string err, VeBan vb_delete)
        {
            try
            {
                var vb = dbs.VeBans.Include("HangHoas").Where(p=>p.MaVeBan==vb_delete.MaVeBan).FirstOrDefault();
                if (vb != null)
                {
                    dbs.VeBans.Remove(vb);
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
