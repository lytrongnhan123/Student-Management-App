using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
namespace EnrollStudentsInSchool_
{
    public partial class FPhanBoLop : UserControl
    {
        MyExecuteNonQuery myExecuteNonQuery;
        DataGridView dataGridView;
        InsertData insert = new InsertData();
        UpdateData update = new UpdateData();
        DeleteData delete = new DeleteData();
        FindData find = new FindData();
        string TableName = "thamgiahoc";
        string MaLop = "";
        string MaSV = "";
        public FPhanBoLop()
        {
            InitializeComponent();
            LoadData();
            RefreshInput();
            pnlMain.SetDoubleBuffered();
        }
        private void LoadData()
        {
            myExecuteNonQuery = new MyExecuteNonQuery();
            myExecuteNonQuery.LoadData(dgvPhanBoLop, TableName);
        }
        private void RefreshInput()
        {
            btnNhapDiem.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            foreach (Control txt in pnlMain.Controls)
            {
                if (txt is System.Windows.Forms.TextBox)
                {
                    txt.ResetText();
                }
            }
        }
        private bool CheckInforInput()
        {
            string query = "(SELECT maLopHocPhan FROM lophocphan INNER JOIN (SELECT maMonHoc" +
                            $" FROM monhoc INNER JOIN (SELECT maChuongTrinhDaoTao FROM sinhvien WHERE maSinhVien = {txtMaSV.Text}) as maCTDT" +
                            " ON monhoc.maChuongTrinhDaoTao = maCTDT.maChuongTrinhDaoTao) as MH" +
                            " ON lophocphan.maMonHoc = MH.maMonHoc) as LOP";
                            
            if (!(new Regex("[^' ']").IsMatch(txtMaLop.Text)) || !(new Regex("[^' ']").IsMatch(txtMaSV.Text)))
            {
                MessageBox.Show("VUI LÒNG NHẬP ĐÀY ĐỦ THÔNG TIN");
                return false;
            }
            else if (!txtMaLop.CheckStringIsNumber() || !txtMaSV.CheckStringIsNumber())
            {
                MessageBox.Show("MÃ LỚP HOẶC MÃ SV NHẬP CHƯA HỢP LỆ");
                return false;
            }    
            else if(!find.Find("lophocphan", $"maLopHocPhan = {txtMaLop.Text}"))
            {
                MessageBox.Show("MÃ LỚP HỌC PHẦN KHÔNG TỒN TẠI");
                return false;
            }    
            else if(!find.Find("sinhvien", $"maSinhVien = {txtMaSV.Text}"))
            {
                MessageBox.Show("MÃ SINH VIÊN KHÔNG TỒN TẠI");
                return false;
            }    
            else if(!find.Find(query, $"LOP.maLopHocPhan = {txtMaLop.Text}"))
            {
                MessageBox.Show("KHÔNG TỒN TẠI LỚP NÀY TRONG CHƯƠNG TRÌNH ĐÀO TẠO");
                return false;
            }    
            return true;
        }    
        private List<string> getAllValuesOfTable()
        {
            List<string> lstComponents = new List<string>();
            if(btnAdd.Enabled == true)
            {
                lstComponents.Add(txtMaLop.Text);
                lstComponents.Add(txtMaSV.Text);
            }
            else
            {
                lstComponents.Add(MaLop);
                lstComponents.Add(MaSV);
            }
            return lstComponents;
        }
        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNhapDiem.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhanBoLop.Rows[e.RowIndex];
                MaLop = row.Cells[0].Value.ToString();
                MaSV = row.Cells[1].Value.ToString();
            }
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            int dgvLenght = dgvPhanBoLop.Rows.Count-1;
            for (int row = 0; row < dgvLenght; row++)
            {
                if (dgvPhanBoLop.Rows[row].Cells[0].Value.ToString() != txtMaLop.Text)
                {
                    dgvPhanBoLop.Rows.RemoveAt(row);
                    dgvLenght--;
                    row--;
                }
            }
        }

        private void btnTimSV_Click(object sender, EventArgs e)
        {
            int dgvLenght = dgvPhanBoLop.Rows.Count - 1;
            for (int row = 0; row < dgvLenght; row++)
            {
                if (dgvPhanBoLop.Rows[row].Cells[1].Value.ToString() != txtMaSV.Text)
                {
                    dgvPhanBoLop.Rows.RemoveAt(row);
                    dgvLenght--;
                    row--;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            RefreshInput();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckInforInput())
            {
                List<string> lst = getAllValuesOfTable();
                lst.Add("NULL");
                lst.Add("NULL");
                lst.Add("NULL");
                insert.Insert(TableName, lst);
                LoadData(); RefreshInput();
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("BẠN CÓ CHẮC CHẤN MUỐN XÓA VÌ NÓ SẼ BỊ XÓA VĨNH VIỄN", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                delete.Delete(TableName, $"maLopHocPhan = {MaLop} and maSinhVien = {MaSV}");
                LoadData(); RefreshInput();
            }    
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            float DiemTB = 0f;
            bool CheckPoint = true;
            try
            {
                DiemTB = (float)(float.Parse(txtDiemCK.Text) + float.Parse(txtDiemGK.Text)) / 2;
                if(float.Parse(txtDiemCK.Text) < 0 || float.Parse(txtDiemCK.Text) > 10 || float.Parse(txtDiemGK.Text) < 0 || float.Parse(txtDiemGK.Text) > 10)
                {
                    CheckPoint = false;
                }    
            }
            catch
            {
                MessageBox.Show("ĐIỂM NHẬP KHÔNG HỢP LỆ");
                CheckPoint = false;
            }
            if(CheckPoint == true)
            {
                List<string> lst = getAllValuesOfTable();
                lst.Add($"{txtDiemGK.Text}");
                lst.Add($"{txtDiemCK.Text}");
                lst.Add($"{DiemTB}");
                update.Update(2, TableName, lst, $"maLopHocPhan = {MaLop} AND maSinhVien = {MaSV}");
                LoadData(); RefreshInput();
            }       
            else
            {
                MessageBox.Show("ĐIỂM NHẬP KHÔNG HỢP LỆ");
            }    
        }

        private void btnShowSV_Click(object sender, EventArgs e)
        {
            if(btnShowSV.Text == "Tra MSSV")
            {
                /*FStudent fStudent = new FStudent();
                MainControls.Show(fStudent.pnlMain, pnlDgv);
                btnShowSV.Text = "Back";*/
                dataGridView = new DataGridView();
                dgvPhanBoLop.Swap(dataGridView, pnlDgv, "sinhvien");
                btnShowSV.Text = "Back";
            }    
            else
            {
                dataGridView.Swap(dgvPhanBoLop, pnlDgv, "thamgiahoc");
                btnShowSV.Text = "Tra MSSV";
            }    
        }

        private void btnInDiem_Click(object sender, EventArgs e)
        {

        }
    }
}
