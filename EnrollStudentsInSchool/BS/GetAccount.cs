using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace EnrollStudentsInSchool_
{
    class GetAccount : MyExecuteNonQuery
    {
        public string CheckAccountExists(string UserName, string PassWord, string position)
        {
            string str = "";
            try
            {
                ConnectSql();
                sqlCmd = new SqlCommand($"SELECT  dbo.LoginFunction('{UserName}', '{PassWord}', {position})", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                str = dt.Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("LỖI KIỂM TRA TÀI KHOẢN TỒN TẠI");
            }
            return str;
        }
        public List<string> GetInfor(string ID)
        {
            List<string> lstInfor = new List<string>();
            try
            {
                ConnectSql();             
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM sinhvien WHERE maSinhVien = {ID}", sqlConnection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int col = 0; col < dt.Columns.Count; col++)
                {
                    lstInfor.Add(dt.Rows[0][col].ToString());
                }    
            }
            catch
            {
                MessageBox.Show("LỖI KIỂM TRA TÀI KHOẢN TỒN TẠI");
            }
            return lstInfor;
        }
        public void GetData(DataGridView dgv,string query)
        {
            try
            {
                ConnectSql();
                da = new SqlDataAdapter(query, sqlConnection);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                sqlConnection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không load được data. Lỗi rồi!!!");
            }
        }
    }
}
