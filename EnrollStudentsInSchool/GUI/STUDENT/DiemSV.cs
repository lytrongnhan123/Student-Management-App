using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace EnrollStudentsInSchool_
{
    public partial class DiemSV : UserControl
    {
        GetAccount getData = new GetAccount();
        string MSSV = "";
        public DiemSV(string mssv)
        {
            InitializeComponent();
            MSSV = mssv;
            LoadData(mssv);
        }
        private void LoadData(string mssv)
        {
            string query = "SELECT tenMonHoc, namHoc, hocKy, DiemGiuaKy, DiemCuoiKy, DiemTrungBinh";
            query += $" FROM monhoc INNER JOIN (SELECT maMonHoc, namHoc, hocKy, DiemGiuaKy, DiemCuoiKy, DiemTrungBinh FROM thamgiahoc INNER JOIN lophocphan ON thamgiahoc.maLopHocPhan = lophocphan.maLopHocPhan  WHERE maSinhVien = {mssv})  AS MaMH";
            query += " ON MaMH.maMonHoc = monhoc.maMonHoc";
            getData.GetData(dgvDiem, query);
        }

        private void cbBHocKyChanged(object sender, EventArgs e)
        {
            LoadData(MSSV);
            int dgvLenght = dgvDiem.Rows.Count - 1;
            for(int row = 0; row < dgvLenght; row++)
            {
                if(dgvDiem.Rows[row].Cells[2].Value.ToString() != cbBHocKy.SelectedItem.ToString())
                {
                    dgvDiem.Rows.RemoveAt(row);
                    row--;
                    dgvLenght--;
                }    
            }    
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!txtNamhoc.CheckStringIsNumber())
            {
                MessageBox.Show("NĂM HỌC NHẬP KHÔNG HỢP LỆ");
            }    
            else
            {
                LoadData(MSSV);
                int dgvLenght = dgvDiem.Rows.Count - 1;
                for (int row = 0; row < dgvLenght; row++)
                {
                    if (dgvDiem.Rows[row].Cells[1].Value.ToString() != txtNamhoc.Text)
                    {
                        dgvDiem.Rows.RemoveAt(row);
                        row--;
                        dgvLenght--;
                    }
                }
            }    
        }

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            LoadData(MSSV);
            txtNamhoc.ResetText();
            cbBHocKy.ResetText();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
