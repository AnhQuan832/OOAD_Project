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
            this.pnCardView.AutoSize = true;
            this.pnCardView.BorderColor = System.Drawing.Color.Navy;
            this.pnCardView.BorderRadius = 20;
            this.pnCardView.BorderThickness = 2;
            this.pnCardView.Location = new System.Drawing.Point(24, 0);
            this.pnCardView.Name = "pnCardView";
            this.pnCardView.Size = new System.Drawing.Size(1213, 503);
            this.pnCardView.TabIndex = 0;
            // 
            // UsCtr_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCardView);
            this.Name = "UsCtr_HomePage";
            this.Size = new System.Drawing.Size(1269, 789);
            this.Load += new System.EventHandler(this.UsCtr_HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCardView;
    }
}
