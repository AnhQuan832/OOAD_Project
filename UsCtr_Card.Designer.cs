namespace OOAD_Project
{
    partial class UsCtr_Card
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
            this.pbDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnRegist = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(37, 302);
            this.lbName.Margin = new System.Windows.Forms.Padding(4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 38);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // pbDisc
            // 
            this.pbDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisc.BorderRadius = 5;
            this.pbDisc.ImageRotate = 0F;
            this.pbDisc.Location = new System.Drawing.Point(37, 39);
            this.pbDisc.Margin = new System.Windows.Forms.Padding(4);
            this.pbDisc.Name = "pbDisc";
            this.pbDisc.Size = new System.Drawing.Size(242, 255);
            this.pbDisc.TabIndex = 2;
            this.pbDisc.TabStop = false;
            // 
            // btnRegist
            // 
            this.btnRegist.BorderRadius = 12;
            this.btnRegist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRegist.ForeColor = System.Drawing.Color.White;
            this.btnRegist.Location = new System.Drawing.Point(37, 363);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(242, 45);
            this.btnRegist.TabIndex = 4;
            this.btnRegist.Text = "Regist";
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // UsCtr_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbDisc);
            this.Name = "UsCtr_Card";
            this.Size = new System.Drawing.Size(320, 431);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2PictureBox pbDisc;
        private Guna.UI2.WinForms.Guna2Button btnRegist;
    }
}
