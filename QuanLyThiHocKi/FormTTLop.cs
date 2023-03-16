using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;

namespace QuanLyThiHocKi
{
    public partial class FormTTLop : Form
    {
        private int _id;
        public FormTTLop(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormTTLop_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            tableLopHocs.DataSource = GetLopHocChuaDK("", 0, 0);
            getLopHocDangGD();
            foreach (DataGridViewRow row in tableLopHocs.Rows)
            {
                row.Tag = row.Cells["ID"].Value;
            }
            tableLopHocs.Columns["ID"].Visible = false;
            HocPhan hp = new HocPhan();
            hp.Id = 0;
            hp.TenHp = "Tất cả";
            var hps = context.HocPhans.ToList();
            hps.Insert(0, hp);
            cbHocPhan.DataSource = hps;

            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;
            var gv = context.GiangViens.Find(_id);
            groupBox3.Text += gv.HoTen;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tableLopHocs.DataSource = GetLopHocChuaDK(txtKeyWord.Text, (int)cbHocPhan.SelectedValue, (int)cbDotHoc.SelectedValue);
            foreach (DataGridViewRow row in tableLopHocs.Rows)
            {
                row.Tag = row.Cells["ID"].Value;
            }
        }
        public dynamic GetLopHocChuaDK(string key, int idHP, int idNH)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.LopHocs
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdnhhkNavigation)
                .Where(x => x.Idgv == null
                && (key == "" ? true : (x.MaLop + " " + x.TenLop + " " + x.IdhpNavigation.TenHp + " " + x.IdhpNavigation.MaHp).ToLower().Contains(key.ToLower()))
                && (idHP == 0 ? true : idHP == x.Idhp)
                && (idNH == 0 ? true : idNH == x.Idnhhk)
                )
                .Select(x => new
                {
                    ID = x.Id,
                    MaLop = x.MaLop,
                    TenLop = x.TenLop,
                    MaHP = x.IdhpNavigation.MaHp,
                    TenHP = x.IdhpNavigation.TenHp,
                    DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                })
                .ToList();
                return a;
            }
        }
        public void getLopHocDangGD()
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.LopHocs
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdnhhkNavigation)
                .Where(x => x.Idgv == _id)
                .Select(x => new
                {
                    ID = x.Id,
                    MaLop = x.MaLop,
                    TenLop = x.TenLop,
                    MaHP = x.IdhpNavigation.MaHp,
                    TenHP = x.IdhpNavigation.TenHp,
                    DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                })
                .ToList();
                tableGDLopHocs.DataSource = a;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableLopHocs.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    var lop = context.LopHocs.Find(id);

                    lop.Idgv = _id;

                    context.LopHocs.Update(lop);

                    context.SaveChanges();
                }
                MessageBox.Show("Phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Phân công thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tableLopHocs.DataSource = GetLopHocChuaDK(txtKeyWord.Text, (int)cbHocPhan.SelectedValue, (int)cbDotHoc.SelectedValue);
            getLopHocDangGD();
            foreach (DataGridViewRow row in tableLopHocs.Rows)
            {
                row.Tag = row.Cells["ID"].Value;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableGDLopHocs.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    var lop = context.LopHocs.Find(id);

                    lop.Idgv = null;

                    context.LopHocs.Update(lop);

                    context.SaveChanges();
                }
                MessageBox.Show("Huỷ phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Huỷ phân công thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tableLopHocs.DataSource = GetLopHocChuaDK(txtKeyWord.Text, (int)cbHocPhan.SelectedValue, (int)cbDotHoc.SelectedValue);
            getLopHocDangGD();
            foreach (DataGridViewRow row in tableLopHocs.Rows)
            {
                row.Tag = row.Cells["ID"].Value;
            }
        }
    }
}
