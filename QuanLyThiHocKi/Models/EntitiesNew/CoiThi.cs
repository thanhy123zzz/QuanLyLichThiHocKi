using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class CoiThi
    {
        public int Id { get; set; }
        public int Idcbct { get; set; }
        public int IdlichThi { get; set; }
        public int? Ca { get; set; }
        public DateTime? NgayThi { get; set; }
        public int? Idnhhk { get; set; }
        public bool? TrangThai { get; set; }

        public virtual CanBoCoiThi IdcbctNavigation { get; set; } = null!;
        public virtual LichThi IdlichThiNavigation { get; set; } = null!;
    }
}
