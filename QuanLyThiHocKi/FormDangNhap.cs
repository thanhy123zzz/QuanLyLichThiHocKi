using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;

namespace QuanLyThiHocKi
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            var acc = context.TaiKhoans
                .Include(x => x.IdvtNavigation)
                .Where(x => x.TaiKhoan1.Equals(taiKhoan) && x.MatKhau.Equals(matKhau)).FirstOrDefault();

            if (acc == null)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (acc.Idvt == 1)
                {
                    var gv = context.GiangViens.Where(x => x.Idtk == acc.Id && x.TrangThai == true).FirstOrDefault();
                    if (gv == null)
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormGiangVien form = new FormGiangVien(gv.Id);
                        form.ShowDialog();
                    }
                }
                if (acc.Idvt == 2)
                {
                    FormMenu form = new FormMenu(acc);
                    form.ShowDialog();
                }
                if (acc.Idvt == 3)
                {
                    var cb = context.CanBoCoiThis.Where(x => x.Idtk == acc.Id && x.TrangThai == true).FirstOrDefault();
                    if (cb == null)
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FormCanBo form = new FormCanBo(cb.Id);
                        form.ShowDialog();
                    }


                }
            }
        }
    }
}
