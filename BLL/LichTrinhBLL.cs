using System;
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
    }
}
