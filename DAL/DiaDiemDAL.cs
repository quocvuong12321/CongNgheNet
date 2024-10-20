using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DiaDiemDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();
        public List<DiaDiem> loadDiaDiem() 
        {
            return db.DiaDiems.ToList();

        }



        public int LayMaDiaDiemTheoTen(string tenDiaDiem)
        {
            try
            {
                var maDiaDiem = (from dd in db.DiaDiems
                                 where dd.TEN_TINH_THANH == tenDiaDiem
                                 select dd.ID_DIADIEM).FirstOrDefault();
                return maDiaDiem;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã địa điểm: " + ex.Message);
                return -1;
            }
        }


    }
}
