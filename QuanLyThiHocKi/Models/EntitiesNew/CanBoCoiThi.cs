using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class CanBoCoiThi
    {
        public CanBoCoiThi()
        {
            CoiThis = new HashSet<CoiThi>();
        }

        public int Id { get; set; }
        public string MaGv { get; set; } = null!;
        public string? HoTen { get; set; }
        public int? Idhp { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public int? Idph { get; set; }
        public int? Idnhhk { get; set; }
        public bool? TrangThai { get; set; }
        public int? Idtk { get; set; }

        public virtual HocPhan? IdhpNavigation { get; set; }
        public virtual NamHocHocKi? IdnhhkNavigation { get; set; }
        public virtual PhongHoc? IdphNavigation { get; set; }
        public virtual TaiKhoan? IdtkNavigation { get; set; }
        public virtual ICollection<CoiThi> CoiThis { get; set; }
    }
}
