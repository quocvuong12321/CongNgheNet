using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class XeDTO
    {
        public int Id { get; set; }
        public string BienSoXe { get; set; }
        public int SoGhe { get; set; }
        public DateTime NgayThem { get; set; }
        public XeDTO()
        {
            Id = 0;
            BienSoXe = string.Empty;
            SoGhe = 0;
            NgayThem = DateTime.Now;
        }
        public XeDTO(int id, string bsx, int ghe, DateTime ngayThem)
        {
            Id = id;
            BienSoXe = bsx;
            SoGhe = ghe;
            NgayThem = ngayThem;
        }
    }

}
