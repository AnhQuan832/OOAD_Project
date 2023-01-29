namespace OOAD_Project
{
    partial class UsCtr_Cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Disc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtRent = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDeposite = new System.Windows.Forms.Label();
            this.lbRentPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.messsageBox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCart
            // 
            this.gvCart.AllowUserToAddRows = false;
            this.gvCart.AllowUserToDeleteRows = false;
            this.gvCart.AllowUserToResizeColumns = false;
            this.gvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvCart.ColumnHeadersHeight = 50;
            this.gvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Disc_Name,
            this.Amount,
            this.Price_day,
            this.Total_price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCart.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvCart.Location = new System.Drawing.Point(18, 28);
            this.gvCart.MultiSelect = false;
            this.gvCart.Name = "gvCart";
            this.gvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvCart.RowHeadersVisible = false;
            this.gvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gvCart.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvCart.RowTemplate.DividerHeight = 1;
            this.gvCart.RowTemplate.Height = 210;
            this.gvCart.RowTemplate.ReadOnly = true;
            this.gvCart.Size = new System.Drawing.Size(862, 788);
            this.gvCart.TabIndex = 1;
            this.gvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvCart.ThemeStyle.HeaderStyle.Height = 50;
            this.gvCart.ThemeStyle.ReadOnly = false;
            this.gvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvCart.ThemeStyle.RowsStyle.Height = 210;
            this.gvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            this.Image.DefaultCellStyle = dataGridViewCellStyle3;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 175;
            // 
            // Disc_Name
            // 
            this.Disc_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Disc_Name.DataPropertyName = "DISC_NAME";
            this.Disc_Name.FillWeight = 191.0627F;
            this.Disc_Name.HeaderText = "Disc Name";
            this.Disc_Name.MinimumWidth = 6;
            this.Disc_Name.Name = "Disc_Name";
            this.Disc_Name.ReadOnly = true;
            this.Disc_Name.Width = 270;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "AMOUNT";
            this.Amount.FillWeight = 8.529577F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Amount.Width = 80;
            // 
            // Price_day
            // 
            this.Price_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price_day.DataPropertyName = "DISC_PRICE";
            this.Price_day.FillWeight = 8.529577F;
            this.Price_day.HeaderText = "Price per day";
            this.Price_day.MinimumWidth = 6;
            this.Price_day.Name = "Price_day";
            this.Price_day.ReadOnly = true;
            this.Price_day.Width = 170;
            // 
            // Total_price
            // 
            this.Total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total_price.DataPropertyName = "TOTAL";
            this.Total_price.HeaderText = "Total Price";
            this.Total_price.MinimumWidth = 6;
            this.Total_price.Name = "Total_price";
            this.Total_price.ReadOnly = true;
            this.Total_price.Width = 180;
            // 
            // dtDue
            // 
            this.dtDue.AutoRoundedCorners = true;
            this.dtDue.BackColor = System.Drawing.Color.Transparent;
            this.dtDue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.dtDue.BorderRadius = 19;
            this.dtDue.Checked = true;
            this.dtDue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtDue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.dtDue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtDue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDue.Location = new System.Drawing.Point(942, 268);
            this.dtDue.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDue.MinDate = new System.DateTime(2023, 1, 28, 0, 0, 0, 0);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(271, 41);
            this.dtDue.TabIndex = 6;
            this.dtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtDue.Value = new System.DateTime(2023, 1, 28, 0, 0, 0, 0);
            this.dtDue.ValueChanged += new System.EventHandler(this.dtDue_ValueChanged);
            // 
            // dtRent
            // 
            this.dtRent.AutoRoundedCorners = true;
            this.dtRent.BackColor = System.Drawing.Color.Transparent;
            this.dtRent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.dtRent.BorderRadius = 19;
            this.dtRent.Checked = true;
            this.dtRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtRent.Enabled = false;
            this.dtRent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.dtRent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtRent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRent.Location = new System.Drawing.Point(942, 170);
            this.dtRent.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtRent.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtRent.Name = "dtRent";
            this.dtRent.Size = new System.Drawing.Size(271, 41);
            this.dtRent.TabIndex = 7;
            this.dtRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtRent.Value = new System.DateTime(2023, 1, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(950, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(950, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rent Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(878, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Deposit (30.000VND/Disc):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDeposite
            // 
            this.lbDeposite.AutoSize = true;
            this.lbDeposite.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.lbDeposite.Location = new System.Drawing.Point(1088, 603);
            this.lbDeposite.Name = "lbDeposite";
            this.lbDeposite.Size = new System.Drawing.Size(164, 30);
            this.lbDeposite.TabIndex = 9;
            this.lbDeposite.Text = "xx.xxx.xxx VND";
            // 
            // lbRentPrice
            // 
            this.lbRentPrice.AutoSize = true;
            this.lbRentPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRentPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRentPrice.Location = new System.Drawing.Point(1088, 568);
            this.lbRentPrice.Name = "lbRentPrice";
            this.lbRentPrice.Size = new System.Drawing.Size(136, 25);
            this.lbRentPrice.TabIndex = 10;
            this.lbRentPrice.Text = "xx.xxx.xxx VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(878, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rent Price:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 15;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(933, 667);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(291, 49);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // messsageBox
            // 
            this.messsageBox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messsageBox.Caption = "Your order ID is";
            this.messsageBox.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messsageBox.Parent = null;
            this.messsageBox.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messsageBox.Text = null;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(942, 71);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(271, 49);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UsCtr_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDeposite);
            this.Controls.Add(this.lbRentPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDue);
            this.Controls.Add(this.dtRent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gvCart);
            this.Name = "UsCtr_Cart";
            this.Size = new System.Drawing.Size(1269, 789);
            this.Load += new System.EventHandler(this.UsCtr_Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gvCart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDue;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDeposite;
        private System.Windows.Forms.Label lbRentPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2MessageDialog messsageBox;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}
