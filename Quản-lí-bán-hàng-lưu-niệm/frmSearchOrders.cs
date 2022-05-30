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
    public partial class frmSearchOrders : Form
    {
        bool modeNew;
        private Dataservices dsOrder;
        private DataTable dtOrder;
        public frmSearchOrders()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
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
        private void frmSearchOrders_Load(object sender, EventArgs e)
        {
            // truy vấn dũ liệu
            string sSql = "Select * from tblUsers order by FullName";
            Dataservices dsuser = new Dataservices();
            DataTable dtuser = dsuser.RunQuery(sSql);
            // chuyển dữ liệu vào
            cboFullNameUser.DataSource = dtuser;
            cboFullNameUser.DisplayMember = "FullName";
            cboFullNameUser.ValueMember = "UserID";

            // truy vấn dữ liệu
            sSql = "select * from tblGoods order by GoodName";
            Dataservices dsGood = new Dataservices();
            DataTable dtGood = dsGood.RunQuery(sSql);
            // chuyển dũ liệu vào
            cboFullNamegood.DataSource = dtGood;
            cboFullNamegood.DisplayMember = "GoodName";
            cboFullNamegood.ValueMember = "GoodID";


            Display();
        }

        private void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            //int r = dgvOrders.CurrentRow.Index;
            int OrderID = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());

            cboFullNameUser.SelectedValue = dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdate.Text = dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString();
            cboFullNamegood.SelectedValue = dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMoney.Text = dgvOrders.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdescription.Text = dgvOrders.Rows[e.RowIndex].Cells[5].Value.ToString();
            
            // hiên thị tên khách hàng địa chỉ điện thoại
            string sSql = "SELECT tblCustomers.FullName, tblCustomers.Address, tblCustomers.Phone FROM tblCustomers INNER JOIN ";
            sSql = sSql + "tblOrdersDetails ON tblCustomers.CustomerID = tblOrdersDetails.customerID INNER JOIN ";
            sSql = sSql + "tblOrders ON tblOrdersDetails.OrderID = tblOrders.OrderID  where tblOrders.OrderID = N'" + OrderID + "'";

            Dataservices dsCustomer = new Dataservices();
            DataTable dtcustomer = dsCustomer.RunQuery(sSql);
            txtCustomerFullname.Clear();
            txtAdress.Clear();
            txtphone.Clear();
            if (dtcustomer.Rows.Count > 0)
            {
                //Hiển thih lên txtAuthor
                txtCustomerFullname.Text = txtCustomerFullname.Text + dtcustomer.Rows[0]["FullName"].ToString();
                txtAdress.Text = txtAdress.Text + dtcustomer.Rows[0]["Address"].ToString();
                txtphone.Text = txtphone.Text + dtcustomer.Rows[0]["Phone"].ToString();
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
            txtMoney.Clear();
            if (dtOrder.Rows.Count > 0)
            {
                txtAcount.Text = txtAcount.Text + dtOrder.Rows[0]["Amount"].ToString();
                txtdiscount.Text = txtdiscount.Text + dtOrder.Rows[0]["Discount"].ToString();
                txtprice.Text = txtprice.Text + dtOrder.Rows[0]["Price"].ToString();
                
               txtMoney.Text = txtMoney.Text + dtOrder.Rows[0]["Money"].ToString();
            }

         }
        private void Search(string sSql)
        {
            
             dsOrder = new Dataservices();
            dtOrder = dsOrder.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvOrders.DataSource = dtOrder;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql;
            if (rbcustomerName.Checked == true)
            {
                sSql = "SELECT tblOrders.OrderID, tblOrders.UserID, tblOrders.date, tblOrders.GoodID, tblOrders.money, tblOrders.Description ";
                sSql = sSql + "FROM tblCustomers INNER JOIN tblOrdersDetails ON tblCustomers.CustomerID = tblOrdersDetails.customerID INNER JOIN ";
                sSql = sSql + "tblOrders ON tblOrdersDetails.OrderID = tblOrders.OrderID where FullName LIKE N'%" + txtSearch.Text + "%' order by OrderID";

            }
            else
            {
                sSql = "SELECT tblOrders.OrderID, tblOrders.UserID, tblOrders.date, tblOrders.GoodID, tblOrders.money, tblOrders.Description ";
                sSql = sSql + "FROM tblOrders INNER JOIN tblGoods ON tblGoods.GoodID = tblOrders.GoodID where GoodName LIKE N'%" + txtSearch.Text +"%' order by OrderID";
            }
            Search(sSql);
        }

        private void btnclose_Click(object sender, EventArgs e)
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
