using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string UserName { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string LoaiNV { get; set; }

        public NhanVienDTO()
        {
            UserName = string.Empty;
            MatKhau = string.Empty;
            HoTen = string.Empty;
            SDT = string.Empty;
            GioiTinh = string.Empty;
            DiaChi = string.Empty;
            LoaiNV = string.Empty;
        }
        public NhanVienDTO(string us,string mk,string ht,string sdt,string gt,string dc,string lnv)
        {
            UserName = us;
            MatKhau = mk;
            HoTen = ht;
            SDT = sdt;
            GioiTinh = gt;
            DiaChi = dc;
            LoaiNV = lnv;
        }

    }
}
