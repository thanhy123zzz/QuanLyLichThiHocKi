namespace QuanLyThiHocKi
{
    partial class FormSuaLichThi
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
            this.lopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namHocHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDotHoc = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPhongHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSLDK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSX = new System.Windows.Forms.ComboBox();
            this.cachSxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.txtNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachSxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lopHocBindingSource
            // 
            this.lopHocBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.LopHoc);
            // 
            // hocPhanBindingSource
            // 
            this.hocPhanBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.HocPhan);
            // 
            // caBindingSource
            // 
            this.caBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.Ca);
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.PhongHoc);
            // 
            // namHocHocKiBindingSource
            // 
            this.namHocHocKiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.NamHocHocKi);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtDotHoc);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNhom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbPhongHoc);
            this.groupBox1.Controls.Add(this.label8);
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
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 422);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sửa lịch thi";
            // 
            // txtDotHoc
            // 
            this.txtDotHoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDotHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDotHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDotHoc.Location = new System.Drawing.Point(121, 45);
            this.txtDotHoc.Name = "txtDotHoc";
            this.txtDotHoc.ReadOnly = true;
            this.txtDotHoc.Size = new System.Drawing.Size(803, 34);
            this.txtDotHoc.TabIndex = 43;
            // 
            // txtLop
            // 
            this.txtLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLop.Location = new System.Drawing.Point(121, 118);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(308, 34);
            this.txtLop.TabIndex = 42;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGhiChu.Location = new System.Drawing.Point(121, 348);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(308, 34);
            this.txtGhiChu.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ghi chú:";
            // 
            // txtNhom
            // 
            this.txtNhom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNhom.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtNhom.Location = new System.Drawing.Point(121, 274);
            this.txtNhom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.ReadOnly = true;
            this.txtNhom.Size = new System.Drawing.Size(308, 34);
            this.txtNhom.TabIndex = 39;
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
            this.label10.Location = new System.Drawing.Point(476, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 26);
            this.label10.TabIndex = 38;
            this.label10.Text = "Phòng:";
            // 
            // cbPhongHoc
            // 
            this.cbPhongHoc.DataSource = this.phongHocBindingSource;
            this.cbPhongHoc.DisplayMember = "TenPhong";
            this.cbPhongHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhongHoc.FormattingEnabled = true;
            this.cbPhongHoc.Location = new System.Drawing.Point(616, 190);
            this.cbPhongHoc.Name = "cbPhongHoc";
            this.cbPhongHoc.Size = new System.Drawing.Size(308, 34);
            this.cbPhongHoc.TabIndex = 37;
            this.cbPhongHoc.ValueMember = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Đợt học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(480, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "SLĐK:";
            // 
            // txtSLDK
            // 
            this.txtSLDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLDK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSLDK.Location = new System.Drawing.Point(616, 274);
            this.txtSLDK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSLDK.Name = "txtSLDK";
            this.txtSLDK.Size = new System.Drawing.Size(308, 34);
            this.txtSLDK.TabIndex = 33;
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
            this.label2.Location = new System.Drawing.Point(480, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cách SX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 26);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ca:";
            // 
            // cbSX
            // 
            this.cbSX.DataSource = this.cachSxBindingSource;
            this.cbSX.DisplayMember = "TenCachSx";
            this.cbSX.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSX.FormattingEnabled = true;
            this.cbSX.Location = new System.Drawing.Point(616, 348);
            this.cbSX.Name = "cbSX";
            this.cbSX.Size = new System.Drawing.Size(308, 34);
            this.cbSX.TabIndex = 30;
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
            this.cbCa.Location = new System.Drawing.Point(121, 185);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(308, 34);
            this.cbCa.TabIndex = 29;
            this.cbCa.ValueMember = "Id";
            this.cbCa.SelectedIndexChanged += new System.EventHandler(this.cbCa_SelectedIndexChanged);
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.CustomFormat = "dd-MM-yyyy";
            this.txtNgayThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayThi.Location = new System.Drawing.Point(616, 115);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Size = new System.Drawing.Size(308, 34);
            this.txtNgayThi.TabIndex = 28;
            this.txtNgayThi.ValueChanged += new System.EventHandler(this.txtNgayThi_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(476, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Thi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nhóm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lớp:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(674, 438);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 43);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Huỷ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(811, 438);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 43);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormSuaLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSuaLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuaLichThi_FormClosed);
            this.Load += new System.EventHandler(this.FormSuaLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachSxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource lopHocBindingSource;
        private BindingSource hocPhanBindingSource;
        private BindingSource caBindingSource;
        private BindingSource phongHocBindingSource;
        private BindingSource namHocHocKiBindingSource;
        private GroupBox groupBox1;
        private Button btnBack;
        private Button btnSua;
        private BindingSource cachSxBindingSource;
        private TextBox txtGhiChu;
        private Label label3;
        private NumericUpDown txtNhom;
        private Label label10;
        private ComboBox cbPhongHoc;
        private Label label8;
        private Label label7;
        private NumericUpDown txtSLDK;
        private Label label2;
        private Label label6;
        private ComboBox cbSX;
        private ComboBox cbCa;
        private DateTimePicker txtNgayThi;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox txtLop;
        private TextBox txtDotHoc;
    }
}