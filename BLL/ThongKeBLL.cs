using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        ThongKeDAL dal = new ThongKeDAL();
        public List<LichTrinh> LayLichTrinhTheoNgay(DateTime ngay)
        {
            return dal.LayLichTrinhTheoNgay(ngay);
        }

        public List<Ve> LayDanhSachVeTheoMaLichTrinh(string maLichTrinh)
        {
            return dal.LayDanhSachVeTheoMaLichTrinh(maLichTrinh);
        }

        public List<Ve> LayDanhSachVeTheoNgay(DateTime ngay)
        {
            return dal.LayDanhSachVeTheoNgay(ngay);
        }

        public List<Ve> LayDanhSachVeTheoThang(int thang,int nam)
        {
            return dal.LayDanhSachVeTheoThang(thang,nam);
        }


    }
}
