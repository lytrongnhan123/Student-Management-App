
namespace EnrollStudentsInSchool_
{
    partial class FLopHP_SV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyMon = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLopHP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnTimKiem);
            this.pnlMain.Controls.Add(this.txtMaLop);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnHuyMon);
            this.pnlMain.Controls.Add(this.btnDangky);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.dgvLopHP);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1084, 711);
            this.pnlMain.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::EnrollStudentsInSchool_.Properties.Resources.searching;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(837, 159);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(731, 159);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 23);
            this.txtMaLop.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(654, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Lớp";
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyMon.Location = new System.Drawing.Point(992, 158);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(75, 25);
            this.btnHuyMon.TabIndex = 4;
            this.btnHuyMon.Text = "HỦY MÔN";
            this.btnHuyMon.UseVisualStyleBackColor = false;
            this.btnHuyMon.Click += new System.EventHandler(this.btnHuyMon_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangky.Location = new System.Drawing.Point(891, 158);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(75, 25);
            this.btnDangky.TabIndex = 4;
            this.btnDangky.Text = "ĐĂNG KÝ";
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(357, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "DANH SÁCH LỚP ĐANG HỌC";
            // 
            // dgvLopHP
            // 
            this.dgvLopHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLopHP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvLopHP.Location = new System.Drawing.Point(1, 189);
            this.dgvLopHP.Name = "dgvLopHP";
            this.dgvLopHP.RowTemplate.Height = 25;
            this.dgvLopHP.Size = new System.Drawing.Size(1081, 522);
            this.dgvLopHP.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maLopHocPhan";
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "maMonHoc";
            this.Column2.HeaderText = "Mã Môn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "namHoc";
            this.Column3.HeaderText = "Năm Học";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "hocKy";
            this.Column4.HeaderText = "Học Kỳ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "maGiangVien";
            this.Column5.HeaderText = "Mã Giáo Viên";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ngonNguGiangDay";
            this.Column6.HeaderText = "Ngôn Ngữ Giảng Dạy";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "moTa";
            this.Column7.HeaderText = "Mô Tả";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "gioiHanSoLuongSinhVien";
            this.Column8.HeaderText = "Giới Hạn Số Lượng Sinh Viên";
            this.Column8.Name = "Column8";
            // 
            // FLopHP_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "FLopHP_SV";
            this.Size = new System.Drawing.Size(1084, 711);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.DataGridView dgvLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuyMon;
    }
}
