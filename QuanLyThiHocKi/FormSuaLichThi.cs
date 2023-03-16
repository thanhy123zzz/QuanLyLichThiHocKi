using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormSuaLichThi : Form
    {
        private LichThi _lichThi;
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormSuaLichThi(LichThi lichThi)
        {
            InitializeComponent();
            _lichThi = lichThi;
        }

        private void FormSuaLichThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var lop = context.LopHocs.Find(_lichThi.Idlop);
            var dotHoc = context.NamHocHocKis.Find(_lichThi.Idnhhk);
            txtLop.Text = lop.TenLop + "(" + lop.MaLop + ")";

            txtDotHoc.Text = "Học kì: " + dotHoc.HocKi + " Năm: " + dotHoc.NamHoc;

            txtNgayThi.MinDate = dotHoc.Tu.Value;
            txtNgayThi.MaxDate = dotHoc.Den.Value;

            cbCa.DataSource = context.Cas.ToList();
            cbCa.SelectedValue = _lichThi.Ca;

            var phongHoc = context.PhongHocs.Include(x => x.LichThis)
                    .Where(x => x.Loai == true
                    && (x.LichThis.Where(y => (y.Idnhhk == _lichThi.Idnhhk)
                        && (y.NgayThi == _lichThi.NgayThi.Date)

                        && (y.Ca == _lichThi.Ca)).ToList().Count == 0)

                    ).ToList();
            PhongHoc p = new PhongHoc();
            p.Id = _lichThi.Idph;
            p.TenPhong = context.PhongHocs.Find(_lichThi.Idph).TenPhong;
            phongHoc.Insert(0, p);
            cbPhongHoc.DataSource = phongHoc;

            cbPhongHoc.SelectedValue = _lichThi.Idph;

            cbSX.DataSource = context.CachSxes.ToList();
            cbSX.SelectedValue = _lichThi.Idsx;

            txtGhiChu.Text = _lichThi.GhiChu;
            txtNgayThi.Value = _lichThi.NgayThi;

            var lisLichThi = context.LichThis
                .Where(x => x.Idlop == _lichThi.Idlop && x.Id != _lichThi.Id).ToList();

            txtNhom.Value = (decimal)_lichThi.Nhom;

            txtSLDK.Maximum = lop.SiSo.Value - lisLichThi.Sum(x => x.Sldk).Value;
            txtSLDK.Value = _lichThi.Sldk.Value;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            _lichThi.Idph = (int)cbPhongHoc.SelectedValue;
            _lichThi.Idsx = (int)cbSX.SelectedValue;
            _lichThi.Ca = (int)cbCa.SelectedValue;

            _lichThi.GhiChu = txtGhiChu.Text;
            _lichThi.Nhom = (int)txtNhom.Value;
            _lichThi.Sldk = (int)txtSLDK.Value;
            string n = txtNgayThi.Text;
            _lichThi.NgayThi = DateTime.ParseExact(n, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            _lichThi.TrangThaiToChuc = false;
            _lichThi.TrangThai = true;
            _lichThi.KinhPhiToChuc = 0;

            var tran = context.Database.BeginTransaction();

            try
            {
                context.LichThis.Update(_lichThi);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Sửa lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa lịch thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        private void FormSuaLichThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNgayThi_ValueChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                .Where(x => x.Loai == true
                && (x.LichThis.Where(y => (y.Idnhhk == _lichThi.Idnhhk)
                    && (y.NgayThi == txtNgayThi.Value)
                    && (y.TrangThai == true)
                    && (y.Ca == (int)cbCa.SelectedValue)).ToList().Count == 0)

                ).ToList();

            var lop = context.LopHocs.Find(_lichThi.Idlop);
            var lisLichThi = context.LichThis.Where(x => x.Idlop == _lichThi.Idlop && x.Id != _lichThi.Id).ToList();

            txtNhom.Value = (decimal)_lichThi.Nhom;

            txtSLDK.Maximum = lop.SiSo.Value - lisLichThi.Sum(x => x.Sldk).Value;
            txtSLDK.Value = _lichThi.Sldk.Value;
        }

        private void cbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            cbPhongHoc.DataSource = context.PhongHocs.Include(x => x.LichThis)
                .Where(x => x.Loai == true
                && (x.LichThis.Where(y => (y.Idnhhk == _lichThi.Idnhhk && x.Id != _lichThi.Id)
                    && (y.NgayThi == txtNgayThi.Value)
                    && (y.TrangThai == true)
                    && (y.Ca == (int)cbCa.SelectedValue)).ToList().Count == 0)
                ).ToList();

            var lop = context.LopHocs.Find(_lichThi.Idlop);
            var lisLichThi = context.LichThis.Where(x => x.Idlop == _lichThi.Idlop && x.Id != _lichThi.Id).ToList();

            txtNhom.Value = (decimal)_lichThi.Nhom;

            txtSLDK.Maximum = lop.SiSo.Value - lisLichThi.Sum(x => x.Sldk).Value;
            txtSLDK.Value = _lichThi.Sldk.Value;
        }
    }
}
