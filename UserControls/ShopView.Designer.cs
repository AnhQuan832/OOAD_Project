namespace OOAD_Project
{
    partial class ShopView
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnView = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tbxSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1270, 68);
            this.guna2Panel1.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbxSearch.BorderRadius = 10;
            this.tbxSearch.BorderThickness = 2;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.Black;
            this.tbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.IconRight = global::OOAD_Project.Properties.Resources.search_icon;
            this.tbxSearch.IconRightOffset = new System.Drawing.Point(13, 0);
            this.tbxSearch.IconRightSize = new System.Drawing.Size(25, 25);
            this.tbxSearch.Location = new System.Drawing.Point(780, 8);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderText = "Search";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.ShadowDecoration.BorderRadius = 200;
            this.tbxSearch.Size = new System.Drawing.Size(421, 48);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            // 
            // pnView
            // 
            this.pnView.AutoScroll = true;
            this.pnView.BackColor = System.Drawing.Color.Transparent;
            this.pnView.BorderRadius = 30;
            this.pnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnView.Location = new System.Drawing.Point(0, 68);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1270, 692);
            this.pnView.TabIndex = 1;
            // 
            // ShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ShopView";
            this.Size = new System.Drawing.Size(1270, 760);
            this.Load += new System.EventHandler(this.ShopView_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnView;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
    }
}
