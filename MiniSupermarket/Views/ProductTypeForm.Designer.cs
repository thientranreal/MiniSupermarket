namespace MiniSupermarket.Views
{
    partial class ProductTypeForm
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
            pnl_title = new Panel();
            lb_title = new Label();
            pnl_left = new Panel();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            txt_name_type = new TextBox();
            lb_name_type = new Label();
            txt_typeID = new TextBox();
            lb_typeID = new Label();
            pnl_search = new Panel();
            pnl_data = new Panel();
            dgv_show_product_type = new DataGridView();
            cb_search_type = new ComboBox();
            txt_search = new TextBox();
            pnl_title.SuspendLayout();
            pnl_left.SuspendLayout();
            pnl_search.SuspendLayout();
            pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_show_product_type).BeginInit();
            SuspendLayout();
            // 
            // pnl_title
            // 
            pnl_title.BackColor = Color.White;
            pnl_title.Controls.Add(lb_title);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.Location = new Point(0, 0);
            pnl_title.Name = "pnl_title";
            pnl_title.Size = new Size(836, 93);
            pnl_title.TabIndex = 0;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_title.Location = new Point(307, 32);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(223, 28);
            lb_title.TabIndex = 1;
            lb_title.Text = "Quản lý loại sản phẩm";
            // 
            // pnl_left
            // 
            pnl_left.BackColor = Color.White;
            pnl_left.Controls.Add(btn_update);
            pnl_left.Controls.Add(btn_delete);
            pnl_left.Controls.Add(btn_add);
            pnl_left.Controls.Add(txt_name_type);
            pnl_left.Controls.Add(lb_name_type);
            pnl_left.Controls.Add(txt_typeID);
            pnl_left.Controls.Add(lb_typeID);
            pnl_left.Dock = DockStyle.Left;
            pnl_left.Location = new Point(0, 93);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new Size(258, 375);
            pnl_left.TabIndex = 1;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ControlLight;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Location = new Point(78, 189);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ControlLight;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Location = new Point(125, 154);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ControlLight;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Location = new Point(25, 154);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 4;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // txt_name_type
            // 
            txt_name_type.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name_type.Location = new Point(25, 114);
            txt_name_type.Name = "txt_name_type";
            txt_name_type.Size = new Size(198, 34);
            txt_name_type.TabIndex = 3;
            // 
            // lb_name_type
            // 
            lb_name_type.AutoSize = true;
            lb_name_type.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name_type.Location = new Point(25, 91);
            lb_name_type.Name = "lb_name_type";
            lb_name_type.Size = new Size(63, 20);
            lb_name_type.TabIndex = 2;
            lb_name_type.Text = "Tên loại";
            // 
            // txt_typeID
            // 
            txt_typeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_typeID.Location = new Point(25, 36);
            txt_typeID.Name = "txt_typeID";
            txt_typeID.Size = new Size(198, 34);
            txt_typeID.TabIndex = 1;
            // 
            // lb_typeID
            // 
            lb_typeID.AutoSize = true;
            lb_typeID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_typeID.Location = new Point(25, 13);
            lb_typeID.Name = "lb_typeID";
            lb_typeID.Size = new Size(60, 20);
            lb_typeID.TabIndex = 0;
            lb_typeID.Text = "Mã loại";
            // 
            // pnl_search
            // 
            pnl_search.Controls.Add(txt_search);
            pnl_search.Controls.Add(cb_search_type);
            pnl_search.Dock = DockStyle.Top;
            pnl_search.Location = new Point(258, 93);
            pnl_search.Name = "pnl_search";
            pnl_search.Size = new Size(578, 54);
            pnl_search.TabIndex = 2;
            // 
            // pnl_data
            // 
            pnl_data.Controls.Add(dgv_show_product_type);
            pnl_data.Dock = DockStyle.Fill;
            pnl_data.Location = new Point(258, 147);
            pnl_data.Name = "pnl_data";
            pnl_data.Size = new Size(578, 321);
            pnl_data.TabIndex = 3;
            // 
            // dgv_show_product_type
            // 
            dgv_show_product_type.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_show_product_type.Dock = DockStyle.Fill;
            dgv_show_product_type.Location = new Point(0, 0);
            dgv_show_product_type.Name = "dgv_show_product_type";
            dgv_show_product_type.RowHeadersWidth = 51;
            dgv_show_product_type.RowTemplate.Height = 29;
            dgv_show_product_type.Size = new Size(578, 321);
            dgv_show_product_type.TabIndex = 0;
            // 
            // cb_search_type
            // 
            cb_search_type.FormattingEnabled = true;
            cb_search_type.Location = new Point(6, 13);
            cb_search_type.Name = "cb_search_type";
            cb_search_type.Size = new Size(110, 28);
            cb_search_type.TabIndex = 0;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(122, 14);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(444, 27);
            txt_search.TabIndex = 1;
            // 
            // ProductTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(836, 468);
            Controls.Add(pnl_data);
            Controls.Add(pnl_search);
            Controls.Add(pnl_left);
            Controls.Add(pnl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductTypeForm";
            pnl_title.ResumeLayout(false);
            pnl_title.PerformLayout();
            pnl_left.ResumeLayout(false);
            pnl_left.PerformLayout();
            pnl_search.ResumeLayout(false);
            pnl_search.PerformLayout();
            pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_show_product_type).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_title;
        private Label lb_title;
        private Panel pnl_left;
        private TextBox txt_typeID;
        private Label lb_typeID;
        private TextBox txt_name_type;
        private Label lb_name_type;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Panel pnl_search;
        private Panel pnl_data;
        private DataGridView dgv_show_product_type;
        private TextBox txt_search;
        private ComboBox cb_search_type;
    }
}