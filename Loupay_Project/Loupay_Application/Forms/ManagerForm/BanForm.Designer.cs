
namespace Loupay_Application.Forms.ManagerForm
{
    partial class BanForm
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
            this.pnlLeft = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtMKV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTKV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddKV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboKV = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtIDBan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnAddBan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvKV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvBan = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboTrangThai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.contextDGVBan = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.contextDGVKhuVuc = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.kryptonGroupBox2);
            this.pnlLeft.Controls.Add(this.kryptonGroupBox1);
            this.pnlLeft.Location = new System.Drawing.Point(12, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(442, 548);
            this.pnlLeft.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnAddKV);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTKV);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtMKV);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(436, 260);
            this.kryptonGroupBox1.TabIndex = 4;
            this.kryptonGroupBox1.Values.Heading = "Khu vực";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(3, 269);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.cboTrangThai);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnAddBan);
            this.kryptonGroupBox2.Panel.Controls.Add(this.cboKV);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtIDBan);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(439, 276);
            this.kryptonGroupBox2.TabIndex = 5;
            this.kryptonGroupBox2.Values.Heading = "Bàn";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(52, 34);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Mã khu vực";
            // 
            // txtMKV
            // 
            this.txtMKV.Location = new System.Drawing.Point(228, 31);
            this.txtMKV.Name = "txtMKV";
            this.txtMKV.Size = new System.Drawing.Size(127, 23);
            this.txtMKV.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(52, 90);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Tên khu vực";
            // 
            // txtTKV
            // 
            this.txtTKV.Location = new System.Drawing.Point(228, 87);
            this.txtTKV.Name = "txtTKV";
            this.txtTKV.Size = new System.Drawing.Size(127, 23);
            this.txtTKV.TabIndex = 1;
            // 
            // btnAddKV
            // 
            this.btnAddKV.Location = new System.Drawing.Point(166, 162);
            this.btnAddKV.Name = "btnAddKV";
            this.btnAddKV.Size = new System.Drawing.Size(90, 50);
            this.btnAddKV.TabIndex = 2;
            this.btnAddKV.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAddKV.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAddKV.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAddKV.Values.ImageStates.ImagePressed = global::Loupay_Application.Properties.Resources.add;
            this.btnAddKV.Values.Text = "Thêm khu vực";
            this.btnAddKV.Click += new System.EventHandler(this.btnAddKV_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(52, 33);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "Khu vực";
            // 
            // cboKV
            // 
            this.cboKV.DropDownWidth = 127;
            this.cboKV.Location = new System.Drawing.Point(228, 33);
            this.cboKV.Name = "cboKV";
            this.cboKV.Size = new System.Drawing.Size(127, 21);
            this.cboKV.TabIndex = 1;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(52, 90);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel4.TabIndex = 0;
            this.kryptonLabel4.Values.Text = "Mã bàn";
            // 
            // txtIDBan
            // 
            this.txtIDBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtIDBan.Location = new System.Drawing.Point(228, 90);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(127, 23);
            this.txtIDBan.TabIndex = 1;
            // 
            // btnAddBan
            // 
            this.btnAddBan.Location = new System.Drawing.Point(166, 182);
            this.btnAddBan.Name = "btnAddBan";
            this.btnAddBan.Size = new System.Drawing.Size(90, 50);
            this.btnAddBan.TabIndex = 2;
            this.btnAddBan.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAddBan.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAddBan.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAddBan.Values.ImageStates.ImagePressed = global::Loupay_Application.Properties.Resources.add;
            this.btnAddBan.Values.Text = "Thêm bàn";
            this.btnAddBan.Click += new System.EventHandler(this.btnAddBan_Click);
            // 
            // dgvKV
            // 
            this.dgvKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKV.Location = new System.Drawing.Point(460, 1);
            this.dgvKV.Name = "dgvKV";
            this.dgvKV.Size = new System.Drawing.Size(260, 548);
            this.dgvKV.TabIndex = 1;
            // 
            // dgvBan
            // 
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Location = new System.Drawing.Point(726, 1);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(346, 548);
            this.dgvBan.TabIndex = 1;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(52, 142);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel5.TabIndex = 0;
            this.kryptonLabel5.Values.Text = "Mã bàn";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownWidth = 127;
            this.cboTrangThai.Location = new System.Drawing.Point(228, 141);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(127, 21);
            this.cboTrangThai.TabIndex = 3;
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.dgvKV);
            this.Controls.Add(this.pnlLeft);
            this.Name = "BanForm";
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 0;
            this.Text = "BanForm";
            this.Load += new System.EventHandler(this.BanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboKV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTrangThai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlLeft;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTKV;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMKV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddKV;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboKV;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIDBan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddBan;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvKV;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvBan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTrangThai;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu contextDGVBan;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu contextDGVKhuVuc;
    }
}