using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class PhongHoc
    {
        public PhongHoc()
        {
            CanBoCoiThis = new HashSet<CanBoCoiThi>();
            GiangViens = new HashSet<GiangVien>();
            LichThis = new HashSet<LichThi>();
            LopHocs = new HashSet<LopHoc>();
        }

        public int Id { get; set; }
        public string MaPhong { get; set; } = null!;
        public string? TenPhong { get; set; }
        public bool? Loai { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<CanBoCoiThi> CanBoCoiThis { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<LichThi> LichThis { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
