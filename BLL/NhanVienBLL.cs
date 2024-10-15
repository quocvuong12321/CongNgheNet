using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {

        NhanVienDAL nvDAL = new NhanVienDAL();

        public bool Insert(NhanVienDTO nv)
        {
            return nvDAL.Insert(nv);
        }

        public bool Login (string username,string password)
        {
            return nvDAL.Login(username, password);
        }
    }
}
