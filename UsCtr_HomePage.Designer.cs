namespace OOAD_Project
{
    partial class UsCtr_HomePage
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
            this.pnCardView = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // pnCardView
            // 
            this.pnCardView.AutoScroll = true;
            this.pnCardView.BorderRadius = 10;
            this.pnCardView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCardView.Location = new System.Drawing.Point(0, 0);
            this.pnCardView.Name = "pnCardView";
            this.pnCardView.Size = new System.Drawing.Size(1692, 442);
            this.pnCardView.TabIndex = 0;
            // 
            // UsCtr_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCardView);
            this.Name = "UsCtr_HomePage";
            this.Size = new System.Drawing.Size(1692, 971);
            this.Load += new System.EventHandler(this.UsCtr_HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCardView;
    }
}
