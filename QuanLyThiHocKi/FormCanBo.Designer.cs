namespace QuanLyThiHocKi
{
    partial class FormCanBo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCanBo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXemSX = new System.Windows.Forms.Button();
            this.btnRefreshTT = new System.Windows.Forms.Button();
            this.btnSearchTT = new System.Windows.Forms.Button();
            this.cbDotHocTT = new System.Windows.Forms.ComboBox();
            this.txtKeywordTT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableCBLichThi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNHHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiToChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbHP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTenGV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCBLichThi)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 608);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tableCBLichThi);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch trông thi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXemSX);
            this.groupBox1.Controls.Add(this.btnRefreshTT);
            this.groupBox1.Controls.Add(this.btnSearchTT);
            this.groupBox1.Controls.Add(this.cbDotHocTT);
            this.groupBox1.Controls.Add(this.txtKeywordTT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 144);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(877, 85);
            this.button1.MaximumSize = new System.Drawing.Size(50, 50);
            this.button1.MinimumSize = new System.Drawing.Size(50, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 22;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "In lịch trông thi theo đợt học");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXemSX
            // 
            this.btnXemSX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemSX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemSX.BackgroundImage")));
            this.btnXemSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXemSX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXemSX.FlatAppearance.BorderSize = 2;
            this.btnXemSX.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemSX.Location = new System.Drawing.Point(877, 29);
            this.btnXemSX.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnXemSX.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnXemSX.Name = "btnXemSX";
            this.btnXemSX.Size = new System.Drawing.Size(50, 50);
            this.btnXemSX.TabIndex = 22;
            this.btnXemSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemSX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXemSX.UseVisualStyleBackColor = true;
            this.btnXemSX.Click += new System.EventHandler(this.btnXemSX_Click);
            // 
            // btnRefreshTT
            // 
            this.btnRefreshTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshTT.BackgroundImage")));
            this.btnRefreshTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefreshTT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshTT.FlatAppearance.BorderSize = 2;
            this.btnRefreshTT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshTT.Location = new System.Drawing.Point(933, 29);
            this.btnRefreshTT.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnRefreshTT.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnRefreshTT.Name = "btnRefreshTT";
            this.btnRefreshTT.Size = new System.Drawing.Size(50, 50);
            this.btnRefreshTT.TabIndex = 22;
            this.btnRefreshTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRefreshTT, "Refresh");
            this.btnRefreshTT.UseVisualStyleBackColor = true;
            this.btnRefreshTT.Click += new System.EventHandler(this.btnRefreshTT_Click);
            // 
            // btnSearchTT
            // 
            this.btnSearchTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchTT.BackgroundImage")));
            this.btnSearchTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchTT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchTT.FlatAppearance.BorderSize = 2;
            this.btnSearchTT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearchTT.Location = new System.Drawing.Point(933, 85);
            this.btnSearchTT.MaximumSize = new System.Drawing.Size(50, 50);
            this.btnSearchTT.MinimumSize = new System.Drawing.Size(50, 50);
            this.btnSearchTT.Name = "btnSearchTT";
            this.btnSearchTT.Size = new System.Drawing.Size(50, 50);
            this.btnSearchTT.TabIndex = 21;
            this.btnSearchTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnSearchTT, "Tìm kiếm");
            this.btnSearchTT.UseVisualStyleBackColor = true;
            this.btnSearchTT.Click += new System.EventHandler(this.btnSearchTT_Click);
            // 
            // cbDotHocTT
            // 
            this.cbDotHocTT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDotHocTT.DisplayMember = "NamHoc";
            this.cbDotHocTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDotHocTT.FormattingEnabled = true;
            this.cbDotHocTT.Location = new System.Drawing.Point(108, 94);
            this.cbDotHocTT.Name = "cbDotHocTT";
            this.cbDotHocTT.Size = new System.Drawing.Size(763, 34);
            this.cbDotHocTT.TabIndex = 20;
            this.cbDotHocTT.ValueMember = "Id";
            // 
            // txtKeywordTT
            // 
            this.txtKeywordTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeywordTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeywordTT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKeywordTT.Location = new System.Drawing.Point(108, 38);
            this.txtKeywordTT.Name = "txtKeywordTT";
            this.txtKeywordTT.Size = new System.Drawing.Size(763, 34);
            this.txtKeywordTT.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Từ khoá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Đợt học:";
            // 
            // tableCBLichThi
            // 
            this.tableCBLichThi.AllowUserToOrderColumns = true;
            this.tableCBLichThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCBLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCBLichThi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableCBLichThi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCBLichThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCBLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCBLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.clMaLop,
            this.clMaHocPhan,
            this.clTenHocPhan,
            this.clGhiChu,
            this.clNhom,
            this.clNHHK,
            this.clThu,
            this.clNgayThi,
            this.clCa,
            this.clSLDangKy,
            this.clPhongThi,
            this.TrangThaiToChuc});
            this.tableCBLichThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableCBLichThi.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableCBLichThi.Location = new System.Drawing.Point(13, 156);
            this.tableCBLichThi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableCBLichThi.MultiSelect = false;
            this.tableCBLichThi.Name = "tableCBLichThi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCBLichThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tableCBLichThi.RowHeadersVisible = false;
            this.tableCBLichThi.RowHeadersWidth = 51;
            this.tableCBLichThi.RowTemplate.Height = 29;
            this.tableCBLichThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCBLichThi.Size = new System.Drawing.Size(989, 409);
            this.tableCBLichThi.TabIndex = 21;
            this.tableCBLichThi.Tag = "ID";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // clMaLop
            // 
            this.clMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clMaLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.MinimumWidth = 6;
            this.clMaLop.Name = "clMaLop";
            // 
            // clMaHocPhan
            // 
            this.clMaHocPhan.DataPropertyName = "MaHocPhan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clMaHocPhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.clMaHocPhan.HeaderText = "Mã học phần";
            this.clMaHocPhan.MinimumWidth = 6;
            this.clMaHocPhan.Name = "clMaHocPhan";
            // 
            // clTenHocPhan
            // 
            this.clTenHocPhan.DataPropertyName = "TenHP";
            this.clTenHocPhan.HeaderText = "Tên học phần";
            this.clTenHocPhan.MinimumWidth = 6;
            this.clTenHocPhan.Name = "clTenHocPhan";
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clNhom
            // 
            this.clNhom.DataPropertyName = "Nhom";
            this.clNhom.HeaderText = "Nhóm";
            this.clNhom.MinimumWidth = 6;
            this.clNhom.Name = "clNhom";
            // 
            // clNHHK
            // 
            this.clNHHK.DataPropertyName = "NHHK";
            this.clNHHK.HeaderText = "Đợt học";
            this.clNHHK.MinimumWidth = 6;
            this.clNHHK.Name = "clNHHK";
            // 
            // clThu
            // 
            this.clThu.DataPropertyName = "Thu";
            this.clThu.HeaderText = "Thứ";
            this.clThu.MinimumWidth = 6;
            this.clThu.Name = "clThu";
            // 
            // clNgayThi
            // 
            this.clNgayThi.DataPropertyName = "NgayThi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clNgayThi.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNgayThi.HeaderText = "Ngày thi";
            this.clNgayThi.MinimumWidth = 6;
            this.clNgayThi.Name = "clNgayThi";
            // 
            // clCa
            // 
            this.clCa.DataPropertyName = "Ca";
            this.clCa.HeaderText = "Ca";
            this.clCa.MinimumWidth = 6;
            this.clCa.Name = "clCa";
            // 
            // clSLDangKy
            // 
            this.clSLDangKy.DataPropertyName = "SLDK";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clSLDangKy.DefaultCellStyle = dataGridViewCellStyle5;
            this.clSLDangKy.HeaderText = "SLĐK";
            this.clSLDangKy.MinimumWidth = 6;
            this.clSLDangKy.Name = "clSLDangKy";
            // 
            // clPhongThi
            // 
            this.clPhongThi.DataPropertyName = "PhongThi";
            this.clPhongThi.HeaderText = "Phòng thi";
            this.clPhongThi.MinimumWidth = 6;
            this.clPhongThi.Name = "clPhongThi";
            // 
            // TrangThaiToChuc
            // 
            this.TrangThaiToChuc.DataPropertyName = "TrangThaiToChuc";
            this.TrangThaiToChuc.HeaderText = "Trạng thái tổ chức";
            this.TrangThaiToChuc.MinimumWidth = 6;
            this.TrangThaiToChuc.Name = "TrangThaiToChuc";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lbPhone);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.lbHP);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbTenGV);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbEmail);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lbPhong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lbMaGV);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin cá nhân";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(859, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "Đổi mật khẩu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(765, 352);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(69, 23);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(629, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Phone:";
            // 
            // lbHP
            // 
            this.lbHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHP.AutoSize = true;
            this.lbHP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHP.Location = new System.Drawing.Point(765, 192);
            this.lbHP.Name = "lbHP";
            this.lbHP.Size = new System.Drawing.Size(120, 23);
            this.lbHP.TabIndex = 5;
            this.lbHP.Text = "Chuyên môn:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Chuyên môn:";
            // 
            // lbTenGV
            // 
            this.lbTenGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTenGV.Location = new System.Drawing.Point(765, 32);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(72, 23);
            this.lbTenGV.TabIndex = 7;
            this.lbTenGV.Text = "TênGV";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "TênGV";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(215, 353);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(65, 23);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email:";
            // 
            // lbPhong
            // 
            this.lbPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPhong.AutoSize = true;
            this.lbPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhong.Location = new System.Drawing.Point(215, 193);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(100, 23);
            this.lbPhong.TabIndex = 13;
            this.lbPhong.Text = "Phòng CT:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Phòng CT:";
            // 
            // lbMaGV
            // 
            this.lbMaGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaGV.Location = new System.Drawing.Point(215, 33);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(78, 23);
            this.lbMaGV.TabIndex = 15;
            this.lbMaGV.Text = "Mã GV:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã GV:";
            // 
            // FormCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 608);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cán bộ coi thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCanBo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCBLichThi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView tableCBLichThi;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private ToolTip toolTip1;
        private ComboBox cbDotHocTT;
        private TextBox txtKeywordTT;
        private Button btnRefreshTT;
        private Button btnSearchTT;
        private Label lbPhone;
        private Label label11;
        private Label lbHP;
        private Label label10;
        private Label lbTenGV;
        private Label label8;
        private Label lbEmail;
        private Label label9;
        private Label lbPhong;
        private Label label7;
        private Label lbMaGV;
        private Label label5;
        private Button btnXemSX;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn clMaLop;
        private DataGridViewTextBoxColumn clMaHocPhan;
        private DataGridViewTextBoxColumn clTenHocPhan;
        private DataGridViewTextBoxColumn clGhiChu;
        private DataGridViewTextBoxColumn clNhom;
        private DataGridViewTextBoxColumn clNHHK;
        private DataGridViewTextBoxColumn clThu;
        private DataGridViewTextBoxColumn clNgayThi;
        private DataGridViewTextBoxColumn clCa;
        private DataGridViewTextBoxColumn clSLDangKy;
        private DataGridViewTextBoxColumn clPhongThi;
        private DataGridViewTextBoxColumn TrangThaiToChuc;
        private Button button1;
        private Button button2;
    }
}