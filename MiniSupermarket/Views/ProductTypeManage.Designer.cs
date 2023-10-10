namespace MiniSupermarket.Views
{
    partial class ProductTypeManage
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
            pnl_top = new Panel();
            lb_QLLSP = new Label();
            pnl_left = new Panel();
            grb_textField = new GroupBox();
            btn_mod = new Button();
            btn_del = new Button();
            btn_add = new Button();
            txt_nameType = new TextBox();
            txt_idType = new TextBox();
            lb_typeName = new Label();
            lb_idType = new Label();
            grb_search = new GroupBox();
            txt_search = new TextBox();
            cb_search = new ComboBox();
            pnl_right = new Panel();
            dgv_qllsp = new DataGridView();
            pnl_top.SuspendLayout();
            pnl_left.SuspendLayout();
            grb_textField.SuspendLayout();
            grb_search.SuspendLayout();
            pnl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_qllsp).BeginInit();
            SuspendLayout();
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(lb_QLLSP);
            pnl_top.Dock = DockStyle.Top;
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(1034, 125);
            pnl_top.TabIndex = 0;
            // 
            // lb_QLLSP
            // 
            lb_QLLSP.Dock = DockStyle.Fill;
            lb_QLLSP.Location = new Point(0, 0);
            lb_QLLSP.Name = "lb_QLLSP";
            lb_QLLSP.Size = new Size(1034, 125);
            lb_QLLSP.TabIndex = 0;
            lb_QLLSP.Text = "Quản lý loại sản phẩm";
            lb_QLLSP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_left
            // 
            pnl_left.Controls.Add(grb_textField);
            pnl_left.Controls.Add(grb_search);
            pnl_left.Dock = DockStyle.Left;
            pnl_left.Location = new Point(0, 125);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new Size(417, 413);
            pnl_left.TabIndex = 1;
            // 
            // grb_textField
            // 
            grb_textField.Controls.Add(btn_mod);
            grb_textField.Controls.Add(btn_del);
            grb_textField.Controls.Add(btn_add);
            grb_textField.Controls.Add(txt_nameType);
            grb_textField.Controls.Add(txt_idType);
            grb_textField.Controls.Add(lb_typeName);
            grb_textField.Controls.Add(lb_idType);
            grb_textField.Dock = DockStyle.Fill;
            grb_textField.Location = new Point(0, 125);
            grb_textField.Name = "grb_textField";
            grb_textField.Size = new Size(417, 288);
            grb_textField.TabIndex = 1;
            grb_textField.TabStop = false;
            grb_textField.Text = "Thông tin";
            // 
            // btn_mod
            // 
            btn_mod.Location = new Point(316, 153);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(94, 29);
            btn_mod.TabIndex = 2;
            btn_mod.Text = "Sửa";
            btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(164, 153);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(94, 29);
            btn_del.TabIndex = 2;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 153);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 2;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_nameType
            // 
            txt_nameType.Location = new Point(127, 95);
            txt_nameType.Name = "txt_nameType";
            txt_nameType.Size = new Size(284, 27);
            txt_nameType.TabIndex = 1;
            // 
            // txt_idType
            // 
            txt_idType.Location = new Point(127, 40);
            txt_idType.Name = "txt_idType";
            txt_idType.Size = new Size(284, 27);
            txt_idType.TabIndex = 1;
            // 
            // lb_typeName
            // 
            lb_typeName.AutoSize = true;
            lb_typeName.Location = new Point(12, 102);
            lb_typeName.Name = "lb_typeName";
            lb_typeName.Size = new Size(61, 20);
            lb_typeName.TabIndex = 0;
            lb_typeName.Text = "Tên loại";
            // 
            // lb_idType
            // 
            lb_idType.AutoSize = true;
            lb_idType.Location = new Point(12, 47);
            lb_idType.Name = "lb_idType";
            lb_idType.Size = new Size(59, 20);
            lb_idType.TabIndex = 0;
            lb_idType.Text = "Mã loại";
            // 
            // grb_search
            // 
            grb_search.Controls.Add(txt_search);
            grb_search.Controls.Add(cb_search);
            grb_search.Dock = DockStyle.Top;
            grb_search.Location = new Point(0, 0);
            grb_search.Name = "grb_search";
            grb_search.Size = new Size(417, 125);
            grb_search.TabIndex = 0;
            grb_search.TabStop = false;
            grb_search.Text = "Tìm kiếm theo";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(169, 55);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(242, 27);
            txt_search.TabIndex = 1;
            // 
            // cb_search
            // 
            cb_search.FormattingEnabled = true;
            cb_search.Location = new Point(12, 55);
            cb_search.Name = "cb_search";
            cb_search.Size = new Size(151, 28);
            cb_search.TabIndex = 0;
            // 
            // pnl_right
            // 
            pnl_right.Controls.Add(dgv_qllsp);
            pnl_right.Dock = DockStyle.Fill;
            pnl_right.Location = new Point(417, 125);
            pnl_right.Name = "pnl_right";
            pnl_right.Size = new Size(617, 413);
            pnl_right.TabIndex = 2;
            // 
            // dgv_qllsp
            // 
            dgv_qllsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_qllsp.Dock = DockStyle.Fill;
            dgv_qllsp.Location = new Point(0, 0);
            dgv_qllsp.Name = "dgv_qllsp";
            dgv_qllsp.RowHeadersWidth = 51;
            dgv_qllsp.RowTemplate.Height = 29;
            dgv_qllsp.Size = new Size(617, 413);
            dgv_qllsp.TabIndex = 0;
            dgv_qllsp.CellClick += dgv_qllsp_CellClick;
            // 
            // ProductTypeManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 538);
            Controls.Add(pnl_right);
            Controls.Add(pnl_left);
            Controls.Add(pnl_top);
            Name = "ProductTypeManage";
            Text = "ProductTypeManage";
            pnl_top.ResumeLayout(false);
            pnl_left.ResumeLayout(false);
            grb_textField.ResumeLayout(false);
            grb_textField.PerformLayout();
            grb_search.ResumeLayout(false);
            grb_search.PerformLayout();
            pnl_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_qllsp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_top;
        private Label lb_QLLSP;
        private Panel pnl_left;
        private Panel pnl_right;
        private DataGridView dgv_qllsp;
        private GroupBox grb_search;
        private ComboBox cb_search;
        private TextBox txt_search;
        private GroupBox grb_textField;
        private TextBox txt_nameType;
        private TextBox txt_idType;
        private Label lb_typeName;
        private Label lb_idType;
        private Button btn_add;
        private Button btn_mod;
        private Button btn_del;
    }
}