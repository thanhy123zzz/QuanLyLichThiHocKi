using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class LichThi
    {
        public LichThi()
        {
            CoiThis = new HashSet<CoiThi>();
        }

        public int Id { get; set; }
        public int Idlop { get; set; }
        public string? GhiChu { get; set; }
        public int? Nhom { get; set; }
        public int? Idnhhk { get; set; }
        public DateTime NgayThi { get; set; }
        public int? Ca { get; set; }
        public int? Sldk { get; set; }
        public int Idph { get; set; }
        public bool? TrangThaiToChuc { get; set; }
        public double? KinhPhiToChuc { get; set; }
        public bool? TrangThai { get; set; }
        public int? Idsx { get; set; }

        public virtual Ca? CaNavigation { get; set; }
        public virtual LopHoc IdlopNavigation { get; set; } = null!;
        public virtual NamHocHocKi? IdnhhkNavigation { get; set; }
        public virtual PhongHoc IdphNavigation { get; set; } = null!;
        public virtual CachSx? IdsxNavigation { get; set; }
        public virtual ICollection<CoiThi> CoiThis { get; set; }
    }
}
