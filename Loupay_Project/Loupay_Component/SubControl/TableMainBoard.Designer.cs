namespace Loupay_Component.SubControl
{
    partial class TableMainBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_lamMoi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Thanhtoan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tienThanhToan = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.soMonDat = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableId = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableOrder1 = new Loupay_Component.SubControl.TableOrder();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupbox.Panel)).BeginInit();
            this.groupbox.Panel.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox
            // 
            this.groupbox.Location = new System.Drawing.Point(0, 0);
            this.groupbox.Name = "groupbox";
            // 
            // groupbox.Panel
            // 
            this.groupbox.Panel.Controls.Add(this.kryptonButton1);
            this.groupbox.Panel.Controls.Add(this.kryptonButton2);
            this.groupbox.Panel.Controls.Add(this.tableOrder1);
            this.groupbox.Panel.Controls.Add(this.btn_lamMoi);
            this.groupbox.Panel.Controls.Add(this.btn_Thanhtoan);
            this.groupbox.Panel.Controls.Add(this.tienThanhToan);
            this.groupbox.Panel.Controls.Add(this.kryptonLabel7);
            this.groupbox.Panel.Controls.Add(this.soMonDat);
            this.groupbox.Panel.Controls.Add(this.kryptonLabel5);
            this.groupbox.Panel.Controls.Add(this.tableStatus);
            this.groupbox.Panel.Controls.Add(this.kryptonLabel3);
            this.groupbox.Panel.Controls.Add(this.tableId);
            this.groupbox.Panel.Controls.Add(this.kryptonLabel1);
            this.groupbox.Size = new System.Drawing.Size(380, 615);
            this.groupbox.TabIndex = 0;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(279, 548);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(96, 36);
            this.btn_lamMoi.TabIndex = 12;
            this.btn_lamMoi.Values.Text = "Làm mới";
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_Thanhtoan
            // 
            this.btn_Thanhtoan.Location = new System.Drawing.Point(3, 548);
            this.btn_Thanhtoan.Name = "btn_Thanhtoan";
            this.btn_Thanhtoan.Size = new System.Drawing.Size(104, 36);
            this.btn_Thanhtoan.TabIndex = 9;
            this.btn_Thanhtoan.Values.Text = "Thanh toán";
            this.btn_Thanhtoan.Click += new System.EventHandler(this.btn_Thanhtoan_Click);
            // 
            // tienThanhToan
            // 
            this.tienThanhToan.Location = new System.Drawing.Point(189, 116);
            this.tienThanhToan.Name = "tienThanhToan";
            this.tienThanhToan.Size = new System.Drawing.Size(175, 31);
            this.tienThanhToan.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienThanhToan.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienThanhToan.TabIndex = 8;
            this.tienThanhToan.Values.Text = "THANH_TOAN";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(3, 123);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(92, 24);
            this.kryptonLabel7.TabIndex = 7;
            this.kryptonLabel7.Values.Text = "Thanh toán:";
            // 
            // soMonDat
            // 
            this.soMonDat.Location = new System.Drawing.Point(189, 79);
            this.soMonDat.Name = "soMonDat";
            this.soMonDat.Size = new System.Drawing.Size(177, 31);
            this.soMonDat.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soMonDat.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soMonDat.TabIndex = 6;
            this.soMonDat.Values.Text = "SO_MON_DAT";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 86);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(115, 24);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "Số món đã đặt:";
            // 
            // tableStatus
            // 
            this.tableStatus.Location = new System.Drawing.Point(189, 42);
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.Size = new System.Drawing.Size(164, 31);
            this.tableStatus.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableStatus.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableStatus.TabIndex = 4;
            this.tableStatus.Values.Text = "TRANG_THAI";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 49);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(84, 24);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Trạng thái:";
            // 
            // tableId
            // 
            this.tableId.Location = new System.Drawing.Point(189, 5);
            this.tableId.Name = "tableId";
            this.tableId.Size = new System.Drawing.Size(111, 31);
            this.tableId.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableId.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableId.TabIndex = 2;
            this.tableId.Values.Text = "MA_BAN";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(66, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Mã bàn:";
            // 
            // tableOrder1
            // 
            this.tableOrder1.AutoScroll = true;
            this.tableOrder1.Location = new System.Drawing.Point(7, 153);
            this.tableOrder1.Name = "tableOrder1";
            this.tableOrder1.Size = new System.Drawing.Size(366, 388);
            this.tableOrder1.TabIndex = 13;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(196, 548);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(77, 36);
            this.kryptonButton2.TabIndex = 15;
            this.kryptonButton2.Values.Text = "Gộp";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(113, 547);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(77, 36);
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Text = "Chuyển";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // TableMainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupbox);
            this.Name = "TableMainBoard";
            this.Size = new System.Drawing.Size(380, 615);
            ((System.ComponentModel.ISupportInitialize)(this.groupbox.Panel)).EndInit();
            this.groupbox.Panel.ResumeLayout(false);
            this.groupbox.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupbox)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox groupbox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel tableId;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel tienThanhToan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel soMonDat;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel tableStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Thanhtoan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_lamMoi;
        private TableOrder tableOrder1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
