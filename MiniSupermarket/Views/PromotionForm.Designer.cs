namespace MiniSupermarket.Views
{
    partial class PromotionForm
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
            pnlInformation = new Panel();
            dtpkEndDate = new DateTimePicker();
            dtpkStartDate = new DateTimePicker();
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            btnExportExcel = new Button();
=======
            btnStartWork = new Button();
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            btnUpdate = new Button();
            btnDelete = new Button();
            btnStopWork = new Button();
            btnRefresh = new Button();
            btnAdd = new Button();
            lblDateStart = new Label();
            lblPromotionID = new Label();
            txtPromotionID = new TextBox();
            lblDateEnd = new Label();
            lblDiscount = new Label();
            txtDiscount = new TextBox();
            lblPromotionName = new Label();
            txtPromotionName = new TextBox();
            lblTitle = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            grbDateFilter = new GroupBox();
            lblDateTo = new Label();
            lblDateFrom = new Label();
            dtpkSearchEndDate = new DateTimePicker();
            dtpkSearchStartDate = new DateTimePicker();
            grbPriceFilter = new GroupBox();
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            txtSearchEndDiscount = new TextBox();
            txtSearchStartDiscount = new TextBox();
=======
            txtEndDiscount = new TextBox();
            txtStartDiscount = new TextBox();
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblPriceTo = new Label();
            lblPriceFrom = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            cbxTypeOfSearch = new ComboBox();
            panel3 = new Panel();
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            dgvPromotion = new DataGridView();
=======
            dgvPromotions = new DataGridView();
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            pnlInformation.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            grbDateFilter.SuspendLayout();
            grbPriceFilter.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).BeginInit();
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(dtpkEndDate);
            pnlInformation.Controls.Add(dtpkStartDate);
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            pnlInformation.Controls.Add(btnExportExcel);
=======
            pnlInformation.Controls.Add(btnStartWork);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            pnlInformation.Controls.Add(btnUpdate);
            pnlInformation.Controls.Add(btnDelete);
            pnlInformation.Controls.Add(btnStopWork);
            pnlInformation.Controls.Add(btnRefresh);
            pnlInformation.Controls.Add(btnAdd);
            pnlInformation.Controls.Add(lblDateStart);
            pnlInformation.Controls.Add(lblPromotionID);
            pnlInformation.Controls.Add(txtPromotionID);
            pnlInformation.Controls.Add(lblDateEnd);
            pnlInformation.Controls.Add(lblDiscount);
            pnlInformation.Controls.Add(txtDiscount);
            pnlInformation.Controls.Add(lblPromotionName);
            pnlInformation.Controls.Add(txtPromotionName);
            pnlInformation.Controls.Add(lblTitle);
            pnlInformation.Dock = DockStyle.Left;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(462, 485);
            pnlInformation.TabIndex = 0;
            // 
            // dtpkEndDate
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            dtpkEndDate.Location = new Point(216, 224);
=======
            dtpkEndDate.Location = new Point(217, 234);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            dtpkEndDate.Name = "dtpkEndDate";
            dtpkEndDate.Size = new Size(214, 27);
            dtpkEndDate.TabIndex = 31;
            // 
            // dtpkStartDate
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            dtpkStartDate.Location = new Point(216, 167);
=======
            dtpkStartDate.Location = new Point(217, 178);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(215, 27);
            dtpkStartDate.TabIndex = 30;
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            // btnExportExcel
            // 
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Location = new Point(28, 409);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(94, 31);
            btnExportExcel.TabIndex = 24;
            btnExportExcel.Text = "Lưu Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
=======
            // btnStartWork
            // 
            btnStartWork.FlatAppearance.BorderSize = 0;
            btnStartWork.FlatStyle = FlatStyle.Flat;
            btnStartWork.Location = new Point(27, 442);
            btnStartWork.Name = "btnStartWork";
            btnStartWork.Size = new Size(94, 31);
            btnStartWork.TabIndex = 24;
            btnStartWork.Text = "Hoạt động";
            btnStartWork.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(168, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 31);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            btnDelete.Location = new Point(309, 336);
