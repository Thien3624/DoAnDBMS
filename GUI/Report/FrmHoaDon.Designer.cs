namespace GUI.Report
{
    partial class FrmHoaDon
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
            this.viewHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // viewHoaDon
            // 
            this.viewHoaDon.ActiveViewIndex = -1;
            this.viewHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHoaDon.Location = new System.Drawing.Point(0, 0);
            this.viewHoaDon.Name = "viewHoaDon";
            this.viewHoaDon.Size = new System.Drawing.Size(766, 516);
            this.viewHoaDon.TabIndex = 0;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 516);
            this.Controls.Add(this.viewHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHoaDon";
            this.Text = "Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer viewHoaDon;
    }
}