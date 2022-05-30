namespace Quản_lí_bán_hàng_lưu_niệm
{
    partial class frmSearchOrders
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
            this.rbcustomerName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboFullNamegood = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCustomerFullname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbgoodname = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboFullNameUser = new System.Windows.Forms.ComboBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbcustomerName
            // 
            this.rbcustomerName.AutoSize = true;
            this.rbcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcustomerName.Location = new System.Drawing.Point(282, 16);
            this.rbcustomerName.Name = "rbcustomerName";
            this.rbcustomerName.Size = new System.Drawing.Size(202, 20);
            this.rbcustomerName.TabIndex = 1;
            this.rbcustomerName.TabStop = true;
            this.rbcustomerName.Text = "Tìm kiếm theo tên khách hàng";
            this.rbcustomerName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(524, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(60, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 228);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách hóa đơn";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(39, 25);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(613, 197);
            this.dgvOrders.TabIndex = 4;
            this.dgvOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_RowEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giảm giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Đơn giá";
            // 
            // txtAcount
            // 
            this.txtAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtAcount.ForeColor = System.Drawing.Color.White;
            this.txtAcount.Location = new System.Drawing.Point(106, 57);
            this.txtAcount.Name = "txtAcount";
            this.txtAcount.Size = new System.Drawing.Size(188, 22);
            this.txtAcount.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtprice.ForeColor = System.Drawing.Color.White;
            this.txtprice.Location = new System.Drawing.Point(106, 127);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(188, 22);
            this.txtprice.TabIndex = 1;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtMoney.ForeColor = System.Drawing.Color.White;
            this.txtMoney.Location = new System.Drawing.Point(106, 168);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(188, 22);
            this.txtMoney.TabIndex = 1;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtdiscount.ForeColor = System.Drawing.Color.White;
            this.txtdiscount.Location = new System.Drawing.Point(106, 92);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(188, 22);
            this.txtdiscount.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Thành tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboFullNamegood);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAcount);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(418, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 203);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // cboFullNamegood
            // 
            this.cboFullNamegood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cboFullNamegood.ForeColor = System.Drawing.Color.White;
            this.cboFullNamegood.FormattingEnabled = true;
            this.cboFullNamegood.Location = new System.Drawing.Point(106, 21);
            this.cboFullNamegood.Name = "cboFullNamegood";
            this.cboFullNamegood.Size = new System.Drawing.Size(188, 24);
            this.cboFullNamegood.TabIndex = 26;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtphone.ForeColor = System.Drawing.Color.White;
            this.txtphone.Location = new System.Drawing.Point(206, 139);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(188, 20);
            this.txtphone.TabIndex = 15;
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtAdress.ForeColor = System.Drawing.Color.White;
            this.txtAdress.Location = new System.Drawing.Point(206, 103);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(188, 20);
            this.txtAdress.TabIndex = 14;
            // 
            // txtCustomerFullname
            // 
            this.txtCustomerFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtCustomerFullname.ForeColor = System.Drawing.Color.White;
            this.txtCustomerFullname.Location = new System.Drawing.Point(206, 68);
            this.txtCustomerFullname.Name = "txtCustomerFullname";
            this.txtCustomerFullname.Size = new System.Drawing.Size(188, 20);
            this.txtCustomerFullname.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên khách hàng";
            // 
            // rbgoodname
            // 
            this.rbgoodname.AutoSize = true;
            this.rbgoodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbgoodname.Location = new System.Drawing.Point(72, 16);
            this.rbgoodname.Name = "rbgoodname";
            this.rbgoodname.Size = new System.Drawing.Size(192, 20);
            this.rbgoodname.TabIndex = 1;
            this.rbgoodname.TabStop = true;
            this.rbgoodname.Text = "Tìm kiếm theo tên sản phẩm";
            this.rbgoodname.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(72, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(406, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // cboFullNameUser
            // 
            this.cboFullNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.cboFullNameUser.ForeColor = System.Drawing.Color.White;
            this.cboFullNameUser.FormattingEnabled = true;
            this.cboFullNameUser.Location = new System.Drawing.Point(206, 174);
            this.cboFullNameUser.Name = "cboFullNameUser";
            this.cboFullNameUser.Size = new System.Drawing.Size(188, 21);
            this.cboFullNameUser.TabIndex = 26;
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtdescription.ForeColor = System.Drawing.Color.White;
            this.txtdescription.Location = new System.Drawing.Point(206, 251);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(188, 20);
            this.txtdescription.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô tả thêm";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.txtdate.ForeColor = System.Drawing.Color.White;
            this.txtdate.Location = new System.Drawing.Point(206, 211);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(188, 20);
            this.txtdate.TabIndex = 17;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(662, 26);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(92, 36);
            this.btnclose.TabIndex = 27;
            this.btnclose.Text = "Đóng";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSearchOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.cboFullNameUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCustomerFullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbgoodname);
            this.Controls.Add(this.rbcustomerName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmSearchOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchOrders";
            this.Load += new System.EventHandler(this.frmSearchOrders_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbcustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCustomerFullname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbgoodname;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFullNamegood;
        private System.Windows.Forms.ComboBox cboFullNameUser;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timer1;
    }
}