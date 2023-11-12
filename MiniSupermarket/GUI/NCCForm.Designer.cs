namespace MiniSupermarket.GUI
{
    partial class NCCForm
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
            customDateTimePicker1 = new CustomControl.CustomDateTimePicker();
            customDateTimePicker2 = new CustomControl.CustomDateTimePicker();
            customDateTimePicker3 = new CustomControl.CustomDateTimePicker();
            SuspendLayout();
            // 
            // customDateTimePicker1
            // 
            customDateTimePicker1.BorderColor = Color.PaleVioletRed;
            customDateTimePicker1.BorderSize = 0;
            customDateTimePicker1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customDateTimePicker1.Location = new Point(361, 193);
            customDateTimePicker1.MinimumSize = new Size(0, 35);
            customDateTimePicker1.Name = "customDateTimePicker1";
            customDateTimePicker1.Size = new Size(221, 35);
            customDateTimePicker1.SkinColor = Color.MediumSlateBlue;
            customDateTimePicker1.TabIndex = 0;
            customDateTimePicker1.TextColor = Color.White;
            // 
            // customDateTimePicker2
            // 
            customDateTimePicker2.BorderColor = Color.PaleVioletRed;
            customDateTimePicker2.BorderSize = 0;
            customDateTimePicker2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customDateTimePicker2.Location = new Point(295, 86);
            customDateTimePicker2.MinimumSize = new Size(0, 35);
            customDateTimePicker2.Name = "customDateTimePicker2";
            customDateTimePicker2.Size = new Size(200, 35);
            customDateTimePicker2.SkinColor = Color.MediumSlateBlue;
            customDateTimePicker2.TabIndex = 1;
            customDateTimePicker2.TextColor = Color.White;
            // 
            // customDateTimePicker3
            // 
            customDateTimePicker3.BorderColor = Color.PaleVioletRed;
            customDateTimePicker3.BorderSize = 0;
            customDateTimePicker3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            customDateTimePicker3.Location = new Point(551, 276);
            customDateTimePicker3.MinimumSize = new Size(0, 35);
            customDateTimePicker3.Name = "customDateTimePicker3";
            customDateTimePicker3.Size = new Size(200, 35);
            customDateTimePicker3.SkinColor = Color.GhostWhite;
            customDateTimePicker3.TabIndex = 2;
            customDateTimePicker3.TextColor = Color.Black;
            // 
            // NCCForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(customDateTimePicker3);
            Controls.Add(customDateTimePicker2);
            Controls.Add(customDateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NCCForm";
            Text = "Form Nha cung cap";
            Load += NCCForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private CustomControl.CustomDateTimePicker customDateTimePicker1;
        private CustomControl.CustomDateTimePicker customDateTimePicker2;
        private CustomControl.CustomDateTimePicker customDateTimePicker3;
    }
}