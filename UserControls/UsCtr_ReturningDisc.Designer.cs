namespace OOAD_Project
{
    partial class UsCtr_ReturningDisc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDiscName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvReturningDisc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lnFinalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDmgFine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOverDateFine = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.nbDamageDisc = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.message = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lbNotifi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturningDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDamageDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BorderRadius = 15;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(888, 469);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(270, 55);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return Disc";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(853, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Amount of Damaged Disc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(846, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Disc Name";
            // 
            // tbDiscName
            // 
            this.tbDiscName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.tbDiscName.BorderRadius = 15;
            this.tbDiscName.BorderThickness = 2;
            this.tbDiscName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDiscName.DefaultText = "";
            this.tbDiscName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDiscName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDiscName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDiscName.Enabled = false;
            this.tbDiscName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiscName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDiscName.Location = new System.Drawing.Point(851, 42);
            this.tbDiscName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDiscName.Name = "tbDiscName";
            this.tbDiscName.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.tbDiscName.PasswordChar = '\0';
            this.tbDiscName.PlaceholderText = "";
            this.tbDiscName.ReadOnly = true;
            this.tbDiscName.SelectedText = "";
            this.tbDiscName.ShadowDecoration.BorderRadius = 200;
            this.tbDiscName.Size = new System.Drawing.Size(364, 47);
            this.tbDiscName.TabIndex = 23;
            // 
            // gvReturningDisc
            // 
            this.gvReturningDisc.AllowUserToAddRows = false;
            this.gvReturningDisc.AllowUserToDeleteRows = false;
            this.gvReturningDisc.AllowUserToResizeColumns = false;
            this.gvReturningDisc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gvReturningDisc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReturningDisc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvReturningDisc.ColumnHeadersHeight = 50;
            this.gvReturningDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvReturningDisc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Disc_Name,
            this.Amount,
            this.Price_day,
            this.Rent_Price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvReturningDisc.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvReturningDisc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvReturningDisc.Location = new System.Drawing.Point(21, 10);
            this.gvReturningDisc.MultiSelect = false;
            this.gvReturningDisc.Name = "gvReturningDisc";
            this.gvReturningDisc.ReadOnly = true;
            this.gvReturningDisc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReturningDisc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvReturningDisc.RowHeadersVisible = false;
            this.gvReturningDisc.RowHeadersWidth = 51;
            this.gvReturningDisc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gvReturningDisc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvReturningDisc.RowTemplate.DividerHeight = 1;
            this.gvReturningDisc.RowTemplate.Height = 70;
            this.gvReturningDisc.Size = new System.Drawing.Size(801, 514);
            this.gvReturningDisc.TabIndex = 21;
            this.gvReturningDisc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvReturningDisc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvReturningDisc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvReturningDisc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvReturningDisc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvReturningDisc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvReturningDisc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvReturningDisc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.gvReturningDisc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvReturningDisc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvReturningDisc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvReturningDisc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvReturningDisc.ThemeStyle.HeaderStyle.Height = 50;
            this.gvReturningDisc.ThemeStyle.ReadOnly = true;
            this.gvReturningDisc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvReturningDisc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvReturningDisc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvReturningDisc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvReturningDisc.ThemeStyle.RowsStyle.Height = 70;
            this.gvReturningDisc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvReturningDisc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvReturningDisc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturningDisc_CellContentClick);
            this.gvReturningDisc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReturningDisc_CellMouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "DISC_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            this.Disc_Name.Width = 300;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Amount.DataPropertyName = "RENT_AMOUNT";
            this.Amount.FillWeight = 8.529577F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Price_day
            // 
            this.Price_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price_day.DataPropertyName = "DISC_PRICE";
            this.Price_day.FillWeight = 8.529577F;
            this.Price_day.HeaderText = "Price per Day";
            this.Price_day.MinimumWidth = 6;
            this.Price_day.Name = "Price_day";
            this.Price_day.ReadOnly = true;
            this.Price_day.Width = 150;
            // 
            // Rent_Price
            // 
            this.Rent_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Rent_Price.DataPropertyName = "TOTAL";
            this.Rent_Price.HeaderText = "Rent Price";
            this.Rent_Price.Name = "Rent_Price";
            this.Rent_Price.ReadOnly = true;
            this.Rent_Price.Width = 150;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnUpdate.Location = new System.Drawing.Point(851, 216);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(364, 47);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(854, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "Total Rent Price:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lnFinalPrice
            // 
            this.lnFinalPrice.AutoSize = true;
            this.lnFinalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.lnFinalPrice.Location = new System.Drawing.Point(995, 408);
            this.lnFinalPrice.Name = "lnFinalPrice";
            this.lnFinalPrice.Size = new System.Drawing.Size(78, 30);
            this.lnFinalPrice.TabIndex = 30;
            this.lnFinalPrice.Text = "0 VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.label12.Location = new System.Drawing.Point(868, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Final Price:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(996, 279);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 21);
            this.lbTotal.TabIndex = 29;
            this.lbTotal.Text = "0 VND";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(860, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Damaged Fine:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDmgFine
            // 
            this.lbDmgFine.AutoSize = true;
            this.lbDmgFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDmgFine.ForeColor = System.Drawing.Color.Black;
            this.lbDmgFine.Location = new System.Drawing.Point(996, 311);
            this.lbDmgFine.Name = "lbDmgFine";
            this.lbDmgFine.Size = new System.Drawing.Size(56, 21);
            this.lbDmgFine.TabIndex = 29;
            this.lbDmgFine.Text = "0 VND";
            this.lbDmgFine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(863, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Overdate Fine:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbOverDateFine
            // 
            this.lbOverDateFine.AutoSize = true;
            this.lbOverDateFine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverDateFine.ForeColor = System.Drawing.Color.Black;
            this.lbOverDateFine.Location = new System.Drawing.Point(996, 344);
            this.lbOverDateFine.Name = "lbOverDateFine";
            this.lbOverDateFine.Size = new System.Drawing.Size(56, 21);
            this.lbOverDateFine.TabIndex = 29;
            this.lbOverDateFine.Text = "0 VND";
            this.lbOverDateFine.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(907, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Deposit:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposit.ForeColor = System.Drawing.Color.Black;
            this.lbDeposit.Location = new System.Drawing.Point(996, 377);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.Size = new System.Drawing.Size(56, 21);
            this.lbDeposit.TabIndex = 29;
            this.lbDeposit.Text = "0 VND";
            this.lbDeposit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nbDamageDisc
            // 
            this.nbDamageDisc.BackColor = System.Drawing.Color.Transparent;
            this.nbDamageDisc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.nbDamageDisc.BorderRadius = 15;
            this.nbDamageDisc.BorderThickness = 2;
            this.nbDamageDisc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbDamageDisc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nbDamageDisc.Location = new System.Drawing.Point(854, 143);
            this.nbDamageDisc.Margin = new System.Windows.Forms.Padding(5);
            this.nbDamageDisc.Name = "nbDamageDisc";
            this.nbDamageDisc.Size = new System.Drawing.Size(361, 52);
            this.nbDamageDisc.TabIndex = 35;
            this.nbDamageDisc.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.nbDamageDisc.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // message
            // 
            this.message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.message.Caption = "Success";
            this.message.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.message.Parent = null;
            this.message.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.message.Text = null;
            // 
            // lbNotifi
            // 
            this.lbNotifi.BackColor = System.Drawing.Color.Transparent;
            this.lbNotifi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNotifi.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbNotifi.Location = new System.Drawing.Point(976, 445);
            this.lbNotifi.Name = "lbNotifi";
            this.lbNotifi.Size = new System.Drawing.Size(3, 2);
            this.lbNotifi.TabIndex = 36;
            // 
            // UsCtr_ReturningDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbNotifi);
            this.Controls.Add(this.nbDamageDisc);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lnFinalPrice);
            this.Controls.Add(this.lbDeposit);
            this.Controls.Add(this.lbOverDateFine);
            this.Controls.Add(this.lbDmgFine);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiscName);
            this.Controls.Add(this.gvReturningDisc);
            this.Name = "UsCtr_ReturningDisc";
            this.Size = new System.Drawing.Size(1240, 533);
            this.Load += new System.EventHandler(this.UsCtr_ReturningDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvReturningDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDamageDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbDiscName;
        private Guna.UI2.WinForms.Guna2DataGridView gvReturningDisc;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lnFinalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDmgFine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOverDateFine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDeposit;
        private Guna.UI2.WinForms.Guna2NumericUpDown nbDamageDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent_Price;
        private Guna.UI2.WinForms.Guna2MessageDialog message;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNotifi;
    }
}
