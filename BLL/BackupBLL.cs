using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BackupBLL
    {
        BackupDAL bck = new BackupDAL();
        public bool BackupDatabase(string backupPath)
        {
            return bck.BackupDatabase(backupPath);
        }
    }
}
