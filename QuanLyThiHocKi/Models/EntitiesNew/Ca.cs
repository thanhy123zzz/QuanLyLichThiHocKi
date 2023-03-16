using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class Ca
    {
        public Ca()
        {
            LichThis = new HashSet<LichThi>();
        }

        public int Id { get; set; }
        public string? TenCa { get; set; }
        public TimeSpan? Tu { get; set; }
        public TimeSpan? Den { get; set; }

        public virtual ICollection<LichThi> LichThis { get; set; }
    }
}