=======
            btnDelete.Location = new Point(322, 396);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnStopWork
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            btnImportExcel.FlatAppearance.BorderSize = 0;
            btnImportExcel.FlatStyle = FlatStyle.Flat;
            btnImportExcel.Location = new Point(168, 409);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(94, 31);
            btnImportExcel.TabIndex = 21;
            btnImportExcel.Text = "Tải Excel";
            btnImportExcel.UseVisualStyleBackColor = true;
=======
            btnStopWork.FlatAppearance.BorderSize = 0;
            btnStopWork.FlatStyle = FlatStyle.Flat;
            btnStopWork.Location = new Point(157, 442);
            btnStopWork.Name = "btnStopWork";
            btnStopWork.Size = new Size(140, 31);
            btnStopWork.TabIndex = 21;
            btnStopWork.Text = "Ngưng hoạt động";
            btnStopWork.UseVisualStyleBackColor = true;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            btnRefresh.Location = new Point(309, 409);
=======
            btnRefresh.Location = new Point(322, 442);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 31);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Tải lại";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(28, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 31);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblDateStart.Location = new Point(29, 170);
=======
            lblDateStart.Location = new Point(27, 181);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(102, 20);
            lblDateStart.TabIndex = 16;
            lblDateStart.Text = "Ngày bắt dầu:";
            // 
            // lblPromotionID
            // 
            lblPromotionID.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblPromotionID.Location = new Point(28, 56);
=======
            lblPromotionID.Location = new Point(27, 69);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblPromotionID.Name = "lblPromotionID";
            lblPromotionID.Size = new Size(76, 20);
            lblPromotionID.TabIndex = 12;
            lblPromotionID.Text = "Mã CTKM:";
            // 
            // txtPromotionID
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            txtPromotionID.Location = new Point(216, 53);
            txtPromotionID.Name = "txtPromotionID";
=======
            txtPromotionID.Location = new Point(218, 66);
            txtPromotionID.Name = "txtPromotionID";
            txtPromotionID.ReadOnly = true;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            txtPromotionID.Size = new Size(214, 27);
            txtPromotionID.TabIndex = 11;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblDateEnd.Location = new Point(29, 227);
=======
            lblDateEnd.Location = new Point(27, 237);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(103, 20);
            lblDateEnd.TabIndex = 6;
            lblDateEnd.Text = "Ngày kết thúc:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblDiscount.Location = new Point(29, 284);
=======
            lblDiscount.Location = new Point(27, 293);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(47, 20);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Giảm:";
            // 
            // txtDiscount
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            txtDiscount.Location = new Point(216, 281);
=======
            txtDiscount.Location = new Point(217, 290);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(214, 27);
            txtDiscount.TabIndex = 3;
            // 
            // lblPromotionName
            // 
            lblPromotionName.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblPromotionName.Location = new Point(29, 113);
=======
            lblPromotionName.Location = new Point(27, 125);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblPromotionName.Name = "lblPromotionName";
            lblPromotionName.Size = new Size(78, 20);
            lblPromotionName.TabIndex = 2;
            lblPromotionName.Text = "Tên CTKM:";
            // 
            // txtPromotionName
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            txtPromotionName.Location = new Point(217, 110);
=======
            txtPromotionName.Location = new Point(217, 122);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            txtPromotionName.Name = "txtPromotionName";
            txtPromotionName.Size = new Size(214, 27);
            txtPromotionName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
