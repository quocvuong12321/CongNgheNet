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

        public List<object> LoadNhanVien()
        {
            return nvDAL.LoadNhanVien();
        }

        public bool Insert(NHANVIEN nv)
        {
            return nvDAL.Insert(nv);
        }

        public bool Login(string username, string password)
        {
            return nvDAL.Login(username, password);
        }
        public string getTenNV(string username)
        {
            return nvDAL.getTenNV(username);
        }

        public bool update(string username, NHANVIEN nvMoi)
        {
            return nvDAL.update(username, nvMoi);
        }

        public string getRoleNhanVien(string username)
        {
            return nvDAL.getRoleNhanVien(username);
        }

        public NHANVIEN getThongTinNhanVien(string username)
        {
            return nvDAL.getThongTinNhanVien(username);
        }

        public bool ktMatKhau(string password, string username)
        {
            return nvDAL.ktMatKhau(password, username);
        }
        public int DoiMatKhau(string newPassword, string username)
        {
            return nvDAL.DoiMatKhau(newPassword, username);
        }
    }
}
