namespace GUI.FormAdmin.UC_ThanPhanAdmin
{
    partial class O_BanAnAdmin
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
            this.lb_maBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_xoaBanAn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_maBan
            // 
            this.lb_maBan.BackColor = System.Drawing.Color.Transparent;
            this.lb_maBan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maBan.ForeColor = System.Drawing.Color.White;
            this.lb_maBan.Location = new System.Drawing.Point(90, 81);
            this.lb_maBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_maBan.Name = "lb_maBan";
            this.lb_maBan.Size = new System.Drawing.Size(109, 47);
            this.lb_maBan.TabIndex = 4;
            this.lb_maBan.Text = "Bàn 01";
            this.lb_maBan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btn_xoaBanAn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 205);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(300, 100);
            this.guna2Panel1.TabIndex = 14;
            // 
            // btn_xoaBanAn
            // 
            this.btn_xoaBanAn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaBanAn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaBanAn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoaBanAn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoaBanAn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xoaBanAn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoaBanAn.ForeColor = System.Drawing.Color.White;
            this.btn_xoaBanAn.Location = new System.Drawing.Point(90, 30);
            this.btn_xoaBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoaBanAn.Name = "btn_xoaBanAn";
            this.btn_xoaBanAn.Size = new System.Drawing.Size(109, 55);
            this.btn_xoaBanAn.TabIndex = 14;
            this.btn_xoaBanAn.Text = "Xóa";
            // 
            // O_BanAnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lb_maBan);
            this.Name = "O_BanAnAdmin";
            this.Size = new System.Drawing.Size(300, 305);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_maBan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_xoaBanAn;
    }
}
