using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class XeBLL
    {
        XeDAL xeDal = new XeDAL();
        public List<Xe> Xe()
        {
            return xeDal.Xe();
        }
        XeDAL xeDAL = new XeDAL();
        public List<XeDTO> GetAllXe()
        {
            return xeDAL.GetAllXe();
        }
        public void InsertXe(XeDTO xe)
        {
            xeDAL.InsertXe(xe);
        }
        public bool UpdateXe(XeDTO xe)
        {
            return xeDAL.UpdateXe(xe);
        }
        public void DeleteXe(int id)
        {
            xeDAL.DeleteXe(id);
        }
        public bool CheckBienSoXe(string bienSoXe)
        {
            return xeDAL.CheckBienSoXe(bienSoXe);
        }

        public List<Xe> LayDanhSachXeTheoSoGhe(int soGhe)
        {
            return xeDAL.LayDanhSachXeTheoSoGhe(soGhe);
        }



    }
}
