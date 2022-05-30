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
    public partial class frmlogin1 : Form
    {
        public frmlogin1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ////Mở kết nối tới CSDL
            Dataservices myDBservices = new Dataservices();
           if (myDBservices.OpenDB(@"Data Source=DESKTOP-3A6Q730\SQLEXPRESS;Initial Catalog=DAQLBH;Integrated Security=True") == false) return;
            //Kiểm tra username và password trong  bảng User

            string sSql = "Select * From tblUsers Where (UserName = N'" + txtusername.Text + "')AND (Password = N'" + txtPassword.Text + "')";

            //Truy vấn dữ liệu
            DataTable dtUser = myDBservices.RunQuery(sSql);
            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("Không đúng tên hoặc mật khẩu truy nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Focus();
                return;
            }
            //Nếu đúng thì gọi hàm main

            frmmain1 frmmain = new frmmain1();
            frmmain.ShowDialog();
            this.Close();
        }
        
        private void btnsignin_Click(object sender, EventArgs e)
        {
            frmsignin frmsignin = new frmsignin();
            frmsignin.ShowDialog();
            this.Close();
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
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
                btnlogin.Focus();
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
