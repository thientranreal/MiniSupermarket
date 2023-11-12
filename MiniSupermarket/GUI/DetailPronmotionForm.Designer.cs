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
            dataGridView1 = new DataGridView();
            lblTitlePromotion = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            lblTitleProduct = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblTitlePromotion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 533);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(692, 447);
            dataGridView1.TabIndex = 1;
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
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(692, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 533);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 163);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(576, 370);
            dataGridView2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Location = new Point(347, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 71);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lọc theo loại sản phẩm";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(7, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(139, 28);
            comboBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(3, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 71);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lblTitlePromotion;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label lblTitleProduct;
    }
}