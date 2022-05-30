using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lí_bán_hàng_lưu_niệm
{
    public partial class frmOrders : Form
    {

        bool modeNew;
        private Dataservices dsOrder;
        private DataTable dtOrder;
        private string _phone;
        public frmOrders()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        private void setEnable(bool edit)
        {
            txtAcount.Enabled = edit;
            //cboCustomerName.Enabled = edit;
            txtDate.Enabled = edit;
            txtdiscount.Enabled = edit;
            cboGoodfullname.Enabled = edit;
            txtcustomerFullname.Enabled = edit;
            txtPhone.Enabled = edit;
            txtAdress.Enabled = edit;
            txtmoney.Enabled = edit;
            txtprice.Enabled = edit;
            btncancel.Enabled = edit;
            btnSave.Enabled = edit;
            btnNew.Enabled = !edit;
            btnclose.Enabled = !edit;
            btnDelete.Enabled = !edit;
           // btnEdit.Enabled = !edit;
        }
        private void Display()
        {
            // truy vấn dữ liệu
           string sSql = "select * from tblOrders ";
          
            
            dsOrder = new Dataservices();
            dtOrder = dsOrder.RunQuery(sSql);
            // hiển thị dữ liệu lên lưới
            dgvOrders.DataSource = dtOrder;
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {

            // truy vấn dũ liệu
             string sSql = "Select * from tblUsers order by FullName";
            Dataservices dsuser = new Dataservices();
            DataTable dtuser = dsuser.RunQuery(sSql);
            // chuyển dữ liệu vào
            cboFullname.DataSource = dtuser;
            cboFullname.DisplayMember = "FullName";
            cboFullname.ValueMember = "UserID";

            // truy vấn dữ liệu
            sSql = "select * from tblGoods order by GoodName";
            Dataservices dsGood = new Dataservices();
            DataTable dtGood = dsGood.RunQuery(sSql);
            // chuyển dũ liệu vào
            cboGoodfullname.DataSource = dtGood;
            cboGoodfullname.DisplayMember = "GoodName";
            cboGoodfullname.ValueMember = "GoodID";

            

            Display();
            setEnable(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            setEnable(true);
            txtAcount.Clear();
            txtDate.Clear();
            txtdiscount.Clear();
            txtmoney.Clear();
            txtprice.Clear();
            txtcustomerFullname.Clear();
            txtPhone.Clear();
            txtAdress.Clear();
            txtDescription.Clear();
            txtcustomerFullname.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            setEnable(true);
            txtcustomerFullname.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check các trường phải nhập vào
            if(txtcustomerFullname.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập tên khách hàng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcustomerFullname.Focus();
                return;
            }
            if (txtAdress.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập Địa chỉ khách hàng", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdress.Focus();
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập số điện thoại khách hàng ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcustomerFullname.Focus();
                return;
            }
            if (txtAcount.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập số lượng sản phẩm ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAcount.Focus();
                return;
            }
            if (txtprice.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập giá sản phẩm  ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprice.Focus();
                return;
            }

            // kiểm tra trùng số điện thoại
            if ( modeNew == true || modeNew == false && txtPhone.Text!= _phone)
            {
                string sSql = "Select * from tblCustomers where Phone = N'" + txtPhone.Text + "'";
                Dataservices mydataServices1 = new Dataservices();
                DataTable dtSearch = mydataServices1.RunQuery(sSql);
                if (dtSearch.Rows.Count > 0)
                {
                    MessageBox.Show("Đã trùng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Focus();
                    return;
                }
            }

            if (modeNew == true)
            {
             

                DataRow mydatarow = dtOrder.NewRow();
                mydatarow["UserID"] = cboFullname.SelectedValue;
                mydatarow["GoodID"] = cboGoodfullname.SelectedValue;
                mydatarow["Date"] = txtDate.Text;
                mydatarow["Description"] = txtDescription.Text;
                double acount = Convert.ToDouble(txtAcount.Text);
                double price = Convert.ToDouble(txtprice.Text);
                double disc = Convert.ToDouble(txtdiscount.Text);
                double money = (acount * price) ;
                double total =Convert.ToDouble( money * ((100 - disc) / 100));
                txtmoney.Text = total.ToString();
                mydatarow["Money"] = txtmoney.Text;
                


                // kiểm tra số điện thoại
                
                if (txtPhone.Text.Count() == 10)
                {
                    int n;
                    // đưa dữ liệu vào bảng tblCustommer
                    if (int.TryParse(txtPhone.Text, out n))
                    {
                        string sSq = "Insert Into tblCustomers (FullName, Address, Phone) Values (N'" + txtcustomerFullname.Text + "', N'" + txtAdress.Text + "',N'" + txtPhone.Text + "')";
                        Dataservices dsCustomers = new Dataservices();
                        dsCustomers.ExecuteNonQuery(sSq);
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

                dtOrder.Rows.Add(mydatarow);
                dsOrder.Update(dtOrder);

                // đưa dữ liệu vừa nhập vào bảng tblOrderDetail
                // lây OrderID vừa nhập từ bảng OrderID
                string sSql = "select OrderID from tblOrders where OrderID = (select max(OrderID) from tblOrders)";
                dtOrder = dsOrder.RunQuery(sSql);
                string OrderID = dtOrder.Rows[0]["OrderID"].ToString();

                // lấy CustomerID vừa nhập
                sSql = "Select CustomerID from tblCustomers Where CustomerID = (select max(CustomerID) from tblCustomers)";
                Dataservices dsCustomer = new Dataservices();
                DataTable dtCustomer = dsCustomer.RunQuery(sSql);
                string CustomerID = dtCustomer.Rows[0]["CustomerID"].ToString();

                //đưa OrderID và CustomerID vừa nhập vào bảng OrderDetail
                sSql = "Insert Into tblOrdersDetails (OrderID, CustomerID, Amount, Price, Discount, money) Values (" + OrderID + "," + CustomerID + ",N'" + txtAcount.Text + "',N'" + txtprice.Text + "',N'" + txtdiscount.Text + "',N'" + txtmoney.Text + "')";
                dsCustomer.ExecuteNonQuery(sSql);

               
            }
            else
            {

                // lấy dòng hiện thời
                int r = dgvOrders.CurrentRow.Index;
                // tạo một dòng dữ liệu
                DataRow mydatarow = dtOrder.Rows[r];

                mydatarow["UserID"] = cboFullname.SelectedValue;
                mydatarow["GoodID"] = cboGoodfullname.SelectedValue;
                mydatarow["Date"] = txtDate.Text;
                mydatarow["Description"] = txtDescription.Text;
                double acount = Convert.ToDouble(txtAcount.Text);
                double price = Convert.ToDouble(txtprice.Text);
                double disc = Convert.ToDouble(txtdiscount.Text);
                double money = (acount * price);
                double total = Convert.ToDouble(money * ((100 - disc) / 100));
                txtmoney.Text = total.ToString();
                mydatarow["Money"] = txtmoney.Text;

                if (txtPhone.Text.Count() == 10)
                {
                    
                    int n;
                    // đưa dữ liệu mới sửa vào bảng tblCustommer
                    if (int.TryParse(txtPhone.Text, out n))
                    {
                        string sSq = "update tblCustomers set FullName = N'" + txtcustomerFullname.Text + "', Address = N'" + txtAdress.Text + "', Phone = N'" + txtPhone.Text + "'";
                        sSq = sSq + "where CustomerID";
                        Dataservices dsCustomers = new Dataservices();
                        dsCustomers.ExecuteNonQuery(sSq);
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
                dsOrder.Update(dtOrder);

                // đưa dữ liệu vừa sửa vào bảng tblOrderDetail
                // lây OrderID vừa sửa từ bảng OrderID
                string sSql = "select OrderID from tblOrders where OrderID = (select max(OrderID) from tblOrders)";
                dtOrder = dsOrder.RunQuery(sSql);
                string OrderID = dtOrder.Rows[0]["OrderID"].ToString();

                // lấy CustomerID vừa sửa
                sSql = "Select CustomerID from tblCustomers Where CustomerID = (select max(CustomerID) from tblCustomers)";
                Dataservices dsCustomer = new Dataservices();
                DataTable dtCustomer = dsCustomer.RunQuery(sSql);
                string CustomerID = dtCustomer.Rows[0]["CustomerID"].ToString();

                //đưa OrderID và CustomerID vừa sửa vào bảng OrderDetail
                sSql = " update tblOrdersDetails set OrderID = N'" + OrderID + "', CustomerID = N'" + CustomerID + "', Amount = N'" + txtAcount.Text + "', Price = N'" + txtprice.Text + "', Discount = N'" + txtdiscount.Text + "', money = N'" + txtmoney.Text + "'";
                sSql = sSql + "where tblOrders.OrderID = N'" + OrderID + "'";
                dsCustomer.ExecuteNonQuery(sSql);
            }
            
            Display();
            setEnable(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // thông báo
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            // lấy dòng hiện thời cần xóa
            int r = dgvOrders.CurrentRow.Index;

            // thực hiện lệnh xóa
            dtOrder.Rows[r].Delete();

            // cập nhật lại dữ liệu
            dsOrder.Update(dtOrder);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvOrders.CurrentRow != null)
            {
                int OrderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());

                cboFullname.SelectedValue = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDate.Text = dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboGoodfullname.SelectedValue = dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtmoney.Text = dgvOrders.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDescription.Text = dgvOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
                // lưu lại biến phone
                _phone = txtPhone.Text;
                // hiên thị tên khách hàng địa chỉ điện thoại
                string sSql = "SELECT tblCustomers.FullName, tblCustomers.Address, tblCustomers.Phone FROM tblCustomers INNER JOIN ";
                sSql = sSql + "tblOrdersDetails ON tblCustomers.CustomerID = tblOrdersDetails.customerID INNER JOIN ";
                sSql = sSql + "tblOrders ON tblOrdersDetails.OrderID = tblOrders.OrderID  where tblOrders.OrderID = N'" + OrderID + "'";

                Dataservices dsCustomer = new Dataservices();
                DataTable dtcustomer = dsCustomer.RunQuery(sSql);
                txtcustomerFullname.Clear();
                txtAdress.Clear();
                txtPhone.Clear();
                if (dtcustomer.Rows.Count > 0)
                {
                    //Hiển thih lên txtAuthor
                    txtcustomerFullname.Text = txtcustomerFullname.Text + dtcustomer.Rows[0]["FullName"].ToString();
                    txtAdress.Text = txtAdress.Text + dtcustomer.Rows[0]["Address"].ToString();
                    txtPhone.Text = txtPhone.Text + dtcustomer.Rows[0]["Phone"].ToString();
                }


                // hiển thị các trường của tblorderdetail
                sSql = "select tblOrdersDetails.Amount, tblOrdersDetails.Price, tblOrdersDetails.Discount, tblOrdersDetails.money  FROM tblOrdersDetails INNER JOIN ";
                sSql = sSql + "tblCustomers ON tblCustomers.CustomerID = tblOrdersDetails.customerID INNER JOIN ";
                sSql = sSql + "tblOrders ON tblOrdersDetails.OrderID = tblOrders.OrderID where tblOrders.OrderID = N'" + OrderID + "'";
                Dataservices dsOrderdetail = new Dataservices();
                DataTable dtOrder = dsOrderdetail.RunQuery(sSql);
                // hiển thị lên các text box
                txtAcount.Clear();
                txtdiscount.Clear();
                txtprice.Clear();
                txtmoney.Clear();
                if (dtOrder.Rows.Count > 0)
                {
                    txtAcount.Text = txtAcount.Text + dtOrder.Rows[0]["Amount"].ToString();
                    txtdiscount.Text = txtdiscount.Text + dtOrder.Rows[0]["Discount"].ToString();
                    txtprice.Text = txtprice.Text + dtOrder.Rows[0]["Price"].ToString();
                    txtmoney.Text = txtmoney.Text + dtOrder.Rows[0]["Money"].ToString();
                }
            }

        }

        private void txtcustomerFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtAdress.Focus();
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtDate.Focus();
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                cboFullname.Focus();
            }
        }

        private void cboFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                cboGoodfullname.Focus();
            }
        }

        private void cboGoodfullname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtAcount.Focus();
            }
        }

        private void txtAcount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtdiscount.Focus();
            }
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtprice.Focus();
            }
        }

        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
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
