namespace GUI.UC_ThanhPhan
{
    partial class O_MonAn
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
            this.picb_anhMonAn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lb_tenMonAn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_giaMonAn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_datMon = new Guna.UI2.WinForms.Guna2Button();
            this.numeric_soLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picb_anhMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_soLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_anhMonAn
            // 
            this.picb_anhMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.picb_anhMonAn.ImageRotate = 0F;
            this.picb_anhMonAn.Location = new System.Drawing.Point(0, 0);
            this.picb_anhMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.picb_anhMonAn.Name = "picb_anhMonAn";
            this.picb_anhMonAn.Size = new System.Drawing.Size(329, 248);
            this.picb_anhMonAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_anhMonAn.TabIndex = 0;
            this.picb_anhMonAn.TabStop = false;
            // 
            // lb_tenMonAn
            // 
            this.lb_tenMonAn.AutoSize = false;
            this.lb_tenMonAn.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenMonAn.Location = new System.Drawing.Point(0, 255);
            this.lb_tenMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.lb_tenMonAn.Name = "lb_tenMonAn";
            this.lb_tenMonAn.Size = new System.Drawing.Size(329, 46);
            this.lb_tenMonAn.TabIndex = 1;
            this.lb_tenMonAn.Text = "Tên món ăn";
            this.lb_tenMonAn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_giaMonAn
            // 
            this.lb_giaMonAn.AutoSize = false;
            this.lb_giaMonAn.BackColor = System.Drawing.Color.Transparent;
            this.lb_giaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giaMonAn.Location = new System.Drawing.Point(0, 308);
            this.lb_giaMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.lb_giaMonAn.Name = "lb_giaMonAn";
            this.lb_giaMonAn.Size = new System.Drawing.Size(329, 46);
            this.lb_giaMonAn.TabIndex = 2;
            this.lb_giaMonAn.Text = "Giá món ăn";
            this.lb_giaMonAn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_datMon
            // 
            this.btn_datMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_datMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_datMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_datMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_datMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_datMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_datMon.ForeColor = System.Drawing.Color.White;
            this.btn_datMon.Location = new System.Drawing.Point(4, 375);
            this.btn_datMon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_datMon.Name = "btn_datMon";
            this.btn_datMon.Size = new System.Drawing.Size(124, 55);
            this.btn_datMon.TabIndex = 3;
            this.btn_datMon.Text = "Đặt món";
            // 
            // numeric_soLuong
            // 
            this.numeric_soLuong.BackColor = System.Drawing.Color.Transparent;
            this.numeric_soLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numeric_soLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numeric_soLuong.Location = new System.Drawing.Point(215, 375);
            this.numeric_soLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeric_soLuong.Name = "numeric_soLuong";
            this.numeric_soLuong.Size = new System.Drawing.Size(114, 55);
            this.numeric_soLuong.TabIndex = 4;
            this.numeric_soLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // O_MonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numeric_soLuong);
            this.Controls.Add(this.btn_datMon);
            this.Controls.Add(this.lb_giaMonAn);
            this.Controls.Add(this.lb_tenMonAn);
            this.Controls.Add(this.picb_anhMonAn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "O_MonAn";
            this.Size = new System.Drawing.Size(329, 434);
            ((System.ComponentModel.ISupportInitialize)(this.picb_anhMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_soLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picb_anhMonAn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_tenMonAn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_giaMonAn;
        private Guna.UI2.WinForms.Guna2Button btn_datMon;
        private Guna.UI2.WinForms.Guna2NumericUpDown numeric_soLuong;
    }
}
