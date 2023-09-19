using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class GUI_Admin : Form
    {
        public GUI_Admin()
        {
            InitializeComponent();
            ClickEffect();
            pnlMaincontrols.SetDoubleBuffered();
        }

        private void ClickEffect()
        {
            foreach(Button btn in tlPMain.Controls)
            {
                btn.BackColor = Color.FromArgb(0, 57, 162, 217);
            }    
        }   
        private void btnStudent_Click(object sender, EventArgs e)
        {
            FStudent fstd = new FStudent();
            MainControls.Show(fstd.pnlMain, pnlMaincontrols, fstd.dgvStudent);
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            FStaff fStaff = new FStaff();
            MainControls.Show(fStaff.pnlMain, pnlMaincontrols, fStaff.dgvStaff);
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            FMonHoc fmh = new FMonHoc();
            MainControls.Show(fmh.pnlMain, pnlMaincontrols, fmh.dgvMonhoc);
        }

        private void btnChuongTrinhDaoTao_Click(object sender, EventArgs e)
        {
            FChuongTrinhDaoTao fChuongTrinhDaoTao = new FChuongTrinhDaoTao();
            MainControls.Show(fChuongTrinhDaoTao.pnlMain, pnlMaincontrols, fChuongTrinhDaoTao.dgvChuongTrinhDaoTao);
        }

        private void btnLopHocPhan_Click(object sender, EventArgs e)
        {
            FLopHocPhan fLopHocPhan = new FLopHocPhan();
            MainControls.Show(fLopHocPhan.pnlMain, pnlMaincontrols, fLopHocPhan.dgvLopHocPhan);
        }
        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            FUserAccount fUserAccount = new FUserAccount();
            MainControls.Show(fUserAccount.pnlMain, pnlMaincontrols, fUserAccount.dgvUserAccount);
        }
        private void btnPhanBoLop_Click(object sender, EventArgs e)
        {
            FPhanBoLop fPhanBoLop = new FPhanBoLop();
            MainControls.Show(fPhanBoLop, pnlMaincontrols, fPhanBoLop.dgvPhanBoLop);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
