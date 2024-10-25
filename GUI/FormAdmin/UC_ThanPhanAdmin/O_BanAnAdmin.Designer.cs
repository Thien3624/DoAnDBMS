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
            // O_BanAnAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_maBan);
            this.Name = "O_BanAnAdmin";
            this.Size = new System.Drawing.Size(300, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_maBan;
    }
}
