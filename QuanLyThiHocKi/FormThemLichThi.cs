using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormThemLichThi : Form
    {
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormThemLichThi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThemLichThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            /*            cbLopHoc.DataSource = context.LopHocs.Include(x => x.IdhpNavigation)
                            .Select(x => new { id = x.Id, MaLop = x.TenLop + "(" + x.IdhpNavigation.TenHp + ")" })
                            .ToList();
            */
            var newItem = new { id = 0, NamHoc = "None" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;
            cbCa.DataSource = context.Cas.ToList();
            /*            cbPhongHoc.DataSource = context.PhongHocs.Where(x => x.Loai == true).ToList();*/
            cbSX.DataSource = context.CachSxes.ToList();
            txtNgayThi.MinDate = DateTime.Now.Date;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            LichThi lichThi = new LichThi();

            lichThi.Idlop = (int)cbLopHoc.SelectedValue;
            lichThi.Idnhhk = (int)cbDotHoc.SelectedValue;
            lichThi.Idph = (int)cbPhongHoc.SelectedValue;
            lichThi.Ca = (int)cbCa.SelectedValue;
            lichThi.Idsx = (int)cbSX.SelectedValue;

            lichThi.GhiChu = txtGhiChu.Text;
            lichThi.Nhom = (int)txtNhom.Value;
            lichThi.Sldk = (int)txtSLDK.Value;
            string n = txtNgayThi.Text;
            lichThi.NgayThi = DateTime.ParseExact(n, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            lichThi.TrangThaiToChuc = false;
            lichThi.TrangThai = true;
            lichThi.KinhPhiToChuc = 0;

            var tran = context.Database.BeginTransaction();

            try
            {
                context.LichThis.Add(lichThi);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Thêm lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lịch thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        private void FormThemLichThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void cbDotHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            if ((int)cbDotHoc.SelectedValue != 0)
            {
                var newItem = new { id = 0, MaLop = "None" };
                var a = context.LopHocs.Include(x => x.IdhpNavigation)
                    .Include(x => x.LichThis)
                    .Where(x => (x.Idnhhk == (int)cbDotHoc.SelectedValue)
                    && (x.TrangThai == true)
                    && ((x.LichThis.Where(y => y.TrangThai == true).ToList().Count == 0) || (x.LichThis.Where(y => y.TrangThai == true).Sum(y => y.Sldk) < x.SiSo))
                    )
                    .Select(x => new { id = x.Id, MaLop = x.TenLop + "(" + x.IdhpNavigation.TenHp + ")" })
                    .ToList();
                a.Insert(0, newItem);
                cbLopHoc.DataSource = a;
            }
            else
            {
                cbLopHoc.Text = "";
                cbLopHoc.DataSource = context.LopHocs.Include(x => x.IdhpNavigation)
                    .Where(x => x.Id == 0)
                            .Select(x => new { id = x.Id, MaLop = x.TenLop + "(" + x.IdhpNavigation.TenHp + ")" })
                            .ToList();
            }
            txtNgayThi.Value = DateTime.Now;
        }

        private void cbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            int idLop = (int)cbLopHoc.SelectedValue;
            if (idLop != 0)
            {
                cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                    .Where(x => x.Loai == true
                    && (x.LichThis.Where(y => (y.Idnhhk == (int)cbDotHoc.SelectedValue)
                        && (y.NgayThi == txtNgayThi.Value)
                        && (y.Ca == (int)cbCa.SelectedValue)
                         && (y.TrangThai == true)
                        ).ToList().Count == 0)
                    ).ToList();

                var listlichThi = context.LichThis.Where(x => x.Idlop == idLop && x.TrangThai == true).ToList();
                var lop = context.LopHocs.Find(idLop);
                if (listlichThi.Count > 0)
                {
                    txtNhom.Minimum = listlichThi.Max(x => x.Nhom).Value + 1;
                    txtSLDK.Maximum = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                    txtSLDK.Value = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                }
                else
                {
                    txtNhom.Minimum = 1;
                    txtNhom.Value = 1;
                    txtSLDK.Maximum = lop.SiSo.Value;
                    txtSLDK.Value = lop.SiSo.Value;
                }
            }
            else
            {
                txtNgayThi.Value = DateTime.Now;
                cbCa.SelectedIndex = 0;

                cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                    .Where(x => x.Id == 0).ToList();
                cbPhongHoc.Text = "";
                txtNhom.Value = 1;
                txtSLDK.Value = 1;
            }
        }

        private void txtNgayThi_ValueChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            if (cbDotHoc.Items.Count > 0 && cbLopHoc.Items.Count > 0 && cbCa.Items.Count > 0 && (int)cbLopHoc.SelectedValue > 0)
            {
                int idLop = (int)cbLopHoc.SelectedValue;
                cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                    .Where(x => x.Loai == true
                    && (x.LichThis.Where(y => (y.Idnhhk == (int)cbDotHoc.SelectedValue)
                        && (y.NgayThi == txtNgayThi.Value)
                        && (y.Ca == (int)cbCa.SelectedValue)
                        && (y.TrangThai == true)
                        ).ToList().Count == 0)
                    ).ToList();

                var listlichThi = context.LichThis.Where(x => x.Idlop == idLop && x.TrangThai == true).ToList();
                var lop = context.LopHocs.Find(idLop);
                if (listlichThi.Count > 0)
                {
                    txtNhom.Value = listlichThi.Max(x => x.Nhom).Value + 1;
                    txtSLDK.Maximum = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                    txtSLDK.Value = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                }
                else
                {
                    txtNhom.Value = 1;
                    txtSLDK.Maximum = lop.SiSo.Value;
                    txtSLDK.Value = lop.SiSo.Value;
                }
            }
        }

        private void cbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            if (cbDotHoc.Items.Count > 0 && cbLopHoc.Items.Count > 0 && cbCa.Items.Count > 0 && (int)cbLopHoc.SelectedValue > 0)
            {
                int idLop = (int)cbLopHoc.SelectedValue;
                cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                    .Where(x => x.Loai == true
                    && (x.LichThis.Where(y => (y.Idnhhk == (int)cbDotHoc.SelectedValue)
                        && (y.NgayThi == txtNgayThi.Value)
                        && (y.Ca == (int)cbCa.SelectedValue)
                        && (y.TrangThai == true)
                        ).ToList().Count == 0)
                    ).ToList();

                var listlichThi = context.LichThis.Where(x => x.Idlop == idLop && x.TrangThai == true).ToList();
                var lop = context.LopHocs.Find(idLop);
                if (listlichThi.Count > 0)
                {

                    txtNhom.Minimum = listlichThi.Max(x => x.Nhom).Value + 1;
                    txtSLDK.Maximum = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                    txtSLDK.Value = lop.SiSo.Value - listlichThi.Sum(x => x.Sldk).Value;
                }
                else
                {
                    txtNhom.Minimum = 1;
                    txtNhom.Value = 1;
                    txtSLDK.Maximum = lop.SiSo.Value;
                    txtSLDK.Value = lop.SiSo.Value;
                }
            }
        }
    }
}
