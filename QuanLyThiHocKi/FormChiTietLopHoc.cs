using Microsoft.EntityFrameworkCore;
using QuanLyThiHocKi.Models.EntitiesNew;
using System.Data;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormChiTietLopHoc : Form
    {
        private int _id;
        public FormChiTietLopHoc(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FormChiTietLopHoc_Load(object sender, EventArgs e)
        {
            getLichThi();
        }
        private void getLichThi()
        {
            var context = new QuanLyThiHocKiContext();
            var a = context.LichThis.Include(x => x.IdlopNavigation)
                        .Include(x => x.IdlopNavigation.IdhpNavigation)
                        .Include(x => x.IdlopNavigation)
                        .Include(x => x.IdphNavigation)
                        .Where(x => (x.TrangThai == true) && (x.Idlop == _id))
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
            tableLichThi.Columns["ID"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
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
            string[] t = new string[] { "Tổng chi phí", "", "", tong.Value.ToString("#,##0") };
            tableKinhPhi.Rows.Add(t);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(tableKinhPhi.Font, FontStyle.Bold);
            tableKinhPhi.Rows[tableKinhPhi.Rows.Count - 2].DefaultCellStyle = style;
            tableKinhPhi.Rows[tableKinhPhi.Rows.Count - 2].DefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
