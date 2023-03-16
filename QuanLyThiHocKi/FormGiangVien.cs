using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormGiangVien : Form
    {
        private int _id;
        public FormGiangVien(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            var context = new QuanLyThiHocKiContext();
            var gv = context.GiangViens
                .Include(x => x.IdtkNavigation)
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdphNavigation)
                .Where(x => x.Id == _id).FirstOrDefault();
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
            cbDotHocTT.DataSource = nhs2;

            lbMaGV.Text = gv.MaGv;
            lbTenGV.Text = gv.HoTen;
            lbPhong.Text = gv.IdphNavigation.TenPhong;
            lbHP.Text = gv.IdhpNavigation.TenHp;
            lbPhone.Text = gv.Phone;
            lbEmail.Text = gv.Email;
        }
        private void GetTableLopHocGD(int idNH, string key)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.LopHocs
                .Include(x => x.IdhpNavigation)
                .Include(x => x.IdnhhkNavigation)
                .Include(x => x.LichThis)
                .Where(x => (x.Idgv == _id)
                && (idNH == 0 ? true : x.Idnhhk == idNH)
                && (key == "" ? true : (x.MaLop + " " + x.TenLop + " " + x.IdhpNavigation.MaHp + " " + x.IdhpNavigation.TenHp).ToLower().Contains(key.ToLower()))
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

        private void btnGDSearchGV_Click(object sender, EventArgs e)
        {
            GetTableLopHocGD((int)cbGDDotHocLop.SelectedValue, txtGDKeyWordGV.Text);
        }

        private void btnGDRefreshGV_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
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
            txtGDKeyWordGV.Text = "";
            cbGDDotHocLop.SelectedIndex = 0;
        }

        private void tableGDLopHocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = tableGDLopHocs.SelectedCells[0].RowIndex;
            var id = (int)tableGDLopHocs.Rows[rowIndex].Cells["ID"].Value;
            FormChiTietLopHoc form = new FormChiTietLopHoc(id);
            form.ShowDialog();
        }

        private void GetLichThiList(int idNH, string key)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var gv = context.GiangViens.Find(_id);
                var cb = context.CanBoCoiThis.Where(x => x.MaGv == gv.MaGv).FirstOrDefault();
                var a = context.CoiThis.Include(x => x.IdlichThiNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
                    .Include(x => x.IdlichThiNavigation.IdnhhkNavigation)
                    .Include(x => x.IdlichThiNavigation.IdphNavigation)
                    .Where(x => (x.TrangThai == true) && (x.Idcbct == cb.Id)
                    && (idNH == 0 ? true : (x.IdlichThiNavigation.Idnhhk == idNH))
                    && (key == "" ? true : (x.IdlichThiNavigation.IdlopNavigation.MaLop + " " + x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.TenHp + " " + x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation.MaHp + " " + x.IdlichThiNavigation.GhiChu + " " + x.IdlichThiNavigation.IdphNavigation.MaPhong).ToLower().Contains(key.ToLower()))
                )
                .Select(x =>
                new
                {
                    ID = x.IdlichThi,
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
                tableCBLichThi.DataSource = a;
            }
            tableCBLichThi.Columns["ID"].Visible = false;
        }

        private void btnSearchTT_Click(object sender, EventArgs e)
        {
            GetLichThiList((int)cbDotHocTT.SelectedValue, txtKeywordTT.Text);
        }

        private void btnShowDK_Click(object sender, EventArgs e)
        {
            FormDKCoiThi form = new FormDKCoiThi(_id);
            form.ShowDialog();
        }

        private void btnRefreshTT_Click(object sender, EventArgs e)
        {
            using (var context = new QuanLyThiHocKiContext())
            {
                var a = context.CoiThis.Include(x => x.IdlichThiNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation)
                    .Include(x => x.IdlichThiNavigation.IdlopNavigation.IdhpNavigation)
                    .Include(x => x.IdlichThiNavigation.IdnhhkNavigation)
                    .Include(x => x.IdlichThiNavigation.IdphNavigation)
                    .Where(x => x.Id == 0)
                .Select(x =>
                new
                {
                    ID = x.IdlichThi,
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
                tableCBLichThi.DataSource = a;
            }
            cbDotHocTT.SelectedIndex = 0;
            txtKeywordTT.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (tableCBLichThi.SelectedRows.Count == 1 && tableCBLichThi.SelectedRows[0].Cells["ID"].Value != null)
            {
                int id = (int)tableCBLichThi.SelectedRows[0].Cells["ID"].Value;
                FormXemSX form = new FormXemSX(id);
                form.Show();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Tạo một đối tượng ExcelPackage mới
            ExcelPackage excel = new ExcelPackage();
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            // Tạo một worksheet mới với tên "My Worksheet"
            var worksheet = excel.Workbook.Worksheets.Add("My Worksheet");
            worksheet.Cells[1, 1].Value = "";
            var gv = context.GiangViens.Find(_id);
            var cb = context.CanBoCoiThis.Where(x => x.MaGv == gv.MaGv).FirstOrDefault();
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
                && (x.Idcbct == cb.Id)
                && ((int)cbDotHocTT.SelectedValue == 0 ? true : (x.IdlichThiNavigation.Idnhhk == (int)cbDotHocTT.SelectedValue))
                ).ToList();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new QuanLyThiHocKiContext();
            var gv = context.GiangViens.Find(_id);
            FormDoiMatKhau form = new FormDoiMatKhau(gv.Idtk.Value);
            form.ShowDialog();
        }
    }
}
