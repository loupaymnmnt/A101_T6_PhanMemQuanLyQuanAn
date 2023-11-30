namespace Loupay_Component.SubControl
{
    partial class OrderedDish
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
            this.label_tenmon = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label_price = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_tenmon
            // 
            this.label_tenmon.Location = new System.Drawing.Point(79, 12);
            this.label_tenmon.MaximumSize = new System.Drawing.Size(180, 0);
            this.label_tenmon.Name = "label_tenmon";
            this.label_tenmon.Size = new System.Drawing.Size(82, 24);
            this.label_tenmon.TabIndex = 0;
            this.label_tenmon.Values.Text = "TEN_MON";
            // 
            // nud_soluong
            // 
            this.nud_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_soluong.Location = new System.Drawing.Point(308, 9);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(41, 27);
            this.nud_soluong.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(272, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(30, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "SL:";
            // 
            // label_price
            // 
            this.label_price.Location = new System.Drawing.Point(218, 42);
            this.label_price.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(131, 28);
            this.label_price.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.label_price.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.TabIndex = 3;
            this.label_price.Values.Text = "TONG_TIEN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // OrderedDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.nud_soluong);
            this.Controls.Add(this.label_tenmon);
            this.Name = "OrderedDish";
            this.Size = new System.Drawing.Size(366, 75);
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel label_tenmon;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label_price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
