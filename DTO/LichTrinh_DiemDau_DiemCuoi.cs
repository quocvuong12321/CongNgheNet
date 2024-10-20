using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichTrinh_DiemDau_DiemCuoi
    {
        public string MaLichTrinh { get; set; }
        public string TenTuyenDuong { get; set; }
        public string DiemDau { get; set; }
        public string DiemCuoi { get; set; }

        public LichTrinh_DiemDau_DiemCuoi(string maLichTrinh, string tenTuyenDuong, string diemDau, string diemCuoi)
        {
            MaLichTrinh = maLichTrinh;
            TenTuyenDuong = tenTuyenDuong;
            DiemDau = diemDau;
            DiemCuoi = diemCuoi;
        }

        
    }
}
