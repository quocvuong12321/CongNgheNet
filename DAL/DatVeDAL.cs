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

        public int LaySoVe(string maLichTrinh)
        {
            int count = db.Ves.Where(t => t.ID_LICH_TRINH.Equals(maLichTrinh)).Count();
            return count + 1;
        }

        public bool LuuVe(Ve ve)
        {
            try
            {
                db.Ves.InsertOnSubmit(ve);
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex);
            }
        }

        public bool LuuChiTietVe(ChiTietVe ctVe)
        {
            try
            {
                db.ChiTietVes.InsertOnSubmit(ctVe);
                db.SubmitChanges();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.GHEs);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex);
            }
        }

        public int LayIDGhe(string viTriNgoi, string MaLichTrinh)
        {
            return db.GHEs.FirstOrDefault(t => t.VI_TRI_NGOI.Equals(viTriNgoi) && t.MA_LICH_TRINH.Equals(MaLichTrinh)).ID_GHE;
        }


    }
}
