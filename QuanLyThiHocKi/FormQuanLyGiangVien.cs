using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Text.RegularExpressions;

namespace QuanLyThiHocKi
{
    public partial class FormQuanLyGiangVien : Form
    {
        private readonly TaiKhoan tk;
        public FormQuanLyGiangVien(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        public void GetTTGiangVien(string key, bool tt)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                if (tt)
                {
                    var a = context.GiangViens
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                        .Include(x => x.IdtkNavigation)
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
                            TaiKhoan = x.IdtkNavigation.TaiKhoan1,
                            MatKhau = x.IdtkNavigation.MatKhau,
                            TrangThai = x.TrangThai
                        })
                        .ToList();
                    tableGiangVien.DataSource = a;
                    foreach (DataGridViewRow row in tableGiangVien.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                    }

                }
                else
                {
                    var a = context.GiangViens
                        .Include(x => x.IdhpNavigation)
                        .Include(x => x.IdphNavigation)
                        .Include(x => x.IdtkNavigation)
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
                            TaiKhoan = x.IdtkNavigation.TaiKhoan1,
                            MatKhau = x.IdtkNavigation.MatKhau,
                            TrangThai = x.TrangThai
                        })
                        .ToList();
                    tableGiangVien.DataSource = a;
                    foreach (DataGridViewRow row in tableGiangVien.Rows)
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

        private void FormQuanLyGiangVien_Load(object sender, EventArgs e)
        {
            GetTTGiangVien("", true);
            tableGiangVien.Columns["ID"].Visible = false;
            cbTrangThai.SelectedIndex = 0;
        }
        private void ChildFormClosed()
        {
            GetTTGiangVien("", true);
            txtKeyWord.Text = "";
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetTTGiangVien("", true);
            txtKeyWord.Text = "";
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemGiangVien form = new FormThemGiangVien();
            form.FormClosedCallback = new FormThemGiangVien.FormClosedHandler(ChildFormClosed);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int rowIndex = tableGiangVien.SelectedCells[0].RowIndex;
            int id = (int)tableGiangVien.Rows[rowIndex].Cells[0].Value;

            FormSuaGiangVien form = new FormSuaGiangVien(id);
            form.FormClosedCallback = new FormSuaGiangVien.FormClosedHandler(ChildFormClosed);
            form.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = tableGiangVien.SelectedCells[0].RowIndex;
            int id = (int)tableGiangVien.Rows[rowIndex].Cells[0].Value;
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            var tran = context.Database.BeginTransaction();
            try
            {
                var gv = context.GiangViens.Find(id);

                gv.TrangThai = false;

                context.GiangViens.Update(gv);
                context.SaveChanges();

                tran.Commit();

                MessageBox.Show("Xoá giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Xoá giảng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
            GetTTGiangVien("", (cbTrangThai.SelectedIndex == 0 ? true : false));
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            int rowIndex = tableGiangVien.SelectedCells[0].RowIndex;
            int id = (int)tableGiangVien.Rows[rowIndex].Cells[0].Value;

            FormTTLop form = new FormTTLop(id);
            form.ShowDialog();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string sourceFile = Application.StartupPath + @"\Files\MauExcelGV.xlsx"; // đường dẫn tệp gốc trong dự án
            string destFile = @"C:\Users\ASUS\Downloads\MauExcelGV.xlsx"; // đường dẫn để lưu trữ tệp

            File.Copy(sourceFile, destFile, true); // sao chép tệp từ thư mục gốc của dự án vào đường dẫn mới

            MessageBox.Show("Tải hoàn tất, tệp đã được tải xuống trong :" + destFile); // thông báo khi tải xuống hoàn tất
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(txtFilePath.Text);
            if (f != null)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(f))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // lấy worksheet đầu tiên

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
                                GiangVien l = new GiangVien();
                                l.MaGv = (string)worksheet.Cells[row, 1].Value;

                                l.HoTen = (string)worksheet.Cells[row, 2].Value;

                                var hp = context.HocPhans.Where(x => x.MaHp == worksheet.Cells[row, 3].Value).FirstOrDefault();
                                l.Idhp = hp.Id;

                                l.Phone = worksheet.Cells[row, 4].Value.ToString();

                                l.Email = (string)worksheet.Cells[row, 5].Value;

                                var ph = context.PhongHocs.Where(x => x.MaPhong == worksheet.Cells[row, 6].Value && x.Loai == false).FirstOrDefault();
                                l.Idph = ph.Id;

                                l.TrangThai = true;
                                context.GiangViens.Add(l);
                                context.SaveChanges();

                                TaiKhoan tk = new TaiKhoan();
                                tk.TaiKhoan1 = l.MaGv;
                                tk.MatKhau = "123";
                                tk.Idvt = 1;
                                context.TaiKhoans.Add(tk);
                                context.SaveChanges();
                            }
                            package.Dispose();
                            tran.Commit();
                            MessageBox.Show("Import thông tin giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            MessageBox.Show("Import thông tin giảng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
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
        private void button6_Click(object sender, EventArgs e)
        {
            GetTTGiangVien(txtKeyWord.Text, (cbTrangThai.SelectedIndex == 0 ? true : false));
        }
    }
}
