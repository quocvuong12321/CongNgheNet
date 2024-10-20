using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LichTrinhDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();
        public List<ThongTinLichTrinhDTO> TTLichTrinh(int diemdau, int diemcuoi, DateTime ngaydi)
        {
            TuyenDuong d = db.TuyenDuongs.FirstOrDefault(t => t.DIEM_DAU == diemdau && t.DIEM_CUOI == diemcuoi);
            List<LichTrinh> lstLichTrinh = new List<LichTrinh>();

            if (d != null)
            {

                lstLichTrinh = db.LichTrinhs.Where(t => t.ID_TUYEN_DUONG == d.ID_TUYEN).ToList();
                if (lstLichTrinh.Any())
                {
                    var result = (from l in lstLichTrinh
                                  join td in db.TuyenDuongs on l.ID_TUYEN_DUONG equals td.ID_TUYEN
                                  join x in db.Xes on l.ID_XE equals x.ID_XE
                                  join ddau in db.DiaDiems on td.DIEM_DAU equals ddau.ID_DIADIEM
                                  join dcuoi in db.DiaDiems on td.DIEM_CUOI equals dcuoi.ID_DIADIEM
                                  select new
                                  {
                                      l.MA_LICH_TRINH,
                                      DiemDau = ddau.TEN_TINH_THANH,
                                      DiemCuoi = dcuoi.TEN_TINH_THANH,
                                      l.KHOI_HANH,
                                      l.KET_THUC,
                                      x.BIEN_SO_XE,
                                      l.GIA_VE
                                  }
                         );
                    List<ThongTinLichTrinhDTO> lst = new List<ThongTinLichTrinhDTO>();

                    foreach (var item in result)
                    {
                        ThongTinLichTrinhDTO tt = new ThongTinLichTrinhDTO(item.MA_LICH_TRINH, item.DiemDau, item.DiemCuoi, item.KHOI_HANH, item.KET_THUC, item.BIEN_SO_XE, (float)item.GIA_VE);
                        lst.Add(tt);
                    }
                    return lst.Where(t => String.Format("{0:dd/MM/yyyy}", t.GioDi) == String.Format("{0:dd/MM/yyyy}", ngaydi)).ToList();
                }
                return new List<ThongTinLichTrinhDTO>();
            }
            else
            {
                return new List<ThongTinLichTrinhDTO>();
            }
        }

        public bool ThemLichTrinh(string maLichTrinh, int maTuyenDuong, DateTime khoiHanh,float giaVe, int maXe)
        {

            try
            {
                var lichTrinhTonTai = db.LichTrinhs.FirstOrDefault(lt => lt.MA_LICH_TRINH == maLichTrinh);

                if (lichTrinhTonTai != null)
                {
                    return false;
                }


                var tuyenDuong = db.TuyenDuongs.FirstOrDefault(td => td.ID_TUYEN == maTuyenDuong);


                DateTime ketThuc = khoiHanh.AddHours(tuyenDuong.THOI_GIAN_DI_CHUYEN);


                Console.WriteLine("KhoiHanh: " + khoiHanh);
                Console.WriteLine("ThoiGianDiChuyen: " + tuyenDuong.THOI_GIAN_DI_CHUYEN);
                Console.WriteLine("KetThuc: " + ketThuc);


                LichTrinh lichTrinhMoi = new LichTrinh
                {
                    MA_LICH_TRINH = maLichTrinh,
                    ID_TUYEN_DUONG = maTuyenDuong,
                    KHOI_HANH = khoiHanh,
                    KET_THUC = ketThuc,
                    GIA_VE = giaVe,
                    ID_XE = maXe
                };


                db.LichTrinhs.InsertOnSubmit(lichTrinhMoi);

                db.SubmitChanges();

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi khi thêm lịch trình: " + ex.Message);
                return false; 
            }
        }



        public List<string> LayMaLichTrinh()
        {
            try
            {
                var danhSachMaLichTrinh = (from lt in db.LichTrinhs
                                           select lt.MA_LICH_TRINH ).ToList();
                return danhSachMaLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách mã lịch trình: " + ex.Message);
                return new List<string>();
            }
        }


        public LichTrinh_DiemDau_DiemCuoi LayThongTinLichTrinh(string maLichTrinh)
        {
            try
            {
                var thongTinLichTrinh = (from lt in db.LichTrinhs
                                         join td in db.TuyenDuongs on lt.ID_TUYEN_DUONG equals td.ID_TUYEN
                                         join ddDau in db.DiaDiems on td.DIEM_DAU equals ddDau.ID_DIADIEM
                                         join ddCuoi in db.DiaDiems on td.DIEM_CUOI equals ddCuoi.ID_DIADIEM
                                         where lt.MA_LICH_TRINH == maLichTrinh
                                         select new LichTrinh_DiemDau_DiemCuoi(
                                             lt.MA_LICH_TRINH,
                                             td.TEN_TUYEN,
                                             ddDau.TEN_TINH_THANH,
                                             ddCuoi.TEN_TINH_THANH
                                         )).FirstOrDefault();


                return thongTinLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy thông tin lịch trình: " + ex.Message);
                return null;
            }
        }


    }
}
