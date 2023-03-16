using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class VaiTro
    {
        public VaiTro()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public int Id { get; set; }
        public string MaVaiTro { get; set; } = null!;
        public string? TenVaiTro { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
