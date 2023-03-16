using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class DkcoiThi
    {
        public int Id { get; set; }
        public int? Idgv { get; set; }
        public int? Idnhhk { get; set; }
        public DateTime? NgayDk { get; set; }

        public virtual GiangVien? IdgvNavigation { get; set; }
        public virtual NamHocHocKi? IdnhhkNavigation { get; set; }
    }
}
