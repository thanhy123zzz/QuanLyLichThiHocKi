using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class CachSx
    {
        public CachSx()
        {
            LichThis = new HashSet<LichThi>();
        }

        public int Id { get; set; }
        public string? TenCachSx { get; set; }

        public virtual ICollection<LichThi> LichThis { get; set; }
    }
}
