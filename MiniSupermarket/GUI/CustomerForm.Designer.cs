namespace MiniSupermarket.GUI
{
    partial class CustomerForm
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
            components = new System.ComponentModel.Container();
            pnlInformation = new Panel();
            rdoNu = new RadioButton();
            btnUpdate = new Button();
            rdoNam = new RadioButton();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            lblCustomerID = new Label();
            txtCustomerID = new TextBox();
            lblPoint = new Label();
            txtPoint = new TextBox();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            grb_rdoNu = new RadioButton();
            grb_rdoNam = new RadioButton();
            groupBox1 = new GroupBox();
            txtFind = new TextBox();
            cboFind = new ComboBox();
            lblTitleProduct = new Label();
            panel3 = new Panel();
            dgvCustomer = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            pnlInformation.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(rdoNu);
            pnlInformation.Controls.Add(btnUpdate);
            pnlInformation.Controls.Add(rdoNam);
            pnlInformation.Controls.Add(btnDelete);
            pnlInformation.Controls.Add(btnRefresh);
            pnlInformation.Controls.Add(btnAdd);
            pnlInformation.Controls.Add(lblCustomerID);
            pnlInformation.Controls.Add(txtCustomerID);
            pnlInformation.Controls.Add(lblPoint);
            pnlInformation.Controls.Add(txtPoint);
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(txtPhoneNumber);
            pnlInformation.Controls.Add(lblPhoneNumber);
            pnlInformation.Controls.Add(lblCustomerName);
            pnlInformation.Controls.Add(txtCustomerName);
            pnlInformation.Controls.Add(lblTitle);
            pnlInformation.Dock = DockStyle.Top;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(4, 3, 4, 3);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(1924, 422);
            pnlInformation.TabIndex = 0;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(1449, 170);
            rdoNu.Margin = new Padding(4, 5, 4, 5);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 0;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(1153, 340);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(174, 38);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(1319, 170);
            rdoNam.Margin = new Padding(4, 5, 4, 5);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1394, 340);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 38);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(1579, 340);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 38);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Làm Mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(969, 340);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 38);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(206, 168);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(137, 25);
            lblCustomerID.TabIndex = 12;
            lblCustomerID.Text = "Mã Khách Hàng";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(444, 165);
            txtCustomerID.Margin = new Padding(4, 3, 4, 3);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(267, 31);
            txtCustomerID.TabIndex = 11;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new Point(1161, 245);
            lblPoint.Margin = new Padding(4, 0, 4, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(54, 25);
            lblPoint.TabIndex = 4;
            lblPoint.Text = "Điểm";
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(1319, 235);
            txtPoint.Margin = new Padding(4, 3, 4, 3);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(187, 31);
            txtPoint.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 312);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 4;
            label1.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(444, 305);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(267, 31);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(1134, 170);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(81, 25);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Giới Tính";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(204, 240);
            lblCustomerName.Margin = new Padding(4, 0, 4, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(138, 25);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên Khách Hàng";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(444, 235);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(267, 31);
            txtCustomerName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(856, 40);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 422);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 157);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grb_rdoNu);
            groupBox2.Controls.Add(grb_rdoNam);
            groupBox2.Location = new Point(1269, 68);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(250, 75);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giới tính";
            // 
            // grb_rdoNu
            // 
            grb_rdoNu.AutoSize = true;
            grb_rdoNu.Location = new Point(139, 27);
            grb_rdoNu.Margin = new Padding(4, 5, 4, 5);
            grb_rdoNu.Name = "grb_rdoNu";
            grb_rdoNu.Size = new Size(61, 29);
            grb_rdoNu.TabIndex = 0;
            grb_rdoNu.TabStop = true;
            grb_rdoNu.Text = "Nữ";
            grb_rdoNu.UseVisualStyleBackColor = true;
            grb_rdoNu.CheckedChanged += Find_Changed;
            // 
            // grb_rdoNam
            // 
            grb_rdoNam.AutoSize = true;
            grb_rdoNam.Location = new Point(29, 27);
            grb_rdoNam.Margin = new Padding(4, 5, 4, 5);
            grb_rdoNam.Name = "grb_rdoNam";
            grb_rdoNam.Size = new Size(75, 29);
            grb_rdoNam.TabIndex = 0;
            grb_rdoNam.TabStop = true;
            grb_rdoNam.Text = "Nam";
            grb_rdoNam.UseVisualStyleBackColor = true;
            grb_rdoNam.CheckedChanged += Find_Changed;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFind);
            groupBox1.Controls.Add(cboFind);
            groupBox1.Location = new Point(463, 53);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(756, 83);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(381, 33);
            txtFind.Margin = new Padding(4, 3, 4, 3);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(355, 31);
            txtFind.TabIndex = 1;
            txtFind.TextChanged += Find_Changed;
            // 
            // cboFind
            // 
            cboFind.FormattingEnabled = true;
            cboFind.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số điện thoại", "" });
            cboFind.Location = new Point(27, 33);
            cboFind.Margin = new Padding(4, 3, 4, 3);
            cboFind.Name = "cboFind";
            cboFind.Size = new Size(303, 33);
            cboFind.TabIndex = 0;
            cboFind.SelectedIndexChanged += Find_Changed;
            // 
            // lblTitleProduct
            // 
            lblTitleProduct.AutoSize = true;
            lblTitleProduct.Location = new Point(869, 18);
            lblTitleProduct.Margin = new Padding(4, 0, 4, 0);
            lblTitleProduct.Name = "lblTitleProduct";
            lblTitleProduct.Size = new Size(196, 25);
            lblTitleProduct.TabIndex = 3;
            lblTitleProduct.Text = "Danh Sách Khách Hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvCustomer);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 579);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 279);
            panel3.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(0, 0);
            dgvCustomer.Margin = new Padding(4, 3, 4, 3);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(1924, 279);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 858);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlInformation);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerForm";
            Text = "PromotionForm";
            Load += CustomerForm_Load;
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInformation;
        private Panel panel2;
        private Panel panel3;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblPhoneNumber;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblTitle;

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnAdd;
        private DataGridView dgvCustomer;
        private Label lblPoint;
        private TextBox txtPoint;
        private GroupBox groupBox1;
        private TextBox txtFind;
        private ComboBox cboFind;
        private Label lblTitleProduct;
        private Label label1;
        private TextBox txtPhoneNumber;
        private GroupBox groupBox2;
        private RadioButton grb_rdoNu;
        private RadioButton grb_rdoNam;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private ErrorProvider errorProvider1;
    }
}