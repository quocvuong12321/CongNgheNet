using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();

        public List<LichTrinh> LayLichTrinhTheoNgay(DateTime ngay)
        {
            try
            {
                var danhSachLichTrinh = db.LichTrinhs
                    .Where(lt => lt.NGAY_TAO_LICH_TRINH.Date == ngay.Date)
                    .ToList();

                return danhSachLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình theo ngày: " + ex.Message);
                return new List<LichTrinh>();
            }
        }


        public List<Ve> LayDanhSachVeTheoMaLichTrinh(string maLichTrinh)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.ID_LICH_TRINH == maLichTrinh)
                    //.Select(ve => new Ve
                    //{
                    //    ID_VE = ve.ID_VE,
                    //    ID_LICH_TRINH = ve.ID_LICH_TRINH,
                    //    TONG_TIEN = ve.TONG_TIEN,
                    //    NHAN_VIEN_TAO = ve.NHAN_VIEN_TAO,
                    //    SOLUONG = ve.SOLUONG
                    //})
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo mã lịch trình: " + ex.Message);
                return new List<Ve>();
            }

        }

        public List<Ve> LayDanhSachVeTheoNgay(DateTime ngay)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.NGAY_DAT_VE.Date == ngay.Date) // Lọc vé theo ngày
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo ngày: " + ex.Message);
                return new List<Ve>(); // Trả về danh sách rỗng khi có lỗi
            }
        }


        public List<Ve> LayDanhSachVeTheoThang(int thang,int nam)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.NGAY_DAT_VE.Month == thang && ve.NGAY_DAT_VE.Year == nam) // Lọc vé theo ngày
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo tháng: " + ex.Message);
                return new List<Ve>(); // Trả về danh sách rỗng khi có lỗi
            }
        }


    }
}
