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
    public partial class frmSearchCustomers : Form
    {
        private Dataservices dsCustomer;
        private DataTable dtCustomer;
        // tạo đối tượng với mô hình thực thế
        private DAQLBHEntities3 myDAQLBHEntities;
        public frmSearchCustomers()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }

        private void frmSearchCustomers_Load(object sender, EventArgs e)
        {
            myDAQLBHEntities = new DAQLBHEntities3();

            // gọi hàm display
            Display();
        }
        private void Display()
        {
            //Truy vấn dữ liệu
            string sSql = "Select * From tblCustomers Order By FullName";

            dsCustomer = new Dataservices();
            dtCustomer = dsCustomer.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvCustomers.DataSource = dtCustomer;
        }

        private void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            
            txtFullName.Text = dgvCustomers.Rows[i].Cells[1].Value.ToString();
            txtadress.Text = dgvCustomers.Rows[i].Cells[2].Value.ToString();
            txtPhone.Text = dgvCustomers.Rows[i].Cells[3].Value.ToString();
            txtDescription.Text = dgvCustomers.Rows[i].Cells[4].Value.ToString();
        }
        private void Search(string sSql)
        {

            dsCustomer = new Dataservices();
            dtCustomer = dsCustomer.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvCustomers.DataSource = dtCustomer;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSql;
            if (rbnameCustomer.Checked == true)
            {
                sSql = "select * from tblCustomers where FullName LIKE N'%" + txtSearch.Text + "%' Order by CustomerID";

            }
            else
            {
                sSql = "select * from tblCustomers where Phone LIKE N'%" + txtSearch.Text + "%' Order by CustomerID";
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
