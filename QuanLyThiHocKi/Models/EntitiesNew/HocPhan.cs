using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class HocPhan
    {
        public HocPhan()
        {
            CanBoCoiThis = new HashSet<CanBoCoiThi>();
            GiangViens = new HashSet<GiangVien>();
            LopHocs = new HashSet<LopHoc>();
        }

        public int Id { get; set; }
        public string? MaHp { get; set; }
        public string? TenHp { get; set; }
        public int? SoTinChi { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<CanBoCoiThi> CanBoCoiThis { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
