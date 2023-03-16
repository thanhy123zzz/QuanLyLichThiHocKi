using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Text.RegularExpressions;

namespace QuanLyThiHocKi
{
    public partial class FormSuaCanBo : Form
    {
        private int _id;
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormSuaCanBo(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSuaCanBo_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var gv = context.CanBoCoiThis
                .Where(x => x.Id == _id).FirstOrDefault();

            txtEmail.Text = gv.Email;
            txtSDT.Text = gv.Phone;
            txtMaGV.Text = gv.MaGv;
            txtTenGV.Text = gv.HoTen;

            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbPhong.DataSource = context.PhongHocs.Where(x => x.Loai == false).ToList();
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            cbDotThi.DataSource = nhs;

            cbHocPhan.SelectedValue = gv.Idhp;
            cbPhong.SelectedValue = gv.Idph;
            cbDotThi.SelectedValue = gv.Idnhhk;
        }

        private void FormSuaCanBo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                var gv = context.CanBoCoiThis
                .Where(x => x.Id == _id).FirstOrDefault();

                gv.HoTen = txtTenGV.Text;
                gv.Email = txtEmail.Text;
                gv.Phone = txtSDT.Text;
                gv.MaGv = txtMaGV.Text;

                gv.Idhp = (int)cbHocPhan.SelectedValue;
                gv.Idph = (int)cbPhong.SelectedValue;
                gv.Idnhhk = (int)cbDotThi.SelectedValue;

                context.CanBoCoiThis.Update(gv);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Sửa cán bộ coi thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show("Sửa cán bộ coi thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
