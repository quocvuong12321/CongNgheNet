﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenDuongDTO
    {
        public int IdTuyen { get; set; }
        public string TenTuyen { get; set; }
        public string DiemDau { get; set; }
        public string DiemCuoi { get; set; }
        public float KhoangCach { get; set; }
        public float TgianDiChuyen { get; set; }

        public TuyenDuongDTO()
        {
            IdTuyen = 0;
            TenTuyen = string.Empty;
            DiemDau = string.Empty;
            DiemCuoi = string.Empty;
            KhoangCach = 0;
            TgianDiChuyen = 0;
        }
        public TuyenDuongDTO(int id, string ten, string dd, string dc, float kc, float tg)
        {
            IdTuyen = id;
            TenTuyen = ten;
            DiemDau = dd;
            DiemCuoi = dc;
            KhoangCach = kc;
            TgianDiChuyen = tg;
        }
    }
}