=======
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(26, 9);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(397, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin chương trình khuyến mãi";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(462, 0);
            panel2.Name = "panel2";
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            panel2.Size = new Size(690, 112);
=======
            panel2.Size = new Size(832, 112);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(grbDateFilter);
            panel5.Controls.Add(grbPriceFilter);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(161, 0);
            panel5.Name = "panel5";
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            panel5.Size = new Size(529, 112);
=======
            panel5.Size = new Size(675, 112);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            panel5.TabIndex = 1;
            // 
            // grbDateFilter
            // 
            grbDateFilter.Controls.Add(lblDateTo);
            grbDateFilter.Controls.Add(lblDateFrom);
            grbDateFilter.Controls.Add(dtpkSearchEndDate);
            grbDateFilter.Controls.Add(dtpkSearchStartDate);
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            grbDateFilter.Dock = DockStyle.Right;
            grbDateFilter.Location = new Point(188, 0);
            grbDateFilter.Name = "grbDateFilter";
            grbDateFilter.Size = new Size(341, 112);
            grbDateFilter.TabIndex = 0;
            grbDateFilter.TabStop = false;
            grbDateFilter.Text = "Tìm kiếm theo ngày";
=======
            grbDateFilter.Dock = DockStyle.Fill;
            grbDateFilter.Location = new Point(186, 0);
            grbDateFilter.Name = "grbDateFilter";
            grbDateFilter.Size = new Size(489, 112);
            grbDateFilter.TabIndex = 0;
            grbDateFilter.TabStop = false;
            grbDateFilter.Text = "Lọc theo ngày";
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Location = new Point(18, 74);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(37, 20);
            lblDateTo.TabIndex = 29;
            lblDateTo.Text = "đến:";
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Location = new Point(18, 29);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(65, 20);
            lblDateFrom.TabIndex = 28;
            lblDateFrom.Text = "Ngày từ:";
            // 
            // dtpkSearchEndDate
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            dtpkSearchEndDate.Location = new Point(117, 71);
=======
            dtpkSearchEndDate.Location = new Point(113, 69);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            dtpkSearchEndDate.Name = "dtpkSearchEndDate";
            dtpkSearchEndDate.Size = new Size(214, 27);
            dtpkSearchEndDate.TabIndex = 1;
            // 
            // dtpkSearchStartDate
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            dtpkSearchStartDate.Location = new Point(117, 24);
=======
            dtpkSearchStartDate.Location = new Point(113, 24);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            dtpkSearchStartDate.Name = "dtpkSearchStartDate";
            dtpkSearchStartDate.Size = new Size(214, 27);
            dtpkSearchStartDate.TabIndex = 0;
            // 
            // grbPriceFilter
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            grbPriceFilter.Controls.Add(txtSearchEndDiscount);
            grbPriceFilter.Controls.Add(txtSearchStartDiscount);
=======
            grbPriceFilter.Controls.Add(txtEndDiscount);
            grbPriceFilter.Controls.Add(txtStartDiscount);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            grbPriceFilter.Controls.Add(lblPriceTo);
            grbPriceFilter.Controls.Add(lblPriceFrom);
            grbPriceFilter.Dock = DockStyle.Left;
            grbPriceFilter.Location = new Point(0, 0);
            grbPriceFilter.Name = "grbPriceFilter";
            grbPriceFilter.Size = new Size(186, 112);
            grbPriceFilter.TabIndex = 0;
            grbPriceFilter.TabStop = false;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            grbPriceFilter.Text = "Tìm kiếm theo giá giảm";
            // 
            // txtSearchEndDiscount
            // 
            txtSearchEndDiscount.Location = new Point(70, 71);
            txtSearchEndDiscount.Name = "txtSearchEndDiscount";
            txtSearchEndDiscount.Size = new Size(110, 27);
            txtSearchEndDiscount.TabIndex = 27;
            // 
            // txtSearchStartDiscount
            // 
            txtSearchStartDiscount.Location = new Point(70, 26);
            txtSearchStartDiscount.Name = "txtSearchStartDiscount";
            txtSearchStartDiscount.Size = new Size(110, 27);
            txtSearchStartDiscount.TabIndex = 25;
=======
            grbPriceFilter.Text = "Lọc theo giá";
            // 
            // txtEndDiscount
            // 
            txtEndDiscount.Location = new Point(70, 71);
            txtEndDiscount.Name = "txtEndDiscount";
            txtEndDiscount.Size = new Size(110, 27);
            txtEndDiscount.TabIndex = 27;
            // 
            // txtStartDiscount
            // 
            txtStartDiscount.Location = new Point(70, 26);
            txtStartDiscount.Name = "txtStartDiscount";
            txtStartDiscount.Size = new Size(110, 27);
            txtStartDiscount.TabIndex = 25;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // lblPriceTo
            // 
            lblPriceTo.AutoSize = true;
            lblPriceTo.Location = new Point(6, 76);
            lblPriceTo.Name = "lblPriceTo";
            lblPriceTo.Size = new Size(37, 20);
            lblPriceTo.TabIndex = 26;
            lblPriceTo.Text = "đến:";
            // 
            // lblPriceFrom
            // 
            lblPriceFrom.AutoSize = true;
            lblPriceFrom.Location = new Point(6, 29);
            lblPriceFrom.Name = "lblPriceFrom";
            lblPriceFrom.Size = new Size(52, 20);
            lblPriceFrom.TabIndex = 25;
            lblPriceFrom.Text = "Giá từ:";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 112);
            panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 59);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Từ khoá tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(6, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 27);
            txtSearch.TabIndex = 12;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            txtSearch.TextChanged += txtSearch_TextChanged;
