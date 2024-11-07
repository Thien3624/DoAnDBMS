namespace GUI.UC_ThanhPhan
{
    partial class O_BanAn
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
            this.lb_banAn = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lb_maBan
            // 
            this.lb_maBan.BackColor = System.Drawing.Color.Transparent;
            this.lb_maBan.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maBan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_maBan.Location = new System.Drawing.Point(73, 92);
            this.lb_maBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_maBan.Name = "lb_maBan";
            this.lb_maBan.Size = new System.Drawing.Size(109, 47);
            this.lb_maBan.TabIndex = 1;
            this.lb_maBan.Text = "Bàn 01";
            this.lb_maBan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_banAn
            // 
            this.lb_banAn.AutoSize = false;
            this.lb_banAn.BackColor = System.Drawing.Color.Transparent;
            this.lb_banAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_banAn.Location = new System.Drawing.Point(0, 0);
            this.lb_banAn.Margin = new System.Windows.Forms.Padding(4);
            this.lb_banAn.Name = "lb_banAn";
            this.lb_banAn.Size = new System.Drawing.Size(255, 231);
            this.lb_banAn.TabIndex = 0;
            this.lb_banAn.Text = null;
            this.lb_banAn.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_banAn.Click += new System.EventHandler(this.lb_banAn_Click);
            // 
            // O_BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_maBan);
            this.Controls.Add(this.lb_banAn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "O_BanAn";
            this.Size = new System.Drawing.Size(255, 231);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_maBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_banAn;
    }
}
