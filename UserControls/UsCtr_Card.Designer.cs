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
            this.pbDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubscribe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnJustify = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDisc
            // 
            this.pbDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisc.BorderRadius = 5;
            this.pbDisc.ImageRotate = 0F;
            this.pbDisc.Location = new System.Drawing.Point(64, 31);
            this.pbDisc.Margin = new System.Windows.Forms.Padding(4);
            this.pbDisc.Name = "pbDisc";
            this.pbDisc.Size = new System.Drawing.Size(227, 273);
            this.pbDisc.TabIndex = 1;
            this.pbDisc.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.lbName.Location = new System.Drawing.Point(64, 322);
            this.lbName.Margin = new System.Windows.Forms.Padding(4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(71, 38);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BorderRadius = 15;
            this.btnSubscribe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubscribe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscribe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubscribe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubscribe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubscribe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnSubscribe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubscribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btnSubscribe.Location = new System.Drawing.Point(64, 391);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(240, 55);
            this.btnSubscribe.TabIndex = 3;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnJustify);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(361, 469);
            this.guna2Panel1.TabIndex = 4;
            // 
            // btnJustify
            // 
            this.btnJustify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJustify.BackColor = System.Drawing.Color.Transparent;
            this.btnJustify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustify.FlatAppearance.BorderSize = 0;
            this.btnJustify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustify.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnJustify.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnJustify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJustify.IconSize = 28;
            this.btnJustify.Location = new System.Drawing.Point(322, 10);
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(28, 28);
            this.btnJustify.TabIndex = 1;
            this.btnJustify.UseVisualStyleBackColor = false;
            this.btnJustify.Click += new System.EventHandler(this.btnJustify_Click);
            // 
            // UsCtr_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbDisc);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsCtr_Card";
            this.Size = new System.Drawing.Size(361, 469);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbDisc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2Button btnSubscribe;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnJustify;
    }
}
