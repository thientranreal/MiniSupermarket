namespace MiniSupermarket.GUI
{
    partial class DetailPurchaseOrderForm
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
            dgvProductOrders = new DataGridView();
            lblProductOrder = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            dgvProducts = new DataGridView();
            pnlInformation = new Panel();
            nudQuantity = new NumericUpDown();
            txtOrderPrice = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtProductID = new TextBox();
            label1 = new Label();
            lblProduct = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProductOrders);
            panel1.Controls.Add(lblProductOrder);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 595);
            panel1.TabIndex = 0;
            // 
            // dgvProductOrders
            // 
            dgvProductOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductOrders.Dock = DockStyle.Bottom;
            dgvProductOrders.Location = new Point(0, 86);
            dgvProductOrders.Margin = new Padding(3, 4, 3, 4);
            dgvProductOrders.Name = "dgvProductOrders";
            dgvProductOrders.RowHeadersWidth = 51;
            dgvProductOrders.RowTemplate.Height = 25;
            dgvProductOrders.Size = new Size(557, 509);
            dgvProductOrders.TabIndex = 1;
            // 
            // lblProductOrder
            // 
            lblProductOrder.AutoSize = true;
            lblProductOrder.Location = new Point(68, 24);
            lblProductOrder.Name = "lblProductOrder";
            lblProductOrder.Size = new Size(184, 20);
            lblProductOrder.TabIndex = 0;
            lblProductOrder.Text = "DANH SÁCH NHẬP HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pnlInformation);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(557, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 595);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvProducts);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 257);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(575, 338);
            panel4.TabIndex = 6;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(575, 338);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellMouseClick += dgvProducts_CellMouseClick;
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(nudQuantity);
            pnlInformation.Controls.Add(txtOrderPrice);
            pnlInformation.Controls.Add(label4);
            pnlInformation.Controls.Add(label3);
            pnlInformation.Controls.Add(txtProductName);
            pnlInformation.Controls.Add(label2);
            pnlInformation.Controls.Add(txtProductID);
            pnlInformation.Controls.Add(label1);
            pnlInformation.Controls.Add(lblProduct);
            pnlInformation.Controls.Add(groupBox1);
            pnlInformation.Controls.Add(groupBox2);
            pnlInformation.Dock = DockStyle.Top;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(3, 4, 3, 4);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(575, 257);
            pnlInformation.TabIndex = 5;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(449, 114);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(114, 27);
            nudQuantity.TabIndex = 13;
            // 
            // txtOrderPrice
            // 
            txtOrderPrice.Location = new Point(449, 64);
            txtOrderPrice.Margin = new Padding(3, 4, 3, 4);
            txtOrderPrice.Name = "txtOrderPrice";
            txtOrderPrice.Size = new Size(114, 27);
            txtOrderPrice.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 67);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Số lượng:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(185, 112);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(114, 27);
            txtProductName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 115);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(185, 64);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(114, 27);
            txtProductID.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã sản phẩm:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(97, 12);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(173, 20);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(7, 169);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(299, 63);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 24);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(7, 24);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Location = new Point(320, 172);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(203, 63);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 24);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 28);
            comboBox2.TabIndex = 1;
            // 
            // DetailPurchaseOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 595);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetailPurchaseOrderForm";
            Text = "DetailPurchaseOrderForm";
            Load += DetailPurchaseOrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductOrders).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProductOrder;
        private Panel panel2;
        private Label lblProduct;
        private DataGridView dgvProductOrders;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel4;
        private Panel pnlInformation;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtProductID;
        private Label label1;
        private DataGridView dgvProducts;
        private TextBox txtOrderPrice;
        private Label label4;
        private NumericUpDown nudQuantity;
    }
}