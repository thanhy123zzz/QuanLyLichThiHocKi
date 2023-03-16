using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class KinhPhi
    {
        public int Id { get; set; }
        public string? TenGia { get; set; }
        public double? DonGia { get; set; }
        public bool? TrangThai { get; set; }
    }
}
