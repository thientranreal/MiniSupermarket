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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductPromotions = new System.Windows.Forms.DataGridView();
            this.lblTitlePromotion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTypeProduct = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxTypeSearch = new System.Windows.Forms.ComboBox();
            this.lblTitleProduct = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPromotions)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductPromotions);
            this.panel1.Controls.Add(this.lblTitlePromotion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 533);
            this.panel1.TabIndex = 0;
            // 
            // dgvProductPromotions
            // 
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
            this.lblTitlePromotion.AutoSize = true;
            this.lblTitlePromotion.Location = new System.Drawing.Point(21, 22);
            this.lblTitlePromotion.Name = "lblTitlePromotion";
            this.lblTitlePromotion.Size = new System.Drawing.Size(265, 20);
            this.lblTitlePromotion.TabIndex = 0;
            this.lblTitlePromotion.Text = "DANH SÁCH SẢN PHẨM KHUYẾN MÃI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblTitleProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(692, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 533);
            this.panel2.TabIndex = 1;
            // 
            // dgvProducts
            // 
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
            this.cbxTypeSearch.FormattingEnabled = true;
            this.cbxTypeSearch.Location = new System.Drawing.Point(20, 26);
            this.cbxTypeSearch.Name = "cbxTypeSearch";
            this.cbxTypeSearch.Size = new System.Drawing.Size(151, 28);
            this.cbxTypeSearch.TabIndex = 0;
            // 
            // lblTitleProduct
            // 
            this.lblTitleProduct.AutoSize = true;
            this.lblTitleProduct.Location = new System.Drawing.Point(168, 22);
            this.lblTitleProduct.Name = "lblTitleProduct";
            this.lblTitleProduct.Size = new System.Drawing.Size(173, 20);
            this.lblTitleProduct.TabIndex = 0;
            this.lblTitleProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // DetailPronmotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailPronmotionForm";
            this.Text = "DetailPronmotionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPromotions)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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