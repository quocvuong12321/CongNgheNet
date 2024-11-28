using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class GheDAL
    {
        QuanLyNhaXeDataContext db;
        public GheDAL()
        {
            db = new QuanLyNhaXeDataContext(DTO.Connect.ConnectString);
        }
        public List<GHE> HienThiGheTheoLichTrinh(string malt)
        {
            List<GHE> dsGhe = db.GHEs.Where(t => t.MA_LICH_TRINH.Equals(malt)).ToList();
            return dsGhe;
        }

        public int LaySoGhe(string malt)
        {
            int soghe = db.LichTrinhs.FirstOrDefault(t => t.MA_LICH_TRINH.Equals(malt)).Xe.SO_GHE;
            return soghe;
        }
        public List<GHE> LoadGhe(string malt)
        {
            return db.GHEs.Where(t => t.MA_LICH_TRINH.Equals(malt)).ToList();
        }
    }
}
