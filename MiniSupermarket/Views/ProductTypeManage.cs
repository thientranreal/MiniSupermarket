﻿using MiniSupermarket.Controllers;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.Views
{
    public partial class ProductTypeManage : Form
    {
        // khai bao controller
        private ProductTypeController ptController = new ProductTypeController();
        public ProductTypeManage()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            lb_QLLSP.Font = ProjectFont.getTitleFont();
            txt_idType.Font = ProjectFont.getNormalFont();
            txt_nameType.Font = ProjectFont.getNormalFont();
            txt_search.Font = ProjectFont.getNormalFont();
            lb_idType.Font = ProjectFont.getNormalFont();
            lb_typeName.Font = ProjectFont.getNormalFont();
            cb_search.Font = ProjectFont.getNormalFont();
            //
            cb_search.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_search.Items.Add("Mã loại");
            cb_search.Items.Add("Tên loại");
            cb_search.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dgv_qllsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tải dữ liệu lên data grid view
            dgv_qllsp.DataSource = ptController.getAllProducts();

            // Chỉ cho đọc data grid view
            dgv_qllsp.ReadOnly = true;

            // Đổi tên cột
            dgv_qllsp.Columns["TypeID"].HeaderText = "Mã loại";
            dgv_qllsp.Columns["Name"].HeaderText = "Tên loại";

            // Đổi màu mặc định của data grid view
            dgv_qllsp.BackgroundColor = Color.White;
           

        }
    }
}
