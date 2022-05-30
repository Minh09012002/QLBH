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
    public partial class frmmain1 : Form
    {
        bool Mide;
        bool Mide1;
        public frmmain1()
        {
            InitializeComponent();
            Mide = false;
            Mide1 = false;
            this.Opacity = 0;
            timer3.Start();
        }
        private Form currentFormChild;
        private void OpenchillForm(Form childform)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childform);
            pnBody.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        // check trạng thái

        public delegate void SendMessage(string Message);
        public SendMessage Sender;
       
        private void setEnable(bool edit)
        {
            btnusers.Enabled = edit;
            btnCustomers.Enabled = edit;
            btnGoods.Enabled = edit;
            btnSearchCustomer.Enabled = edit;
            btnSearchGood.Enabled = edit;
            btnSearchOrder.Enabled = edit;
            btnCodema.Enabled = edit;
            btnorders.Enabled = edit;
        }
        
        private void frmmain1_Load(object sender, EventArgs e)
        {
            
        }


       

     
       
     

      

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmUsers());
            title.Text = btnusers.Text;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmCustomers());
            title.Text = btnCustomers.Text;
        }
        private void btnCodema_Click(object sender, EventArgs e)
        {
            OpenchillForm(new FrmCodeMaterial());
            title.Text = btnCodema.Text;

        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmGoods());
            title.Text = btnGoods.Text;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmSearchOrders());
            title.Text = btnSearchOrder.Text;
        }

        private void btnSearchGood_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmSearchGoods());
            title.Text = btnSearchGood.Text;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmSearchCustomers());
            title.Text = btnSearchCustomer.Text;
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            OpenchillForm(new frmOrders());
            title.Text = btnorders.Text;
        }

        private void btnzoomout_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnenlarge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Mide)
            {
                pnMenuCategory.Height = pnMenuCategory.Height + 20;
                if(pnMenuCategory.Height == 160)
                {
                    timer1.Stop();
                    Mide = false;
                    this.Refresh();
                }
            }
            else
            {
                pnMenuCategory.Height = pnMenuCategory.Height - 20;
                if (pnMenuCategory.Height == 0)
                {
                    timer1.Stop();
                    Mide = true;
                    this.Refresh();
                }
            }
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (Mide1)
            {
                pnsearch.Height = pnsearch.Height + 10;
                if (pnsearch.Height == 140)
                {
                    timer2.Stop();
                    Mide1 = false;
                    this.Refresh();
                }
            }
            else
            {
                pnsearch.Height = pnsearch.Height - 10;
                if (pnsearch.Height == 0)
                {
                    timer2.Stop();
                    Mide1 = true;
                    this.Refresh();
                }
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            title.Text = "Phần mềm quản lí bán hàng lưu niệm ";
         
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.1;
            if(this.Opacity == 1)
            {
                timer3.Stop();
            }
        }

        private void btnthu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
