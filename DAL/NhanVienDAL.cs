using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class NhanVienDAL
    {
        public QuanLyNhaXeDataContext db;
        public NhanVienDAL()
        {
            db = new QuanLyNhaXeDataContext();
        }
        public List<object> LoadNhanVien()
        {
            var dsNV = db.NHANVIENs.Select(nv => new
            {
                nv.USERNAME,
                nv.HOTEN,
                nv.SO_DT,
                nv.GIOITINH,
                nv.DIACHI,
                nv.LOAINV
            }).ToList();
            return dsNV.Cast<object>().ToList();
        }

        public bool Insert(NHANVIEN nv)
        {
            try
            {
                int result = db.ThemNhanVien(nv.USERNAME, nv.MAT_KHAU, nv.HOTEN, nv.SO_DT, nv.GIOITINH, nv.DIACHI, nv.LOAINV);
                return result == 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool Login(string username, string password)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username));
            if (nv != null)
            {
                if (nv.MAT_KHAU.Equals(password))
                {
                    DTO.Connect.ConnectString = $"Data Source = DESKTOP-86N3SME\\SQL_KING;Database=QuanLyBanVeXeKhach;Integrated Security=False;User Id={username};Password={password};";
                    return true;
                }
                else return false;
            }
            return false;
        }



        public string getTenNV(string username) {
            return db.NHANVIENs.First(t => t.USERNAME.Equals(username)).HOTEN;
        }


        public bool update(string username, NHANVIEN nvMoi)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username));
            if (nv == null)
            {
                return false;
            }
            try
            {
                nv.HOTEN = nvMoi.HOTEN;
                nv.SO_DT = nvMoi.SO_DT;
                nv.GIOITINH = nvMoi.GIOITINH;
                nv.DIACHI = nvMoi.DIACHI;
                nv.LOAINV = nvMoi.LOAINV;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex);
            }

        }

        public string getRoleNhanVien(string username)
        {
            return db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username)).LOAINV;
        }

        public NHANVIEN getThongTinNhanVien(string username)
        {
            return db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username));
        }

        public bool ktMatKhau(string password,string username)
        {
            return db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username) && t.MAT_KHAU.Equals(password)) != null;
        }

        public int DoiMatKhau(string newPassword,string username)
        {
            int result = (int)db.sp_DoiMatKhau(username, newPassword);
            return result;

        }
    }
}
