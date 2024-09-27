using System.ComponentModel;

namespace WaterRefillingSystem.Views
{
    partial class CustomerTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTest));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.dtgCustomerView = new System.Windows.Forms.DataGridView();
            this.tbSearchField = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSelect = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbFilterType = new Bunifu.UI.WinForms.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCustomerView
            // 
            this.dtgCustomerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomerView.Location = new System.Drawing.Point(12, 142);
            this.dtgCustomerView.Name = "dtgCustomerView";
            this.dtgCustomerView.Size = new System.Drawing.Size(1045, 496);
            this.dtgCustomerView.TabIndex = 1;
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
            this.tbSearchField.Location = new System.Drawing.Point(209, 45);
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
            this.tbSearchField.Size = new System.Drawing.Size(262, 43);
            this.tbSearchField.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearchField.TabIndex = 3;
            this.tbSearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchField.TextMarginBottom = 0;
            this.tbSearchField.TextMarginLeft = 3;
            this.tbSearchField.TextMarginTop = 1;
            this.tbSearchField.TextPlaceholder = "Enter text";
            this.tbSearchField.UseSystemPasswordChar = false;
            this.tbSearchField.WordWrap = true;
            this.tbSearchField.TextChanged += new System.EventHandler(this.tbSearchField_TextChanged);
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
            this.btnSelect.Location = new System.Drawing.Point(490, 45);
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
            this.btnSelect.Size = new System.Drawing.Size(125, 43);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelect.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelect.TextMarginLeft = 0;
            this.btnSelect.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSelect.UseDefaultRadiusAndThickness = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(12, 670);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(70, 15);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Date and Shit";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(941, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(103, 32);
            this.bunifuLabel1.TabIndex = 6;
            this.bunifuLabel1.Text = "Customer";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilterType.BackgroundColor = System.Drawing.Color.White;
            this.cmbFilterType.BorderColor = System.Drawing.Color.Silver;
            this.cmbFilterType.BorderRadius = 1;
            this.cmbFilterType.Color = System.Drawing.Color.Silver;
            this.cmbFilterType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbFilterType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFilterType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbFilterType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbFilterType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbFilterType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbFilterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilterType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFilterType.FillDropDown = true;
            this.cmbFilterType.FillIndicator = false;
            this.cmbFilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterType.ForeColor = System.Drawing.Color.Black;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Icon = null;
            this.cmbFilterType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFilterType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbFilterType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbFilterType.IndicatorThickness = 2;
            this.cmbFilterType.IsDropdownOpened = false;
            this.cmbFilterType.ItemBackColor = System.Drawing.Color.White;
            this.cmbFilterType.ItemBorderColor = System.Drawing.Color.White;
            this.cmbFilterType.ItemForeColor = System.Drawing.Color.Black;
            this.cmbFilterType.ItemHeight = 26;
            this.cmbFilterType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbFilterType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbFilterType.Items.AddRange(new object[] { "All", "Customer Name", "Customer ID", "Address", "Distributor" });
            this.cmbFilterType.ItemTopMargin = 3;
            this.cmbFilterType.Location = new System.Drawing.Point(12, 45);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(180, 32);
            this.cmbFilterType.TabIndex = 7;
            this.cmbFilterType.Text = null;
            this.cmbFilterType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbFilterType.TextLeftMargin = 5;
            // 
            // CustomerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 697);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbSearchField);
            this.Controls.Add(this.dtgCustomerView);
            this.Name = "CustomerTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerTest";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Bunifu.UI.WinForms.BunifuDropdown cmbFilterType;

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;

        #endregion

        private System.Windows.Forms.DataGridView dtgCustomerView;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearchField;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSelect;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
    }
}