using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class CTDT_SV : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery = new MyExecuteNonQuery();
        string CTDT = "";
        public CTDT_SV(string ctdt)
        {
            InitializeComponent();
            CTDT = ctdt;
            LoadData();
        }
        private void LoadData()
        {
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvCTDT, $"monhoc WHERE maChuongTrinhDaoTao = '{CTDT}'");
        }
    }
}
