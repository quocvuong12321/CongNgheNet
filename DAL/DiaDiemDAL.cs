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
        public List<DiaDiem> loadDiaDiem() {
            return db.DiaDiems.ToList();
        }
    }
}