=======
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxTypeOfSearch);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // cbxTypeOfSearch
            // 
            cbxTypeOfSearch.FormattingEnabled = true;
            cbxTypeOfSearch.Location = new Point(6, 23);
            cbxTypeOfSearch.Name = "cbxTypeOfSearch";
            cbxTypeOfSearch.Size = new Size(145, 28);
            cbxTypeOfSearch.TabIndex = 0;
            // 
            // panel3
            // 
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            panel3.Controls.Add(dgvPromotion);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(462, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 373);
            panel3.TabIndex = 2;
            // 
            // dgvPromotion
            // 
            dgvPromotion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotion.Dock = DockStyle.Fill;
            dgvPromotion.Location = new Point(0, 0);
            dgvPromotion.Name = "dgvPromotion";
            dgvPromotion.RowHeadersWidth = 51;
            dgvPromotion.RowTemplate.Height = 29;
            dgvPromotion.Size = new Size(690, 373);
            dgvPromotion.TabIndex = 0;
=======
            panel3.Controls.Add(dgvPromotions);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(462, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(832, 373);
            panel3.TabIndex = 2;
            // 
            // dgvPromotions
            // 
            dgvPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromotions.Dock = DockStyle.Fill;
            dgvPromotions.Location = new Point(0, 0);
            dgvPromotions.Name = "dgvPromotions";
            dgvPromotions.RowHeadersWidth = 51;
            dgvPromotions.RowTemplate.Height = 29;
            dgvPromotions.Size = new Size(832, 373);
            dgvPromotions.TabIndex = 0;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            ClientSize = new Size(1152, 485);
=======
            ClientSize = new Size(1294, 485);
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlInformation);
            Name = "PromotionForm";
            Text = "PromotionForm";
            Load += PromotionForm_Load;
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            grbDateFilter.ResumeLayout(false);
            grbDateFilter.PerformLayout();
            grbPriceFilter.ResumeLayout(false);
            grbPriceFilter.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)dgvPromotions).EndInit();
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInformation;
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel5;
        private GroupBox grbDateFilter;
        private GroupBox grbPriceFilter;
        private Label lblDateStart;
        private Label lblPromotionID;
        private TextBox txtPromotionID;
        private Label lblDateEnd;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblPromotionName;
        private TextBox txtPromotionName;
        private Label lblTitle;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
        private Button btnExportExcel;
=======
        private Button btnStartWork;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnStopWork;
        private Button btnRefresh;
        private Button btnAdd;
<<<<<<< Updated upstream:MiniSupermarket/Views/PromotionForm.Designer.cs
        private TextBox txtSearchEndDiscount;
        private TextBox txtSearchStartDiscount;
        private Label lblPriceTo;
        private Label lblPriceFrom;
        private TextBox txtSearch;
        private DataGridView dgvPromotion;
=======
        private TextBox txtEndDiscount;
        private TextBox txtStartDiscount;
        private Label lblPriceTo;
        private Label lblPriceFrom;
        private TextBox txtSearch;
        private DataGridView dgvPromotions;
>>>>>>> Stashed changes:MiniSupermarket/GUI/PromotionForm.Designer.cs
        private DateTimePicker dtpkSearchStartDate;
        private ComboBox cbxTypeOfSearch;
        private Label lblDateTo;
        private Label lblDateFrom;
        private DateTimePicker dtpkSearchEndDate;
        private DateTimePicker dtpkEndDate;
        private DateTimePicker dtpkStartDate;
    }
}