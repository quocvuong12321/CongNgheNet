using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class XeDAL
    {
        QuanLyNhaXeDataContext db;

        public XeDAL()
        {
            db = new QuanLyNhaXeDataContext(DTO.Connect.ConnectString);

        }
        public List<Xe> Xe()
        {
            return db.Xes.ToList();
        }
        public List<XeDTO> GetAllXe()
        {
            return db.Xes.Select(x => new XeDTO
            {
                Id = x.ID_XE,
                BienSoXe = x.BIEN_SO_XE,
                SoGhe = x.SO_GHE,
                NgayThem = x.NGAY_THEM
            }).ToList();
        }
        public void InsertXe(XeDTO xeDTO)
        {
            Xe xe = new Xe
            {
                BIEN_SO_XE = xeDTO.BienSoXe,
                SO_GHE = xeDTO.SoGhe,
                NGAY_THEM = DateTime.Now
            };
            db.Xes.InsertOnSubmit(xe);
            db.SubmitChanges();
        }
        public bool UpdateXe(XeDTO xeDTO)
        {
            Xe xe = db.Xes.FirstOrDefault(x => x.ID_XE == xeDTO.Id);
            if (xe != null)
            {
                xe.BIEN_SO_XE = xeDTO.BienSoXe;
                xe.SO_GHE = xeDTO.SoGhe;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool DeleteXe(int id)
        {
            Xe xe = db.Xes.FirstOrDefault(x => x.ID_XE == id);
            if (db.LichTrinhs.Contains(db.LichTrinhs.FirstOrDefault(t => t.ID_XE == id)))
            {
                return false;
            }
            if (xe != null)
            {
                db.Xes.DeleteOnSubmit(xe);
                db.SubmitChanges();
                return true;
            }
            return false;

        }
        public bool CheckBienSoXe(string bienSoXe)
        {
            return db.Xes.Any(x => x.BIEN_SO_XE == bienSoXe); // Kiểm tra nếu có xe với biển số này

        }

        public List<Xe> LayDanhSachXeTheoSoGhe(int soGhe)
        {
            return db.Xes
                     .Where(x => x.SO_GHE == soGhe)
                     .ToList();
        }

    }
}
