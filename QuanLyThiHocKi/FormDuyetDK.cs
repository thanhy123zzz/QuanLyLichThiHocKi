using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;

namespace QuanLyThiHocKi
{
    public partial class FormDuyetDK : Form
    {
        public FormDuyetDK()
        {
            InitializeComponent();
        }

        private void FormDuyetDK_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;

            tableDK.Columns["ID"].Visible = false;
        }

        private void getDSDK(int idNH)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var a = context.DkcoiThis
                        .Include(x => x.IdnhhkNavigation)
                        .Include(x => x.IdgvNavigation)
                        .Where(x => (idNH == 0 ? true : x.Idnhhk == idNH))
            .Select(x => new
            {
                ID = x.Id,
                MaGV = x.IdgvNavigation.MaGv,
                TenGV = x.IdgvNavigation.HoTen,
                NgayDK = x.NgayDk.Value.ToString("dd-MM-yyyy"),
                DotDK = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
            })
            .ToList();
            tableDK.DataSource = a;
        }

        private void cbDotHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDSDK((int)cbDotHoc.SelectedValue);
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableDK.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    var dk = context.DkcoiThis
                        .Include(x => x.IdgvNavigation).Where(x => x.Id == id).FirstOrDefault();

                    CanBoCoiThi cb = new CanBoCoiThi();
                    cb.MaGv = dk.IdgvNavigation.MaGv;
                    cb.HoTen = dk.IdgvNavigation.HoTen;
                    cb.Email = dk.IdgvNavigation.Email;
                    cb.Phone = dk.IdgvNavigation.Phone;
                    cb.Idnhhk = dk.Idnhhk;
                    cb.Idhp = dk.IdgvNavigation.Idhp;
                    cb.Idph = dk.IdgvNavigation.Idph;
                    cb.TrangThai = true;

                    context.CanBoCoiThis.Add(cb);
                    context.DkcoiThis.Remove(dk);
                    context.SaveChanges();
                }
                MessageBox.Show("Duyệt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tran.Commit();
                getDSDK((int)cbDotHoc.SelectedValue);
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Duyệt thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                foreach (DataGridViewRow r in tableDK.SelectedRows)
                {
                    int id = (int)r.Cells["ID"].Value;
                    var dk = context.DkcoiThis
                        .Include(x => x.IdgvNavigation).Where(x => x.Id == id).FirstOrDefault();
                    context.DkcoiThis.Remove(dk);
                    context.SaveChanges();
                }
                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tran.Commit();
                getDSDK((int)cbDotHoc.SelectedValue);
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
