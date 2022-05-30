using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_lí_bán_hàng_lưu_niệm
{
    public partial class frmSearchGoods : Form
    {
        SqlCommand mysqlcommand = new SqlCommand();
        SqlConnection mysqlconection = new SqlConnection();
        private Dataservices dsGood;
        private DataTable dtGood;
        public frmSearchGoods()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        private void Display()
        {
            //Truy vấn dữ liệu
            string sSql = "Select * From tblGoods Order By GoodName";

            dsGood = new Dataservices();
            dtGood = dsGood.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvGoods.DataSource = dtGood;
        }

        private void frmSearchGoods_Load(object sender, EventArgs e)
        {

            // chuyển dữ liệu vào cobcodematerial
            // 1.1. truy vấn dữ liệu
            string sSql = "select * from tblCodeMaterials Order by CodeMaterialName";
            Dataservices dsCodeMaterial = new Dataservices();
            DataTable dtCodeMaterial = dsCodeMaterial.RunQuery(sSql);
            // 1.2 chuyển dữ liệu vào cbocateogry
            cobCodeMaterialID.DataSource = dtCodeMaterial;
            cobCodeMaterialID.DisplayMember = "CodeMaterialName";
            cobCodeMaterialID.ValueMember = "CodeMaterialID";

            Display();
        }

        private void dgvGoods_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGoodID.Text = dgvGoods.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtGoodName.Text = dgvGoods.Rows[e.RowIndex].Cells[1].Value.ToString();
            cobCodeMaterialID.SelectedValue = dgvGoods.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAcount.Text = dgvGoods.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtpriceImport.Text = dgvGoods.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpriceSell.Text = dgvGoods.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDescription.Text = dgvGoods.Rows[e.RowIndex].Cells[7].Value.ToString();
            // hiển thị dữ liệu ảnh
            if (dgvGoods.Rows[e.RowIndex].Cells[6].Value.ToString() != "")
            {
                Byte[] i = (byte[])dgvGoods.Rows[e.RowIndex].Cells[6].Value;
                MemoryStream stmBLOBData = new MemoryStream(i);
                pictureboxphoto.Image = Image.FromStream(stmBLOBData);

            }
        }
        private void Search(string sSql)
        {
           // sSql = "Select * From tblGoods Order By GoodName";

            dsGood = new Dataservices();
            dtGood = dsGood.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvGoods.DataSource = dtGood;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            // định nghĩa xâu truy vấn
            string sSql;
            if (rbnamegood.Checked == true)
            {
                sSql = "select * from tblGoods where GoodName LIKE N'%" + txtSearch.Text + "%' Order by GoodID";

            }
            else
            {
                sSql = "select * from tblGoods where GoodName LIKE N'%" + txtSearch.Text + "%' Order by GooID";
            }
            Search(sSql);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
