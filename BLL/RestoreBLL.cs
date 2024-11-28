using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class RestoreBLL
    {
        RestoreDAL rDal = new RestoreDAL();
        public bool RestoreDatabase(string backupPath)
        {
            return rDal.RestoreDatabase(backupPath);
        }
    }
}
