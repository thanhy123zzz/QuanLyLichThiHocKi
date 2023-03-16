namespace QuanLyThiHocKi
{
    partial class FormDKCoiThi
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
            this.cbDotHoc = new System.Windows.Forms.ComboBox();
            this.namHocHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTenGV = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.cbDotHoc);
            this.groupBox1.Controls.Add(this.lbTenGV);
            this.groupBox1.Controls.Add(this.lbMaGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbDotHoc
            // 
            this.cbDotHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDotHoc.DataSource = this.namHocHocKiBindingSource;
            this.cbDotHoc.DisplayMember = "NamHoc";
            this.cbDotHoc.FormattingEnabled = true;
            this.cbDotHoc.Location = new System.Drawing.Point(124, 184);
            this.cbDotHoc.Name = "cbDotHoc";
            this.cbDotHoc.Size = new System.Drawing.Size(442, 30);
            this.cbDotHoc.TabIndex = 1;
            this.cbDotHoc.ValueMember = "Id";
            // 
            // namHocHocKiBindingSource
            // 
            this.namHocHocKiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.NamHocHocKi);
            // 
            // lbTenGV
            // 
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Location = new System.Drawing.Point(124, 120);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(77, 22);
            this.lbTenGV.TabIndex = 0;
            this.lbTenGV.Text = "Tên GV:";
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Location = new System.Drawing.Point(124, 56);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(73, 22);
            this.lbMaGV.TabIndex = 0;
            this.lbMaGV.Text = "Mã GV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đợt thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên GV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.Location = new System.Drawing.Point(451, 264);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 44);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormDKCoiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 314);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDKCoiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký trông thi";
            this.Load += new System.EventHandler(this.FormDKCoiThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbDotHoc;
        private Label lbTenGV;
        private Label lbMaGV;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXacNhan;
        private BindingSource namHocHocKiBindingSource;
    }
}