using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class GheBLL
    {
        GheDAL gDAL = new GheDAL();
        public List<GHE> HienThiGheTheoLichTrinh(string malt)
        {
            return gDAL.HienThiGheTheoLichTrinh(malt);
        }
        public int LaySoGhe(string malt)
        {
            return gDAL.LaySoGhe(malt);
        }
        public List<GHE> LoadGhe(string malt)
        {
            return gDAL.LoadGhe(malt);
        }
    }
}
