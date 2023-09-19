using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class GUI_Student : Form
    {
        string MSSV = "";
        GetAccount getAccount = new GetAccount();
        List<string> lst;
        public GUI_Student(string ID)
        {
            InitializeComponent();
            MSSV = ID;
            lst = getAccount.GetInfor(MSSV);
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            FormInforStudent finfor = new FormInforStudent(MSSV);
            MainControls.Show(finfor, pnlMaincontrol);
        }

        private void btnChuongTrinhDaoTao_Click(object sender, EventArgs e)
        {
            CTDT_SV fCTDT_SV = new CTDT_SV(lst[4]);
            MainControls.Show(fCTDT_SV, pnlMaincontrol, fCTDT_SV.dgvCTDT);
        }

        private void btnLopHocPhan_Click(object sender, EventArgs e)
        {
            FLopHP_SV fLopHP_SV = new FLopHP_SV(lst[4], MSSV);
            MainControls.Show(fLopHP_SV, pnlMaincontrol, fLopHP_SV.dgvLopHP);
        }
        private void btnDiem_Click(object sender, EventArgs e)
        {
            DiemSV diem = new DiemSV($"{MSSV}");
            MainControls.Show(diem, pnlMaincontrol, diem.dgvDiem);
        }

        private void btnLogoutSV(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
