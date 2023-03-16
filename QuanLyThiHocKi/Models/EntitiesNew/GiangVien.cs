using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            DkcoiThis = new HashSet<DkcoiThi>();
            LopHocs = new HashSet<LopHoc>();
        }

        public int Id { get; set; }
        public string MaGv { get; set; } = null!;
        public string? HoTen { get; set; }
        public int? Idhp { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? Idph { get; set; }
        public int? Idtk { get; set; }
        public bool? TrangThai { get; set; }

        public virtual HocPhan? IdhpNavigation { get; set; }
        public virtual PhongHoc? IdphNavigation { get; set; }
        public virtual TaiKhoan? IdtkNavigation { get; set; }
        public virtual ICollection<DkcoiThi> DkcoiThis { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
