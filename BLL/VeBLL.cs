using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class VeBLL
    {
        VeDAL vDAL = new VeDAL();

        public List<object> LoadDSVe()
        {
            return vDAL.LoadDSVe();
        }

        //public List<Ve> LocTheoMaLichTrinh(string maLichTrinh)
        //{
        //    return vDAL.LocTheoMaLichTrinh(maLichTrinh);
        //}

        public List<object> locVe(string maLichTrinh, string trangThai)
        {
            return vDAL.locVe(maLichTrinh, trangThai);
        }

        public List<object> TimKiemVe(string keyword)
        {
            return vDAL.TimKiemVe(keyword);
        }
        public bool HuyVe(string mave)
        {
           
            return vDAL.HuyVe(mave);
        }
    }
}
