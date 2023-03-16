using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Text.RegularExpressions;

namespace QuanLyThiHocKi
{
    public partial class FormSuaGiangVien : Form
    {
        private int _id;
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormSuaGiangVien(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void FormSuaGiangVien_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var gv = context.GiangViens
                .Include(x => x.IdtkNavigation)
                .Where(x => x.Id == _id).FirstOrDefault();

            txtEmail.Text = gv.Email;
            txtSDT.Text = gv.Phone;
            txtMaGV.Text = gv.MaGv;
            txtTenGV.Text = gv.HoTen;
            txtMatKhau.Text = gv.IdtkNavigation.MatKhau == null ? "" : gv.IdtkNavigation.MatKhau;
            txtTaiKhoan.Text = gv.IdtkNavigation.TaiKhoan1 == null ? "" : gv.IdtkNavigation.TaiKhoan1;

            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbPhong.DataSource = context.PhongHocs.Where(x => x.Loai == false).ToList();

            cbHocPhan.SelectedValue = gv.Idhp;
            cbPhong.SelectedValue = gv.Idph;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                var gv = context.GiangViens
                .Include(x => x.IdtkNavigation)
                .Where(x => x.Id == _id).FirstOrDefault();

                TaiKhoan tk = gv.IdtkNavigation;

                tk.TaiKhoan1 = txtTaiKhoan.Text;
                tk.MatKhau = txtMatKhau.Text;
                context.TaiKhoans.Update(tk);
                context.SaveChanges();

                gv.HoTen = txtTenGV.Text;
                gv.Email = txtEmail.Text;
                gv.Phone = txtSDT.Text;
                gv.MaGv = txtMaGV.Text;

                gv.Idhp = (int)cbHocPhan.SelectedValue;
                gv.Idph = (int)cbPhong.SelectedValue;

                context.GiangViens.Update(gv);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Sửa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Sửa giảng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSuaGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            // định dạng email
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            // sử dụng hàm Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            // định dạng số điện thoại
            string pattern = @"^(0|\+84)(3[2-9]|5[689]|7[0|6-9]|8[1-9]|9[0-4|6-9])\d{7}$";

            // sử dụng hàm Regex.IsMatch để kiểm tra
            return Regex.IsMatch(phoneNumber, pattern);
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng");
                txtEmail.Focus();
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                txtSDT.Focus();
            }
        }
    }
}
