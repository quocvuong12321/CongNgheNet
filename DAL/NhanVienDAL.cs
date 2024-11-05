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
        public string str;
        SqlConnection conn;
        public QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();
        public NhanVienDAL()
        {
            str = ConfigurationManager.ConnectionStrings["QLBanVeXe"].ConnectionString;
            conn = new SqlConnection(str);
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
            try {
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }

        public bool Login(string username, string password)
        {

            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(t => t.USERNAME.Equals(username));
            if (nv != null)
            {
                if (nv.MAT_KHAU.Equals(password))
                    return true;
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
    }
}
