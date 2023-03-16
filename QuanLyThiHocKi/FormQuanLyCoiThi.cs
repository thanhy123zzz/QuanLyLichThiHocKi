using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormQuanLyCoiThi : Form
    {
        public FormQuanLyCoiThi()
        {
            InitializeComponent();
        }

        private void FormQuanLyCoiThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();

            var newItem = new { id = 0, NamHoc = "Tất cả" };
            var nhs = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            nhs.Insert(0, newItem);
            cbDotHoc.DataSource = nhs;
            cbTrangThai.SelectedIndex = 0;
        }
        public void GetTTCBCT(string key, bool tt, int idNH)
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
                    tableCanBo.DataSource = a;
                    foreach (DataGridViewRow row in tableCanBo.Rows)
                    {
                        row.Tag = row.Cells["ID"].Value;
                        bool tttc = (bool)row.Cells["TrangThai"].Value;
                        if (!tttc)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }

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
                    tableCanBo.DataSource = a;
                    foreach (DataGridViewRow row in tableCanBo.Rows)
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
        private void ChildFormClosed()
        {
            if (txtKeyWord.Text != "" || cbDotHoc.SelectedIndex != 0 || cbTrangThai.SelectedIndex != 0)
            {
                GetTTCBCT("", true, 0);
                txtKeyWord.Text = "";
                cbDotHoc.SelectedIndex = 0;
                cbTrangThai.SelectedIndex = 0;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemCanBo form = new FormThemCanBo();
            form.FormClosedCallback = new FormThemCanBo.FormClosedHandler(ChildFormClosed);
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
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
                tableCanBo.DataSource = a;
            }
            txtKeyWord.Text = "";
            cbDotHoc.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetTTCBCT(txtKeyWord.Text, (cbTrangThai.SelectedIndex == 0 ? true : false), (int)cbDotHoc.SelectedValue);
            tableCanBo.Columns["ID"].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tableCanBo.SelectedRows.Count == 1 && tableCanBo.SelectedRows[0].Cells["ID"].Value != null)
            {
                int rowIndex = tableCanBo.SelectedCells[0].RowIndex;
                int id = (int)tableCanBo.Rows[rowIndex].Cells[0].Value;

                FormSuaCanBo form = new FormSuaCanBo(id);
                form.FormClosedCallback = new FormSuaCanBo.FormClosedHandler(ChildFormClosed);
                form.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tableCanBo.SelectedRows.Count == 1 && tableCanBo.SelectedRows[0].Cells["ID"].Value != null)
            {
                int rowIndex = tableCanBo.SelectedCells[0].RowIndex;
                int id = (int)tableCanBo.Rows[rowIndex].Cells[0].Value;
                QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
                var tran = context.Database.BeginTransaction();
                try
                {
                    var gv = context.CanBoCoiThis.Find(id);

                    gv.TrangThai = false;

                    context.CanBoCoiThis.Update(gv);
                    context.SaveChanges();
                    tran.Commit();

                    MessageBox.Show("Xoá cán bộ coi thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTTCBCT(txtKeyWord.Text, (cbTrangThai.SelectedIndex == 0 ? true : false), (int)cbDotHoc.SelectedValue);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Xoá cán bộ coi thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tran.Rollback();
                }

            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            FormDuyetDK form = new FormDuyetDK();
            form.ShowDialog();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (tableCanBo.SelectedRows.Count == 1 && tableCanBo.SelectedRows[0].Cells["ID"].Value != null)
            {
                int rowIndex = tableCanBo.SelectedCells[0].RowIndex;
                int id = (int)tableCanBo.Rows[rowIndex].Cells[0].Value;
                FormPhanCong form = new FormPhanCong(id);
                form.ShowDialog();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (tableCanBo.SelectedRows.Count >= 1)
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // Tạo một đối tượng ExcelPackage mới
                ExcelPackage excel = new ExcelPackage();
                QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
                // Tạo một worksheet mới với tên "My Worksheet"
                var worksheet = excel.Workbook.Worksheets.Add("My Worksheet");
                worksheet.Cells[1, 1].Value = "";

                for (int r = 0; r < tableCanBo.SelectedRows.Count; r++)
                {


                    int id = (int)tableCanBo.SelectedRows[r].Cells["ID"].Value;
                    var cb = context.CanBoCoiThis.Find(id);
                    int row = worksheet.Dimension.Rows;
                    worksheet.Cells[row + 2, 2].Value = "Mã cá bộ";
                    worksheet.Cells[row + 2, 3].Value = cb.MaGv;
                    worksheet.Cells[row + 2, 5].Value = "Tên cán bộ";
                    worksheet.Cells[row + 2, 6].Value = cb.HoTen;

                    worksheet.Rows[row + 2].Style.Font.Bold = true;

                    worksheet.Cells[row + 4, 2].Value = "Mã lớp";
                    worksheet.Cells[row + 4, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 3].Value = "Tên lớp";
                    worksheet.Cells[row + 4, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 4].Value = "Mã MH";
                    worksheet.Cells[row + 4, 4].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 5].Value = "Tên môn học";
                    worksheet.Cells[row + 4, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 6].Value = "Ghi chú";
                    worksheet.Cells[row + 4, 6].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 7].Value = "Năm học";
                    worksheet.Cells[row + 4, 7].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 8].Value = "Nhóm";
                    worksheet.Cells[row + 4, 8].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 9].Value = "Thứ";
                    worksheet.Cells[row + 4, 9].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 10].Value = "Ngày thi";
                    worksheet.Cells[row + 4, 10].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 11].Value = "Ca";
                    worksheet.Cells[row + 4, 11].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 12].Value = "Giờ bắt đầu";
                    worksheet.Cells[row + 4, 12].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 13].Value = "Giờ kết thúc";
                    worksheet.Cells[row + 4, 13].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 14].Value = "Số lượng ĐK";
                    worksheet.Cells[row + 4, 14].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 15].Value = "Phòng thi";
                    worksheet.Cells[row + 4, 15].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells[row + 4, 2, row + 4, 15].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[row + 4, 2, row + 4, 15].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                    var listCB = context.CoiThis
                        .Include(x => x.IdlichThiNavigation)
                        .Include(x => x.IdlichThiNavigation.IdlopNavigation)
                        .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
                        .Include(x => x.IdlichThiNavigation.IdphNavigation)
                        .Include(x => x.IdlichThiNavigation.IdnhhkNavigation)
                        .Include(x => x.IdlichThiNavigation.CaNavigation)
                        .Where(x => (x.TrangThai == true)
                        && (x.Idcbct == id)).ToList();
                    for (int i = 5; i < listCB.Count + 5; i++)
                    {
                        worksheet.Cells[row + i, 2].Value = listCB[i - 5].IdlichThiNavigation.IdlopNavigation.MaLop;
                        worksheet.Cells[row + i, 2].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 3].Value = listCB[i - 5].IdlichThiNavigation.IdlopNavigation.TenLop;
                        worksheet.Cells[row + i, 3].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 4].Value = listCB[i - 5].IdlichThiNavigation.IdlopNavigation.IdhpNavigation.MaHp;
                        worksheet.Cells[row + i, 4].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 5].Value = listCB[i - 5].IdlichThiNavigation.IdlopNavigation.IdhpNavigation.TenHp;
                        worksheet.Cells[row + i, 5].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 6].Value = listCB[i - 5].IdlichThiNavigation.GhiChu;
                        worksheet.Cells[row + i, 6].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 7].Value = "Học kì: " + listCB[i - 5].IdlichThiNavigation.IdnhhkNavigation.HocKi + " Năm: " + listCB[i - 5].IdlichThiNavigation.IdnhhkNavigation.NamHoc;
                        worksheet.Cells[row + i, 7].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 8].Value = listCB[i - 5].IdlichThiNavigation.Nhom;
                        worksheet.Cells[row + i, 8].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 9].Value = listCB[i - 5].IdlichThiNavigation.NgayThi.ToString("dddd", new CultureInfo("vi-VN"));
                        worksheet.Cells[row + i, 9].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 10].Value = listCB[i - 5].IdlichThiNavigation.NgayThi.ToString("dd-MM-yyyy");
                        worksheet.Cells[row + i, 10].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 11].Value = listCB[i - 5].IdlichThiNavigation.Ca;
                        worksheet.Cells[row + i, 11].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 12].Value = listCB[i - 5].IdlichThiNavigation.CaNavigation.Tu.Value.ToString(@"hh\:mm");
                        worksheet.Cells[row + i, 12].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 13].Value = listCB[i - 5].IdlichThiNavigation.CaNavigation.Den.Value.ToString(@"hh\:mm");
                        worksheet.Cells[row + i, 13].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 14].Value = listCB[i - 5].IdlichThiNavigation.Sldk;
                        worksheet.Cells[row + i, 14].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                        worksheet.Cells[row + i, 15].Value = listCB[i - 5].IdlichThiNavigation.IdphNavigation.TenPhong;
                        worksheet.Cells[row + i, 15].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }
                // Auto-fit the columns
                worksheet.Cells.AutoFitColumns();

                // Lưu file excel vào một MemoryStream
                MemoryStream stream = new MemoryStream();
                excel.SaveAs(stream);

                // Đặt con trỏ đến đầu của MemoryStream
                stream.Position = 0;

                // Tạo một file mới và ghi dữ liệu từ MemoryStream vào file đó
                string fileName = "LichThi.xlsx";
                string filePath = @"C:\Users\ASUS\Downloads\" + fileName; // Thêm đường dẫn đến thư mục download vào tên file
                using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    stream.WriteTo(file);
                }
                MessageBox.Show("Tải thành công! Xem file ở " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
