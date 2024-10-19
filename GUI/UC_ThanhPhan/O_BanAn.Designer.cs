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
            this.SuspendLayout();
            // 
            // lb_maBan
            // 
            this.lb_maBan.AutoSize = false;
            this.lb_maBan.BackColor = System.Drawing.Color.Green;
            this.lb_maBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maBan.Location = new System.Drawing.Point(0, 0);
            this.lb_maBan.Name = "lb_maBan";
            this.lb_maBan.Size = new System.Drawing.Size(306, 198);
            this.lb_maBan.TabIndex = 0;
            this.lb_maBan.Text = "Bàn 01";
            this.lb_maBan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // O_BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_maBan);
            this.Name = "O_BanAn";
            this.Size = new System.Drawing.Size(306, 198);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_maBan;
    }
}
