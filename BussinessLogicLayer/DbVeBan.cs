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
        //Tìm kiếm thông thường - Tìm theo mã vé hoặc mã vé bán hoặc mã nhân viên hoặc mã khách hàng
        public DataSet normal_Search_VeBan(ref string err, int flag, VeBan vb_search)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã vé bán");
            dt.Columns.Add("Mã vé");
            dt.Columns.Add("Số lượng vé bán");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Thời gian bán");
            dt.Columns.Add("Thời gian thanh toán");
            dt.Columns.Add("Số lượng hàng hóa");

            //Lựa chọn phương thức tìm kiếm
            switch (flag)
            {
                case 0:
                    //Tìm theo mã vé
                    if (vb_search.MaVe != null)
                    {
                        try
                        {
                            var dsVeBan = dbs.VeBans
                                .Where(r => r.MaVe.Contains(vb_search.MaVe))
                                .Select(r => r);
                            //Thêm các bộ vào các cột 
                            foreach (var i in dsVeBan)
                            {
                                dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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
                    //Tìm theo mã vé bán
                    if (vb_search.MaVeBan != null)
                    {
                        try
                        {
                            var dsVeBan = dbs.VeBans
                                .Where(r => r.MaVeBan.Contains(vb_search.MaVeBan))
                                .Select(r => r);
                            //Thêm các bộ vào các cột 
                            foreach (var i in dsVeBan)
                            {
                                dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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
                    //Tìm theo mã nhân viên
                    if (vb_search.MaNhanVien != null)
                    {
                        try
                        {
                            var dsVeBan = dbs.VeBans
                                .Where(r => r.MaNhanVien.Contains(vb_search.MaNhanVien))
                                .Select(r => r);
                            //Thêm các bộ vào các cột 
                            foreach (var i in dsVeBan)
                            {
                                dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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
                case 3:
                    //Tìm theo mã khách hàng
                    if (vb_search.MaKhachHang != null)
                    {
                        try
                        {
                            var dsVeBan = dbs.VeBans
                                .Where(r => r.MaKhachHang.Contains(vb_search.MaKhachHang))
                                .Select(r => r);
                            //Thêm các bộ vào các cột 
                            foreach (var i in dsVeBan)
                            {
                                dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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

        //Tìm kiếm nâng cao - Tìm theo số lượng vé bán, tổng tiền, thời gian bán, thời gian thanh toán
        public DataSet advanced_Search_VeBan(ref string err, int flag, int start_SLVeOrTongTien, int end_SLVeOrTongTien, DateTime start_date, DateTime end_date)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            //Thêm các cột vào dt
            dt.Columns.Add("Mã vé bán");
            dt.Columns.Add("Mã vé");
            dt.Columns.Add("Số lượng vé bán");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Thời gian bán");
            dt.Columns.Add("Thời gian thanh toán");
            dt.Columns.Add("Số lượng hàng hóa");
            switch (flag)
            {
                case 0://Tìm theo số lượng vé bán
                    try
                    {
                        var dsVeBan = dbs.VeBans
                                .Where(r => r.SLVeBan >= start_SLVeOrTongTien && r.SLVeBan <= end_SLVeOrTongTien)
                                .Select(r => r);
                        foreach (var i in dsVeBan)
                        {
                            dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                case 1://Tìm  theo tổng tiền
                    try
                    {
                        var dsVeBan = dbs.VeBans
                                .Where(r => r.TongTien >= start_SLVeOrTongTien && r.TongTien <= end_SLVeOrTongTien)
                                .Select(r => r);
                        foreach (var i in dsVeBan)
                        {
                            dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                case 2: //Tìm theo thời gian bán
                    try
                    {
                        var dsVeBan = dbs.VeBans
                                .Where(r => r.ThoiGianBan >= start_date && r.ThoiGianBan <= end_date)
                                .Select(r => r);
                        foreach (var i in dsVeBan)
                        {
                            dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                        }
                        ds.Tables.Add(dt);
                        return ds;
                    }
                    catch (Exception ex)
                    {
                        err = ex.Message;
                        return ds;
                    }
                case 3: //Tìm theo thời gian thanh toán
                    try
                    {
                        var dsVeBan = dbs.VeBans
                                .Where(r => r.ThoiGianThanhToan >= start_date && r.ThoiGianThanhToan <= end_date)
                                .Select(r => r);
                        foreach (var i in dsVeBan)
                        {
                            dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                                i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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

        //Tìm kiếm tổng quát - tìm kiếm theo tất cả thuộc tính 
        public DataSet general_Search_VeBan(ref string err, VeBan vb_search)
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

            try
            {
                //Tìm theo mã vé bán
                var dsVeBan = dbs.VeBans
                        .Where(r => r.MaVeBan.Contains(vb_search.MaVeBan))
                        .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                }
                //Tìm theo mã vé 
                dsVeBan = dbs.VeBans
                        .Where(r => r.MaVe.Contains(vb_search.MaVe))
                        .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                }
                //Tìm theo mã nhân viên
                dsVeBan = dbs.VeBans
                        .Where(r => r.MaNhanVien.Contains(vb_search.MaNhanVien))
                        .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                }
                //Tìm theo mã khách hàng
                dsVeBan = dbs.VeBans
                         .Where(r => r.MaKhachHang.Contains(vb_search.MaKhachHang))
                         .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                }
                //Tìm theo số lượng vé bán
                dsVeBan = dbs.VeBans
                        .Where(r => r.SLVeBan == vb_search.SLVeBan)
                        .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
                }
                //Tìm theo tổng tiền
                dsVeBan = dbs.VeBans
                        .Where(r => r.TongTien == vb_search.TongTien)
                        .Select(r => r);
                foreach (var i in dsVeBan)
                {
                    dt.Rows.Add(i.MaVeBan, i.MaVe, i.SLVeBan, i.MaNhanVien,
                         i.MaKhachHang, i.TongTien, i.ThoiGianBan, i.ThoiGianThanhToan, i.SoLuongHangHoa);
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
