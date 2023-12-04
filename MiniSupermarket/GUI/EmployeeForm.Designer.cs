namespace MiniSupermarket.BUS
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            button2 = new Button();
            cb_role = new ComboBox();
            ds_qlnv = new DataGridView();
            btn_reset = new Button();
            lb_title = new Label();
            label5 = new Label();
            tb_pass = new TextBox();
            tb_name = new TextBox();
            tb_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gb_Info = new GroupBox();
            tb_address = new TextBox();
            textBox1 = new TextBox();
            tb_email = new TextBox();
            label1 = new Label();
            cb_sex = new ComboBox();
            label8 = new Label();
            tb_pNumber = new TextBox();
            label7 = new Label();
            dtp_birth = new DateTimePicker();
            label6 = new Label();
            label9 = new Label();
            gb_Function = new GroupBox();
            tb_find = new TextBox();
            cb_find = new ComboBox();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_find = new Button();
            gb_List = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ds_qlnv).BeginInit();
            gb_Info.SuspendLayout();
            gb_Function.SuspendLayout();
            gb_List.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(185, 200);
            button2.Name = "button2";
            button2.Size = new Size(164, 52);
            button2.TabIndex = 2;
            button2.Text = "Xuất File";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // cb_role
            // 
            cb_role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_role.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(232, 361);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(300, 44);
            cb_role.TabIndex = 7;
            // 
            // ds_qlnv
            // 
            ds_qlnv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds_qlnv.Location = new Point(6, 38);
            ds_qlnv.Name = "ds_qlnv";
            ds_qlnv.RowHeadersVisible = false;
            ds_qlnv.RowHeadersWidth = 62;
            ds_qlnv.RowTemplate.Height = 33;
            ds_qlnv.Size = new Size(1777, 324);
            ds_qlnv.TabIndex = 9;
            // 
            // btn_reset
            // 
            btn_reset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reset.Image = (Image)resources.GetObject("btn_reset.Image");
            btn_reset.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reset.Location = new Point(185, 122);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(128, 47);
            btn_reset.TabIndex = 10;
            btn_reset.Text = "Reset";
            btn_reset.TextAlign = ContentAlignment.MiddleRight;
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_title.Location = new Point(533, -1);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(342, 48);
            lb_title.TabIndex = 11;
            lb_title.Text = "Quản Lý Nhân Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 283);
            label5.Name = "label5";
            label5.Size = new Size(137, 38);
            label5.TabIndex = 23;
            label5.Text = "Giới Tính:";
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(232, 198);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(300, 39);
            tb_pass.TabIndex = 22;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(232, 119);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(300, 39);
            tb_name.TabIndex = 21;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(232, 43);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(300, 39);
            tb_id.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(113, 38);
            label4.TabIndex = 19;
            label4.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 198);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 18;
            label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(205, 38);
            label2.TabIndex = 17;
            label2.Text = "Mã Nhân Viên:";
            // 
            // gb_Info
            // 
            gb_Info.Controls.Add(tb_address);
            gb_Info.Controls.Add(textBox1);
            gb_Info.Controls.Add(tb_email);
            gb_Info.Controls.Add(label1);
            gb_Info.Controls.Add(cb_sex);
            gb_Info.Controls.Add(cb_role);
            gb_Info.Controls.Add(label8);
            gb_Info.Controls.Add(tb_pNumber);
            gb_Info.Controls.Add(label7);
            gb_Info.Controls.Add(dtp_birth);
            gb_Info.Controls.Add(label6);
            gb_Info.Controls.Add(label2);
            gb_Info.Controls.Add(label3);
            gb_Info.Controls.Add(label9);
            gb_Info.Controls.Add(label5);
            gb_Info.Controls.Add(label4);
            gb_Info.Controls.Add(tb_pass);
            gb_Info.Controls.Add(tb_id);
            gb_Info.Controls.Add(tb_name);
            gb_Info.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Info.Location = new Point(12, 50);
            gb_Info.Name = "gb_Info";
            gb_Info.Size = new Size(1173, 416);
            gb_Info.TabIndex = 25;
            gb_Info.TabStop = false;
            gb_Info.Text = "Thông Tin Nhân Viên";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(739, 279);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(415, 39);
            tb_address.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(739, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 39);
            textBox1.TabIndex = 31;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(739, 200);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(415, 39);
            tb_email.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(580, 282);
            label1.Name = "label1";
            label1.Size = new Size(114, 38);
            label1.TabIndex = 30;
            label1.Text = "Địa Chỉ:";
            // 
            // cb_sex
            // 
            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cb_sex.FormattingEnabled = true;
            cb_sex.Location = new Point(232, 283);
            cb_sex.Name = "cb_sex";
            cb_sex.Size = new Size(300, 44);
            cb_sex.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(580, 198);
            label8.Name = "label8";
            label8.Size = new Size(93, 38);
            label8.TabIndex = 30;
            label8.Text = "Email:";
            // 
            // tb_pNumber
            // 
            tb_pNumber.Location = new Point(739, 119);
            tb_pNumber.Name = "tb_pNumber";
            tb_pNumber.Size = new Size(415, 39);
            tb_pNumber.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(580, 120);
            label7.Name = "label7";
            label7.Size = new Size(74, 38);
            label7.TabIndex = 28;
            label7.Text = "SĐT:";
            // 
            // dtp_birth
            // 
            dtp_birth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dtp_birth.Location = new Point(739, 44);
            dtp_birth.Name = "dtp_birth";
            dtp_birth.Size = new Size(415, 35);
            dtp_birth.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(580, 45);
            label6.Name = "label6";
            label6.Size = new Size(153, 38);
            label6.TabIndex = 26;
            label6.Text = "Ngày Sinh:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 367);
            label9.Name = "label9";
            label9.Size = new Size(166, 38);
            label9.TabIndex = 23;
            label9.Text = "Phân quyền";
            // 
            // gb_Function
            // 
            gb_Function.Controls.Add(tb_find);
            gb_Function.Controls.Add(cb_find);
            gb_Function.Controls.Add(btn_add);
            gb_Function.Controls.Add(btn_edit);
            gb_Function.Controls.Add(button2);
            gb_Function.Controls.Add(btn_delete);
            gb_Function.Controls.Add(btn_reset);
            gb_Function.Controls.Add(btn_find);
            gb_Function.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_Function.Location = new Point(1191, 50);
            gb_Function.Name = "gb_Function";
            gb_Function.Size = new Size(445, 416);
            gb_Function.TabIndex = 27;
            gb_Function.TabStop = false;
            gb_Function.Text = "Chức Năng";
            // 
            // tb_find
            // 
            tb_find.Location = new Point(29, 347);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(284, 39);
            tb_find.TabIndex = 26;
            // 
            // cb_find
            // 
            cb_find.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_find.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cb_find.FormattingEnabled = true;
            cb_find.Location = new Point(29, 275);
            cb_find.Name = "cb_find";
            cb_find.Size = new Size(284, 46);
            cb_find.TabIndex = 25;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(29, 45);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(128, 49);
            btn_add.TabIndex = 22;
            btn_add.Text = "Thêm";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(185, 45);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(128, 49);
            btn_edit.TabIndex = 22;
            btn_edit.Text = "Sửa";
            btn_edit.TextAlign = ContentAlignment.MiddleRight;
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(29, 120);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(128, 49);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "Xoá";
            btn_delete.TextAlign = ContentAlignment.MiddleRight;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_find.Image = (Image)resources.GetObject("btn_find.Image");
            btn_find.ImageAlign = ContentAlignment.MiddleLeft;
            btn_find.Location = new Point(29, 200);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(128, 56);
            btn_find.TabIndex = 8;
            btn_find.Text = "Tìm";
            btn_find.TextAlign = ContentAlignment.MiddleRight;
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // gb_List
            // 
            gb_List.Controls.Add(ds_qlnv);
            gb_List.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gb_List.Location = new Point(12, 484);
            gb_List.Name = "gb_List";
            gb_List.Size = new Size(1789, 348);
            gb_List.TabIndex = 28;
            gb_List.TabStop = false;
            gb_List.Text = "Danh Sách Nhân Viên";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1813, 844);
            Controls.Add(gb_List);
            Controls.Add(gb_Function);
            Controls.Add(gb_Info);
            Controls.Add(lb_title);
            Name = "EmployeeForm";
            Text = "EmployeeManage";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)ds_qlnv).EndInit();
            gb_Info.ResumeLayout(false);
            gb_Info.PerformLayout();
            gb_Function.ResumeLayout(false);
            gb_Function.PerformLayout();
            gb_List.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private ComboBox cb_role;
        private DataGridView ds_qlnv;
        private Button btn_reset;
        private Label lb_title;
        private Label label5;
        private TextBox tb_pass;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox gb_Info;
        private TextBox tb_email;
        private Label label8;
        private TextBox tb_pNumber;
        private Label label7;
        private DateTimePicker dtp_birth;
        private Label label6;
        private GroupBox gb_Function;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_find;
        private GroupBox gb_List;
        private Button btn_add;
        private Label label1;
        private TextBox tb_address;
        private TextBox textBox1;
        private TextBox tb_find;
        private ComboBox cb_find;
        private Label label9;
        private ComboBox cb_sex;
    }
}