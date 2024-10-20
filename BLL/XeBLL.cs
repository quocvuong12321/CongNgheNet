using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class XeBLL
    {
        XeDAL xeDal = new XeDAL();
        public List<Xe> Xe()
        {
            return xeDal.Xe();
        }
        
    }
}
