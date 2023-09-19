using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EnrollStudentsInSchool_
{
    public partial class FLopHP_SV : UserControl
    {
        string LopDangHoc_Table;
        string getdata;
        string CTDT = "";
        string MSSV = "";
        InsertData insert = new InsertData();
        DeleteData delete = new DeleteData();
        bool FindClass = false;
        GetAccount getData = new GetAccount();
        FindData find = new FindData();
        DataGridView dataGridView;
        public FLopHP_SV(string ctdt, string mssv)
        {
            InitializeComponent();
            CTDT = ctdt;
            MSSV = mssv;
            LopDangHoc_Table = "SELECT maLopHocPhan, lophocphan.maMonHoc, namHoc, hocKy, maGiangVien, ngonNguGiangDay, moTa, gioiHanSoLuongSinhVien" +
            $" FROM lophocphan, (SELECT maMonHoc FROM monhoc WHERE maChuongTrinhDaoTao = '{CTDT}') as MH" +
            " WHERE MH.maMonHoc = lophocphan.maMonHoc";
            LoadData();
        }
        private void LoadData()
        {
            getdata = "SELECT lophocphan.maLopHocPhan, maMonHoc, namHoc, hocKy, maGiangVien, ngonNguGiangDay, moTa" +
                $" FROM lophocphan, (SELECT maLopHocPhan FROM thamgiahoc WHERE maSinhVien = {MSSV}) as LopDangHoc" +
                " WHERE lophocphan.maLopHocPhan = LopDangHoc.maLopHocPhan";
            getData.GetData(dgvLopHP, getdata);
        }
        private bool CheckInputInfor()
        {
            string query = "lophocphan INNER JOIN monhoc ON lophocphan.maMonHoc = monhoc.maMonHoc";
            if (!(new Regex("[^' ']").IsMatch(txtMaLop.Text)))
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ LỚP BẠN MUỐN ĐĂNG KÝ");
                return false;
            }
            else if(!txtMaLop.CheckStringIsNumber())
            {
                MessageBox.Show("MÃ LỚP VỪA NHẬP KHÔNG HỢP LỆ");
                return false;
            }    
            else if (!find.Find(query, $"monhoc.maChuongTrinhDaoTao = '{CTDT}' and maLopHocPhan = {txtMaLop.Text}"))
            {
                MessageBox.Show("KHÔNG TỒN TẠI LỚP NÀY TRONG CHƯƠNG TRÌNH ĐÀO TẠO");
                return false;
            }
            return true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(FindClass == false)
            {
                dataGridView = new DataGridView();
                dgvLopHP.SwapGetNewTable(dataGridView, pnlMain, $"{LopDangHoc_Table}");
                FindClass = true;
            }   
            else
            {
                dataGridView.SwapGetNewTable(dgvLopHP, pnlMain, $"{getdata}");
                FindClass = false; 
            }    
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (CheckInputInfor())
            {
                List<string> lst = new List<string>();
                lst.Add($"{txtMaLop.Text}");
                lst.Add($"{MSSV}");
                lst.Add("NULL");
                lst.Add("NULL");
                lst.Add("NULL");
                insert.Insert("thamgiahoc", lst);
                LoadData();
            }
        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if(CheckInputInfor())
            {
                if (MessageBox.Show("BẠN CÓ CHẮC CHẤN MUỐN XÓA VÌ NÓ SẼ BỊ XÓA VĨNH VIỄN", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete.Delete("thamgiahoc", $"maLopHocPhan = {txtMaLop.Text} and maSinhVien = {MSSV}");
                    LoadData();
                }
            }    
        }
    }
}
