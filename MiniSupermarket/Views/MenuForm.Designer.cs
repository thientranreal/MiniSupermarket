namespace MiniSupermarket.Views
{
    partial class MenuForm
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
            pnl_root = new Panel();
            pnl_form = new Panel();
            pnl_header = new Panel();
            lb_header = new Label();
            pnl_menu = new Panel();
            btn_product = new Button();
            btn_product_type = new Button();
            pnl_root.SuspendLayout();
            pnl_header.SuspendLayout();
            pnl_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_root
            // 
            pnl_root.BackColor = Color.Gray;
            pnl_root.Controls.Add(pnl_form);
            pnl_root.Controls.Add(pnl_header);
            pnl_root.Controls.Add(pnl_menu);
            pnl_root.Dock = DockStyle.Fill;
            pnl_root.Location = new Point(0, 0);
            pnl_root.Name = "pnl_root";
            pnl_root.Size = new Size(1063, 710);
            pnl_root.TabIndex = 1;
            // 
            // pnl_form
            // 
            pnl_form.BackColor = Color.White;
            pnl_form.Dock = DockStyle.Fill;
            pnl_form.Location = new Point(233, 125);
            pnl_form.Name = "pnl_form";
            pnl_form.Size = new Size(830, 585);
            pnl_form.TabIndex = 2;
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.FromArgb(64, 64, 64);
            pnl_header.Controls.Add(lb_header);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.ForeColor = Color.White;
            pnl_header.Location = new Point(233, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(830, 125);
            pnl_header.TabIndex = 1;
            // 
            // lb_header
            // 
            lb_header.AutoSize = true;
            lb_header.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lb_header.Location = new Point(172, 32);
            lb_header.Name = "lb_header";
            lb_header.Size = new Size(349, 46);
            lb_header.TabIndex = 0;
            lb_header.Text = "Quản lý siêu thị mini";
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(64, 64, 64);
            pnl_menu.Controls.Add(btn_product);
            pnl_menu.Controls.Add(btn_product_type);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.ForeColor = Color.White;
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(233, 710);
            pnl_menu.TabIndex = 0;
            // 
            // btn_product
            // 
            btn_product.AutoSize = true;
            btn_product.BackColor = Color.Gray;
            btn_product.FlatAppearance.BorderSize = 0;
            btn_product.FlatStyle = FlatStyle.Flat;
            btn_product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_product.ForeColor = Color.White;
            btn_product.Location = new Point(0, 231);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(233, 100);
            btn_product.TabIndex = 1;
            btn_product.Text = "Quản lý sản phẩm";
            btn_product.UseVisualStyleBackColor = false;
            // 
            // btn_product_type
            // 
            btn_product_type.AutoSize = true;
            btn_product_type.BackColor = Color.Gray;
            btn_product_type.FlatAppearance.BorderSize = 0;
            btn_product_type.FlatStyle = FlatStyle.Flat;
            btn_product_type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_product_type.ForeColor = Color.White;
            btn_product_type.Location = new Point(0, 125);
            btn_product_type.Name = "btn_product_type";
            btn_product_type.Size = new Size(233, 100);
            btn_product_type.TabIndex = 0;
            btn_product_type.Text = "Quản lý loại sản phẩm";
            btn_product_type.UseVisualStyleBackColor = false;
            btn_product_type.Click += btn_product_type_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 710);
            Controls.Add(pnl_root);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý siêu thị mini";
            pnl_root.ResumeLayout(false);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            pnl_menu.ResumeLayout(false);
            pnl_menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_root;
        private Panel pnl_menu;
        private Panel pnl_header;
        private Label lb_header;
        private Panel pnl_form;
        private Button btn_product_type;
        private Button btn_product;
    }
}