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
    public partial class frmsignin : Form
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
        public frmsignin()
        {
            InitializeComponent();
            // hiện form từ2
            this.Opacity = 0;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmsignin_Load(object sender, EventArgs e)
        {
            // load dữ liệu lên lưới
            myConnection = new SqlConnection(ConSt);
            myConnection.Open();
            txtFullname.Focus();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            modeNew = true;
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
            if (txtPhone.Text.Trim() != _Phone)
            {
                // truy vấn tên loại
                string sSql = "select * from tblUsers where phone = N'" + txtPhone.Text + "'";
                myCommand = new SqlCommand(sSql, myConnection);
                SqlDataReader myDatareader = myCommand.ExecuteReader();
                if (myDatareader.HasRows == true)
                {
                    MessageBox.Show("Đã trùng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();

                    // đóng datareader
                    myDatareader.Close();
                    return;
                }
                myDatareader.Close();
            }

            if (modeNew == true)
            {

                string sSql = "insert into tblUsers (Fullname, UserName, Password, Gender, Address, Phone, Date, Description) values (@Fullname, @UserName, @Password, @Gender, @Address, @Phone, @Date, @Description)";

                myCommand = new SqlCommand(sSql, myConnection);
                // truyền tham số
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
            txtAdress.Clear();
            txtDesciption.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
            txtFullname.Focus();
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
            txtDesciption.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frmlogin1 frmlogin = new frmlogin1();
            frmlogin.ShowDialog();
            this.Close();
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
