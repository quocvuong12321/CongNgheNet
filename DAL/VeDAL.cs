using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class VeDAL
    {
        QuanLyNhaXeDataContext db = new QuanLyNhaXeDataContext();

        public List<object> LoadlstVe(List<Ve> lstve)
        {
            var dsVe = lstve.Select(ve => new
            {
                ve.ID_VE,
                ve.ID_LICH_TRINH,
                ve.TENKHACHHANG,
                ve.SDT,
                ve.TONG_TIEN,
                ve.NHAN_VIEN_TAO,
                ve.TRANG_THAI,
                ve.NGAY_DAT_VE,
                ve.SOLUONG
            }).ToList();
            return dsVe.Cast<object>().ToList();
        }

        public List<object> LoadDSVe()
        {

            return LoadlstVe(db.Ves.ToList());
        }

      
        public List<object> locVe(string maLichTrinh, string trangThai)
        {
            var query = db.Ves.AsQueryable();

            if (!string.IsNullOrEmpty(maLichTrinh))
            {
                query = query.Where(t => t.ID_LICH_TRINH.Equals(maLichTrinh));
            }

            if(trangThai == "Đã thanh toán" || trangThai == "Chưa thanh toán")
            {
                query = query.Where(t => t.TRANG_THAI.Equals(trangThai));
            }

            return LoadlstVe(query.ToList());
        }

        public  List<object> TimKiemVe(string keyword)
        {
            var query = db.Ves.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(t => t.ID_VE.Contains(keyword) ||
                                    t.TENKHACHHANG.Contains(keyword) ||
                                    t.SDT.Contains(keyword)
                                    );
            }
            return LoadlstVe(query.ToList());
        }

        
    }
}
