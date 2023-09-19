
namespace EnrollStudentsInSchool_
{
    partial class DiemSV
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamhoc = new System.Windows.Forms.TextBox();
            this.cbBHocKy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnReFresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDiem.Location = new System.Drawing.Point(0, 277);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowTemplate.Height = 25;
            this.dgvDiem.Size = new System.Drawing.Size(1084, 434);
            this.dgvDiem.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenMonHoc";
            this.Column1.HeaderText = "Tên Môn Học";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "namHoc";
            this.Column5.HeaderText = "Năm Học";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "hocKy";
            this.Column6.HeaderText = "Học Kỳ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DiemGiuaKy";
            this.Column2.HeaderText = "Điểm Giữa Kỳ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiemCuoiKy";
            this.Column3.HeaderText = "Điểm Cuối Kỳ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiemTrungBinh";
            this.Column4.HeaderText = "Điểm Trung Bình";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(61, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(61, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học";
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(167, 141);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(100, 23);
            this.txtNamhoc.TabIndex = 3;
            // 
            // cbBHocKy
            // 
            this.cbBHocKy.FormattingEnabled = true;
            this.cbBHocKy.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2",
            "Học kỳ 3"});
            this.cbBHocKy.Location = new System.Drawing.Point(167, 204);
            this.cbBHocKy.Name = "cbBHocKy";
            this.cbBHocKy.Size = new System.Drawing.Size(100, 23);
            this.cbBHocKy.TabIndex = 4;
            this.cbBHocKy.SelectedIndexChanged += new System.EventHandler(this.cbBHocKyChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(425, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "ĐIỂM TỔNG KẾT";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::EnrollStudentsInSchool_.Properties.Resources.searching;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(273, 141);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(23, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnReFresh
            // 
            this.btnReFresh.BackgroundImage = global::EnrollStudentsInSchool_.Properties.Resources.refresh;
            this.btnReFresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReFresh.FlatAppearance.BorderSize = 0;
            this.btnReFresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReFresh.Location = new System.Drawing.Point(6, 282);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(30, 30);
            this.btnReFresh.TabIndex = 10;
            this.btnReFresh.UseVisualStyleBackColor = true;
            this.btnReFresh.Click += new System.EventHandler(this.btnReFresh_Click);
            // 
            // DiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReFresh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbBHocKy);
            this.Controls.Add(this.txtNamhoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiem);
            this.Name = "DiemSV";
            this.Size = new System.Drawing.Size(1084, 711);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamhoc;
        private System.Windows.Forms.ComboBox cbBHocKy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnReFresh;
    }
}
