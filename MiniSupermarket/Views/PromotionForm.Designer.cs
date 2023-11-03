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
            btnExportExcel = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnImportExcel = new Button();
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
            txtSearchEndDiscount = new TextBox();
            txtSearchStartDiscount = new TextBox();
            lblPriceTo = new Label();
            lblPriceFrom = new Label();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            cbxTypeOfSearch = new ComboBox();
            panel3 = new Panel();
            dgvPromotion = new DataGridView();
            pnlInformation.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            grbDateFilter.SuspendLayout();
            grbPriceFilter.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).BeginInit();
            SuspendLayout();
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(dtpkEndDate);
            pnlInformation.Controls.Add(dtpkStartDate);
            pnlInformation.Controls.Add(btnExportExcel);
            pnlInformation.Controls.Add(btnUpdate);
            pnlInformation.Controls.Add(btnDelete);
            pnlInformation.Controls.Add(btnImportExcel);
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
            dtpkEndDate.Location = new Point(216, 224);
            dtpkEndDate.Name = "dtpkEndDate";
            dtpkEndDate.Size = new Size(214, 27);
            dtpkEndDate.TabIndex = 31;
            // 
            // dtpkStartDate
            // 
            dtpkStartDate.Location = new Point(216, 167);
            dtpkStartDate.Name = "dtpkStartDate";
            dtpkStartDate.Size = new Size(215, 27);
            dtpkStartDate.TabIndex = 30;
            // 
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
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(168, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 31);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(309, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 31);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnImportExcel
            // 
            btnImportExcel.FlatAppearance.BorderSize = 0;
            btnImportExcel.FlatStyle = FlatStyle.Flat;
            btnImportExcel.Location = new Point(168, 409);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(94, 31);
            btnImportExcel.TabIndex = 21;
            btnImportExcel.Text = "Tải Excel";
            btnImportExcel.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(309, 409);
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
            lblDateStart.Location = new Point(29, 170);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(102, 20);
            lblDateStart.TabIndex = 16;
            lblDateStart.Text = "Ngày bắt dầu:";
            // 
            // lblPromotionID
            // 
            lblPromotionID.AutoSize = true;
            lblPromotionID.Location = new Point(28, 56);
            lblPromotionID.Name = "lblPromotionID";
            lblPromotionID.Size = new Size(76, 20);
            lblPromotionID.TabIndex = 12;
            lblPromotionID.Text = "Mã CTKM:";
            // 
            // txtPromotionID
            // 
            txtPromotionID.Location = new Point(216, 53);
            txtPromotionID.Name = "txtPromotionID";
            txtPromotionID.Size = new Size(214, 27);
            txtPromotionID.TabIndex = 11;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Location = new Point(29, 227);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(103, 20);
            lblDateEnd.TabIndex = 6;
            lblDateEnd.Text = "Ngày kết thúc:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(29, 284);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(47, 20);
            lblDiscount.TabIndex = 4;
            lblDiscount.Text = "Giảm:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(216, 281);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(214, 27);
            txtDiscount.TabIndex = 3;
            // 
            // lblPromotionName
            // 
            lblPromotionName.AutoSize = true;
            lblPromotionName.Location = new Point(29, 113);
            lblPromotionName.Name = "lblPromotionName";
            lblPromotionName.Size = new Size(78, 20);
            lblPromotionName.TabIndex = 2;
            lblPromotionName.Text = "Tên CTKM:";
            // 
            // txtPromotionName
            // 
            txtPromotionName.Location = new Point(217, 110);
            txtPromotionName.Name = "txtPromotionName";
            txtPromotionName.Size = new Size(214, 27);
            txtPromotionName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
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
            panel2.Size = new Size(690, 112);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(grbDateFilter);
            panel5.Controls.Add(grbPriceFilter);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(161, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(529, 112);
            panel5.TabIndex = 1;
            // 
            // grbDateFilter
            // 
            grbDateFilter.Controls.Add(lblDateTo);
            grbDateFilter.Controls.Add(lblDateFrom);
            grbDateFilter.Controls.Add(dtpkSearchEndDate);
            grbDateFilter.Controls.Add(dtpkSearchStartDate);
            grbDateFilter.Dock = DockStyle.Right;
            grbDateFilter.Location = new Point(188, 0);
            grbDateFilter.Name = "grbDateFilter";
            grbDateFilter.Size = new Size(341, 112);
            grbDateFilter.TabIndex = 0;
            grbDateFilter.TabStop = false;
            grbDateFilter.Text = "Tìm kiếm theo ngày";
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
            dtpkSearchEndDate.Location = new Point(117, 71);
            dtpkSearchEndDate.Name = "dtpkSearchEndDate";
            dtpkSearchEndDate.Size = new Size(214, 27);
            dtpkSearchEndDate.TabIndex = 1;
            // 
            // dtpkSearchStartDate
            // 
            dtpkSearchStartDate.Location = new Point(117, 24);
            dtpkSearchStartDate.Name = "dtpkSearchStartDate";
            dtpkSearchStartDate.Size = new Size(214, 27);
            dtpkSearchStartDate.TabIndex = 0;
            // 
            // grbPriceFilter
            // 
            grbPriceFilter.Controls.Add(txtSearchEndDiscount);
            grbPriceFilter.Controls.Add(txtSearchStartDiscount);
            grbPriceFilter.Controls.Add(lblPriceTo);
            grbPriceFilter.Controls.Add(lblPriceFrom);
            grbPriceFilter.Dock = DockStyle.Left;
            grbPriceFilter.Location = new Point(0, 0);
            grbPriceFilter.Name = "grbPriceFilter";
            grbPriceFilter.Size = new Size(186, 112);
            grbPriceFilter.TabIndex = 0;
            grbPriceFilter.TabStop = false;
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
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            // 
            // PromotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 485);
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
            ((System.ComponentModel.ISupportInitialize)dgvPromotion).EndInit();
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
        private Button btnExportExcel;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnImportExcel;
        private Button btnRefresh;
        private Button btnAdd;
        private TextBox txtSearchEndDiscount;
        private TextBox txtSearchStartDiscount;
        private Label lblPriceTo;
        private Label lblPriceFrom;
        private TextBox txtSearch;
        private DataGridView dgvPromotion;
        private DateTimePicker dtpkSearchStartDate;
        private ComboBox cbxTypeOfSearch;
        private Label lblDateTo;
        private Label lblDateFrom;
        private DateTimePicker dtpkSearchEndDate;
        private DateTimePicker dtpkEndDate;
        private DateTimePicker dtpkStartDate;
    }
}