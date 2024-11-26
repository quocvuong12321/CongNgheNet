using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class DatVeBLL
    {
        DatVeDAL dvDAL = new DatVeDAL();

        public bool layLoaiXe(string maLichTrinh)
        {
            return dvDAL.layLoaiXe(maLichTrinh);
        }

        public int LaySoVe(string maLichTrinh)
        {
            return dvDAL.LaySoVe(maLichTrinh);
        }
        public bool LuuVe(Ve ve)
        {
            return dvDAL.LuuVe(ve);
        }

        public bool LuuChiTietVe(ChiTietVe ctVe)
        {
            return dvDAL.LuuChiTietVe(ctVe);
        }

        public int LayIDGhe(string viTriNgoi, string MaLichTrinh)
        {
            return dvDAL.LayIDGhe(viTriNgoi, MaLichTrinh);
        }

        public List<TRAMDUNGCHAN> layDiemDon(string malt, int diemkh)
        {

            return dvDAL.layDiemDon(malt, diemkh);
        }
        public List<TRAMDUNGCHAN> layDiemTra(string malt, int diemden)
        {
            return dvDAL.layDiemDon(malt, diemden);
        }
    }
}
