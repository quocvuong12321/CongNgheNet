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
                DiemDau = x.DiaDiem.TEN_TINH_THANH,
                DiemCuoi  = x.DiaDiem1.TEN_TINH_THANH,
                KhoangCach = (float)x.KHOANG_CACH,
                TgianDiChuyen = (float)x.THOI_GIAN_DI_CHUYEN
            }).ToList();
        }
        public void InsertTuyen(TuyenDuong tdDTO)
        {
            TuyenDuong td = new TuyenDuong
            {
                ID_TUYEN = tdDTO.ID_TUYEN,
                TEN_TUYEN = tdDTO.TEN_TUYEN,
                DIEM_DAU = tdDTO.DIEM_DAU,
                DIEM_CUOI = tdDTO.DIEM_CUOI,
                KHOANG_CACH = tdDTO.KHOANG_CACH,
                THOI_GIAN_DI_CHUYEN = tdDTO.THOI_GIAN_DI_CHUYEN
            };
            db.TuyenDuongs.InsertOnSubmit(td);
            db.SubmitChanges();
        }
        public void UpdateTuyen(TuyenDuong tdDTO)
        {
            TuyenDuong td = db.TuyenDuongs.FirstOrDefault(x => x.ID_TUYEN == tdDTO.ID_TUYEN);
            if (td != null)
            {
                td.TEN_TUYEN = tdDTO.TEN_TUYEN;
                td.KHOANG_CACH = tdDTO.KHOANG_CACH;
                td.THOI_GIAN_DI_CHUYEN = tdDTO.THOI_GIAN_DI_CHUYEN;
                td.DIEM_DAU = tdDTO.DIEM_DAU;
                td.DIEM_CUOI = tdDTO.DIEM_CUOI;
                db.SubmitChanges();
            }
        }
        public bool DeleteTuyen(int id)
        {
            TuyenDuong td = db.TuyenDuongs.FirstOrDefault(x => x.ID_TUYEN == id);
            if (td != null)
            {
                if (db.LichTrinhs.Where(t => t.ID_TUYEN_DUONG == td.ID_TUYEN).Count() > 0)
                {
                    return false;
                }
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

        public int timMaTuyenDuong(string tenTuyen)
        {
            return db.DiaDiems.FirstOrDefault(t => t.TEN_TINH_THANH.Equals(tenTuyen)).ID_DIADIEM;
        }
    }
}
