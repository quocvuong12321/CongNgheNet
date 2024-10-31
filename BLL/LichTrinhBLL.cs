using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class LichTrinhBLL
    {
        LichTrinhDAL ltDAL = new LichTrinhDAL();
        public List<ThongTinLichTrinhDTO> TTLichTrinh(int diemdau,int diemcuoi,DateTime ngaydi)
        {
            return ltDAL.TTLichTrinh(diemdau,diemcuoi,ngaydi);
        }

        public bool ThemLichTrinh(string maLichTrinh, int maTuyenDuong, DateTime khoiHanh, float giaVe, int maXe)
        {
            return ltDAL.ThemLichTrinh(maLichTrinh, maTuyenDuong, khoiHanh, giaVe, maXe);
        }


        public bool CapNhatLichTrinh(string maLichTrinh, int maTuyenDuong, DateTime khoiHanh, float giaVe, int maXe)
        {
            return ltDAL.CapNhatLichTrinh(maLichTrinh, maTuyenDuong, khoiHanh, giaVe, maXe);
        }

        public List<string> LayDanhSachMaLichTrinh()
        {
            return ltDAL.LayMaLichTrinh();
        }

        public LichTrinh_DiemDau_DiemCuoi LayThongTinLichTrinh(string maLichTrinh)
        {
            return ltDAL.LayThongTinLichTrinh(maLichTrinh);
        }

        public List<LichTrinh> LayDanhSachLichTrinh()
        {
            return ltDAL.LayDanhSachLichTrinh();
        }

        public DataTable LayDanhSachLichTrinhTheoTuyenDuong(int maTuyenDuong)
        {
            return ltDAL.LayDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);
        }


        public double LayGiaLichTrinh(string maLichTrinh)
        {
            return ltDAL.LayGiaLichTrinh(maLichTrinh);
        }
    }
}
