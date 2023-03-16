namespace QuanLyThiHocKi
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQLLichThi = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            this.btnQLCB = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.btnQLLichThi);
            this.flowLayoutPanel1.Controls.Add(this.btnQLGV);
            this.flowLayoutPanel1.Controls.Add(this.btnQLCB);
            this.flowLayoutPanel1.Controls.Add(this.btnTK);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 106);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(679, 262);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnQLLichThi
            // 
            this.btnQLLichThi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLLichThi.Location = new System.Drawing.Point(3, 3);
            this.btnQLLichThi.Name = "btnQLLichThi";
            this.btnQLLichThi.Size = new System.Drawing.Size(328, 125);
            this.btnQLLichThi.TabIndex = 0;
            this.btnQLLichThi.Text = "Quản lý lịch thi";
            this.btnQLLichThi.UseVisualStyleBackColor = true;
            this.btnQLLichThi.Click += new System.EventHandler(this.btnQLLichThi_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLGV.Location = new System.Drawing.Point(337, 3);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(328, 125);
            this.btnQLGV.TabIndex = 1;
            this.btnQLGV.Text = "Quản lý giảng viên";
            this.btnQLGV.UseVisualStyleBackColor = true;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // btnQLCB
            // 
            this.btnQLCB.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQLCB.Location = new System.Drawing.Point(3, 134);
            this.btnQLCB.Name = "btnQLCB";
            this.btnQLCB.Size = new System.Drawing.Size(328, 125);
            this.btnQLCB.TabIndex = 2;
            this.btnQLCB.Text = "Quản lý cán bộ coi thi";
            this.btnQLCB.UseVisualStyleBackColor = true;
            this.btnQLCB.Click += new System.EventHandler(this.btnQLCB_Click);
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTK.Location = new System.Drawing.Point(337, 134);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(328, 125);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(646, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(590, 9);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(50, 50);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(703, 376);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnQLLichThi;
        private Button btnQLGV;
        private Button btnQLCB;
        private Button btnTK;
        private Button btnClose;
        private Button btnGoBack;
    }
}