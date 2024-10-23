namespace WaterRefillingSystem.NewViews
{
    partial class SalesAndExpensesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesAndExpensesPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbSalesFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtgSales = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dtgExpenses = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmbExpensesFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(466, 23);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(58, 15);
            this.bunifuLabel2.TabIndex = 7;
            this.bunifuLabel2.Text = "Sales Filter:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(638, 23);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(79, 15);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Expenses Filter:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbSalesFilter
            // 
            this.cmbSalesFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbSalesFilter.BackgroundColor = System.Drawing.Color.White;
            this.cmbSalesFilter.BorderColor = System.Drawing.Color.Silver;
            this.cmbSalesFilter.BorderRadius = 1;
            this.cmbSalesFilter.Color = System.Drawing.Color.Silver;
            this.cmbSalesFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbSalesFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSalesFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbSalesFilter.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSalesFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbSalesFilter.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSalesFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSalesFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbSalesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSalesFilter.FillDropDown = true;
            this.cmbSalesFilter.FillIndicator = false;
            this.cmbSalesFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSalesFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSalesFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbSalesFilter.FormattingEnabled = true;
            this.cmbSalesFilter.Icon = null;
            this.cmbSalesFilter.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSalesFilter.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbSalesFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbSalesFilter.IndicatorThickness = 2;
            this.cmbSalesFilter.IsDropdownOpened = false;
            this.cmbSalesFilter.ItemBackColor = System.Drawing.Color.White;
            this.cmbSalesFilter.ItemBorderColor = System.Drawing.Color.White;
            this.cmbSalesFilter.ItemForeColor = System.Drawing.Color.Black;
            this.cmbSalesFilter.ItemHeight = 26;
            this.cmbSalesFilter.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbSalesFilter.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbSalesFilter.Items.AddRange(new object[] { "All", "Today", "Yesterday", "This Week", "This Month" });
            this.cmbSalesFilter.ItemTopMargin = 3;
            this.cmbSalesFilter.Location = new System.Drawing.Point(466, 44);
            this.cmbSalesFilter.Name = "cmbSalesFilter";
            this.cmbSalesFilter.Size = new System.Drawing.Size(125, 32);
            this.cmbSalesFilter.TabIndex = 8;
            this.cmbSalesFilter.Text = null;
            this.cmbSalesFilter.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbSalesFilter.TextLeftMargin = 5;
            this.cmbSalesFilter.SelectedIndexChanged += new System.EventHandler(this.cmbSalesFilter_SelectedIndexChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.Location = new System.Drawing.Point(12, 86);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(66, 15);
            this.bunifuLabel3.TabIndex = 9;
            this.bunifuLabel3.Text = "Sales Record";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtgSales
            // 
            this.dtgSales.AllowCustomTheming = false;
            this.dtgSales.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgSales.ColumnHeadersHeight = 40;
            this.dtgSales.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgSales.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgSales.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgSales.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgSales.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgSales.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgSales.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgSales.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgSales.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgSales.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgSales.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgSales.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgSales.CurrentTheme.Name = null;
            this.dtgSales.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSales.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgSales.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgSales.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgSales.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgSales.EnableHeadersVisualStyles = false;
            this.dtgSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgSales.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgSales.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgSales.HeaderForeColor = System.Drawing.Color.White;
            this.dtgSales.Location = new System.Drawing.Point(12, 107);
            this.dtgSales.Name = "dtgSales";
            this.dtgSales.RowHeadersVisible = false;
            this.dtgSales.RowTemplate.Height = 40;
            this.dtgSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSales.Size = new System.Drawing.Size(782, 237);
            this.dtgSales.TabIndex = 11;
            this.dtgSales.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(12, 375);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(87, 15);
            this.bunifuLabel4.TabIndex = 9;
            this.bunifuLabel4.Text = "Expenses Record";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dtgExpenses
            // 
            this.dtgExpenses.AllowCustomTheming = false;
            this.dtgExpenses.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtgExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgExpenses.ColumnHeadersHeight = 40;
            this.dtgExpenses.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgExpenses.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgExpenses.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgExpenses.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgExpenses.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgExpenses.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgExpenses.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgExpenses.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgExpenses.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgExpenses.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgExpenses.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgExpenses.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgExpenses.CurrentTheme.Name = null;
            this.dtgExpenses.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgExpenses.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgExpenses.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgExpenses.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgExpenses.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgExpenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgExpenses.EnableHeadersVisualStyles = false;
            this.dtgExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgExpenses.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgExpenses.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgExpenses.HeaderForeColor = System.Drawing.Color.White;
            this.dtgExpenses.Location = new System.Drawing.Point(12, 396);
            this.dtgExpenses.Name = "dtgExpenses";
            this.dtgExpenses.RowHeadersVisible = false;
            this.dtgExpenses.RowTemplate.Height = 40;
            this.dtgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgExpenses.Size = new System.Drawing.Size(779, 212);
            this.dtgExpenses.TabIndex = 12;
            this.dtgExpenses.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // cmbExpensesFilter
            // 
            this.cmbExpensesFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbExpensesFilter.BackgroundColor = System.Drawing.Color.White;
            this.cmbExpensesFilter.BorderColor = System.Drawing.Color.Silver;
            this.cmbExpensesFilter.BorderRadius = 1;
            this.cmbExpensesFilter.Color = System.Drawing.Color.Silver;
            this.cmbExpensesFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbExpensesFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbExpensesFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbExpensesFilter.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbExpensesFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbExpensesFilter.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbExpensesFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExpensesFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbExpensesFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpensesFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbExpensesFilter.FillDropDown = true;
            this.cmbExpensesFilter.FillIndicator = false;
            this.cmbExpensesFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExpensesFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbExpensesFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbExpensesFilter.FormattingEnabled = true;
            this.cmbExpensesFilter.Icon = null;
            this.cmbExpensesFilter.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbExpensesFilter.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbExpensesFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbExpensesFilter.IndicatorThickness = 2;
            this.cmbExpensesFilter.IsDropdownOpened = false;
            this.cmbExpensesFilter.ItemBackColor = System.Drawing.Color.White;
            this.cmbExpensesFilter.ItemBorderColor = System.Drawing.Color.White;
            this.cmbExpensesFilter.ItemForeColor = System.Drawing.Color.Black;
            this.cmbExpensesFilter.ItemHeight = 26;
            this.cmbExpensesFilter.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbExpensesFilter.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbExpensesFilter.Items.AddRange(new object[] { "All", "Today", "Yesterday", "This Week", "This Month" });
            this.cmbExpensesFilter.ItemTopMargin = 3;
            this.cmbExpensesFilter.Location = new System.Drawing.Point(638, 44);
            this.cmbExpensesFilter.Name = "cmbExpensesFilter";
            this.cmbExpensesFilter.Size = new System.Drawing.Size(125, 32);
            this.cmbExpensesFilter.TabIndex = 13;
            this.cmbExpensesFilter.Text = null;
            this.cmbExpensesFilter.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbExpensesFilter.TextLeftMargin = 5;
            this.cmbExpensesFilter.SelectedIndexChanged += new System.EventHandler(this.cmbExpensesFilter_SelectedIndexChanged);
            // 
            // SalesAndExpensesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 636);
            this.Controls.Add(this.cmbExpensesFilter);
            this.Controls.Add(this.dtgExpenses);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.dtgSales);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.cmbSalesFilter);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesAndExpensesPage";
            this.Text = "SalesAndExpensesPage";
            this.Load += new System.EventHandler(this.SalesAndExpensesPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuDropdown cmbExpensesFilter;

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown cmbSalesFilter;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgSales;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuDataGridView dtgExpenses;
    }
}