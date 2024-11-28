using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TuyenDuongDAL
    {
        QuanLyNhaXeDataContext db;

        public TuyenDuongDAL()
        {
            db = new QuanLyNhaXeDataContext(DTO.Connect.ConnectString);
        }
        public List<TuyenDuong> TuyenDuong()
        {
            return db.TuyenDuongs.ToList();
        }
        public List<TuyenDuongDTO> GetAll()
        {
            return db.TuyenDuongs.Select(x => new TuyenDuongDTO
            {
                IdTuyen = x.ID_TUYEN,
                TenTuyen = x.TEN_TUYEN,
                DiemDau = x.DIEM_DAU,
                DiemCuoi = x.DIEM_CUOI,
                KhoangCach = (float)x.KHOANG_CACH,
                TgianDiChuyen = (float)x.THOI_GIAN_DI_CHUYEN
            }).ToList();
        }
        public void InsertTuyen(TuyenDuongDTO tdDTO)
        {
            TuyenDuong td = new TuyenDuong
            {
                ID_TUYEN = tdDTO.IdTuyen,
                TEN_TUYEN = tdDTO.TenTuyen,
                DIEM_DAU = tdDTO.DiemDau,
                DIEM_CUOI = tdDTO.DiemCuoi,
                KHOANG_CACH = tdDTO.KhoangCach,
                THOI_GIAN_DI_CHUYEN = tdDTO.TgianDiChuyen
            };
            db.TuyenDuongs.InsertOnSubmit(td);
            db.SubmitChanges();
        }
        public void UpdateTuyen(TuyenDuongDTO tdDTO)
        {
            TuyenDuong td = db.TuyenDuongs.FirstOrDefault(x => x.ID_TUYEN == tdDTO.IdTuyen);
            if (td != null)
            {
                td.TEN_TUYEN = tdDTO.TenTuyen;
                td.KHOANG_CACH = tdDTO.KhoangCach;
                td.THOI_GIAN_DI_CHUYEN = tdDTO.TgianDiChuyen;
                td.DIEM_DAU = tdDTO.DiemDau;
                td.DIEM_CUOI = tdDTO.DiemCuoi;
                db.SubmitChanges();
            }
        }
        public bool DeleteTuyen(int id)
        {
            TuyenDuong td = db.TuyenDuongs.FirstOrDefault(x => x.ID_TUYEN == id);

            if (td != null)
            {
                db.TuyenDuongs.DeleteOnSubmit(td);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool CheckTrungTenTuyen(string tenTuyen)
        {
            return db.TuyenDuongs.Any(x => x.TEN_TUYEN == tenTuyen); 

        }
        public bool CheckTrungTenTuyenKhiCapNhat(string tenTuyen, int idTuyen)
        {
            try
            {
                // Kiểm tra nếu có tuyến đường khác (khác idTuyen) nhưng có cùng tên tuyến
                return db.TuyenDuongs.Any(t => t.TEN_TUYEN == tenTuyen && t.ID_TUYEN != idTuyen);
            }
            catch 
            {
                // Xử lý lỗi
                return false;
            }
        }
        public bool CheckTrungTuyen(int diemDau, int diemCuoi)
        {
            // Kiểm tra trong cơ sở dữ liệu xem có tuyến đường nào có cùng điểm đầu và điểm cuối không
            return db.TuyenDuongs.Any(t => t.DIEM_DAU == diemDau && t.DIEM_CUOI == diemCuoi);
        }
    }
}
