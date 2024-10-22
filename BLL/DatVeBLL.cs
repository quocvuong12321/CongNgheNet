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
    }
}
