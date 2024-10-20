using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TramDungChanDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();

        public List<TRAMDUNGCHAN> LayTatCaTramDungChan()
        {
            var danhSachTram = db.TRAMDUNGCHANs.ToList();
            return danhSachTram;
        }

        public bool KiemTraMaTramDungChanTonTai(string maTramDungChan)
        {
            var tram = db.TRAMDUNGCHANs.FirstOrDefault(t => t.ID_TramDungChan == maTramDungChan);
            return tram != null;
        }

        public bool ThemTramDungChan(string maTramDungChan, string tenTramDungChan, int maDiaDiem)
        {
            try
            {
                if (KiemTraMaTramDungChanTonTai(maTramDungChan))
                {
                    return false;
                }

                TRAMDUNGCHAN tram = new TRAMDUNGCHAN()
                {
                    ID_TramDungChan = maTramDungChan,
                    TEN_TramDungChan = tenTramDungChan,
                    ID_DIADIEM = maDiaDiem
                };

                db.TRAMDUNGCHANs.InsertOnSubmit(tram);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm trạm dừng chân: " + ex.Message);
                return false;
            }
        }

        public bool XoaTramDungChan(string maTramDungChan)
        {
            try
            {
                var tram = db.TRAMDUNGCHANs.FirstOrDefault(t => t.ID_TramDungChan == maTramDungChan);
                if (tram != null)
                {
                    db.TRAMDUNGCHANs.DeleteOnSubmit(tram);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa trạm dừng chân: " + ex.Message);
                return false;
            }
        }

        public bool SuaTramDungChan(string maTramDungChan, string tenTramDungChan, int maDiaDiem)
        {
            try
            {
                var tram = db.TRAMDUNGCHANs.FirstOrDefault(t => t.ID_TramDungChan == maTramDungChan);
                if (tram != null)
                {
                    tram.TEN_TramDungChan = tenTramDungChan;
                    tram.ID_DIADIEM = maDiaDiem;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa trạm dừng chân: " + ex.Message);
                return false;
            }
        }


        public List<string> LayDanhSachTenTramDungChanTheoDiaDiem(int maDiaDiem)
        {
            try
            {
                var danhSachTram = (from tram in db.TRAMDUNGCHANs
                                    where tram.ID_DIADIEM == maDiaDiem
                                    select tram.TEN_TramDungChan).ToList();
                return danhSachTram;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách trạm dừng chân: " + ex.Message);
                return new List<string>();
            }
        }

        public List<TRAMDUNGCHAN> LayDanhSachTramDungChanTheoDiaDiem(int maDiaDiem)
        {
            try
            {
                var danhSachTram = (from tram in db.TRAMDUNGCHANs
                                    where tram.ID_DIADIEM == maDiaDiem
                                    select tram).ToList();
                return danhSachTram;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách trạm dừng chân: " + ex.Message);
                return new List<TRAMDUNGCHAN>();
            }
        }


        public List<LichTrinhVaTramDungChanDTO> LayDanhSachLichTrinhVaTramDungChanDiemDi(string maLichTrinh)
        {
            try
            {
                var danhSach = from lt in db.LichTrinhs
                               join tram in db.THEMTRAMDUNGCHANs on lt.MA_LICH_TRINH equals tram.MA_LICH_TRINH
                               join td in db.TuyenDuongs on lt.ID_TUYEN_DUONG equals td.ID_TUYEN
                               join tramdc in db.TRAMDUNGCHANs on tram.ID_TramDungChan equals tramdc.ID_TramDungChan

                               where lt.MA_LICH_TRINH == maLichTrinh && td.DIEM_DAU == tramdc.ID_DIADIEM
                               select new LichTrinhVaTramDungChanDTO
                               {
                                   MaLichTrinh = lt.MA_LICH_TRINH,
                                   TramDungChan = tramdc.TEN_TramDungChan

                               };

                return danhSach.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình và trạm dừng chân: " + ex.Message);
                return new List<LichTrinhVaTramDungChanDTO>();
            }
        }


        public List<LichTrinhVaTramDungChanDTO> LayDanhSachLichTrinhVaTramDungChanDiemTra(string maLichTrinh)
        {
            try
            {
                var danhSach = from lt in db.LichTrinhs
                               join tram in db.THEMTRAMDUNGCHANs on lt.MA_LICH_TRINH equals tram.MA_LICH_TRINH
                               join td in db.TuyenDuongs on lt.ID_TUYEN_DUONG equals td.ID_TUYEN
                               join tramdc in db.TRAMDUNGCHANs on tram.ID_TramDungChan equals tramdc.ID_TramDungChan

                               where lt.MA_LICH_TRINH == maLichTrinh && td.DIEM_CUOI == tramdc.ID_DIADIEM
                               select new LichTrinhVaTramDungChanDTO
                               {
                                   MaLichTrinh = lt.MA_LICH_TRINH,
                                   TramDungChan = tramdc.TEN_TramDungChan

                               };

                return danhSach.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình và trạm dừng chân: " + ex.Message);
                return new List<LichTrinhVaTramDungChanDTO>();
            }
        }
    }
}
