using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Quản_lí_bán_hàng_lưu_niệm
{
    public partial class turnover : Form
    {
        private SqlConnection mySqlconnection = new SqlConnection(@"Data Source=DESKTOP-3A6Q730\SQLEXPRESS;Initial Catalog=DAQLBH;Integrated Security=True");
        public turnover()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from tblCustomer", mySqlconnection); 
                mySqlconnection.Open();
                mySqlconnection.Close();
                da.Fill(dt);
                MessageBox.Show("Thành công");
                chart1.ChartAreas["charArea1"].AxisX.Title = "ID Khách hàng";
                chart1.ChartAreas["charArea1"].AxisY.Title = "Tuổi";
                for(int i = 0; i< dt.Rows.Count; i++)
                {
                    chart1.Series["Age"].Points.AddXY(dt.Rows[i]["ID"], dt.Rows[i]["Age"]);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}
