using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DatVeDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();

        public bool layLoaiXe(string malichtrinh)
        {
            var result = db.ExecuteQuery<bool>(
                "SELECT dbo.ChonXe({0})", malichtrinh).FirstOrDefault();

            return result;
        }
    }
}
