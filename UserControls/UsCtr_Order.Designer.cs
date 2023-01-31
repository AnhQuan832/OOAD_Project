namespace OOAD_Project
{
    partial class UsCtr_Order
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cus_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gvOrder
            // 
            this.gvOrder.AllowUserToAddRows = false;
            this.gvOrder.AllowUserToDeleteRows = false;
            this.gvOrder.AllowUserToResizeColumns = false;
            this.gvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.gvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvOrder.ColumnHeadersHeight = 50;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cus_name,
            this.Rent_Date,
            this.Due_Date,
            this.Deposit,
            this.Total_Price,
            this.Status});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvOrder.DefaultCellStyle = dataGridViewCellStyle13;
            this.gvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.Location = new System.Drawing.Point(16, 105);
            this.gvOrder.MultiSelect = false;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvOrder.RowHeadersVisible = false;
            this.gvOrder.RowHeadersWidth = 51;
            this.gvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gvOrder.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gvOrder.RowTemplate.DividerHeight = 1;
            this.gvOrder.RowTemplate.Height = 70;
            this.gvOrder.Size = new System.Drawing.Size(1240, 744);
            this.gvOrder.TabIndex = 1;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvOrder.ThemeStyle.HeaderStyle.Height = 50;
            this.gvOrder.ThemeStyle.ReadOnly = false;
            this.gvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvOrder.ThemeStyle.RowsStyle.Height = 70;
            this.gvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "RENT_ID";
            this.Id.FillWeight = 291.8782F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 75;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // Cus_name
            // 
            this.Cus_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cus_name.DataPropertyName = "USER_FULLNAME";
            this.Cus_name.FillWeight = 191.0627F;
            this.Cus_name.HeaderText = "Customer Name";
            this.Cus_name.MinimumWidth = 6;
            this.Cus_name.Name = "Cus_name";
            this.Cus_name.ReadOnly = true;
            this.Cus_name.Width = 300;
            // 
            // Rent_Date
            // 
            this.Rent_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rent_Date.DataPropertyName = "RENT_DATE";
            this.Rent_Date.FillWeight = 8.529577F;
            this.Rent_Date.HeaderText = "Rent Date";
            this.Rent_Date.MinimumWidth = 6;
            this.Rent_Date.Name = "Rent_Date";
            this.Rent_Date.ReadOnly = true;
            this.Rent_Date.Width = 140;
            // 
            // Due_Date
            // 
            this.Due_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Due_Date.DataPropertyName = "DUE_DATE";
            this.Due_Date.FillWeight = 8.529577F;
            this.Due_Date.HeaderText = "Due Date";
            this.Due_Date.MinimumWidth = 6;
            this.Due_Date.Name = "Due_Date";
            this.Due_Date.ReadOnly = true;
            this.Due_Date.Width = 140;
            // 
            // Deposit
            // 
            this.Deposit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Deposit.DataPropertyName = "RENT_DEPOSIT";
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.MinimumWidth = 6;
            this.Deposit.Name = "Deposit";
            this.Deposit.ReadOnly = true;
            this.Deposit.Width = 170;
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Total_Price.DataPropertyName = "TOTAL_PRICE";
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 6;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            this.Total_Price.Width = 230;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "STATUS_NAME";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 175;
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
            this.tbxSearch.Location = new System.Drawing.Point(795, 32);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderText = "Enter customer name";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.ShadowDecoration.BorderRadius = 200;
            this.tbxSearch.Size = new System.Drawing.Size(461, 41);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UsCtr_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.gvOrder);
            this.Name = "UsCtr_Order";
            this.Size = new System.Drawing.Size(1269, 852);
            this.Load += new System.EventHandler(this.UsCtr_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gvOrder;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cus_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Timer timer2;
    }
}
