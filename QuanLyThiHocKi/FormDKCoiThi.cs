using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;

namespace QuanLyThiHocKi
{
    public partial class FormDKCoiThi : Form
    {
        private int _id;
        public FormDKCoiThi(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormDKCoiThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var gv = context.GiangViens.Find(_id);

            var nhs1 = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            cbDotHoc.DataSource = nhs1;

            lbMaGV.Text = gv.MaGv;
            lbTenGV.Text = gv.HoTen;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                var gv = context.GiangViens.Find(_id);
                var cb = context.CanBoCoiThis.Where(x => x.MaGv == gv.MaGv && x.Idnhhk == (int)cbDotHoc.SelectedValue).ToList().Count == 0;
                if (cb)
                {
                    DkcoiThi dk = new DkcoiThi();
                    dk.Idnhhk = (int)cbDotHoc.SelectedValue;
                    dk.Idgv = _id;
                    dk.NgayDk = DateTime.Now.Date;
                    context.DkcoiThis.Add(dk);
                    context.SaveChanges();
                    tran.Commit();
                    MessageBox.Show("Đăng ký trông thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bạn đã là cán bộ coi thi ở học kì này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Bạn đã đăng ký trông thi ở học kì này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
