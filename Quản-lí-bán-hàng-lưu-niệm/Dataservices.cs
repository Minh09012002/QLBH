using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// mở thư viện
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Quản_lí_bán_hàng_lưu_niệm
{
    internal class Dataservices
    {
        private static SqlConnection mySqlConnection;
        private SqlDataAdapter myDataAdapter;
        //hàm kết nối tới CSDL
        public bool OpenDB(string dd)
        {
            string conStr = dd;
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                mySqlConnection = null;
                return false;
            }
            return true;
        }
        //Hàm truv vấn dữ liệu
        public DataTable RunQuery(string sSql)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataAdapter = new SqlDataAdapter(sSql, mySqlConnection);
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
                myDataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                return null;
            }
            return myDataTable;
        }
        //Hàm cập nhật dữ liệu từ 1 DataTable
        public void Update(DataTable myDataTable)
        {
            try
            {
                myDataAdapter.Update(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }
        //Hàm thực hiện 1 câu lệnh SQL như INSERt, UPDATE, DELETE
        public void ExecuteNonQuery(string sSql)
        {
            SqlCommand mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }
    }
}

