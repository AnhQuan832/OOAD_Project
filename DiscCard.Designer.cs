namespace OOAD_Project
{
    partial class DiscCard
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
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubscribe = new Guna.UI2.WinForms.Guna2Button();
            this.pbDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(39, 361);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 32);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BorderRadius = 15;
            this.btnSubscribe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscribe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscribe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubscribe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubscribe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubscribe.ForeColor = System.Drawing.Color.White;
            this.btnSubscribe.Location = new System.Drawing.Point(48, 411);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(210, 45);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // pbDisc
            // 
            this.pbDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisc.BorderRadius = 5;
            this.pbDisc.ImageRotate = 0F;
            this.pbDisc.Location = new System.Drawing.Point(39, 25);
            this.pbDisc.Name = "pbDisc";
            this.pbDisc.Size = new System.Drawing.Size(234, 330);
            this.pbDisc.TabIndex = 1;
            this.pbDisc.TabStop = false;
            // 
            // DiscCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbDisc);
            this.Name = "DiscCard";
            this.Size = new System.Drawing.Size(312, 484);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbDisc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2Button btnSubscribe;
    }
}
