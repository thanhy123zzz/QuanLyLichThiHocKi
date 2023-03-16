using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Xử lý sự kiện ở đây
            // Ví dụ:
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void FormatNumberTextBoxes()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                if (double.TryParse(textBox.Text, out double number))
                {
                    textBox.Text = number.ToString("#,##0");
                }
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            var context = new QuanLyThiHocKiContext();
            GetTTGiangVienGD("", true);
            tableGDGiangVien.Columns["ID"].Visible = false;
            tableGDLopHocs.Columns["ID"].Visible = false;
            cbGDTrangThaiGV.SelectedIndex = 0;
            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs1 = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs1.Insert(0, newItem);
            cbGDDotHocLop.DataSource = nhs1;

            var nhs2 = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs2.Insert(0, newItem);
            cbCBDotThi.DataSource = nhs2;

            var nhs3 = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs3.Insert(0, newItem);
            cbTKLopDotHoc.DataSource = nhs3;

            var nhs4 = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs4.Insert(0, newItem);
            cbTKCTDotHoc.DataSource = nhs4;
            cbCBTrangThai.SelectedIndex = 0;

            var kinhPhi = context.KinhPhis.ToList();

            txtInAn.Text = kinhPhi[0].DonGia.Value.ToString("#,##0");
            txtPhoto.Text = kinhPhi[1].DonGia.Value.ToString("#,##0");
            txtKinhPhi.Text = kinhPhi[2].DonGia.Value.ToString("#,##0");
            txtTienCB.Text = kinhPhi[3].DonGia.Value.ToString("#,##0");
            txtInAn.KeyPress += textBox_KeyPress;
            txtKinhPhi.KeyPress += textBox_KeyPress;
            txtPhoto.KeyPress += textBox_KeyPress;
            txtTienCB.KeyPress += textBox_KeyPress;
        }
        private void GetTTGiangVienGD(string key, bool tt)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                if (tt)
                {
                    var a = context.GiangViens
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                    .Where(x => x.TrangThai == true
                    && (key == "" ? true : (x.MaGv + " " + x.HoTen + " " + x.Phone + " " + x.Email + " " + x.IdhpNavigation.TenHp + " " + x.IdphNavigation.TenPhong + " " + x.IdtkNavigation.TaiKhoan1).ToLower().Contains(key.ToLower()))
                    )
                    .Select(x =>
                    new
                    {
                        ID = x.Id,
                        MaGV = x.MaGv,
                        HoTen = x.HoTen,
                        Phone = x.Phone,
                        Email = x.Email,
                        MonGV = x.IdhpNavigation.TenHp,
                        PhongGV = x.IdphNavigation.TenPhong,
                        TrangThai = x.TrangThai
                    })
                        .ToList();
                    tableGDGiangVien.DataSource = a;
                    foreach (DataGridViewRow row in tableGDGiangVien.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                    }

                }
                else
                {
                    var a = context.GiangViens
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                    .Where(x => (key == "" ? true : (x.MaGv + " " + x.HoTen + " " + x.Phone + " " + x.Email + " " + x.IdhpNavigation.TenHp + " " + x.IdphNavigation.TenPhong + " " + x.IdtkNavigation.TaiKhoan1).ToLower().Contains(key.ToLower()))
                    )
                    .Select(x =>
                    new
                    {
                        ID = x.Id,
                        MaGV = x.MaGv,
                        HoTen = x.HoTen,
                        Phone = x.Phone,
                        Email = x.Email,
                        MonGV = x.IdhpNavigation.TenHp,
                        PhongGV = x.IdphNavigation.TenPhong,
                        TrangThai = x.TrangThai
                    })
                        .ToList();
                    tableGDGiangVien.DataSource = a;
                    foreach (DataGridViewRow row in tableGDGiangVien.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                        bool tttc = (bool)row.Cells["TrangThai"].Value;
                        if (!tttc)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
            }
        }
        private void GetTableLopHocGD(int idNH)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                int rowIndex = tableGDGiangVien.SelectedCells[0].RowIndex;
                int id = (int)tableGDGiangVien.Rows[rowIndex].Cells[0].Value;

                var a = context.LopHocs
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdnhhkNavigation)
                .Include(x => x.LichThis)
                .Where(x => (x.Idgv == id)
                && (idNH == 0 ? true : x.Idnhhk == idNH)
                )
                .Select(x => new
                {
                    ID = x.Id,
                    MaLop = x.MaLop,
                    TenLop = x.TenLop,
                    MaHP = x.IdhpNavigation.MaHp,
                    TenHP = x.IdhpNavigation.TenHp,
                    DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                })
                .ToList();
                tableGDLopHocs.DataSource = a;
                foreach (DataGridViewRow row in tableGDLopHocs.Rows)
                {
                    row.Cells["TongChiPhi"].Value = tinhChiPhi((int)row.Cells["ID"].Value).ToString("#,##0");
                }
            }
        }
        private void GetTTCBCT(string key, bool tt, int idNH)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                if (tt)
                {
                    var a = context.CanBoCoiThis
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                        .Where(x => x.TrangThai == true
                        && (idNH == 0 ? true : x.Idnhhk == idNH)
                        && (key == "" ? true : (x.MaGv + " " + x.HoTen + " " + x.Phone + " " + x.Email + " " + x.IdhpNavigation.TenHp + " " + x.IdphNavigation.TenPhong).ToLower().Contains(key.ToLower()))
                        )
                        .Select(x =>
                        new
                        {
                            ID = x.Id,
                            MaCB = x.MaGv,
                            HoTen = x.HoTen,
                            Phone = x.Phone,
                            Email = x.Email,
                            MonGV = x.IdhpNavigation.TenHp,
                            Phong = x.IdphNavigation.TenPhong,
                            TrangThai = x.TrangThai
                        })
                        .ToList();
                    tableCBCanBo.DataSource = a;
                }
                else
                {
                    var a = context.CanBoCoiThis
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                        .Where(x => (idNH == 0 ? true : x.Idnhhk == idNH)
                        && (key == "" ? true : (x.MaGv + " " + x.HoTen + " " + x.Phone + " " + x.Email + " " + x.IdhpNavigation.TenHp + " " + x.IdphNavigation.TenPhong).ToLower().Contains(key.ToLower()))
                        )
                        .Select(x =>
                        new
                        {
                            ID = x.Id,
                            MaGV = x.MaGv,
                            HoTen = x.HoTen,
                            Phone = x.Phone,
                            Email = x.Email,
                            MonGV = x.IdhpNavigation.TenHp,
                            PhongGV = x.IdphNavigation.TenPhong,
                            TrangThai = x.TrangThai
                        })
                        .ToList();
                    tableCBCanBo.DataSource = a;
                }
            }
        }
        private void GetLichThiList(int idNH)
        {
            int rowIndex = tableCBCanBo.SelectedCells[0].RowIndex;
            int id = (int)tableCBCanBo.Rows[rowIndex].Cells[0].Value;
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.CoiThis.Include(x => x.IdlichThiNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
                    .Include(x => x.IdlichThiNavigation.IdnhhkNavigation)
                    .Include(x => x.IdlichThiNavigation.IdphNavigation)
                    .Where(x => (x.TrangThai == true) && (x.Idcbct == id)
                    && (idNH == 0 ? true : (x.IdlichThiNavigation.Idnhhk == idNH))
                    )
                    .Select(x =>
                    new
                    {
                        MaLop = x.IdlichThiNavigation.IdlopNavigation.MaLop,
                        MaHocPhan = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.MaHp,
                        TenHP = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.TenHp,
                        GhiChu = x.IdlichThiNavigation.GhiChu,
                        Nhom = x.IdlichThiNavigation.Nhom,
                        NHHK = "Học kì: " + x.IdlichThiNavigation.IdnhhkNavigation.HocKi + " Năm: "
                        + x.IdlichThiNavigation.IdnhhkNavigation.NamHoc,
                        Thu = x.IdlichThiNavigation.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                        NgayThi = x.IdlichThiNavigation.NgayThi.ToString("dd-MM-yyyy"),
                        Ca = x.IdlichThiNavigation.CaNavigation.TenCa,
                        SLDK = x.IdlichThiNavigation.Sldk,
                        PhongThi = x.IdlichThiNavigation.IdphNavigation.TenPhong,
                        TrangThaiToChuc = x.IdlichThiNavigation.TrangThaiToChuc == true ? "Đã tổ chức" : "Chưa tổ chức"
                    })
                    .ToList();
                tableCBLichThi.DataSource = a;
            }
        }

        private void getTTLopHoc(string key, int idNH)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.LopHocs
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdnhhkNavigation)
                .Include(x => x.IdgvNavigation)
                .Include(x => x.LichThis)
                .Where(x =>
                (idNH == 0 ? true : x.Idnhhk == idNH)
                && (x.TrangThai == true)
                && (key == "" ? true : (x.IdgvNavigation.MaGv + " " + x.IdgvNavigation.HoTen + " " + x.MaLop + " " + x.TenLop + " " + x.IdhpNavigation.MaHp + " " + x.IdhpNavigation.TenHp).ToLower().Contains(key.ToLower()))
                )
                .Select(x => new
                {
                    ID = x.Id,
                    MaLop = x.MaLop,
                    TenLop = x.TenLop,
                    MaHP = x.IdhpNavigation.MaHp,
                    TenHP = x.IdhpNavigation.TenHp,
                    DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                    TenGV = x.IdgvNavigation.HoTen,
                    MaGV = x.IdgvNavigation.MaGv
                })
                .ToList();
                tableTKLopHoc.DataSource = a;
            }
        }
        double tinhChiPhi(int id)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var listChiPhi = context.KinhPhis.ToList();
            var lich = context.LichThis.Include(x => x.CoiThis).Where(x => x.Idlop == id);
            double? tong = 0;
            if (lich != null)
            {
                foreach (LichThi l in lich)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < 3)
                        {
                            tong += listChiPhi[i].DonGia * l.Sldk;
                        }
                        else
                        {
                            tong += listChiPhi[i].DonGia * l.CoiThis.Count;
                        }
                    }
                }
                return tong.Value;
            }
            return 0;
        }
        private void btnGDRefreshGV_Click(object sender, EventArgs e)
        {
            GetTTGiangVienGD("", true);

            var context = new QuanLyThiHocKiContext();
            var a = context.LopHocs
            .Include(x => x.IdhpNavigation)
            .Include(x => x.IdnhhkNavigation)
            .Include(x => x.LichThis)
            .Where(x => x.Id == 0)
            .Select(x => new
            {
                ID = x.Id,
                MaLop = x.MaLop,
                TenLop = x.TenLop,
                MaHP = x.IdhpNavigation.MaHp,
                TenHP = x.IdhpNavigation.TenHp,
                DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
            })
            .ToList();
            tableGDLopHocs.DataSource = a;

            txtGDKeyWordGV.Text = "";
            cbGDTrangThaiGV.SelectedIndex = 0;
        }

        private void btnGDSearchGV_Click(object sender, EventArgs e)
        {
            GetTTGiangVienGD(txtGDKeyWordGV.Text, (cbGDTrangThaiGV.SelectedIndex == 0 ? true : false));
            var context = new QuanLyThiHocKiContext();
            var a = context.LopHocs
            .Include(x => x.IdhpNavigation)
            .Include(x => x.IdnhhkNavigation)
            .Include(x => x.LichThis)
            .Where(x => x.Id == 0)
            .Select(x => new
            {
                ID = x.Id,
                MaLop = x.MaLop,
                TenLop = x.TenLop,
                MaHP = x.IdhpNavigation.MaHp,
                TenHP = x.IdhpNavigation.TenHp,
                DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
            })
            .ToList();
            tableGDLopHocs.DataSource = a;
        }

        private void tableGDGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTableLopHocGD((int)cbGDDotHocLop.SelectedValue);
        }

        private void btnGDSearchLop_Click(object sender, EventArgs e)
        {
            GetTableLopHocGD((int)cbGDDotHocLop.SelectedValue);
        }

        private void btnGDRefreshLop_Click(object sender, EventArgs e)
        {
            GetTableLopHocGD(0);
            cbGDDotHocLop.SelectedIndex = 0;
        }

        private void tableGDLopHocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = tableGDLopHocs.SelectedCells[0].RowIndex;
            var id = (int)tableGDLopHocs.Rows[rowIndex].Cells["ID"].Value;
            FormChiTietLopHoc form = new FormChiTietLopHoc(id);
            form.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*            if (tabControl1.SelectedIndex == 0)
                        {
                            var context = new QuanLyThiHocKiContext();
                            GetTTGiangVienGD("", true);
                            tableGDGiangVien.Columns["ID"].Visible = false;
                            tableGDLopHocs.Columns["ID"].Visible = false;
                            cbGDTrangThaiGV.SelectedIndex = 0;
                            var newItem = new { id = 0, NamHoc = "Tất cả" };
                            var nhs = context.NamHocHocKis
                                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                                .ToList();
                            nhs.Insert(0, newItem);
                            cbGDDotHocLop.DataSource = nhs;
                        }
                        if (tabControl1.SelectedIndex == 1)
                        {

                        }
                        if (tabControl1.SelectedIndex == 2)
                        {

                        }*/
        }

        private void btnCBRefresh_Click(object sender, EventArgs e)
        {
            txtCBKeyWord.Text = "";
            cbCBDotThi.SelectedIndex = 0;
            cbCBTrangThai.SelectedIndex = 0;
            var context = new QuanLyThiHocKiContext();
            var a = context.CanBoCoiThis
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                        .Where(x => x.Id == 0)
            .Select(x =>
            new
            {
                ID = x.Id,
                MaCB = x.MaGv,
                HoTen = x.HoTen,
                Phone = x.Phone,
                Email = x.Email,
                MonGV = x.IdhpNavigation.TenHp,
                Phong = x.IdphNavigation.TenPhong,
                TrangThai = x.TrangThai
            })
            .ToList();
            tableCBCanBo.DataSource = a;

            var b = context.CoiThis.Include(x => x.IdlichThiNavigation)
                .Include(x => x.IdlichThiNavigation.IdlopNavigation)
                .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
                .Include(x => x.IdlichThiNavigation.IdnhhkNavigation)
                .Include(x => x.IdlichThiNavigation.IdphNavigation)
                .Where(x => x.Id == 0)
                .Select(x =>
                new
                {
                    MaLop = x.IdlichThiNavigation.IdlopNavigation.MaLop,
                    MaHocPhan = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.MaHp,
                    TenHP = x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.TenHp,
                    GhiChu = x.IdlichThiNavigation.GhiChu,
                    Nhom = x.IdlichThiNavigation.Nhom,
                    NHHK = "Học kì: " + x.IdlichThiNavigation.IdnhhkNavigation.HocKi + " Năm: " + x.IdlichThiNavigation.IdnhhkNavigation.NamHoc,
                    Thu = x.IdlichThiNavigation.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                    NgayThi = x.IdlichThiNavigation.NgayThi.ToString("dd-MM-yyyy"),
                    Ca = x.IdlichThiNavigation.CaNavigation.TenCa,
                    SLDK = x.IdlichThiNavigation.Sldk,
                    PhongThi = x.IdlichThiNavigation.IdphNavigation.TenPhong,
                    TrangThaiToChuc = x.IdlichThiNavigation.TrangThaiToChuc == true ? "Đã tổ chức" : "Chưa tổ chức"
                })
                .ToList();
            tableCBLichThi.DataSource = b;
        }

        private void btnCBSearch_Click(object sender, EventArgs e)
        {
            GetTTCBCT(txtCBKeyWord.Text, (cbCBTrangThai.SelectedIndex == 0 ? true : false), (int)cbCBDotThi.SelectedValue);
        }

        private void tableCBCanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetLichThiList(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getTTLopHoc(txtTKLopKeyWord.Text, (int)cbTKLopDotHoc.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new QuanLyThiHocKiContext();
            var a = context.LopHocs
            .Include(x => x.IdhpNavigation)
            .Include(x => x.IdnhhkNavigation)
            .Include(x => x.IdgvNavigation)
            .Where(x => x.Id == 0)
            .Select(x => new
            {
                ID = x.Id,
                MaLop = x.MaLop,
                TenLop = x.TenLop,
                MaHP = x.IdhpNavigation.MaHp,
                TenHP = x.IdhpNavigation.TenHp,
                DotHoc = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                TenGV = x.IdgvNavigation.HoTen,
                MaGV = x.IdgvNavigation.MaGv
            })
            .ToList();
            tableTKLopHoc.DataSource = a;
            txtTKLopKeyWord.Text = "";
            cbTKLopDotHoc.SelectedIndex = 0;
        }

        private void cbTKCTDotHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetLichThiList((int)cbTKCTDotHoc.SelectedValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetLichThiList((int)cbTKCTDotHoc.SelectedValue);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtTienCB_Leave(object sender, EventArgs e)
        {
            if (txtTienCB.Text != "")
            {
                double t = double.Parse(txtTienCB.Text);
                txtTienCB.Text = t.ToString("#,##0");
            }
        }

        private void txtKinhPhi_Leave(object sender, EventArgs e)
        {
            if (txtKinhPhi.Text != "")
            {
                double t = double.Parse(txtKinhPhi.Text);
                txtKinhPhi.Text = t.ToString("#,##0");
            }
        }

        private void txtPhoto_Leave(object sender, EventArgs e)
        {
            if (txtPhoto.Text != "")
            {
                double t = double.Parse(txtPhoto.Text);
                txtPhoto.Text = t.ToString("#,##0");
            }
        }

        private void txtInAn_Leave(object sender, EventArgs e)
        {
            if (txtInAn.Text != "")
            {
                double t = double.Parse(txtInAn.Text);
                txtInAn.Text = t.ToString("#,##0");
            }
        }

        private void btnDoiKinhPhi_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            if (txtInAn.Text != "" && txtKinhPhi.Text != "" && txtPhoto.Text != "" && txtTienCB.Text != "")
            {
                var kinhPhi = context.KinhPhis.ToList();
                kinhPhi[0].DonGia = double.Parse(txtInAn.Text);
                kinhPhi[1].DonGia = double.Parse(txtPhoto.Text);
                kinhPhi[2].DonGia = double.Parse(txtKinhPhi.Text);
                kinhPhi[3].DonGia = double.Parse(txtTienCB.Text);
                context.KinhPhis.UpdateRange(kinhPhi);
                context.SaveChanges();
                MessageBox.Show("Sửa kinh phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
