using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormPhanCong : Form
    {
        private int _id;
        public FormPhanCong(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormPhanCong_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            getLichThis1();
            getLichThis2();
            tableLichThi2.Columns["ID"].Visible = false;
            tableLichThi1.Columns["ID"].Visible = false;
            tableLichThi1.ClearSelection();
            tableLichThi2.ClearSelection();

        }
        private void getLichThis1()
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var cb = context.CanBoCoiThis.Find(_id);
            var a = context.LichThis.Include(x => x.IdlopNavigation)
            .Include(x => x.IdlopNavigation.IdhpNavigation)
            .Include(x => x.IdphNavigation)
            .Include(x => x.CoiThis)
            .Include(x => x.IdnhhkNavigation)
            .Include(x => x.CaNavigation)
            .Where(x => (x.TrangThai == true)
            && (x.TrangThaiToChuc == false)
            && (x.Idnhhk == cb.Idnhhk)
            && (x.CoiThis.Where(x => x.Idcbct == cb.Id).ToList().Count == 0)
            && ((x.CoiThis.Count < 1 && x.Sldk < 60) || (x.CoiThis.Count < 2 && x.Sldk >= 60)))
            .ToList();

            var ltcb = context.CoiThis
            .Where(x => (x.TrangThai == true)
            && (x.Idcbct == _id))
            .ToList();

            for (int z = 0; z < ltcb.Count; z++)
            {
                a.RemoveAll(x => (x.Idnhhk == ltcb[z].Idnhhk) && (x.Ca == ltcb[z].Ca) && (x.NgayThi == ltcb[z].NgayThi));
            }

            tableLichThi1.DataSource = a.Select(x => new
            {
                ID = x.Id,
                MaLop = x.IdlopNavigation.MaLop,
                MaHocPhan = x.IdlopNavigation.IdhpNavigation.MaHp,
                TenHP = x.IdlopNavigation.IdhpNavigation.TenHp,
                GhiChu = x.GhiChu,
                Nhom = x.Nhom,
                NHHK = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                Thu = x.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                NgayThi = x.NgayThi.ToString("dd-MM-yyyy"),
                Ca = x.CaNavigation.TenCa,
                SLDK = x.Sldk,
                PhongThi = x.IdphNavigation.TenPhong
            }).ToList();

        }
        private void getLichThis2()
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var cb = context.CanBoCoiThis.Find(_id);
            var a = context.CoiThis
            .Include(x => x.IdlichThiNavigation)
            .Include(x => x.IdlichThiNavigation.IdlopNavigation)
            .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
            .Include(x => x.IdlichThiNavigation.IdphNavigation)
            .Where(x => (x.TrangThai == true)
            && (x.Idcbct == _id)
            && (x.IdlichThiNavigation.Idnhhk == cb.Idnhhk))
            .Select(x =>
            new
            {
                ID = x.Id,
                MaLop = x.IdlichThiNavigation.IdlopNavigation.MaLop,
                MaHocPhan = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.MaHp,
                TenHP = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.TenHp,
                GhiChu = x.IdlichThiNavigation.GhiChu,
                Nhom = x.IdlichThiNavigation.Nhom,
                NHHK = "Học kì: " + x.IdlichThiNavigation.IdnhhkNavigation.HocKi + " Năm: " + x.IdlichThiNavigation.IdnhhkNavigation.NamHoc,
                Thu = x.IdlichThiNavigation.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                NgayThi = x.IdlichThiNavigation.NgayThi.ToString("dd-MM-yyyy"),
                Ca = x.IdlichThiNavigation.CaNavigation.TenCa,
                SLDK = x.IdlichThiNavigation.Sldk,
                PhongThi = x.IdlichThiNavigation.IdphNavigation.TenPhong,
                TrangThaiToChuc = x.IdlichThiNavigation.TrangThaiToChuc
            })
            .ToList();
            tableLichThi2.DataSource = a;
            foreach (DataGridViewRow row in tableLichThi2.Rows)
            {
                row.Tag = row.Cells["ID"].Value;
                bool tttc = (bool)row.Cells["TrangThaiToChuc"].Value;
                if (tttc)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var cb = context.CanBoCoiThis.Find(_id);
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableLichThi1.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    var lich = context.LichThis.Find(id);
                    CoiThi ct = new CoiThi();

                    ct.IdlichThi = id;
                    ct.Idcbct = _id;
                    ct.TrangThai = true;
                    ct.Idnhhk = cb.Idnhhk;
                    ct.Ca = lich.Ca;
                    ct.NgayThi = lich.NgayThi;

                    context.CoiThis.Add(ct);
                    context.SaveChanges();
                }
                MessageBox.Show("Phân công trông thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tran.Commit();
                getLichThis1();
                getLichThis2();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Phân công trông thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyPhanCong_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableLichThi2.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    CoiThi ct = context.CoiThis.Include(x => x.IdlichThiNavigation).Where(x => x.Id == id).FirstOrDefault();
                    if (!ct.IdlichThiNavigation.TrangThaiToChuc.Value)
                    {
                        context.CoiThis.Remove(ct);
                        context.SaveChanges();
                        MessageBox.Show("Huỷ công trông thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tran.Commit();
                        getLichThis1();
                        getLichThis2();
                    }
                    else
                    {
                        MessageBox.Show("Đã được tổ chức, không được huỷ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Huỷ công trông thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
