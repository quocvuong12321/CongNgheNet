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

        public List<dynamic> LayDanhSachLichTrinhVaTramDungChan(string maLichTrinh)
        {
            try
            {
                var danhSach = from lt in db.LichTrinhs
                               join td in db.TuyenDuongs on lt.ID_TUYEN_DUONG equals td.ID_TUYEN
                               join ddDiemDau in db.DiaDiems on td.DIEM_DAU equals ddDiemDau.ID_DIADIEM
                               join ddDiemCuoi in db.DiaDiems on td.DIEM_CUOI equals ddDiemCuoi.ID_DIADIEM
                               join tramDiemDau in db.TRAMDUNGCHANs on ddDiemDau.ID_DIADIEM equals tramDiemDau.ID_DIADIEM into tramDiemDauGroup
                               from tramDiemDau in tramDiemDauGroup.DefaultIfEmpty()
                               join tramDiemCuoi in db.TRAMDUNGCHANs on ddDiemCuoi.ID_DIADIEM equals tramDiemCuoi.ID_DIADIEM into tramDiemCuoiGroup
                               from tramDiemCuoi in tramDiemCuoiGroup.DefaultIfEmpty()
                               where lt.MA_LICH_TRINH == maLichTrinh
                               select new
                               {
                                   MaLichTrinh = lt.MA_LICH_TRINH,
                                   DiemDi = ddDiemDau.TEN_TINH_THANH,
                                   TramDiemDi = tramDiemDau.TEN_TramDungChan,
                                   DiemDen = ddDiemCuoi.TEN_TINH_THANH,
                                   TramDiemDen = tramDiemCuoi.TEN_TramDungChan
                               };

                return danhSach.ToList<dynamic>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình và trạm dừng chân: " + ex.Message);
                return new List<dynamic>();
            }
        }


        


    }
}
