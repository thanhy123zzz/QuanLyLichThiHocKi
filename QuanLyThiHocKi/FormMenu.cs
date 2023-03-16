using QuanLyThiHocKi.Models.EntitiesNew;

namespace QuanLyThiHocKi
{
    public partial class FormMenu : Form
    {
        private readonly TaiKhoan tk;
        public FormMenu(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnQLLichThi_Click(object sender, EventArgs e)
        {
            FormQuanLyLichThi form = new FormQuanLyLichThi(tk);
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLGV_Click(object sender, EventArgs e)
        {
            FormQuanLyGiangVien form = new FormQuanLyGiangVien(tk);
            form.ShowDialog();
        }

        private void btnQLCB_Click(object sender, EventArgs e)
        {
            FormQuanLyCoiThi form = new FormQuanLyCoiThi();
            form.ShowDialog();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            form.ShowDialog();
        }
    }
}
