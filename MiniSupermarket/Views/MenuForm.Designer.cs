namespace MiniSupermarket
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
            pnl_top = new Panel();
            pnl_feature = new Panel();
            SuspendLayout();
            // 
            // pnl_top
            // 
            pnl_top.Dock = DockStyle.Top;
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(1101, 101);
            pnl_top.TabIndex = 0;
            // 
            // pnl_feature
            // 
            pnl_feature.Dock = DockStyle.Fill;
            pnl_feature.Location = new Point(0, 101);
            pnl_feature.Name = "pnl_feature";
            pnl_feature.Size = new Size(1101, 555);
            pnl_feature.TabIndex = 1;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 656);
            Controls.Add(pnl_feature);
            Controls.Add(pnl_top);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_top;
        private Panel pnl_feature;
    }
}