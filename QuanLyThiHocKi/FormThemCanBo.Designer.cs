namespace QuanLyThiHocKi
{
    partial class FormThemCanBo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDotThi = new System.Windows.Forms.ComboBox();
            this.namHocHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.phongHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cbHocPhan = new System.Windows.Forms.ComboBox();
            this.hocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cbDotThi);
            this.groupBox1.Controls.Add(this.cbPhong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbHocPhan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm cán bộ coi thi";
            // 
            // cbDotThi
            // 
            this.cbDotThi.DataSource = this.namHocHocKiBindingSource;
            this.cbDotThi.DisplayMember = "NamHoc";
            this.cbDotThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDotThi.FormattingEnabled = true;
            this.cbDotThi.Location = new System.Drawing.Point(173, 264);
            this.cbDotThi.Name = "cbDotThi";
            this.cbDotThi.Size = new System.Drawing.Size(812, 34);
            this.cbDotThi.TabIndex = 19;
            this.cbDotThi.ValueMember = "Id";
            // 
            // namHocHocKiBindingSource
            // 
            this.namHocHocKiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.NamHocHocKi);
            // 
            // cbPhong
            // 
            this.cbPhong.DataSource = this.phongHocBindingSource;
            this.cbPhong.DisplayMember = "TenPhong";
            this.cbPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(677, 191);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(308, 34);
            this.cbPhong.TabIndex = 19;
            this.cbPhong.ValueMember = "Id";
            // 
            // phongHocBindingSource
            // 
            this.phongHocBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.PhongHoc);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đợt thi:";
            // 
            // cbHocPhan
            // 
            this.cbHocPhan.DataSource = this.hocPhanBindingSource;
            this.cbHocPhan.DisplayMember = "TenHp";
            this.cbHocPhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHocPhan.FormattingEnabled = true;
            this.cbHocPhan.Location = new System.Drawing.Point(173, 120);
            this.cbHocPhan.Name = "cbHocPhan";
            this.cbHocPhan.Size = new System.Drawing.Size(308, 34);
            this.cbHocPhan.TabIndex = 18;
            this.cbHocPhan.ValueMember = "Id";
            // 
            // hocPhanBindingSource
            // 
            this.hocPhanBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.HocPhan);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(509, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phòng làm việc:";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT.Location = new System.Drawing.Point(173, 191);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(308, 34);
            this.txtSDT.TabIndex = 15;
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số ĐT:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(678, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 34);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Môn công tác:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenGV.Location = new System.Drawing.Point(678, 47);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(308, 34);
            this.txtTenGV.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(509, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên CB:";
            // 
            // txtMaGV
            // 
            this.txtMaGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaGV.Location = new System.Drawing.Point(173, 47);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(308, 34);
            this.txtMaGV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã CB:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(736, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 43);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Huỷ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(873, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 43);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormThemCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 410);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThemCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThemCanBo_FormClosed);
            this.Load += new System.EventHandler(this.FormThemCanBo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbDotThi;
        private ComboBox cbPhong;
        private Label label7;
        private ComboBox cbHocPhan;
        private Label label5;
        private TextBox txtSDT;
        private Label label6;
        private TextBox txtEmail;
        private Label label2;
        private Label label4;
        private TextBox txtTenGV;
        private Label label1;
        private TextBox txtMaGV;
        private Label label3;
        private Button btnBack;
        private Button btnThem;
        private BindingSource namHocHocKiBindingSource;
        private BindingSource phongHocBindingSource;
        private BindingSource hocPhanBindingSource;
    }
}