using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TuyenDuongBLL
    {
        TuyenDuongDAL tdDAL = new TuyenDuongDAL();

        public List<TuyenDuong> TuyenDuong()
        {
            return tdDAL.TuyenDuong();
        }
        public List<TuyenDuongDTO> GetAll()
        {
            return tdDAL.GetAll();
        }    
        public void insertTuyen(TuyenDuong td)
        {
            tdDAL.InsertTuyen(td);
        }
        public void updateTuyen(TuyenDuong td)
        {
            tdDAL.UpdateTuyen(td);
        }
        public bool deleteTuyen(int id)
        {
            return tdDAL.DeleteTuyen(id);
        }
        public bool CheckTrungTenTuyen(string ten)
        {
            return tdDAL.CheckTrungTenTuyen(ten);
        }
        public bool CheckTrungTenTuyenKhiCapNhat(string tenTuyen, int idTuyen)
        {
            return tdDAL.CheckTrungTenTuyenKhiCapNhat(tenTuyen, idTuyen);
        }
        public bool CheckTrungTuyen(int diemDau, int diemCuoi)
        {
            return tdDAL.CheckTrungTuyen(diemDau, diemCuoi);
        }
        public int timMaTuyenDuong(string tenTuyen)
        {
            return tdDAL.timMaTuyenDuong(tenTuyen);
        }
    }
}
