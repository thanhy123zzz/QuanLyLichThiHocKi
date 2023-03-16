namespace QuanLyThiHocKi
{
    partial class FormDuyetDK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuyetDK));
            this.tableDK = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHocHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbDotHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDK)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDK
            // 
            this.tableDK.AllowUserToOrderColumns = true;
            this.tableDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableDK.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDK.ColumnHeadersHeight = 29;
            this.tableDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.NgayDK,
            this.NamHocHocKi});
            this.tableDK.Location = new System.Drawing.Point(12, 12);
            this.tableDK.Name = "tableDK";
            this.tableDK.RowHeadersVisible = false;
            this.tableDK.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableDK.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDK.RowTemplate.Height = 29;
            this.tableDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDK.Size = new System.Drawing.Size(923, 236);
            this.tableDK.TabIndex = 0;
            this.tableDK.Tag = "ID";
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Tên GV";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            // 
            // NgayDK
            // 
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "Ngày ĐK";
            this.NgayDK.MinimumWidth = 6;
            this.NgayDK.Name = "NgayDK";
            // 
            // NamHocHocKi
            // 
            this.NamHocHocKi.DataPropertyName = "DotDK";
            this.NamHocHocKi.HeaderText = "Đợt đăng ký";
            this.NamHocHocKi.MinimumWidth = 6;
            this.NamHocHocKi.Name = "NamHocHocKi";
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDuyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDuyet.Location = new System.Drawing.Point(789, 254);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(146, 47);
            this.btnDuyet.TabIndex = 1;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(637, 254);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 47);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbDotHoc
            // 
            this.cbDotHoc.DisplayMember = "NamHoc";
            this.cbDotHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDotHoc.FormattingEnabled = true;
            this.cbDotHoc.Location = new System.Drawing.Point(87, 261);
            this.cbDotHoc.Name = "cbDotHoc";
            this.cbDotHoc.Size = new System.Drawing.Size(272, 34);
            this.cbDotHoc.TabIndex = 12;
            this.cbDotHoc.ValueMember = "Id";
            this.cbDotHoc.SelectedIndexChanged += new System.EventHandler(this.cbDotHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đợt thi:";
            // 
            // FormDuyetDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 313);
            this.Controls.Add(this.cbDotHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.tableDK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDuyetDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt đăng ký coi thi";
            this.Load += new System.EventHandler(this.FormDuyetDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tableDK;
        private Button btnDuyet;
        private Button btnXoa;
        private ComboBox cbDotHoc;
        private Label label2;
        private DataGridViewTextBoxColumn MaGV;
        private DataGridViewTextBoxColumn TenGV;
        private DataGridViewTextBoxColumn NgayDK;
        private DataGridViewTextBoxColumn NamHocHocKi;
    }
}