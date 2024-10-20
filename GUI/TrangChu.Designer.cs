namespace GUI
{
    partial class TrangChu
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
            this.btn_thucDon = new Guna.UI2.WinForms.Guna2Button();
            this.btn_banAn = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHienThi = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_thucDon
            // 
            this.btn_thucDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_thucDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thucDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thucDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thucDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thucDon.FillColor = System.Drawing.Color.Transparent;
            this.btn_thucDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thucDon.ForeColor = System.Drawing.Color.White;
            this.btn_thucDon.Location = new System.Drawing.Point(480, 0);
            this.btn_thucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thucDon.Name = "btn_thucDon";
            this.btn_thucDon.Size = new System.Drawing.Size(208, 66);
            this.btn_thucDon.TabIndex = 1;
            this.btn_thucDon.Text = "Thực đơn";
            this.btn_thucDon.Click += new System.EventHandler(this.btn_thucDon_Click);
            // 
            // btn_banAn
            // 
            this.btn_banAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_banAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_banAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_banAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_banAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_banAn.FillColor = System.Drawing.Color.Transparent;
            this.btn_banAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_banAn.ForeColor = System.Drawing.Color.White;
            this.btn_banAn.Location = new System.Drawing.Point(688, 2);
            this.btn_banAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_banAn.Name = "btn_banAn";
            this.btn_banAn.Size = new System.Drawing.Size(208, 66);
            this.btn_banAn.TabIndex = 2;
            this.btn_banAn.Text = "Bàn ăn";
            this.btn_banAn.Click += new System.EventHandler(this.btn_banAn_Click);
            // 
            // btn_hoaDon
            // 
            this.btn_hoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_hoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_hoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hoaDon.FillColor = System.Drawing.Color.Transparent;
            this.btn_hoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_hoaDon.Location = new System.Drawing.Point(895, 2);
            this.btn_hoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hoaDon.Name = "btn_hoaDon";
            this.btn_hoaDon.Size = new System.Drawing.Size(208, 66);
            this.btn_hoaDon.TabIndex = 3;
            this.btn_hoaDon.Text = "Hóa đơn";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.btn_hoaDon);
            this.guna2Panel1.Controls.Add(this.btn_banAn);
            this.guna2Panel1.Controls.Add(this.btn_thucDon);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1581, 66);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(0, 66);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(1581, 797);
            this.panelHienThi.TabIndex = 1;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 863);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_thucDon;
        private Guna.UI2.WinForms.Guna2Button btn_banAn;
        private Guna.UI2.WinForms.Guna2Button btn_hoaDon;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelHienThi;
    }
}