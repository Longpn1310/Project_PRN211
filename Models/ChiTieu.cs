using System;
using System.Collections.Generic;

namespace Project_PRN211.Models
{
    public partial class ChiTieu
    {
        public string LoaiChi { get; set; } = null!;
        public string LoaiChiTieu { get; set; } = null!;
        public DateTime Ngaychi { get; set; }
        public string GhiChu { get; set; } = null!;
        public decimal SoTienChi { get; set; }
    }
}
