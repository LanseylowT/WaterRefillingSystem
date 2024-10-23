namespace WaterRefillingSystem.NewViews
{
    partial class CustomerPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dtgCustomerView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnSelect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tbSearchField = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cmbFilterType2 = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCustomerView
            // 
            this.dtgCustomerView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCustomerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCustomerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCustomerView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCustomerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCustomerView.ColumnHeadersHeight = 40;
            this.dtgCustomerView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgCustomerView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCustomerView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgCustomerView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgCustomerView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCustomerView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCustomerView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCustomerView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgCustomerView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCustomerView.CurrentTheme.Name = null;
            this.dtgCustomerView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCustomerView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCustomerView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCustomerView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCustomerView.EnableHeadersVisualStyles = false;
            this.dtgCustomerView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCustomerView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCustomerView.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgCustomerView.HeaderForeColor = System.Drawing.Color.White;
            this.dtgCustomerView.Location = new System.Drawing.Point(12, 135);
            this.dtgCustomerView.Name = "dtgCustomerView";
            this.dtgCustomerView.RowHeadersVisible = false;
            this.dtgCustomerView.RowTemplate.Height = 40;
            this.dtgCustomerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCustomerView.Size = new System.Drawing.Size(782, 392);
            this.dtgCustomerView.TabIndex = 0;
            this.dtgCustomerView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dtgCustomerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomerView_CellClick);
            // 
            // btnSelect
            // 
            this.btnSelect.AllowAnimations = true;
            this.btnSelect.AllowMouseEffects = true;
            this.btnSelect.AllowToggling = false;
            this.btnSelect.AnimationSpeed = 200;
            this.btnSelect.AutoGenerateColors = false;
            this.btnSelect.AutoRoundBorders = false;
            this.btnSelect.AutoSizeLeftIcon = true;
            this.btnSelect.AutoSizeRightIcon = true;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelect.BackgroundImage")));
            this.btnSelect.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSelect.ButtonText = "Select";
            this.btnSelect.ButtonTextMarginLeft = 0;
            this.btnSelect.ColorContrastOnClick = 45;
            this.btnSelect.ColorContrastOnHover = 45;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSelect.CustomizableEdges = borderEdges1;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelect.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelect.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelect.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelect.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSelect.IconMarginLeft = 11;
            this.btnSelect.IconPadding = 10;
            this.btnSelect.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSelect.IconSize = 25;
            this.btnSelect.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.IdleBorderRadius = 1;
            this.btnSelect.IdleBorderThickness = 1;
            this.btnSelect.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.IdleIconLeftImage = null;
            this.btnSelect.IdleIconRightImage = null;
            this.btnSelect.IndicateFocus = false;
            this.btnSelect.Location = new System.Drawing.Point(466, 63);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSelect.OnDisabledState.BorderRadius = 1;
            this.btnSelect.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSelect.OnDisabledState.BorderThickness = 1;
            this.btnSelect.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSelect.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSelect.OnDisabledState.IconLeftImage = null;
            this.btnSelect.OnDisabledState.IconRightImage = null;
            this.btnSelect.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSelect.onHoverState.BorderRadius = 1;
            this.btnSelect.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSelect.onHoverState.BorderThickness = 1;
            this.btnSelect.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSelect.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.onHoverState.IconLeftImage = null;
            this.btnSelect.onHoverState.IconRightImage = null;
            this.btnSelect.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.OnIdleState.BorderRadius = 1;
            this.btnSelect.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSelect.OnIdleState.BorderThickness = 1;
            this.btnSelect.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.OnIdleState.IconLeftImage = null;
            this.btnSelect.OnIdleState.IconRightImage = null;
            this.btnSelect.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelect.OnPressedState.BorderRadius = 1;
            this.btnSelect.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSelect.OnPressedState.BorderThickness = 1;
            this.btnSelect.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSelect.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSelect.OnPressedState.IconLeftImage = null;
            this.btnSelect.OnPressedState.IconRightImage = null;
            this.btnSelect.Size = new System.Drawing.Size(98, 32);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelect.TextMarginLeft = 0;
            this.btnSelect.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelect.UseDefaultRadiusAndThickness = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbSearchField
            // 
            this.tbSearchField.AcceptsReturn = false;
            this.tbSearchField.AcceptsTab = false;
            this.tbSearchField.AnimationSpeed = 200;
            this.tbSearchField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearchField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearchField.AutoSizeHeight = true;
            this.tbSearchField.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearchField.BackgroundImage")));
            this.tbSearchField.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearchField.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearchField.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearchField.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearchField.BorderRadius = 1;
            this.tbSearchField.BorderThickness = 1;
            this.tbSearchField.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.tbSearchField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchField.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbSearchField.DefaultText = "";
            this.tbSearchField.FillColor = System.Drawing.Color.White;
            this.tbSearchField.HideSelection = true;
            this.tbSearchField.IconLeft = null;
            this.tbSearchField.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchField.IconPadding = 10;
            this.tbSearchField.IconRight = null;
            this.tbSearchField.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchField.Lines = new string[0];
            this.tbSearchField.Location = new System.Drawing.Point(12, 63);
            this.tbSearchField.MaxLength = 32767;
            this.tbSearchField.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearchField.Modified = false;
            this.tbSearchField.Multiline = false;
            this.tbSearchField.Name = "tbSearchField";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchField.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearchField.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchField.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchField.OnIdleState = stateProperties4;
            this.tbSearchField.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchField.PasswordChar = '\0';
            this.tbSearchField.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchField.PlaceholderText = "Enter text";
            this.tbSearchField.ReadOnly = false;
            this.tbSearchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchField.SelectedText = "";
            this.tbSearchField.SelectionLength = 0;
            this.tbSearchField.SelectionStart = 0;
            this.tbSearchField.ShortcutsEnabled = true;
            this.tbSearchField.Size = new System.Drawing.Size(260, 32);
            this.tbSearchField.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearchField.TabIndex = 1;
            this.tbSearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchField.TextMarginBottom = 0;
            this.tbSearchField.TextMarginLeft = 3;
            this.tbSearchField.TextMarginTop = 1;
            this.tbSearchField.TextPlaceholder = "Enter text";
            this.tbSearchField.UseSystemPasswordChar = false;
            this.tbSearchField.WordWrap = true;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
            // 
            // cmbFilterType2
            // 
            this.cmbFilterType2.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterType2.BackgroundColor = System.Drawing.Color.White;
            this.cmbFilterType2.BorderColor = System.Drawing.Color.Silver;
            this.cmbFilterType2.BorderRadius = 1;
            this.cmbFilterType2.Color = System.Drawing.Color.Silver;
            this.cmbFilterType2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbFilterType2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFilterType2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbFilterType2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFilterType2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFilterType2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbFilterType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterType2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbFilterType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFilterType2.FillDropDown = true;
            this.cmbFilterType2.FillIndicator = false;
            this.cmbFilterType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterType2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterType2.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterType2.FormattingEnabled = true;
            this.cmbFilterType2.Icon = null;
            this.cmbFilterType2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFilterType2.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbFilterType2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFilterType2.IndicatorThickness = 2;
            this.cmbFilterType2.IsDropdownOpened = false;
            this.cmbFilterType2.ItemBackColor = System.Drawing.Color.White;
            this.cmbFilterType2.ItemBorderColor = System.Drawing.Color.White;
            this.cmbFilterType2.ItemForeColor = System.Drawing.Color.Black;
            this.cmbFilterType2.ItemHeight = 26;
            this.cmbFilterType2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbFilterType2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbFilterType2.Items.AddRange(new object[] { "All", "Customer Name", "Customer ID", "Address" });
            this.cmbFilterType2.ItemTopMargin = 3;
            this.cmbFilterType2.Location = new System.Drawing.Point(278, 63);
            this.cmbFilterType2.Name = "cmbFilterType2";
            this.cmbFilterType2.Size = new System.Drawing.Size(171, 32);
            this.cmbFilterType2.TabIndex = 4;
            this.cmbFilterType2.Text = null;
            this.cmbFilterType2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFilterType2.TextLeftMargin = 5;
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 636);
            this.Controls.Add(this.cmbFilterType2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbSearchField);
            this.Controls.Add(this.dtgCustomerView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerPage";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerView)).EndInit();
            this.ResumeLayout(false);
        }

        private Bunifu.UI.WinForms.BunifuDropdown cmbFilterType2;

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtgCustomerView;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearchField;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSelect;
    }
}