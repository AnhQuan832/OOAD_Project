namespace OOAD_Project
{
    partial class ShopItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItem));
            this.pbDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbGenre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDisc
            // 
            this.pbDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisc.BorderRadius = 5;
            this.pbDisc.ImageRotate = 0F;
            this.pbDisc.Location = new System.Drawing.Point(35, 31);
            this.pbDisc.Name = "pbDisc";
            this.pbDisc.Size = new System.Drawing.Size(170, 207);
            this.pbDisc.TabIndex = 0;
            this.pbDisc.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(21, 244);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbGenre
            // 
            this.lbGenre.BackColor = System.Drawing.Color.Transparent;
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGenre.Location = new System.Drawing.Point(21, 282);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(34, 15);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(185, 296);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(33, 32);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2CircleButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(21, 309);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(45, 27);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbDisc);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(240, 350);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbDisc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGenre;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
    }
}
