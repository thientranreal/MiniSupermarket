namespace MiniSupermarket.GUI
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.grb_textField = new System.Windows.Forms.GroupBox();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_nameType = new System.Windows.Forms.TextBox();
            this.txt_idType = new System.Windows.Forms.TextBox();
            this.lb_typeName = new System.Windows.Forms.Label();
            this.lb_idType = new System.Windows.Forms.Label();
            this.grb_search = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.dgv_qllsp = new System.Windows.Forms.DataGridView();
            this.pnl_left.SuspendLayout();
            this.grb_textField.SuspendLayout();
            this.grb_search.SuspendLayout();
            this.pnl_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qllsp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.grb_textField);
            this.pnl_left.Controls.Add(this.grb_search);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(417, 538);
            this.pnl_left.TabIndex = 1;
            // 
            // grb_textField
            // 
            this.grb_textField.Controls.Add(this.btn_mod);
            this.grb_textField.Controls.Add(this.btn_del);
            this.grb_textField.Controls.Add(this.btn_add);
            this.grb_textField.Controls.Add(this.txt_nameType);
            this.grb_textField.Controls.Add(this.txt_idType);
            this.grb_textField.Controls.Add(this.lb_typeName);
            this.grb_textField.Controls.Add(this.lb_idType);
            this.grb_textField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_textField.Location = new System.Drawing.Point(0, 125);
            this.grb_textField.Name = "grb_textField";
            this.grb_textField.Size = new System.Drawing.Size(417, 413);
            this.grb_textField.TabIndex = 1;
            this.grb_textField.TabStop = false;
            this.grb_textField.Text = "Thông tin";
            // 
            // btn_mod
            // 
            this.btn_mod.FlatAppearance.BorderSize = 0;
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod.Location = new System.Drawing.Point(304, 153);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(106, 49);
            this.btn_mod.TabIndex = 2;
            this.btn_mod.Text = "Sửa";
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Location = new System.Drawing.Point(158, 153);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(106, 49);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(12, 153);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(106, 49);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_nameType
            // 
            this.txt_nameType.Location = new System.Drawing.Point(127, 95);
            this.txt_nameType.Name = "txt_nameType";
            this.txt_nameType.Size = new System.Drawing.Size(284, 27);
            this.txt_nameType.TabIndex = 1;
            // 
            // txt_idType
            // 
            this.txt_idType.Location = new System.Drawing.Point(127, 40);
            this.txt_idType.Name = "txt_idType";
            this.txt_idType.Size = new System.Drawing.Size(284, 27);
            this.txt_idType.TabIndex = 1;
            // 
            // lb_typeName
            // 
            this.lb_typeName.AutoSize = true;
            this.lb_typeName.Location = new System.Drawing.Point(12, 102);
            this.lb_typeName.Name = "lb_typeName";
            this.lb_typeName.Size = new System.Drawing.Size(61, 20);
            this.lb_typeName.TabIndex = 0;
            this.lb_typeName.Text = "Tên loại";
            // 
            // lb_idType
            // 
            this.lb_idType.AutoSize = true;
            this.lb_idType.Location = new System.Drawing.Point(12, 47);
            this.lb_idType.Name = "lb_idType";
            this.lb_idType.Size = new System.Drawing.Size(59, 20);
            this.lb_idType.TabIndex = 0;
            this.lb_idType.Text = "Mã loại";
            // 
            // grb_search
            // 
            this.grb_search.Controls.Add(this.txt_search);
            this.grb_search.Controls.Add(this.cb_search);
            this.grb_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_search.Location = new System.Drawing.Point(0, 0);
            this.grb_search.Name = "grb_search";
            this.grb_search.Size = new System.Drawing.Size(417, 125);
            this.grb_search.TabIndex = 0;
            this.grb_search.TabStop = false;
            this.grb_search.Text = "Tìm kiếm theo";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(169, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(242, 27);
            this.txt_search.TabIndex = 1;
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(12, 55);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(151, 28);
            this.cb_search.TabIndex = 0;
            // 
            // pnl_right
            // 
            this.pnl_right.Controls.Add(this.dgv_qllsp);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(417, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(617, 538);
            this.pnl_right.TabIndex = 2;
            // 
            // dgv_qllsp
            // 
            this.dgv_qllsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qllsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qllsp.Location = new System.Drawing.Point(0, 0);
            this.dgv_qllsp.MultiSelect = false;
            this.dgv_qllsp.Name = "dgv_qllsp";
            this.dgv_qllsp.RowHeadersWidth = 51;
            this.dgv_qllsp.RowTemplate.Height = 29;
            this.dgv_qllsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_qllsp.Size = new System.Drawing.Size(617, 538);
            this.dgv_qllsp.TabIndex = 0;
            // 
            // ProductTypeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 538);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.Name = "ProductTypeManage";
            this.Text = "ProductTypeManage";
            this.Load += new System.EventHandler(this.ProductTypeManage_Load_1);
            this.pnl_left.ResumeLayout(false);
            this.grb_textField.ResumeLayout(false);
            this.grb_textField.PerformLayout();
            this.grb_search.ResumeLayout(false);
            this.grb_search.PerformLayout();
            this.pnl_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qllsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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