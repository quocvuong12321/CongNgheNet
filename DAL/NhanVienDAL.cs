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
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();
        public NhanVienDAL()
        {
            str = ConfigurationManager.ConnectionStrings["QLBanVeXe"].ConnectionString;
            conn = new SqlConnection(str);
        }

        public bool Insert(NhanVienDTO nv)
        {
            try {
                conn.Open();
                string sql = @"INSERT INTO NHANVIEN (USERNAME, MAT_KHAU, HOTEN, SO_DT, GIOITINH, DIACHI, LOAINV) VALUES
                    ('"+nv.UserName+ "', '"+nv.MatKhau+ "', N'"+nv.HoTen+ "', '"+nv.SDT+ "', N'"+nv.GioiTinh+ "', N'"+nv.DiaChi+ "', N'"+nv.LoaiNV+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
                conn.Close();
                return kq > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }

        public bool Login(string username, string password)
        {
            conn.Open();
                string sql = "select count(*) from NHANVIEN where USERNAME = '" + username + "' AND MAT_KHAU = '" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            return kq > 0;
        }

        public string getTenNV(string username) {
            string name = string.Empty;
                conn.Open();
                string sql = "select HOTEN from NHANVIEN where USERNAME = '" + username + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                name = (string)cmd.ExecuteScalar();
                conn.Close();
            return name;
        }



    }
}
