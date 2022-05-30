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
using System.IO;

namespace Quản_lí_bán_hàng_lưu_niệm
{
    public partial class frmGoods : Form
    {
        bool modeNew;
        private string _GoodName;
        private Dataservices dsGood;
        private DataTable dtGood;
        
        public frmGoods()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        // hàm check trạng thái
        private void setEnable(bool edit)
        {
            txtGoodName.Enabled = edit;
            cobCodeMaterialName.Enabled = edit;
            txtAmount.Enabled = edit;
            txtam.Enabled = edit;
            txtpriceImport.Enabled = edit;
            txtpriceSell.Enabled = edit;
            txtDescription.Enabled = edit;
            pictureboxphoto.Enabled = edit;
            btnCancel.Enabled = edit;
            btnSave.Enabled = edit;
            btnDelete.Enabled = !edit;
            btnclose.Enabled = !edit;
            btnEdit.Enabled = !edit;
            btnNew.Enabled = !edit;
            btnselectimage.Enabled = edit;
        }

        // hàm display 
        private void Display()
        {
            //Truy vấn dữ liệu
            string sSql = "Select * From tblGoods Order By GoodName";
          
            dsGood = new Dataservices();
            dtGood = dsGood.RunQuery(sSql);
            //hiển thị dữ liệu lên lưới
            dgvGood.DataSource = dtGood;
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            // chuyển dữ liệu vào cobcodematerial
            // 1.1. truy vấn dữ liệu
            string sSql = "select * from tblCodeMaterials Order by CodeMaterialName";
           Dataservices dsCodeMaterial = new Dataservices();
            DataTable dtCodeMaterial = dsCodeMaterial.RunQuery(sSql);
            // 1.2 chuyển dữ liệu vào cbocateogry
            cobCodeMaterialName.DataSource = dtCodeMaterial;
            cobCodeMaterialName.DisplayMember = "CodeMaterialName";
            cobCodeMaterialName.ValueMember = "CodeMaterialID";

            Display();
            setEnable(false);
           
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            // thông báo
            DialogResult dr;
            dr = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            // lấy dòng hiện thời cần xóa
            int r = dgvGood.CurrentRow.Index;

            // thực hiện lệnh xóa
            dtGood.Rows[r].Delete();

            // cập nhật lại dữ liệu
            dsGood.Update(dtGood);
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            modeNew = true;
            setEnable(true);
            txtDescription.Clear();
            txtGoodName.Clear();
            txtam.Clear();
            txtpriceImport.Clear();
            txtpriceSell.Clear();
            pictureboxphoto.Image = null;
            txtGoodName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeNew = false;
            setEnable(true);
            txtGoodName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check các trường cần nhập
            if(txtGoodName.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập tên sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGoodName.Focus();
                return;
            }
            if(txtAmount.Text.Trim() == " ")
            {
                MessageBox.Show("Đề nghị nhập số lượng sản phẩm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                return;
            }
            if(txtpriceImport.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập giá nhập vào của sản phẩm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpriceImport.Focus();
                return;
            }
            if(txtpriceSell.Text.Trim() == "")
            {
                MessageBox.Show("Đề nghị nhập giá bán sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpriceSell.Focus();
                return;
            }
            // kiểm tra trùng tên sản phẩm
            if (txtGoodName.Text.Trim() != _GoodName)
            {
                string sSql = "Select GoodName from tblGoods Where GoodName= N'" + txtGoodName.Text + "'";
                Dataservices dsSearch = new Dataservices();
                DataTable dtSearch = dsSearch.RunQuery(sSql);
                if (dtSearch.Rows.Count > 0)
                {
                    MessageBox.Show("Tên sản phẩm đã có/đã nhập trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGoodName.Focus();
                    return;
                }
            }
            if(modeNew == true)
            {
                DataRow myDatarow = dtGood.NewRow();
                myDatarow["GoodName"] = txtGoodName.Text;
                myDatarow["CodeMaterialID"] = cobCodeMaterialName.SelectedValue;
                myDatarow["Amount"] = txtam.Text;
                myDatarow["priceImport"] = txtpriceImport.Text;
                myDatarow["priceSell"] = txtpriceSell.Text;
                myDatarow["Description"] = txtDescription.Text;
                // lưu ảnh
                var img = new ImageConverter().ConvertTo(pictureboxphoto.Image, typeof(Byte[]));
                myDatarow["Photos"] = (byte[])img;// ép kiểu
                dtGood.Rows.Add(myDatarow);
                dsGood.Update(dtGood);

            }
            else
            {
                
                // lấy dòng hiện thời
                int r = dgvGood.CurrentRow.Index;

                // tạo một dòng dữ liệu
                DataRow myDatarow = dtGood.Rows[r];
                // gán dữ liệu
                myDatarow["GoodName"] = txtGoodName.Text;
                myDatarow["CodeMaterialID"] = cobCodeMaterialName.SelectedValue;
                myDatarow["Amount"] = txtam.Text;
                myDatarow["priceImport"] = txtpriceImport.Text;
                myDatarow["priceSell"] = txtpriceSell.Text;
                myDatarow["Description"] = txtDescription.Text;
                // sửa ảnh
                var img = new ImageConverter().ConvertTo(pictureboxphoto.Image, typeof(Byte[]));
                myDatarow["Photos"] = (byte[])img;// ép kiểu
                dsGood.Update(dtGood);
            }
            Display();
            setEnable(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnable(false);
        }

        private void btnclo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvGood_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGoodName.Text = dgvGood.Rows[e.RowIndex].Cells[1].Value.ToString();
            cobCodeMaterialName.SelectedValue = dgvGood.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtam.Text = dgvGood.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtpriceImport.Text = dgvGood.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpriceSell.Text = dgvGood.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDescription.Text = dgvGood.Rows[e.RowIndex].Cells[7].Value.ToString();
            // hiển thị dữ liệu ảnh
            if (dgvGood.Rows[e.RowIndex].Cells[6].Value.ToString() != "")
            {
                Byte[] i = (byte[])dgvGood.Rows[e.RowIndex].Cells[6].Value;
                MemoryStream stmBLOBData = new MemoryStream(i);
                pictureboxphoto.Image = Image.FromStream(stmBLOBData);
              
            }
            _GoodName = txtGoodName.Text;
        }

        // chọn ảnh
        private void btnselectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg; *.jpeg; *.png";
            if(OD.ShowDialog() == DialogResult.OK)
            {
                pictureboxphoto.Load(OD.FileName);
            }
        }

        private void txtGoodName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                cobCodeMaterialName.Focus();
            }
        }

        private void cobCodeMaterialName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtam.Focus();
            }
        }

        private void txtam_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtpriceImport.Focus();
            }
        }

        private void txtpriceImport_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
            {
                txtpriceSell.Focus();
            }
        }

        private void txtpriceSell_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 || e.KeyValue == 80)
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
