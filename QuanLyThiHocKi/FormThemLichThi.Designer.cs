namespace QuanLyThiHocKi
{
    partial class FormThemLichThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLichThi));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPhongHoc = new System.Windows.Forms.ComboBox();
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbDotHoc = new System.Windows.Forms.ComboBox();
            this.namHocHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLDK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSX = new System.Windows.Forms.ComboBox();
            this.cachSxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.caBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachSxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(811, 440);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(674, 440);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 43);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Huỷ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNhom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbPhongHoc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbDotHoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSLDK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbSX);
            this.groupBox1.Controls.Add(this.cbCa);
            this.groupBox1.Controls.Add(this.txtNgayThi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLopHoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm lịch thi";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGhiChu.Location = new System.Drawing.Point(121, 351);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(308, 34);
            this.txtGhiChu.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ghi chú:";
            // 
            // txtNhom
            // 
            this.txtNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhom.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNhom.Location = new System.Drawing.Point(121, 277);
            this.txtNhom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.ReadOnly = true;
            this.txtNhom.Size = new System.Drawing.Size(308, 34);
            this.txtNhom.TabIndex = 21;
            this.txtNhom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(476, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Phòng:";
            // 
            // cbPhongHoc
            // 
            this.cbPhongHoc.DataSource = this.phongHocBindingSource;
            this.cbPhongHoc.DisplayMember = "TenPhong";
            this.cbPhongHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhongHoc.FormattingEnabled = true;
            this.cbPhongHoc.Location = new System.Drawing.Point(616, 193);
            this.cbPhongHoc.Name = "cbPhongHoc";
            this.cbPhongHoc.Size = new System.Drawing.Size(308, 34);
            this.cbPhongHoc.TabIndex = 19;
            this.cbPhongHoc.ValueMember = "Id";
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.PhongHoc);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Đợt học:";
            // 
            // cbDotHoc
            // 
            this.cbDotHoc.DataSource = this.namHocHocKiBindingSource;
            this.cbDotHoc.DisplayMember = "NamHoc";
            this.cbDotHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDotHoc.FormattingEnabled = true;
            this.cbDotHoc.Location = new System.Drawing.Point(121, 43);
            this.cbDotHoc.Name = "cbDotHoc";
            this.cbDotHoc.Size = new System.Drawing.Size(803, 34);
            this.cbDotHoc.TabIndex = 15;
            this.cbDotHoc.ValueMember = "Id";
            this.cbDotHoc.SelectedIndexChanged += new System.EventHandler(this.cbDotHoc_SelectedIndexChanged);
            // 
            // namHocHocKiBindingSource
            // 
            this.namHocHocKiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.NamHocHocKi);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(480, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "SLĐK:";
            // 
            // txtSLDK
            // 
            this.txtSLDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLDK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSLDK.Location = new System.Drawing.Point(616, 277);
            this.txtSLDK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSLDK.Name = "txtSLDK";
            this.txtSLDK.Size = new System.Drawing.Size(308, 34);
            this.txtSLDK.TabIndex = 13;
            this.txtSLDK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(480, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cách SX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ca:";
            // 
            // cbSX
            // 
            this.cbSX.DataSource = this.cachSxBindingSource;
            this.cbSX.DisplayMember = "TenCachSx";
            this.cbSX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSX.FormattingEnabled = true;
            this.cbSX.Location = new System.Drawing.Point(616, 351);
            this.cbSX.Name = "cbSX";
            this.cbSX.Size = new System.Drawing.Size(308, 34);
            this.cbSX.TabIndex = 11;
            this.cbSX.ValueMember = "Id";
            // 
            // cachSxBindingSource
            // 
            this.cachSxBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.CachSx);
            // 
            // cbCa
            // 
            this.cbCa.DataSource = this.caBindingSource;
            this.cbCa.DisplayMember = "TenCa";
            this.cbCa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Location = new System.Drawing.Point(121, 188);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(308, 34);
            this.cbCa.TabIndex = 11;
            this.cbCa.ValueMember = "Id";
            this.cbCa.SelectedIndexChanged += new System.EventHandler(this.cbCa_SelectedIndexChanged);
            // 
            // caBindingSource
            // 
            this.caBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.Ca);
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.CustomFormat = "dd-MM-yyyy";
            this.txtNgayThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayThi.Location = new System.Drawing.Point(616, 118);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Size = new System.Drawing.Size(308, 34);
            this.txtNgayThi.TabIndex = 10;
            this.txtNgayThi.ValueChanged += new System.EventHandler(this.txtNgayThi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(476, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhóm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lớp:";
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.DataSource = this.lopHocBindingSource;
            this.cbLopHoc.DisplayMember = "MaLop";
            this.cbLopHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Location = new System.Drawing.Point(121, 121);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(308, 34);
            this.cbLopHoc.TabIndex = 0;
            this.cbLopHoc.ValueMember = "Id";
            this.cbLopHoc.SelectedIndexChanged += new System.EventHandler(this.cbLopHoc_SelectedIndexChanged);
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.LopHoc);
            // 
            // hocPhanBindingSource
            // 
            this.hocPhanBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.HocPhan);
            // 
            // FormThemLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThemLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThemLichThi_FormClosed);
            this.Load += new System.EventHandler(this.FormThemLichThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachSxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnThem;
        private Button btnBack;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbLopHoc;
        private BindingSource lopHocBindingSource;
        private BindingSource hocPhanBindingSource;
        private Label label8;
        private ComboBox cbDotHoc;
        private BindingSource namHocHocKiBindingSource;
        private Label label7;
        private NumericUpDown txtSLDK;
        private Label label6;
        private ComboBox cbCa;
        private BindingSource caBindingSource;
        private DateTimePicker txtNgayThi;
        private Label label5;
        private Label label4;
        private Label label10;
        private ComboBox cbPhongHoc;
        private BindingSource phongHocBindingSource;
        private NumericUpDown txtNhom;
        private TextBox txtGhiChu;
        private Label label3;
        private Label label2;
        private ComboBox cbSX;
        private BindingSource cachSxBindingSource;
    }
}