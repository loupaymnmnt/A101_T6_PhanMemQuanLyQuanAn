namespace Loupay_Application.Forms.MainForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.quảnLýToolStripMenuItem1,
            this.quảnLýMónToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.càiĐặtỨngDụngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Image = global::Loupay_Application.Properties.Resources.userIcon;
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Image = global::Loupay_Application.Properties.Resources.importIcon;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý nhập xuất";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.Image = global::Loupay_Application.Properties.Resources.tableIcon;
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.quảnLýToolStripMenuItem1.Text = "Quản lý bàn ăn";
            // 
            // quảnLýMónToolStripMenuItem
            // 
            this.quảnLýMónToolStripMenuItem.Image = global::Loupay_Application.Properties.Resources.foodanddrinkIcon;
            this.quảnLýMónToolStripMenuItem.Name = "quảnLýMónToolStripMenuItem";
            this.quảnLýMónToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quảnLýMónToolStripMenuItem.Text = "Quản lý món";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Image = global::Loupay_Application.Properties.Resources.reportIcon;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // càiĐặtỨngDụngToolStripMenuItem
            // 
            this.càiĐặtỨngDụngToolStripMenuItem.Image = global::Loupay_Application.Properties.Resources.settingsIcon;
            this.càiĐặtỨngDụngToolStripMenuItem.Name = "càiĐặtỨngDụngToolStripMenuItem";
            this.càiĐặtỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.càiĐặtỨngDụngToolStripMenuItem.Text = "Cài đặt ứng dụng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 0;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtỨngDụngToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
