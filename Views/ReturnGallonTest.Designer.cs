using System.ComponentModel;

namespace WaterRefillingSystem.Views
{
    partial class ReturnGallonTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnGallonTest));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cmbBorrowedContainer = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnReturn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblCustomerId = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtItemType = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(108, 61);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(28, 15);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Type:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(108, 150);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(109, 15);
            this.bunifuLabel2.TabIndex = 2;
            this.bunifuLabel2.Text = "Borrowed Container:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cmbBorrowedContainer
            // 
            this.cmbBorrowedContainer.BackColor = System.Drawing.Color.Transparent;
            this.cmbBorrowedContainer.BackgroundColor = System.Drawing.Color.White;
            this.cmbBorrowedContainer.BorderColor = System.Drawing.Color.Silver;
            this.cmbBorrowedContainer.BorderRadius = 1;
            this.cmbBorrowedContainer.Color = System.Drawing.Color.Silver;
            this.cmbBorrowedContainer.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbBorrowedContainer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbBorrowedContainer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbBorrowedContainer.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbBorrowedContainer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbBorrowedContainer.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbBorrowedContainer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBorrowedContainer.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbBorrowedContainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowedContainer.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbBorrowedContainer.FillDropDown = true;
            this.cmbBorrowedContainer.FillIndicator = false;
            this.cmbBorrowedContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBorrowedContainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBorrowedContainer.ForeColor = System.Drawing.Color.Black;
            this.cmbBorrowedContainer.FormattingEnabled = true;
            this.cmbBorrowedContainer.Icon = null;
            this.cmbBorrowedContainer.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbBorrowedContainer.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbBorrowedContainer.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbBorrowedContainer.IndicatorThickness = 2;
            this.cmbBorrowedContainer.IsDropdownOpened = false;
            this.cmbBorrowedContainer.ItemBackColor = System.Drawing.Color.White;
            this.cmbBorrowedContainer.ItemBorderColor = System.Drawing.Color.White;
            this.cmbBorrowedContainer.ItemForeColor = System.Drawing.Color.Black;
            this.cmbBorrowedContainer.ItemHeight = 26;
            this.cmbBorrowedContainer.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbBorrowedContainer.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbBorrowedContainer.ItemTopMargin = 3;
            this.cmbBorrowedContainer.Location = new System.Drawing.Point(108, 171);
            this.cmbBorrowedContainer.Name = "cmbBorrowedContainer";
            this.cmbBorrowedContainer.Size = new System.Drawing.Size(109, 32);
            this.cmbBorrowedContainer.TabIndex = 3;
            this.cmbBorrowedContainer.Text = null;
            this.cmbBorrowedContainer.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbBorrowedContainer.TextLeftMargin = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.AllowAnimations = true;
            this.btnReturn.AllowMouseEffects = true;
            this.btnReturn.AllowToggling = false;
            this.btnReturn.AnimationSpeed = 200;
            this.btnReturn.AutoGenerateColors = false;
            this.btnReturn.AutoRoundBorders = false;
            this.btnReturn.AutoSizeLeftIcon = true;
            this.btnReturn.AutoSizeRightIcon = true;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnReturn.ButtonText = "Return";
            this.btnReturn.ButtonTextMarginLeft = 0;
            this.btnReturn.ColorContrastOnClick = 45;
            this.btnReturn.ColorContrastOnHover = 45;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnReturn.CustomizableEdges = borderEdges1;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReturn.IconMarginLeft = 11;
            this.btnReturn.IconPadding = 10;
            this.btnReturn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReturn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReturn.IconSize = 25;
            this.btnReturn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.IdleBorderRadius = 1;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.IdleIconLeftImage = null;
            this.btnReturn.IdleIconRightImage = null;
            this.btnReturn.IndicateFocus = false;
            this.btnReturn.Location = new System.Drawing.Point(229, 171);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReturn.OnDisabledState.BorderRadius = 1;
            this.btnReturn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnReturn.OnDisabledState.BorderThickness = 1;
            this.btnReturn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnReturn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReturn.OnDisabledState.IconLeftImage = null;
            this.btnReturn.OnDisabledState.IconRightImage = null;
            this.btnReturn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReturn.onHoverState.BorderRadius = 1;
            this.btnReturn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnReturn.onHoverState.BorderThickness = 1;
            this.btnReturn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnReturn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.onHoverState.IconLeftImage = null;
            this.btnReturn.onHoverState.IconRightImage = null;
            this.btnReturn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.OnIdleState.BorderRadius = 1;
            this.btnReturn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnReturn.OnIdleState.BorderThickness = 1;
            this.btnReturn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnIdleState.IconLeftImage = null;
            this.btnReturn.OnIdleState.IconRightImage = null;
            this.btnReturn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReturn.OnPressedState.BorderRadius = 1;
            this.btnReturn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnReturn.OnPressedState.BorderThickness = 1;
            this.btnReturn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReturn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReturn.OnPressedState.IconLeftImage = null;
            this.btnReturn.OnPressedState.IconRightImage = null;
            this.btnReturn.Size = new System.Drawing.Size(98, 32);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.TextMarginLeft = 0;
            this.btnReturn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReturn.UseDefaultRadiusAndThickness = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges2;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.IdleBorderRadius = 1;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(333, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 1;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.BorderRadius = 1;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.OnIdleState.BorderRadius = 1;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.BorderRadius = 1;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AllowParentOverrides = false;
            this.lblCustomerId.AutoEllipsis = false;
            this.lblCustomerId.CursorType = null;
            this.lblCustomerId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerId.Location = new System.Drawing.Point(12, 261);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerId.Size = new System.Drawing.Size(69, 15);
            this.lblCustomerId.TabIndex = 6;
            this.lblCustomerId.Text = "Customer ID:";
            this.lblCustomerId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCustomerId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtItemType
            // 
            this.txtItemType.AcceptsReturn = false;
            this.txtItemType.AcceptsTab = false;
            this.txtItemType.AnimationSpeed = 200;
            this.txtItemType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemType.AutoSizeHeight = true;
            this.txtItemType.BackColor = System.Drawing.Color.Transparent;
            this.txtItemType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtItemType.BackgroundImage")));
            this.txtItemType.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtItemType.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemType.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtItemType.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtItemType.BorderRadius = 1;
            this.txtItemType.BorderThickness = 1;
            this.txtItemType.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtItemType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtItemType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemType.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtItemType.DefaultText = "";
            this.txtItemType.FillColor = System.Drawing.Color.White;
            this.txtItemType.HideSelection = true;
            this.txtItemType.IconLeft = null;
            this.txtItemType.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemType.IconPadding = 10;
            this.txtItemType.IconRight = null;
            this.txtItemType.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemType.Lines = new string[0];
            this.txtItemType.Location = new System.Drawing.Point(108, 92);
            this.txtItemType.MaxLength = 32767;
            this.txtItemType.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtItemType.Modified = false;
            this.txtItemType.Multiline = false;
            this.txtItemType.Name = "txtItemType";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemType.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtItemType.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemType.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtItemType.OnIdleState = stateProperties4;
            this.txtItemType.Padding = new System.Windows.Forms.Padding(3);
            this.txtItemType.PasswordChar = '\0';
            this.txtItemType.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtItemType.PlaceholderText = "Enter text";
            this.txtItemType.ReadOnly = true;
            this.txtItemType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemType.SelectedText = "";
            this.txtItemType.SelectionLength = 0;
            this.txtItemType.SelectionStart = 0;
            this.txtItemType.ShortcutsEnabled = true;
            this.txtItemType.Size = new System.Drawing.Size(323, 39);
            this.txtItemType.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtItemType.TabIndex = 7;
            this.txtItemType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemType.TextMarginBottom = 0;
            this.txtItemType.TextMarginLeft = 3;
            this.txtItemType.TextMarginTop = 1;
            this.txtItemType.TextPlaceholder = "Enter text";
            this.txtItemType.UseSystemPasswordChar = false;
            this.txtItemType.WordWrap = true;
            // 
            // ReturnGallonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 297);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbBorrowedContainer);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "ReturnGallonTest";
            this.Text = "ReturnGallonTest";
            this.Load += new System.EventHandler(this.ReturnGallonTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuDropdown cmbBorrowedContainer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnReturn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCancel;
        private Bunifu.UI.WinForms.BunifuLabel lblCustomerId;
        private Bunifu.UI.WinForms.BunifuTextBox txtItemType;
    }
}