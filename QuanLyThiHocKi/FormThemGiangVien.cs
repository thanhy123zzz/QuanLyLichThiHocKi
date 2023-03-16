using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Text.RegularExpressions;

namespace QuanLyThiHocKi
{
    public partial class FormThemGiangVien : Form
    {
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormThemGiangVien()
        {
            InitializeComponent();
        }

        private void FormThemGiangVien_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            LopHoc l = new LopHoc();
            l.Id = 0;
            l.TenLop = "None";

            var lops = context.LopHocs.Where(x => x.Idgv == null).ToList();
            lops.Insert(0, l);
            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbPhong.DataSource = context.PhongHocs.Where(x => x.Loai == false).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MatKhau = txtMatKhau.Text;
                tk.TaiKhoan1 = txtTaiKhoan.Text;
                tk.Idvt = 2;

                context.TaiKhoans.Add(tk);
                context.SaveChanges();

                GiangVien gv = new GiangVien();
                gv.HoTen = txtTenGV.Text;
                gv.Email = txtEmail.Text;
                gv.Phone = txtSDT.Text;
                gv.MaGv = txtMaGV.Text;

                gv.Idhp = (int)cbHocPhan.SelectedValue;
                gv.Idph = (int)cbPhong.SelectedValue;
                gv.Idtk = tk.Id;

                gv.TrangThai = true;

                context.GiangViens.Add(gv);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Thêm giảng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormThemGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng");
                txtEmail.Focus();
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
        // kiểm tra chuỗi nhập vào có đúng định dạng số điện thoại hay không
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            // định dạng số điện thoại
            string pattern = @"^(0|\+84)(3[2-9]|5[689]|7[0|6-9]|8[1-9]|9[0-4|6-9])\d{7}$";

            // sử dụng hàm Regex.IsMatch để kiểm tra
            return Regex.IsMatch(phoneNumber, pattern);
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
