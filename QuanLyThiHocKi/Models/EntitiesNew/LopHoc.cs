using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class LopHoc
    {
        public LopHoc()
        {
            LichThis = new HashSet<LichThi>();
        }

        public int Id { get; set; }
        public string? MaLop { get; set; }
        public string? TenLop { get; set; }
        public int? Idhp { get; set; }
        public int? Idph { get; set; }
        public int? Idgv { get; set; }
        public int? Idnhhk { get; set; }
        public int? SiSo { get; set; }
        public bool? TrangThai { get; set; }

        public virtual GiangVien? IdgvNavigation { get; set; }
        public virtual HocPhan? IdhpNavigation { get; set; }
        public virtual NamHocHocKi? IdnhhkNavigation { get; set; }
        public virtual PhongHoc? IdphNavigation { get; set; }
        public virtual ICollection<LichThi> LichThis { get; set; }
    }
}
