using QuanLyThiHocKi.Models.EntitiesNew;
using System.Text.RegularExpressions;

namespace QuanLyThiHocKi
{
    public partial class FormThemCanBo : Form
    {
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormThemCanBo()
        {
            InitializeComponent();
        }

        private void FormThemCanBo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void FormThemCanBo_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbPhong.DataSource = context.PhongHocs.Where(x => x.Loai == false).ToList();
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            cbDotThi.DataSource = nhs;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                CanBoCoiThi gv = new CanBoCoiThi();
                gv.HoTen = txtTenGV.Text;
                gv.Email = txtEmail.Text;
                gv.Phone = txtSDT.Text;
                gv.MaGv = txtMaGV.Text;

                gv.Idhp = (int)cbHocPhan.SelectedValue;
                gv.Idph = (int)cbPhong.SelectedValue;
                gv.Idnhhk = (int)cbDotThi.SelectedValue;

                gv.TrangThai = true;

                context.CanBoCoiThis.Add(gv);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Thêm cán bộ coi thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Thêm cán bộ coi thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng");
                txtEmail.Focus();
            }
        }
    }
}
