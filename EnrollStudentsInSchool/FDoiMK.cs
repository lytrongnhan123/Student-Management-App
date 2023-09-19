using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FDoiMK : Form
    {
        string Mssv = "";
        public FDoiMK(string ID)
        {
            InitializeComponent();
            Mssv = ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSetPass_Click(object sender, EventArgs e)
        {
            UpdateData update = new UpdateData();
            update.Update("nguoidung", $"matKhau = '{txtPass.Text}'", $"maSinhVien = {Mssv}");
            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }
    }
}
