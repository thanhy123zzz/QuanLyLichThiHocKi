using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormThemNHHK : Form
    {
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormThemNHHK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            NamHocHocKi n = new NamHocHocKi();
            n.Tu = DateTime.ParseExact(txtTu.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            n.Den = DateTime.ParseExact(txtDen.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            n.NamHoc = txtNamHoc.Text;
            n.HocKi = txtHocKi.Text;

            context.NamHocHocKis.Add(n);
            context.SaveChanges();
            MessageBox.Show("Thêm lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormThemNHHK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }

        private void FormThemNHHK_Load(object sender, EventArgs e)
        {
        }

        private void txtTu_ValueChanged(object sender, EventArgs e)
        {
            txtTu.MaxDate = txtDen.Value;
            txtDen.MinDate = txtTu.Value;
        }

        private void txtDen_ValueChanged(object sender, EventArgs e)
        {
            txtTu.MaxDate = txtDen.Value;
            txtDen.MinDate = txtTu.Value;
        }
    }
}
