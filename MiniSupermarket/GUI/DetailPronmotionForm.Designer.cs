namespace MiniSupermarket.GUI
{
    partial class DetailPronmotionForm
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
            panel1 = new Panel();
            dgvProductPromotions = new DataGridView();
            lblTitlePromotion = new Label();
            panel2 = new Panel();
            dgvProducts = new DataGridView();
            groupBox2 = new GroupBox();
            cbxTypeProduct = new ComboBox();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeSearch = new ComboBox();
            lblTitleProduct = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductPromotions).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProductPromotions);
            panel1.Controls.Add(lblTitlePromotion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 533);
            panel1.TabIndex = 0;
            // 
            // dgvProductPromotions
            // 
            dgvProductPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductPromotions.Dock = DockStyle.Bottom;
            dgvProductPromotions.Location = new Point(0, 86);
            dgvProductPromotions.Name = "dgvProductPromotions";
            dgvProductPromotions.RowHeadersWidth = 51;
            dgvProductPromotions.RowTemplate.Height = 29;
            dgvProductPromotions.Size = new Size(692, 447);
            dgvProductPromotions.TabIndex = 1;
            dgvProductPromotions.CellMouseDoubleClick += dgvProductPromotions_CellMouseDoubleClick;
            // 
            // lblTitlePromotion
            // 
            lblTitlePromotion.AutoSize = true;
            lblTitlePromotion.Location = new Point(21, 22);
            lblTitlePromotion.Name = "lblTitlePromotion";
            lblTitlePromotion.Size = new Size(265, 20);
            lblTitlePromotion.TabIndex = 0;
            lblTitlePromotion.Text = "DANH SÁCH SẢN PHẨM KHUYẾN MÃI";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(692, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 533);
            panel2.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Bottom;
            dgvProducts.Location = new Point(0, 163);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 29;
            dgvProducts.Size = new Size(576, 370);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellMouseDoubleClick += dgvProducts_CellMouseDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxTypeProduct);
            groupBox2.Location = new Point(377, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 71);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc theo loại sản phẩm";
            // 
            // cbxTypeProduct
            // 
            cbxTypeProduct.FormattingEnabled = true;
            cbxTypeProduct.Location = new Point(7, 26);
            cbxTypeProduct.Name = "cbxTypeProduct";
            cbxTypeProduct.Size = new Size(174, 28);
            cbxTypeProduct.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(cbxTypeSearch);
            groupBox1.Location = new Point(3, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(193, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 27);
            txtSearch.TabIndex = 1;
            // 
            // cbxTypeSearch
            // 
            cbxTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeSearch.FormattingEnabled = true;
            cbxTypeSearch.Items.AddRange(new object[] { "Mã sản phẩm", "Tên sản phẩm" });
            cbxTypeSearch.Location = new Point(20, 26);
            cbxTypeSearch.Name = "cbxTypeSearch";
            cbxTypeSearch.Size = new Size(151, 28);
            cbxTypeSearch.TabIndex = 0;
            // 
            // lblTitleProduct
            // 
            lblTitleProduct.AutoSize = true;
            lblTitleProduct.Location = new Point(168, 22);
            lblTitleProduct.Name = "lblTitleProduct";
            lblTitleProduct.Size = new Size(173, 20);
            lblTitleProduct.TabIndex = 0;
            lblTitleProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // DetailPronmotionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DetailPronmotionForm";
            Text = "DetailPronmotionForm";
            Load += DetailPronmotionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductPromotions).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProductPromotions;
        private Label lblTitlePromotion;
        private DataGridView dgvProducts;
        private GroupBox groupBox2;
        private ComboBox cbxTypeProduct;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private ComboBox cbxTypeSearch;
        private Label lblTitleProduct;
    }
}