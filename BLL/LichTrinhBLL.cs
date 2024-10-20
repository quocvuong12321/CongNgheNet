﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

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

        public bool XoaLichTrinh(string maLichTrinh)
        {
            return ltDAL.XoaLichTrinh(maLichTrinh);
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

        public List<LichTrinh> LayDanhSachLichTrinhTheoTuyenDuong(int maTuyenDuong)
        {
            return ltDAL.LayDanhSachLichTrinhTheoTuyenDuong(maTuyenDuong);
        }


    }
}
