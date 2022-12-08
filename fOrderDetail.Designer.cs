namespace OOAD_Project
{
    partial class fOrderDetail
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnviewOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.BorderRadius = 20;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1207, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnviewOrder
            // 
            this.pnviewOrder.BackColor = System.Drawing.Color.Transparent;
            this.pnviewOrder.BorderRadius = 10;
            this.pnviewOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnviewOrder.Location = new System.Drawing.Point(0, 35);
            this.pnviewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnviewOrder.Name = "pnviewOrder";
            this.pnviewOrder.Size = new System.Drawing.Size(1240, 533);
            this.pnviewOrder.TabIndex = 22;
            // 
            // fOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 568);
            this.Controls.Add(this.pnviewOrder);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fOrderDetail";
            this.Load += new System.EventHandler(this.fOrderDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private UsCtr_OrderDetail usCtr_OrderDetail1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Panel pnviewOrder;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}