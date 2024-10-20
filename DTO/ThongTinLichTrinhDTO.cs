using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinLichTrinhDTO
    {
        public ThongTinLichTrinhDTO(string maLichTrinh, string diemDon, string diemTra, DateTime gioDi, DateTime? gioDen, string bienSoXe, float giaVe)
        {
            MaLichTrinh = maLichTrinh;
            DiemDon = diemDon;
            DiemTra = diemTra;
            GioDi = gioDi;
            GioDen = gioDen ?? DateTime.MinValue;
            BienSoXe = bienSoXe;
            GiaVe = giaVe;
        }

        public string MaLichTrinh { get; set; }
        public string DiemDon { get; set; }
        public string DiemTra { get; set; }
        public DateTime GioDi { get; set; }
        public DateTime GioDen { get; set; }
        public string BienSoXe { get; set; }
        public float GiaVe { get; set; }

    }
}
