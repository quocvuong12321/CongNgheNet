using System;
using System.Collections.Generic;
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
    }
}
