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
    public partial class frmUsers : Form
    {
        // kết nối tới cơ sở dữ liệu
        string ConSt = @"Data Source=DESKTOP-3A6Q730\SQLEXPRESS;Initial Catalog=DAQLBH;Integrated Security=True";
        // khai báo biến kết nối tới cơ sở dữ liệu
        SqlConnection myConnection = new SqlConnection();
        // khai báo biến truy vấn
        SqlCommand myCommand = new SqlCommand();

        // khai báo biến để check trạng thái
        private bool modeNew;
        // khai báo biến kiểm tra trùng số điện thoại
        private string _Phone;
        public frmUsers()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // load dữ liệu lên lưới
            myConnection = new SqlConnection(ConSt);
            myConnection.Open();

            // gọi hàm truy vấn 
            Display();
        }
        // hàm display 
        private void Display()
        {
            string sSql = "select * from tblUsers Order by UserID";
            myCommand = new SqlCommand(sSql, myConnection);

            // khai báo đối tượng và đọc dữ liệu từ bảng dữ liệu
            SqlDataReader mySqldatareader = myCommand.ExecuteReader();
            // chuyển dữ liệu sang datatable
            DataTable dtUsers = new DataTable();
            dtUsers.Load(mySqldatareader);

            // hiển thị lên lưới

            mySqldatareader.Close();
            dgvUsers.DataSource = dtUsers;
        }
        // hàm check trạng thái
        private void setEnable(bool edit)
        {
            txtAdress.Enabled = edit;
            txtDesciption.Enabled = edit;
            txtFullname.Enabled = edit;
            txtPassword.Enabled = edit;
            txtUserName.Enabled = edit;
            btnCancel.Enabled = edit;
            btnsave.Enabled = edit;
            btnNew.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnDelete.Enabled = !edit;
            btnClose.Enabled = !edit;
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtFullname.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            // check giới tính
            if (dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "1")
                rdomale.Checked = true;
            else
                rdofemale.Checked = true;
            txtAdress.Text = dgvUsers.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPhone.Text = dgvUsers.Rows[e.RowIndex].Cells[6].Value.ToString();
            dpDate.Text = dgvUsers.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDesciption.Text = dgvUsers.Rows[e.RowIndex].Cells[8].Value.ToString();

            // lưu lại phone
            _Phone = txtPhone.Text;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            setEnable(true);
            txtAdress.Clear();
            txtDesciption.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtFullname.Focus();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            setEnable(true);
            txtFullname.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Hiển thị hộp thoại xác nhận chắc chắn xóa không?
            DialogResult dr;
            dr = MessageBox.Show("Chắc chắn xoá dữ liệu không. Nếu xóa thì tất cả dữ liệu liên quan đến nhà xuất bản sẽ xóa hết?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            int r = dgvUsers.CurrentRow.Index;
            //Lấy mã 
            string UserID = dgvUsers.Rows[r].Cells[0].Value.ToString();
            //Định nghĩa xâu SQL với tham số
            string sSql = "Delete From tblUsers Where UserID = @UserID";
            //Chạy lệnh Sql
            myCommand = new SqlCommand(sSql,myConnection);
            //Định nghĩa tham số
            myCommand.Parameters.Add("@UserID", SqlDbType.Int, 4).Value = UserID;
            //Thự hiện lệnh xóa
            myCommand.ExecuteNonQuery();

            //Hiển thị lại dữ liệu đã xóa
            Display();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int n;
            // kiểm tra nhập thông tin đầy đủ chưa
            if (txtFullname.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullname.Focus();
                return;
            } 
            if (txtUserName.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return;
            }
            if (txtAdress.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdress.Focus();
                return;
            }

            

            // kiểm tra trùng số điện thoại
            if(txtPhone.Text.Trim() != _Phone)
            {
                // truy vấn tên loại
                string sSql = "select * from tblUsers where phone = N'" + txtPhone.Text + "'";
                myCommand = new SqlCommand(sSql, myConnection);
                SqlDataReader myDatareader = myCommand.ExecuteReader();
                if(myDatareader.HasRows == true)
                {
                    MessageBox.Show("Đã trùng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();

                    // đóng datareader
                    myDatareader.Close();
                    return;
                }
                myDatareader.Close();
            }

            if(modeNew == true)
            {
                
                string sSql = "insert into tblUsers (Fullname, UserName, Password, Gender, Address, Phone, Date, Description) values (@Fullname, @UserName, @Password, @Gender, @Address, @Phone, @Date, @Description)";

                myCommand = new SqlCommand(sSql, myConnection);
                // truyền tham số
                myCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 50).Value =txtFullname.Text;
                myCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = txtUserName.Text;
                // kiểm tra password phải nhập trên 6 chữ số
                if(txtPassword.Text.Count() >= 6)
                {
                    myCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = txtPassword.Text;
                }
                else
                {
                    // thông báo phải nhập lớn hơn hoặc bằng 6 số
                    MessageBox.Show("Mật khẩu phải nhập trên 6 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }

                myCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = txtAdress.Text;
                // kiểm tra nhập điện thoại 
                if (int.TryParse(txtPhone.Text, out n))
                {
                    if (txtPhone.Text.Count() == 10)
                    {
                        myCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = txtPhone.Text;
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại nhập chưa đúng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhone.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("kí tự nhập vào phải là số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                myCommand.Parameters.Add("@Date", SqlDbType.NVarChar, 50).Value = dpDate.Text;
                myCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = txtDesciption.Text;
                if(rdomale.Checked)
                {
                    myCommand.Parameters.Add("Gender", SqlDbType.NVarChar, 50).Value = 1;
                }
                else
                {
                    myCommand.Parameters.Add("Gender", SqlDbType.NVarChar, 50).Value = 0;
                }

                myCommand.ExecuteNonQuery();
            }
            else
            {
                // lấy dòng hiện thời
                int r = dgvUsers.CurrentRow.Index;
                // lấy mã cần sửa
                string UserID = dgvUsers.Rows[r].Cells[0].Value.ToString();
                // Thực hiện lệnh sửa

                // thực hiện lệnh sửa
                string sSql = "Update tblUsers Set Fullname = @Fullname,UserName = @UserName,Password = @Password,Gender = @Gender, Address = @Address, Phone = @Phone, Date = @Date,Description = @Description where UserID = @UserID";

                myCommand = new SqlCommand(sSql, myConnection);
                // truyền tham số
                myCommand.Parameters.Add("@UserID", SqlDbType.Int, 5).Value = UserID;
                myCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 50).Value = txtFullname.Text;
                myCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = txtUserName.Text;
                // kiểm tra password phải nhập trên 6 chữ số
                if (txtPassword.Text.Count() >= 6)
                {
                    myCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = txtPassword.Text;
                }
                else
                {
                    // thông báo phải nhập lớn hơn hoặc bằng 6 số
                    MessageBox.Show("Mật khẩu phải nhập trên 6 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }
                myCommand.Parameters.Add("@Address", SqlDbType.NVarChar, 50).Value = txtAdress.Text;
                // kiểm tra nhập điện thoại 
                // kiểm tra nhập điện thoại 
                if (int.TryParse(txtPhone.Text, out n))
                {
                    if (txtPhone.Text.Count() == 10)
                    {
                        myCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 50).Value = txtPhone.Text;
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại nhập chưa đúng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhone.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("kí tự nhập vào phải là số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Focus();
                    return;
                }

                myCommand.Parameters.Add("@Date", SqlDbType.NVarChar, 50).Value = dpDate.Text;
                myCommand.Parameters.Add("@Description", SqlDbType.NVarChar, 250).Value = txtDesciption.Text;
                if (rdomale.Checked)
                {
                    myCommand.Parameters.Add("Gender", SqlDbType.NVarChar, 50).Value = 1;
                }
                else
                {
                    myCommand.Parameters.Add("Gender", SqlDbType.NVarChar, 50).Value = 0;
                }

                myCommand.ExecuteNonQuery(); 

            }

            Display();
            setEnable(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtUserName.Focus();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtAdress.Focus();
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                dpDate.Focus();
            }
        }

        private void dpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtDesciption.Focus();
            }
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
