using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormQuanLyLichThi : Form
    {
        private readonly TaiKhoan tk;

        public FormQuanLyLichThi(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void FormQuanLyLichThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            /*GetLichThiList(0, 0, "", true);
            tableLichThi.Columns["ID"].Visible = false;*/

            HocPhan hp = new HocPhan();
            hp.Id = 0;
            hp.TenHp = "Tất cả";
            var hps = context.HocPhans.ToList();
            hps.Insert(0, hp);
            cbHocPhan.DataSource = hps;

            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;

            cbTrangThai.SelectedIndex = 0;

        }

        public void GetLichThiList(int idDH, int idHP, string key, bool tt)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                if (tt)
                {
                    var a = context.LichThis.Include(x => x.IdlopNavigation)
                        .Include(x => x.IdlopNavigation.IdhpNavigation)
                        .Include(x => x.IdlopNavigation)
                        .Include(x => x.IdphNavigation)
                        .Where(x => (x.TrangThai == true)

                        && (idHP == 0 ? true : x.IdlopNavigation.Idhp == idHP)
                        && (idDH == 0 ? true : x.Idnhhk == idDH)
                        && (key == "" ? true : (x.IdlopNavigation.MaLop + " " + x.IdlopNavigation.IdhpNavigation.TenHp + " " + x.IdlopNavigation.IdhpNavigation.MaHp + " " + x.GhiChu + " " + x.IdphNavigation.MaPhong).ToLower().Contains(key.ToLower()))
                        )
                        .Select(x =>
                        new
                        {
                            ID = x.Id,
                            MaLop = x.IdlopNavigation.MaLop,
                            MaHocPhan = x.IdlopNavigation.IdhpNavigation.MaHp,
                            TenHP = x.IdlopNavigation.IdhpNavigation.TenHp,
                            GhiChu = x.GhiChu,
                            Nhom = x.Nhom,
                            NHHK = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                            Thu = x.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                            NgayThi = x.NgayThi.ToString("dd-MM-yyyy"),
                            Ca = x.CaNavigation.TenCa,
                            SLDK = x.Sldk,
                            PhongThi = x.IdphNavigation.TenPhong,
                            TrangThaiToChuc = x.TrangThaiToChuc
                        })
                        .ToList();
                    tableLichThi.DataSource = a;
                    foreach (DataGridViewRow row in tableLichThi.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                        bool tttc = (bool)row.Cells["TrangThaiToChuc"].Value;
                        if (tttc)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }

                }
                else
                {
                    var a = context.LichThis.Include(x => x.IdlopNavigation)
                       .Include(x => x.IdlopNavigation.IdhpNavigation)
                       .Include(x => x.IdlopNavigation)
                       .Include(x => x.IdphNavigation)
                       .Where(x =>
                       (idHP == 0 ? true : x.IdlopNavigation.Idhp == idHP)
                       && (idDH == 0 ? true : x.Idnhhk == idDH)
                       && (key == "" ? true : (x.IdlopNavigation.MaLop + " " + x.IdlopNavigation.IdhpNavigation.TenHp + " " + x.IdlopNavigation.IdhpNavigation.MaHp + " " + x.GhiChu + " " + x.IdphNavigation.MaPhong).ToLower().Contains(key.ToLower()))
                       )
                       .Select(x =>
                       new
                       {
                           ID = x.Id,
                           MaLop = x.IdlopNavigation.MaLop,
                           MaHocPhan = x.IdlopNavigation.IdhpNavigation.MaHp,
                           TenHP = x.IdlopNavigation.IdhpNavigation.TenHp,
                           GhiChu = x.GhiChu,
                           Nhom = x.Nhom,
                           NHHK = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                           Thu = x.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                           NgayThi = x.NgayThi.ToString("dd-MM-yyyy"),
                           Ca = x.CaNavigation.TenCa,
                           SLDK = x.Sldk,
                           PhongThi = x.IdphNavigation.TenPhong,
                           TrangThaiToChuc = x.TrangThaiToChuc
                       })
                       .ToList();
                    tableLichThi.DataSource = a;
                    foreach (DataGridViewRow row in tableLichThi.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                        bool tttc = (bool)row.Cells["TrangThaiToChuc"].Value;
                        if (tttc)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }

                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddLichThi_Click(object sender, EventArgs e)
        {
            FormThemLichThi form = new FormThemLichThi();
            form.FormClosedCallback = new FormThemLichThi.FormClosedHandler(ChildFormClosed);
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyword.Text = "";
            cbDotHoc.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            cbHocPhan.SelectedIndex = 0;
            var context = new QuanLyThiHocKiContext();
            var a = context.LichThis.Include(x => x.IdlopNavigation)
            .Include(x => x.IdlopNavigation.IdhpNavigation)
            .Include(x => x.IdlopNavigation)
            .Include(x => x.IdphNavigation)
            .Where(x => x.Id == 0)
                    .Select(x =>
                    new
                    {
                        ID = x.Id,
                        MaLop = x.IdlopNavigation.MaLop,
                        MaHocPhan = x.IdlopNavigation.IdhpNavigation.MaHp,
                        TenHP = x.IdlopNavigation.IdhpNavigation.TenHp,
                        GhiChu = x.GhiChu,
                        Nhom = x.Nhom,
                        NHHK = "Học kì: " + x.IdnhhkNavigation.HocKi + " Năm: " + x.IdnhhkNavigation.NamHoc,
                        Thu = x.NgayThi.ToString("dddd", new CultureInfo("vi-VN")),
                        NgayThi = x.NgayThi.ToString("dd-MM-yyyy"),
                        Ca = x.CaNavigation.TenCa,
                        SLDK = x.Sldk,
                        PhongThi = x.IdphNavigation.TenPhong,
                        TrangThaiToChuc = x.TrangThaiToChuc
                    })
            .ToList();
            tableLichThi.DataSource = a;
            tableKinhPhi.Rows.Clear();
            txtTongTien.Text = "";
            button2.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            if (tableLichThi.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = tableLichThi.SelectedRows[0];
                int id = selectedRow.Tag == null ? 0 : (int)selectedRow.Tag;
                var l = context.LichThis
                    .Find(id);
                if (l == null || l.TrangThaiToChuc == true)
                {
                    MessageBox.Show("Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormSuaLichThi form = new FormSuaLichThi(l);

                    form.FormClosedCallback = new FormSuaLichThi.FormClosedHandler(ChildFormClosed);

                    form.ShowDialog();
                }

            }
        }
        // Định nghĩa sự kiện FormClosed của form con
        private void ChildFormClosed()
        {
            GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
        }
        private void FormThemNHHKClose()
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            if (tableLichThi.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = tableLichThi.SelectedRows[0];
                int id = selectedRow.Tag == null ? 0 : (int)selectedRow.Tag;
                var l = context.LichThis.Find(id);

                if (l == null || l.TrangThaiToChuc == true)
                {
                    MessageBox.Show("Không thể xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    l.TrangThai = false;
                    context.LichThis.Update(l);
                    context.SaveChanges();
                    MessageBox.Show("Xoá lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
                }
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Cấu hình các thuộc tính cho OpenFileDialog
            openFileDialog1.Title = "Chọn một file";
            openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";

            // Hiển thị OpenFileDialog và kiểm tra xem người dùng đã chọn tệp tin hay chưa
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tệp tin được chọn
                string filePath = openFileDialog1.FileName;

                txtFilePath.Text = filePath;

            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string sourceFile = Application.StartupPath + @"\Files\MauExcel.xlsx"; // đường dẫn tệp gốc trong dự án
            string destFile = @"C:\Users\ASUS\Downloads\MauExcel.xlsx"; // đường dẫn để lưu trữ tệp

            File.Copy(sourceFile, destFile, true); // sao chép tệp từ thư mục gốc của dự án vào đường dẫn mới

            MessageBox.Show("Tải hoàn tất, tệp đã được tải xuống trong :" + destFile); // thông báo khi tải xuống hoàn tất
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(txtFilePath.Text);
            if (f != null)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(f))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault(); // lấy worksheet đầu tiên

                    if (worksheet != null)
                    {
                        QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
                        int rowCount = worksheet.Dimension.Rows; // số hàng trong sheet
                        int colCount = worksheet.Dimension.Columns; // số cột trong sheet
                        var tran = context.Database.BeginTransaction();
                        try
                        {
                            for (int row = 7; row <= rowCount + 1; row++)
                            {

                                LichThi l = new LichThi();

                                var lop = context.LopHocs.Where(x => x.MaLop == worksheet.Cells[row, 1].Value).FirstOrDefault();
                                l.Idlop = lop.Id;

                                l.GhiChu = (string)worksheet.Cells[row, 2].Value;

                                l.Nhom = Convert.ToInt32(worksheet.Cells[row, 3].Value);

                                var dotHoc = context.NamHocHocKis.Find(Convert.ToInt32(worksheet.Cells[row, 4].Value));
                                l.Idnhhk = dotHoc.Id;

                                string ngThi = (string)worksheet.Cells[row, 5].Value;
                                l.NgayThi = DateTime.ParseExact(ngThi, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                                l.Ca = Convert.ToInt32(worksheet.Cells[row, 6].Value);

                                l.Sldk = Convert.ToInt32(worksheet.Cells[row, 7].Value);

                                var phong = context.PhongHocs.Where(x => x.MaPhong == worksheet.Cells[row, 8].Value).FirstOrDefault();
                                l.Idph = phong.Id;

                                l.Idsx = Convert.ToInt32(worksheet.Cells[row, 9].Value);

                                l.TrangThai = true;
                                l.TrangThaiToChuc = false;
                                l.KinhPhiToChuc = 0;

                                context.LichThis.Add(l);
                                context.SaveChanges();
                            }
                            package.Dispose();
                            tran.Commit();
                            MessageBox.Show("Import lịch thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Import lịch thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
            tableLichThi.Columns["ID"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tongTien = double.Parse(txtTongTien.Text);
            DataGridViewRow selectedRow = tableLichThi.SelectedRows[0];
            int id = selectedRow.Tag == null ? 0 : (int)selectedRow.Tag;
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var lich = context.LichThis.Find(id);
            lich.KinhPhiToChuc = tongTien;
            lich.TrangThaiToChuc = true;
            context.LichThis.Update(lich);
            context.SaveChanges();
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
        }

        private void FormQuanLyLichThi_Resize(object sender, EventArgs e)
        {
        }


        private void tableLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableLichThi.Rows.Count > 0)
            {
                tableKinhPhi.Rows.Clear();
                DataGridViewRow selectedRow = tableLichThi.SelectedRows[0];
                int id = selectedRow.Tag == null ? 0 : (int)selectedRow.Tag;

                QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
                var listChiPhi = context.KinhPhis.ToList();
                var lich = context.LichThis.Include(x => x.CoiThis).Where(x => x.Id == id).FirstOrDefault();

                double? tong = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (i < 3)
                    {
                        string[] a = new string[] { listChiPhi[i].TenGia, listChiPhi[i].DonGia.Value.ToString("#,##0"), lich.Sldk.ToString(), (listChiPhi[i].DonGia * lich.Sldk).Value.ToString("#,##0") };
                        tableKinhPhi.Rows.Add(a);
                        tong += listChiPhi[i].DonGia * lich.Sldk;
                    }
                    else
                    {
                        string[] a = new string[] { listChiPhi[i].TenGia, listChiPhi[i].DonGia.Value.ToString("#,##0"), lich.CoiThis.Count.ToString(), (listChiPhi[i].DonGia * lich.CoiThis.Count).Value.ToString("#,##0") };
                        tableKinhPhi.Rows.Add(a);
                        tong += listChiPhi[i].DonGia * lich.CoiThis.Count;
                    }
                }
                if ((bool)selectedRow.Cells["TrangThaiToChuc"].Value)
                {
                    button2.Enabled = false;
                    label5.Text = "Đã thanh toán";
                    label5.ForeColor = Color.Green;
                }
                else
                {
                    label5.Text = "Tổng thanh toán";
                    label5.ForeColor = Color.Black;
                    if (lich.NgayThi > DateTime.Now.Date)
                    {
                        button2.Enabled = false;
                    }
                    else
                    {
                        button2.Enabled = true;
                    }
                }
                txtTongTien.Text = tong.Value.ToString("#,##0");
            }
        }

        private void btnThemDotHoc_Click(object sender, EventArgs e)
        {
            FormThemNHHK form = new FormThemNHHK();

            form.FormClosedCallback = new FormThemNHHK.FormClosedHandler(FormThemNHHKClose);

            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = tableLichThi.SelectedRows[0];
            int id = selectedRow.Tag == null ? 0 : (int)selectedRow.Tag;
            if (id != 0)
            {
                FormXemSX form = new FormXemSX(id);
                form.Show();
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            GetLichThiList((int)cbDotHoc.SelectedValue, (int)cbHocPhan.SelectedValue, txtKeyword.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
            tableLichThi.Columns["ID"].Visible = false;
        }
    }
}