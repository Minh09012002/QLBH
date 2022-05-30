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
    public partial class frmCustomers : Form
    {
        private Dataservices dsCustomer;
        private DataTable dtCustomer;
        // tạo đối tượng với mô hình thực thế
        private DAQLBHEntities3 myDAQLBHEntities;
        // khai báo biển check trạng thái
        bool modeNew;
        // khai báo biến kiểm tra trùng số điện thoại
        private string _Phone;

        public frmCustomers()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        // hàm check trạng thái
        private void setEnable(bool edit)
        {
            txtFullname.Enabled = edit;
            txtadress.Enabled = edit;
            txtDescription.Enabled = edit;
            txtPhone.Enabled = edit;
            btncancel.Enabled = edit;
            btnsave.Enabled = edit;
            btnnew.Enabled = !edit;
            btnedit.Enabled = !edit;
            btndelete.Enabled = !edit;
            btnclose.Enabled = !edit;
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            myDAQLBHEntities = new DAQLBHEntities3();

            // gọi hàm display
            Display();

            // check trạng thái
            setEnable(false);
        }
        private void Display()
        {
            //Truy vấn dữ liệu
            string sSql = "Select * From tblCustomers Order By FullName";

            dsCustomer = new Dataservices();
            dtCustomer = dsCustomer.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvCustom.DataSource = dtCustomer;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            setEnable(true);
            txtadress.Clear();
            txtDescription.Clear();
            txtFullname.Clear();
            txtPhone.Clear();
            txtFullname.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            setEnable(true);
            txtFullname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // thông báo xóa dữ liệu
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            // lấy dòng hiện thời
            int r = dgvCustom.CurrentRow.Index;
            // lấy mã cần xóa
            int customerID = Convert.ToInt32(dgvCustom.Rows[r].Cells[0].Value.ToString());
            // tìm bản ghi cần xóa
            var queryCustomer = from item in myDAQLBHEntities.tblCustomers
                                where item.CustomerID == customerID
                                select item;

            // xóa bản ghi trong bảng tblOrderDetails
            
                                    

            // xóa đối tượng lớp thực thế trong lớp
            myDAQLBHEntities.tblCustomers.Remove(queryCustomer.First());
            // cập nhật lại dữ liệu
            myDAQLBHEntities.SaveChanges();
            // hiển thị lại dữ liệu đã xóa
            Display();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // kiểm tra trường bắt buộc nhập
            if(txtFullname.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập tên ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullname.Focus();
                return;
            }
            if(txtadress.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập địa chỉ ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtadress.Focus();
                return;
            }
            if(txtPhone.Text.Trim() == " ")
            {
                MessageBox.Show("Đề nghị nhập số điện thoại ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return;
            }

            // kiểm tra trùng số điện thoại
            if( modeNew == true || modeNew == false && txtPhone.Text != _Phone)
            {
                //truy vấn dữ liệu và kiểm tra trùng
                var queryCustomer = from item in myDAQLBHEntities.tblCustomers
                                    where item.Phone == txtPhone.Text
                                    select item;
                if (queryCustomer.Count() > 0)
                {
                    MessageBox.Show("Đã trùng số điện thoại khách hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();
                    return;
                }

            }

            if (modeNew)
            {
                int n;
                tblCustomer itemtblcustomer = new tblCustomer();
                itemtblcustomer.FullName = txtFullname.Text;
                itemtblcustomer.Address = txtadress.Text;
                // kiểm tra số điện thoại đã nhập dúng chưa
                    if(txtPhone.Text.Count() == 10)
                    {
                        if (int.TryParse(txtPhone.Text, out n))
                        {
                            itemtblcustomer.Phone = txtPhone.Text;
                        }
                        else
                        {
                            MessageBox.Show("kí tự nhập vào phải là số ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPhone.Focus();
                            return;
                        }
                     }
                    else
                    {
                        MessageBox.Show("Số điện thoại nhập chưa đúng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPhone.Focus();
                        return;
                    }
               
                itemtblcustomer.Description = txtDescription.Text;
                myDAQLBHEntities.tblCustomers.Add(itemtblcustomer);

                // cập nhật lại bảng
                myDAQLBHEntities.SaveChanges();
            }
            else
            {
                int n;
                // lấy dòng hiện thời cần sửa
                int r = dgvCustom.CurrentRow.Index;

                // lấy mã cần sửa
                int customerID = Convert.ToInt32(dgvCustom.Rows[r].Cells[0].Value.ToString());



                var queryCustomer = from item in myDAQLBHEntities.tblCustomers
                                    where item.CustomerID == customerID
                                    select item;

                // lấy đối tượng cần sửa
                tblCustomer itemCustomer = queryCustomer.First();

                // gán giá trị mới cho đối tượng lớp thực thể
                itemCustomer.FullName = txtFullname.Text;
                itemCustomer.Address = txtadress.Text;
                if (int.TryParse(txtPhone.Text, out n))
                {
                    if (txtPhone.Text.Count() == 10)
                    {
                        itemCustomer.Phone = txtPhone.Text;
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
                itemCustomer.Description = txtDescription.Text;

                myDAQLBHEntities.SaveChanges();
            }

            // hiển thị lại dữ liệu
            Display();
            setEnable(false);
        }
        private void dgvCustom_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustom.CurrentRow != null)
            {
                int i;
                i = e.RowIndex;
                txtFullname.Text = dgvCustom.Rows[i].Cells[1].Value.ToString();
                txtadress.Text = dgvCustom.Rows[i].Cells[2].Value.ToString();
                txtPhone.Text = dgvCustom.Rows[i].Cells[3].Value.ToString();
                txtDescription.Text = dgvCustom.Rows[i].Cells[4].Value.ToString();
                //lưu biến kiểm tra trùng số điện thoại
                _Phone = txtPhone.Text;
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                txtadress.Focus();
            }
        }

        private void txtadress_KeyDown(object sender, KeyEventArgs e)
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
                txtDescription.Focus();
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
