using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();

        public List<LichTrinh> LayLichTrinhTheoNgay(DateTime ngay)
        {
            try
            {
                var danhSachLichTrinh = db.LichTrinhs
                    .Where(lt => lt.NGAY_TAO_LICH_TRINH.Date == ngay.Date)
                    .ToList();

                return danhSachLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình theo ngày: " + ex.Message);
                return new List<LichTrinh>();
            }
        }


        public List<Ve> LayDanhSachVeTheoMaLichTrinh(string maLichTrinh)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.ID_LICH_TRINH == maLichTrinh)
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo mã lịch trình: " + ex.Message);
                return new List<Ve>();
            }

        }

        public List<Ve> LayDanhSachVeTheoNgay(DateTime ngay)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.NGAY_DAT_VE.Date == ngay.Date) // Lọc vé theo ngày
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo ngày: " + ex.Message);
                return new List<Ve>(); // Trả về danh sách rỗng khi có lỗi
            }
        }


        public List<Ve> LayDanhSachVeTheoThang(int thang,int nam)
        {
            try
            {
                var danhSachVe = db.Ves
                    .Where(ve => ve.NGAY_DAT_VE.Month == thang && ve.NGAY_DAT_VE.Year == nam) // Lọc vé theo ngày
                    .ToList();

                return danhSachVe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách vé theo tháng: " + ex.Message);
                return new List<Ve>(); // Trả về danh sách rỗng khi có lỗi
            }
        }

        //public DataTable GetDoanhThuThang(int thang, int nam)
        //{
        //    DataTable dt = new DataTable();
        //    string query = "sp_GetDoanhThuThang";

        //    using (SqlConnection conn = new SqlConnection("Data Source = DESKTOP-I22SAC7\\TKHANGDI;Database=QuanLyBanVeXeKhach;Integrated Security=False;User Id=sa;Password=123;"))
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("Thang", thang));
        //        cmd.Parameters.Add(new SqlParameter("Nam", nam));

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //    }

        //    return dt;
        //}


    }
}
