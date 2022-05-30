namespace Quản_lí_bán_hàng_lưu_niệm
{
    partial class frmGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.txtam = new System.Windows.Forms.TextBox();
            this.txtpriceImport = new System.Windows.Forms.TextBox();
            this.txtpriceSell = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cobCodeMaterialName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGood = new System.Windows.Forms.DataGridView();
            this.btnselectimage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureboxphoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên chất liệu";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(16, 103);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(72, 20);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mô tả thêm";
            // 
            // txtGoodName
            // 
            this.txtGoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtGoodName.ForeColor = System.Drawing.Color.White;
            this.txtGoodName.Location = new System.Drawing.Point(141, 29);
            this.txtGoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(235, 26);
            this.txtGoodName.TabIndex = 1;
            this.txtGoodName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodName_KeyDown);
            // 
            // txtam
            // 
            this.txtam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtam.ForeColor = System.Drawing.Color.White;
            this.txtam.Location = new System.Drawing.Point(141, 103);
            this.txtam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(235, 26);
            this.txtam.TabIndex = 1;
            this.txtam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtam_KeyDown);
            // 
            // txtpriceImport
            // 
            this.txtpriceImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtpriceImport.ForeColor = System.Drawing.Color.White;
            this.txtpriceImport.Location = new System.Drawing.Point(141, 141);
            this.txtpriceImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpriceImport.Name = "txtpriceImport";
            this.txtpriceImport.Size = new System.Drawing.Size(235, 26);
            this.txtpriceImport.TabIndex = 1;
            this.txtpriceImport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpriceImport_KeyDown);
            // 
            // txtpriceSell
            // 
            this.txtpriceSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtpriceSell.ForeColor = System.Drawing.Color.White;
            this.txtpriceSell.Location = new System.Drawing.Point(141, 177);
            this.txtpriceSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpriceSell.Name = "txtpriceSell";
            this.txtpriceSell.Size = new System.Drawing.Size(235, 26);
            this.txtpriceSell.TabIndex = 1;
            this.txtpriceSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpriceSell_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(141, 215);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // cobCodeMaterialName
            // 
            this.cobCodeMaterialName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cobCodeMaterialName.ForeColor = System.Drawing.Color.White;
            this.cobCodeMaterialName.FormattingEnabled = true;
            this.cobCodeMaterialName.Location = new System.Drawing.Point(141, 65);
            this.cobCodeMaterialName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobCodeMaterialName.Name = "cobCodeMaterialName";
            this.cobCodeMaterialName.Size = new System.Drawing.Size(235, 28);
            this.cobCodeMaterialName.TabIndex = 2;
            this.cobCodeMaterialName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cobCodeMaterialName_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGood);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(20, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(834, 275);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvGood
            // 
            this.dgvGood.AllowUserToAddRows = false;
            this.dgvGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGood.Location = new System.Drawing.Point(20, 29);
            this.dgvGood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGood.Name = "dgvGood";
            this.dgvGood.Size = new System.Drawing.Size(792, 237);
            this.dgvGood.TabIndex = 0;
            this.dgvGood.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGood_RowEnter);
            // 
            // btnselectimage
            // 
            this.btnselectimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnselectimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectimage.ForeColor = System.Drawing.Color.White;
            this.btnselectimage.Location = new System.Drawing.Point(415, 25);
            this.btnselectimage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnselectimage.Name = "btnselectimage";
            this.btnselectimage.Size = new System.Drawing.Size(96, 30);
            this.btnselectimage.TabIndex = 5;
            this.btnselectimage.Text = "Chọn ảnh";
            this.btnselectimage.UseVisualStyleBackColor = false;
            this.btnselectimage.Click += new System.EventHandler(this.btnselectimage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(559, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(426, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(296, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 42);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sữa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(166, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(20, 264);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 42);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(699, 264);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(124, 42);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Kết thúc";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureboxphoto);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(513, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh sản phẩm";
            // 
            // pictureboxphoto
            // 
            this.pictureboxphoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureboxphoto.ImageLocation = "";
            this.pictureboxphoto.Location = new System.Drawing.Point(6, 34);
            this.pictureboxphoto.Name = "pictureboxphoto";
            this.pictureboxphoto.Size = new System.Drawing.Size(304, 142);
            this.pictureboxphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxphoto.TabIndex = 0;
            this.pictureboxphoto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(889, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnselectimage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cobCodeMaterialName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtpriceSell);
            this.Controls.Add(this.txtpriceImport);
            this.Controls.Add(this.txtam);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGoods";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGood)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.TextBox txtpriceImport;
        private System.Windows.Forms.TextBox txtpriceSell;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cobCodeMaterialName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGood;
        private System.Windows.Forms.Button btnselectimage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureboxphoto;
        private System.Windows.Forms.Timer timer1;
    }
}