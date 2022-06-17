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
    internal class DbThongBao
    {
        static QuanLyVeMayBayContext dbs = new QuanLyVeMayBayContext();
       

        //Lấy danh sách tất cả thông báo
        public DataSet getThongBaos()
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thông báo");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Thông báo");
            dt.Columns.Add("Thời gian");
            dt.Columns.Add("Kiểm tra chủ");
            dt.Columns.Add("Kiểm tra trạm");
            var dsThongBao = dbs.ThongBaos.Select(p => p);
            foreach (var i in dsThongBao)
            {
                dt.Rows.Add(i.MaThongBao, i.MaNhanVien, i.ThongBao1, i.ThoiGian, i.KiemTraChu, i.KiemTraTram);
            }
            ds.Tables.Add(dt);
            return ds;
        }

        //Thêm một thông báo mới
        public bool insertThongBao(ref string err, ThongBao tb)
        {
            try
            {
                dbs.ThongBaos.Add(tb);
                dbs.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        //Cập nhật thông tin thông báo bằng mã thông báo
        public bool updateThongBao(ref string err, ThongBao tb_update)
        {

            try
            {
                ThongBao tb = dbs.ThongBaos.FirstOrDefault(p => p.MaThongBao == tb_update.MaThongBao);
                if (tb != null)
                {
                    tb.MaNhanVien = tb_update.MaNhanVien;
                    tb.ThongBao1 = tb_update.ThongBao1;
                    tb.ThoiGian = tb_update.ThoiGian;
                    tb.KiemTraChu = tb_update.KiemTraTram;
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

        //Xóa thông báo bằng mã thông báo
        public bool deleteThongBao(ref string err, ThongBao tb_delete)
        {
            try
            {
                var tb = dbs.ThongBaos.FirstOrDefault(p => p.MaThongBao == tb_delete.MaThongBao);
                if (tb != null)
                {
                    dbs.ThongBaos.Remove(tb);
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
