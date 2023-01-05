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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnCardView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCardView
            // 
            this.pnCardView.AutoSize = true;
            this.pnCardView.BorderColor = System.Drawing.Color.Navy;
            this.pnCardView.BorderRadius = 20;
            this.pnCardView.BorderThickness = 2;
            this.pnCardView.Controls.Add(this.guna2HtmlLabel1);
            this.pnCardView.Location = new System.Drawing.Point(33, 38);
            this.pnCardView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCardView.Name = "pnCardView";
            this.pnCardView.Size = new System.Drawing.Size(1632, 619);
            this.pnCardView.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(613, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(365, 83);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Coming soon";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(63, 799);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(1360, 83);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Subscribe to get an email as soon as it comes out!";
            // 
            // UsCtr_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.pnCardView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsCtr_HomePage";
            this.Size = new System.Drawing.Size(1692, 971);
            this.Load += new System.EventHandler(this.UsCtr_HomePage_Load);
            this.pnCardView.ResumeLayout(false);
            this.pnCardView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCardView;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
