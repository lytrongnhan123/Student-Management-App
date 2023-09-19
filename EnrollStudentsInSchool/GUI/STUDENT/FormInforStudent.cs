using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FormInforStudent : UserControl
    {
        string Mssv = "";
        GetAccount getAccount = new GetAccount();
        public FormInforStudent(string ID)
        {
            Mssv = ID;
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            List<string> lstInfor = getAccount.GetInfor(Mssv);
            lbMSSV.Text = lstInfor[0];
            lbName.Text = lstInfor[1];
            lbNgaySinh.Text = lstInfor[2];
            lbNamNhapHoc.Text = lstInfor[3];
            lbCTDT.Text = lstInfor[4];
            if(lstInfor[5] == "True")
            {
                cbBGioTinh.Checked = true;
            }    
            else
            {
                cbBGioTinh.Checked = false;
            }
            lbEmail.Text = lstInfor[6];
            lbSdt.Text = lstInfor[7];
            lbDiachi.Text = lstInfor[8];
            lbNoiSinh.Text = lstInfor[9];
            lbDanToc.Text = lstInfor[10];
            lbCCCD.Text = lstInfor[11];
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            FDoiMK fDoiMK = new FDoiMK(Mssv);
            fDoiMK.ShowDialog();
        }
    }
}
