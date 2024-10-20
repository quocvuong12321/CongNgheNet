using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class DiaDiemBLL
    {
        DiaDiemDAL ddDAL = new DiaDiemDAL();
        public List<DiaDiem> loadDiaDiem()
        {
            return ddDAL.loadDiaDiem();
        }

        public int LayMaDiaDiemTheoTen(string tenDiaDiem)
        {
            DiaDiemDAL diaDiemDAL = new DiaDiemDAL();
            return diaDiemDAL.LayMaDiaDiemTheoTen(tenDiaDiem);
        }
    }
}
