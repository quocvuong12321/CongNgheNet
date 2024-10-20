using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TuyenDuongDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();
        public List<TuyenDuong> TuyenDuong()
        {
            return db.TuyenDuongs.ToList();
        }
    }
}
