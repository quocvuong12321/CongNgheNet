using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class TramDungChanBLL
    {
        TramDungChanDAL tramDungChanDAL = new TramDungChanDAL();

        public List<string> LayDanhSachTenTramDungChanTheoDiaDiem(int maDiaDiem)
        {
            return tramDungChanDAL.LayDanhSachTenTramDungChanTheoDiaDiem(maDiaDiem);
        }

        public List<TRAMDUNGCHAN> LayDanhSachTramDungChanTheoDiaDiem(int maDiaDiem)
        {
            return tramDungChanDAL.LayDanhSachTramDungChanTheoDiaDiem(maDiaDiem);
        }

        public List<LichTrinhVaTramDungChanDTO> LayDanhSachLichTrinhVaTramDungChanDiemDi(string MaLT)
        {
            return tramDungChanDAL.LayDanhSachLichTrinhVaTramDungChanDiemDi(MaLT);
        }
        public List<LichTrinhVaTramDungChanDTO> LayDanhSachLichTrinhVaTramDungChanDiemTra(string MaLT)
        {
            return tramDungChanDAL.LayDanhSachLichTrinhVaTramDungChanDiemTra(MaLT);
        }

        public List<TRAMDUNGCHAN> LayTatCaTramDungChan()
        {
            return tramDungChanDAL.LayTatCaTramDungChan();
        }

        public bool ThemTramDungChan(string maTramDungChan, string tenTramDungChan, int maDiaDiem)
        {
            if (tramDungChanDAL.KiemTraMaTramDungChanTonTai(maTramDungChan))
            {
                return false;
            }

            return tramDungChanDAL.ThemTramDungChan(maTramDungChan,tenTramDungChan,maDiaDiem);
        }

        public bool XoaTramDungChan(string maTramDungChan)
        {
            if (!tramDungChanDAL.KiemTraMaTramDungChanTonTai(maTramDungChan))
            {
                return false;
            }
            return tramDungChanDAL.XoaTramDungChan(maTramDungChan);
        }

        public bool SuaTramDungChan(string maTramDungChan, string tenTramDungChan, int maDiaDiem)
        {
            if (!tramDungChanDAL.KiemTraMaTramDungChanTonTai(maTramDungChan))
            {
                return false;
            }
            return tramDungChanDAL.SuaTramDungChan(maTramDungChan, tenTramDungChan, maDiaDiem);
        }

        public bool ThemTramDungChanTheoMaLichTrinh(string maTramDungChan, string maLichTrinh)
        {
            return tramDungChanDAL.ThemTramDungChanTheoMaLichTrinh(maTramDungChan, maLichTrinh);
        }

        public bool XoaTramDungChanTheoMaLichTrinh(string maTramDungChan, string maLichTrinh)
        {
            return tramDungChanDAL.XoaTramDungChanTheoMaLichTrinh(maTramDungChan, maLichTrinh);
        }



    }
}
