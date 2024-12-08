using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LichTrinhDAL
    {
        public string str;
        SqlConnection conn;

        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key;
        public LichTrinhDAL()
        {
            //str = ConfigurationManager.ConnectionStrings["QLBanVeXe"].ConnectionString;
            db = new QuanLyNhaXeDataContext(DTO.Connect.ConnectString);

            str = DTO.Connect.ConnectString;
            conn = new SqlConnection(str);

            ds = new DataSet();
            

        }

        public DataTable loadLichTrinh()
        {
            string sql = "Select * from LichTrinh where [TRANG_THAI] = N'Chưa đi';";

            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "lt");

            key = new DataColumn[1];
            key[0] = ds.Tables["lt"].Columns[0];
            return ds.Tables["lt"];
        }

        QuanLyNhaXeDataContext db;
        public List<ThongTinLichTrinhDTO> TTLichTrinh(int diemdau, int diemcuoi, DateTime ngaydi)
        {
            TuyenDuong d = db.TuyenDuongs.FirstOrDefault(t => t.DIEM_DAU == diemdau && t.DIEM_CUOI == diemcuoi);
            List<LichTrinh> lstLichTrinh = new List<LichTrinh>();

            if (d != null)
            {

                lstLichTrinh = db.LichTrinhs.Where(t => t.ID_TUYEN_DUONG == d.ID_TUYEN).ToList();
                if (lstLichTrinh.Any())
                {
                    var result = (from l in lstLichTrinh
                                  join td in db.TuyenDuongs on l.ID_TUYEN_DUONG equals td.ID_TUYEN
                                  join x in db.Xes on l.ID_XE equals x.ID_XE
                                  join ddau in db.DiaDiems on td.DIEM_DAU equals ddau.ID_DIADIEM
                                  join dcuoi in db.DiaDiems on td.DIEM_CUOI equals dcuoi.ID_DIADIEM
                                  select new
                                  {
                                      l.MA_LICH_TRINH,
                                      DiemDau = ddau.TEN_TINH_THANH,
                                      DiemCuoi = dcuoi.TEN_TINH_THANH,
                                      l.KHOI_HANH,
                                      l.KET_THUC,
                                      x.BIEN_SO_XE,
                                      l.GIA_VE
                                  }
                         );
                    List<ThongTinLichTrinhDTO> lst = new List<ThongTinLichTrinhDTO>();

                    foreach (var item in result)
                    {
                        ThongTinLichTrinhDTO tt = new ThongTinLichTrinhDTO(item.MA_LICH_TRINH, item.DiemDau, item.DiemCuoi, item.KHOI_HANH, item.KET_THUC, item.BIEN_SO_XE, (float)item.GIA_VE);
                        lst.Add(tt);
                    }
                    return lst.Where(t => String.Format("{0:dd/MM/yyyy}", t.GioDi) == String.Format("{0:dd/MM/yyyy}", ngaydi)).ToList();
                }
                return new List<ThongTinLichTrinhDTO>();
            }
            else
            {
                return new List<ThongTinLichTrinhDTO>();
            }
        }

        public bool ThemLichTrinh(string maLichTrinh, int maTuyenDuong, DateTime khoiHanh, float giaVe, int maXe)
        {
            if (ds.Tables["lt"] == null)
                loadLichTrinh();

            try
            {
                DataRow[] kiemTraTonTai = ds.Tables["lt"].Select("MA_LICH_TRINH = '" + maLichTrinh + "'");
                if (kiemTraTonTai.Length > 0)
                {
                    return false;
                }


                DataRow newR = ds.Tables["lt"].NewRow();
                newR["MA_LICH_TRINH"] = maLichTrinh;
                newR["ID_TUYEN_DUONG"] = maTuyenDuong;
                newR["KHOI_HANH"] = khoiHanh;
                newR["GIA_VE"] = giaVe;
                newR["ID_XE"] = maXe;
                newR["TRANG_THAI"] = "Chưa đi";

                ds.Tables["lt"].Rows.Add(newR);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "lt");


                ds.Tables["lt"].Clear();
                da.Fill(ds, "lt");


                return true;


            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi sửa lịch trình: " + ex.Message);
            }
        }


        public bool CapNhatLichTrinh(string maLichTrinh, int maTuyenDuong, DateTime khoiHanh, float giaVe, int maXe)
        {
            if (ds.Tables["lt"] == null)
                loadLichTrinh();
            try
            {
                DataRow[] rows = ds.Tables["lt"].Select("MA_LICH_TRINH = '" + maLichTrinh + "'");

                if (rows.Length != 0)
                {
                    DataRow row = rows[0];

                    row["ID_TUYEN_DUONG"] = maTuyenDuong;
                    row["KHOI_HANH"] = khoiHanh;
                    row["GIA_VE"] = giaVe;
                    row["ID_XE"] = maXe;

                    var thoiGianDiChuyen = db.TuyenDuongs.FirstOrDefault(td => td.ID_TUYEN == maTuyenDuong)?.THOI_GIAN_DI_CHUYEN;
                    if (thoiGianDiChuyen != null)
                    {
                        row["KET_THUC"] = khoiHanh.AddHours((double)thoiGianDiChuyen);
                    }

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "lt");

                    ds.Tables["lt"].Clear();
                    da.Fill(ds, "lt");

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi sửa lịch trình: " + ex.Message);
            }
        }

        //public List<string> LayMaLichTrinh()
        //{
        //    try
        //    {
        //        var danhSachMaLichTrinh = (from lt in db.LichTrinhs
        //                                   select lt.MA_LICH_TRINH).ToList();
        //        return danhSachMaLichTrinh;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Lỗi khi lấy danh sách mã lịch trình: " + ex.Message);
        //        return new List<string>();
        //    }
        //}

        public List<string> LayMaLichTrinh1()
        {
            try
            {
                var danhSachMaLichTrinh = (from lt in db.LichTrinhs
                                           where lt.KHOI_HANH > DateTime.Now
                                           select lt.MA_LICH_TRINH).ToList();
                return danhSachMaLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách mã lịch trình với ngày khởi hành nhỏ hơn ngày hiện tại: " + ex.Message);
                return new List<string>();
            }
        }





        public LichTrinh_DiemDau_DiemCuoi LayThongTinLichTrinh(string maLichTrinh)
        {
            try
            {
                var thongTinLichTrinh = (from lt in db.LichTrinhs
                                         join td in db.TuyenDuongs on lt.ID_TUYEN_DUONG equals td.ID_TUYEN
                                         join ddDau in db.DiaDiems on td.DIEM_DAU equals ddDau.ID_DIADIEM
                                         join ddCuoi in db.DiaDiems on td.DIEM_CUOI equals ddCuoi.ID_DIADIEM
                                         where lt.MA_LICH_TRINH == maLichTrinh
                                         select new LichTrinh_DiemDau_DiemCuoi(
                                             lt.MA_LICH_TRINH,
                                             td.TEN_TUYEN,
                                             ddDau.TEN_TINH_THANH,
                                             ddCuoi.TEN_TINH_THANH
                                         )).FirstOrDefault();


                return thongTinLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy thông tin lịch trình: " + ex.Message);
                return null;
            }
        }

        public List<LichTrinh> LayDanhSachLichTrinh()
        {
            try
            {
                var danhSachLichTrinh = db.LichTrinhs.ToList();
                return danhSachLichTrinh;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách lịch trình: " + ex.Message);
                return new List<LichTrinh>();
            }
        }

        public DataTable LayDanhSachLichTrinhTheoTuyenDuong(int maTuyenDuong)
        {
            if (ds.Tables["lt"] == null)
                loadLichTrinh();
            DataRow[] rowDs = ds.Tables["lt"].Select("ID_TUYEN_DUONG = '" + maTuyenDuong + "'");
            if (rowDs.Length != 0)
            {
                return rowDs.CopyToDataTable();
            }
            else
            {
                return ds.Tables["lt"].Clone();
            }
        }


        public double LayGiaLichTrinh(string maLichTrinh)
        {
            return db.LichTrinhs.FirstOrDefault(t => t.MA_LICH_TRINH.Equals(maLichTrinh)).GIA_VE;
        }


        public List<LichTrinh> loadLT()
        {
            return db.LichTrinhs.ToList();
        }

        public string taoMaLichTrinhTuDong()
        {
            int solt = db.LichTrinhs.Count() +1;
            return "LT" + solt.ToString("D3");
        }

        public void capnhatTrangThaiLT()
        {
            db.CapNhatTrangThaiLichTrinh();
        }
    }
}
