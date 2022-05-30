using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// mở thư viện
using System.Data.SqlClient;

namespace Quản_lí_bán_hàng_lưu_niệm
{
    
    public partial class FrmCodeMaterial : Form
    {
        
        // khai báo xâu kết nối tới csdl
        string ConSt = @"Data Source=DESKTOP-3A6Q730\SQLEXPRESS;Initial Catalog=DAQLBH;Integrated Security=True";
        // khai báo biến kết kết nối
        SqlConnection mysqlConnection = new SqlConnection();

        // khai báo biến truy vấn và cập nhật dữ liệu
        SqlCommand mysqlcommand = new SqlCommand();

        // khai báo biế
        private bool modeNew;
        // khai báo biến để kiểm tra trùng tên chất liệu
        private string _codeMaterial;
        public FrmCodeMaterial()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        // hàm check trạng thái
        private void setEnable(bool edit)
        {
            txtName.Enabled = edit;
            txtsource.Enabled = edit;
            txtDescripton.Enabled = edit;
            btncancel.Enabled = edit;
            BtnSave.Enabled = edit;
            btnclose.Enabled = !edit;
            btnDelete.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnNew.Enabled = !edit;

        }

        private void FrmCodeMaterial_Load(object sender, EventArgs e)
        {
            mysqlConnection = new SqlConnection(ConSt);
            mysqlConnection.Open();

            // gọi hàm display
            Display();
        }
        // hàm display 
        private void Display()
        {
            // truy vân dữ liệu
            string sSql = "Select * from tblCodeMaterials Order by codematerialName";
            
            mysqlcommand = new SqlCommand(sSql, mysqlConnection);

            // khai báo đối tượng và đọc dữ liệu từ bảng dữ liệu
            SqlDataReader mySqldatareader = mysqlcommand.ExecuteReader();
            // chuyển dữ liệu sang datatable
            DataTable dtMaterial = new DataTable();
            dtMaterial.Load(mySqldatareader);

            // hiển thị lên lưới
            dgvcodeMaterial.DataSource = dtMaterial;
            mySqldatareader.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            setEnable(true);
            txtDescripton.Clear();
            txtName.Clear();
            txtsource.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            setEnable(true);
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // hiên thị thông báo
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            // lấy mã hiện thời
            int r = dgvcodeMaterial.CurrentRow.Index;
            // lấy mã cần xóa
            string CodeMaterialID = dgvcodeMaterial.Rows[r].Cells[0].Value.ToString();

            // thực hiện lệnh xóa
            string sSql = "Delete from tblCodeMaterials where CodeMaterialID = N'" + CodeMaterialID + "'";

            // thực hiện truy vấn
            mysqlcommand = new SqlCommand(sSql, mysqlConnection);
            mysqlcommand.ExecuteNonQuery();

            // gọi hàm display
            Display();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() == " ")
            {
                MessageBox.Show("Đề nghị nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }

            // kiểm tra trùng tên chất liệu
            if(txtName.Text.Trim() != _codeMaterial)
            {
                string sSql = "select * from tblCodeMaterials where codeMaterialName = N'" + txtName.Text + "'";
                mysqlcommand = new SqlCommand(sSql, mysqlConnection);
                SqlDataReader myDatareader = mysqlcommand.ExecuteReader();
                if (myDatareader.HasRows == true)
                {
                    MessageBox.Show("Đã trùng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();

                    // đóng datareader
                    myDatareader.Close();
                    return;
                }
                myDatareader.Close();
            }

            if(modeNew == true)
            {
                // khi nút thêm mới được nhấn
                string sSql = "insert into tblCodeMaterials ( CodeMaterialName, Sources, Description) values (N'" + txtName.Text + "',N'" + txtsource.Text + "', N'" + txtDescripton.Text + "')";
                mysqlcommand = new SqlCommand(sSql, mysqlConnection);
                mysqlcommand.ExecuteNonQuery();
            }
            else
            {
                // khi nút sửa được nhấn
                // lấy dòng hiện thời
                int r = dgvcodeMaterial.CurrentRow.Index;
                // lấy mã cần sửa
                string codeMaterialID = dgvcodeMaterial.Rows[r].Cells[0].Value.ToString();

                string sSql = "Update tblCodeMaterials set CodeMaterialName = N'" + txtName.Text + "',";
                sSql = sSql + "Sources = N'" + txtsource.Text + "',";
                sSql = sSql + "Description = N'" + txtDescripton.Text + "' ";
                sSql = sSql + "where CodematerialID = " + codeMaterialID;

                mysqlcommand = new SqlCommand(sSql, mysqlConnection);
                mysqlcommand.ExecuteNonQuery();
            }
            // gọi lại hàm display
            Display();
            setEnable(false);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvcodeMaterial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // load dữ liệu lên form
            txtName.Text = dgvcodeMaterial.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsource.Text = dgvcodeMaterial.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripton.Text = dgvcodeMaterial.Rows[e.RowIndex].Cells[3].Value.ToString();
            _codeMaterial = txtName.Text;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtsource.Focus();
            }
        }

        private void txtsource_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtDescripton.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if(this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
