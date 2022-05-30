namespace Quản_lí_bán_hàng_lưu_niệm
{
    partial class frmSearchGoods
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobCodeMaterialID = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtpriceSell = new System.Windows.Forms.TextBox();
            this.txtpriceImport = new System.Windows.Forms.TextBox();
            this.txtAcount = new System.Windows.Forms.TextBox();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.txtGoodID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbnamegood = new System.Windows.Forms.RadioButton();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureboxphoto = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1179, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 46);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "&Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Location = new System.Drawing.Point(8, 28);
            this.dgvGoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.Size = new System.Drawing.Size(793, 222);
            this.dgvGoods.TabIndex = 0;
            this.dgvGoods.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGoods);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(52, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(810, 263);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // cobCodeMaterialID
            // 
            this.cobCodeMaterialID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cobCodeMaterialID.ForeColor = System.Drawing.Color.White;
            this.cobCodeMaterialID.FormattingEnabled = true;
            this.cobCodeMaterialID.Location = new System.Drawing.Point(177, 141);
            this.cobCodeMaterialID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobCodeMaterialID.Name = "cobCodeMaterialID";
            this.cobCodeMaterialID.Size = new System.Drawing.Size(235, 21);
            this.cobCodeMaterialID.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(540, 77);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 35);
            this.txtDescription.TabIndex = 28;
            // 
            // txtpriceSell
            // 
            this.txtpriceSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtpriceSell.ForeColor = System.Drawing.Color.White;
            this.txtpriceSell.Location = new System.Drawing.Point(177, 232);
            this.txtpriceSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpriceSell.Name = "txtpriceSell";
            this.txtpriceSell.Size = new System.Drawing.Size(235, 20);
            this.txtpriceSell.TabIndex = 26;
            // 
            // txtpriceImport
            // 
            this.txtpriceImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtpriceImport.ForeColor = System.Drawing.Color.White;
            this.txtpriceImport.Location = new System.Drawing.Point(177, 202);
            this.txtpriceImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpriceImport.Name = "txtpriceImport";
            this.txtpriceImport.Size = new System.Drawing.Size(235, 20);
            this.txtpriceImport.TabIndex = 25;
            // 
            // txtAcount
            // 
            this.txtAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtAcount.ForeColor = System.Drawing.Color.White;
            this.txtAcount.Location = new System.Drawing.Point(177, 172);
            this.txtAcount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcount.Name = "txtAcount";
            this.txtAcount.Size = new System.Drawing.Size(235, 20);
            this.txtAcount.TabIndex = 24;
            // 
            // txtGoodName
            // 
            this.txtGoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtGoodName.ForeColor = System.Drawing.Color.White;
            this.txtGoodName.Location = new System.Drawing.Point(177, 107);
            this.txtGoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(235, 20);
            this.txtGoodName.TabIndex = 23;
            // 
            // txtGoodID
            // 
            this.txtGoodID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtGoodID.ForeColor = System.Drawing.Color.White;
            this.txtGoodID.Location = new System.Drawing.Point(177, 77);
            this.txtGoodID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGoodID.Name = "txtGoodID";
            this.txtGoodID.Size = new System.Drawing.Size(235, 20);
            this.txtGoodID.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mô tả thêm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đơn giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đơn giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã chất liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã hàng";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(228, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(338, 20);
            this.txtSearch.TabIndex = 43;
            // 
            // rbnamegood
            // 
            this.rbnamegood.AutoSize = true;
            this.rbnamegood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnamegood.Location = new System.Drawing.Point(51, 26);
            this.rbnamegood.Name = "rbnamegood";
            this.rbnamegood.Size = new System.Drawing.Size(171, 20);
            this.rbnamegood.TabIndex = 42;
            this.rbnamegood.TabStop = true;
            this.rbnamegood.Text = "Tìm kiếm theo sản phẩm";
            this.rbnamegood.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(590, 17);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(101, 35);
            this.btnsearch.TabIndex = 40;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureboxphoto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(543, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 162);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh sản phẩm";
            // 
            // pictureboxphoto
            // 
            this.pictureboxphoto.Location = new System.Drawing.Point(9, 31);
            this.pictureboxphoto.Name = "pictureboxphoto";
            this.pictureboxphoto.Size = new System.Drawing.Size(286, 125);
            this.pictureboxphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxphoto.TabIndex = 0;
            this.pictureboxphoto.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(752, 17);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 35);
            this.btndelete.TabIndex = 45;
            this.btndelete.Text = "Kết thúc";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSearchGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(913, 549);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbnamegood);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cobCodeMaterialID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtpriceSell);
            this.Controls.Add(this.txtpriceImport);
            this.Controls.Add(this.txtAcount);
            this.Controls.Add(this.txtGoodName);
            this.Controls.Add(this.txtGoodID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSearchGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchGoods";
            this.Load += new System.EventHandler(this.frmSearchGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cobCodeMaterialID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtpriceSell;
        private System.Windows.Forms.TextBox txtpriceImport;
        private System.Windows.Forms.TextBox txtAcount;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.TextBox txtGoodID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbnamegood;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureboxphoto;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Timer timer1;
    }
}