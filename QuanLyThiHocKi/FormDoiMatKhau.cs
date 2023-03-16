using QuanLyThiHocKi.Models.EntitiesNew;

namespace QuanLyThiHocKi
{
    public partial class FormDoiMatKhau : Form
    {
        private int _id;
        private TaiKhoan _tk;
        public FormDoiMatKhau(int id)
        {
            InitializeComponent();
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            _tk = context.TaiKhoans.Find(id);
            _id = id;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOld.Text == _tk.MatKhau)
            {
                QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
                _tk.MatKhau = txtConfirm.Text;
                context.TaiKhoans.Update(_tk);
                context.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            if (txtNew.Text == txtConfirm.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtNew.Text == txtConfirm.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
