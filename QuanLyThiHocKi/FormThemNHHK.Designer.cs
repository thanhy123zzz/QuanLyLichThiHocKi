namespace QuanLyThiHocKi
{
    partial class FormThemNHHK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHocKi = new System.Windows.Forms.NumericUpDown();
            this.txtDen = new System.Windows.Forms.DateTimePicker();
            this.txtTu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtHocKi);
            this.groupBox1.Controls.Add(this.txtDen);
            this.groupBox1.Controls.Add(this.txtTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNamHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm đợt học";
            // 
            // txtHocKi
            // 
            this.txtHocKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHocKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHocKi.Location = new System.Drawing.Point(471, 41);
            this.txtHocKi.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtHocKi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(251, 30);
            this.txtHocKi.TabIndex = 3;
            this.txtHocKi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDen
            // 
            this.txtDen.CustomFormat = "dd-MM-yyyy";
            this.txtDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDen.Location = new System.Drawing.Point(471, 110);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(251, 30);
            this.txtDen.TabIndex = 2;
            this.txtDen.ValueChanged += new System.EventHandler(this.txtDen_ValueChanged);
            // 
            // txtTu
            // 
            this.txtTu.CustomFormat = "dd-MM-yyyy";
            this.txtTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTu.Location = new System.Drawing.Point(104, 110);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(251, 30);
            this.txtTu.TabIndex = 2;
            this.txtTu.ValueChanged += new System.EventHandler(this.txtTu_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(379, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Học kỳ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(379, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến ngày:";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamHoc.Location = new System.Drawing.Point(104, 41);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(251, 30);
            this.txtNamHoc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(586, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThemNHHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThemNHHK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThemNHHK_FormClosed);
            this.Load += new System.EventHandler(this.FormThemNHHK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker txtDen;
        private DateTimePicker txtTu;
        private Label label2;
        private Label label4;
        private TextBox txtNamHoc;
        private Label label3;
        private Label label1;
        private Button button1;
        private NumericUpDown txtHocKi;
    }
}