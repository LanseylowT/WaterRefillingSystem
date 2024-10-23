using System.ComponentModel;

namespace WaterRefillingSystem.NewViews
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCustomers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dtgCustomerSummary = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.AllowAnimations = true;
            this.btnCustomers.AllowMouseEffects = true;
            this.btnCustomers.AllowToggling = false;
            this.btnCustomers.AnimationSpeed = 200;
            this.btnCustomers.AutoGenerateColors = false;
            this.btnCustomers.AutoRoundBorders = false;
            this.btnCustomers.AutoSizeLeftIcon = true;
            this.btnCustomers.AutoSizeRightIcon = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.BackgroundImage")));
            this.btnCustomers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.ButtonText = "Customers";
            this.btnCustomers.ButtonTextMarginLeft = 0;
            this.btnCustomers.ColorContrastOnClick = 45;
            this.btnCustomers.ColorContrastOnHover = 45;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCustomers.CustomizableEdges = borderEdges1;
            this.btnCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomers.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCustomers.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCustomers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomers.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnCustomers.IconLeft")));
            this.btnCustomers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomers.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnCustomers.IconMarginLeft = 11;
            this.btnCustomers.IconPadding = 17;
            this.btnCustomers.IconRight = null;
            this.btnCustomers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomers.IconRightPadding = new System.Windows.Forms.Padding(15, 3, 7, 3);
            this.btnCustomers.IconSize = 25;
            this.btnCustomers.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCustomers.IdleBorderRadius = 0;
            this.btnCustomers.IdleBorderThickness = 0;
            this.btnCustomers.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCustomers.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.IdleIconLeftImage")));
            this.btnCustomers.IdleIconRightImage = null;
            this.btnCustomers.IndicateFocus = false;
            this.btnCustomers.Location = new System.Drawing.Point(94, 92);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCustomers.OnDisabledState.BorderRadius = 1;
            this.btnCustomers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnDisabledState.BorderThickness = 1;
            this.btnCustomers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCustomers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCustomers.OnDisabledState.IconLeftImage = null;
            this.btnCustomers.OnDisabledState.IconRightImage = null;
            this.btnCustomers.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.onHoverState.BorderRadius = 1;
            this.btnCustomers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.onHoverState.BorderThickness = 1;
            this.btnCustomers.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(55)))), ((int)(((byte)(255)))));
            this.btnCustomers.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.onHoverState.IconLeftImage")));
            this.btnCustomers.onHoverState.IconRightImage = null;
            this.btnCustomers.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.OnIdleState.BorderRadius = 1;
            this.btnCustomers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnIdleState.BorderThickness = 1;
            this.btnCustomers.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomers.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCustomers.OnIdleState.IconLeftImage")));
            this.btnCustomers.OnIdleState.IconRightImage = null;
            this.btnCustomers.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.OnPressedState.BorderRadius = 1;
            this.btnCustomers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCustomers.OnPressedState.BorderThickness = 1;
            this.btnCustomers.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.OnPressedState.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomers.OnPressedState.IconLeftImage = null;
            this.btnCustomers.OnPressedState.IconRightImage = null;
            this.btnCustomers.Size = new System.Drawing.Size(216, 55);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomers.TextMarginLeft = 0;
            this.btnCustomers.TextPadding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnCustomers.UseDefaultRadiusAndThickness = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AllowAnimations = true;
            this.btnOrder.AllowMouseEffects = true;
            this.btnOrder.AllowToggling = false;
            this.btnOrder.AnimationSpeed = 200;
            this.btnOrder.AutoGenerateColors = false;
            this.btnOrder.AutoRoundBorders = false;
            this.btnOrder.AutoSizeLeftIcon = true;
            this.btnOrder.AutoSizeRightIcon = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.ButtonText = "Order";
            this.btnOrder.ButtonTextMarginLeft = 0;
            this.btnOrder.ColorContrastOnClick = 45;
            this.btnOrder.ColorContrastOnHover = 45;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnOrder.CustomizableEdges = borderEdges2;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnOrder.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrder.IconLeft = ((System.Drawing.Image)(resources.GetObject("btnOrder.IconLeft")));
            this.btnOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnOrder.IconMarginLeft = 11;
            this.btnOrder.IconPadding = 17;
            this.btnOrder.IconRight = null;
            this.btnOrder.IconRightAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconRightPadding = new System.Windows.Forms.Padding(15, 3, 7, 3);
            this.btnOrder.IconSize = 25;
            this.btnOrder.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnOrder.IdleBorderRadius = 0;
            this.btnOrder.IdleBorderThickness = 0;
            this.btnOrder.IdleFillColor = System.Drawing.Color.Empty;
            this.btnOrder.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.IdleIconLeftImage")));
            this.btnOrder.IdleIconRightImage = null;
            this.btnOrder.IndicateFocus = false;
            this.btnOrder.Location = new System.Drawing.Point(469, 92);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.OnDisabledState.BorderRadius = 1;
            this.btnOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnDisabledState.BorderThickness = 1;
            this.btnOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrder.OnDisabledState.IconLeftImage = null;
            this.btnOrder.OnDisabledState.IconRightImage = null;
            this.btnOrder.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnOrder.onHoverState.BorderRadius = 1;
            this.btnOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.onHoverState.BorderThickness = 1;
            this.btnOrder.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnOrder.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(55)))), ((int)(((byte)(255)))));
            this.btnOrder.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.onHoverState.IconLeftImage")));
            this.btnOrder.onHoverState.IconRightImage = null;
            this.btnOrder.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnOrder.OnIdleState.BorderRadius = 1;
            this.btnOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnIdleState.BorderThickness = 1;
            this.btnOrder.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnOrder.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrder.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.OnIdleState.IconLeftImage")));
            this.btnOrder.OnIdleState.IconRightImage = null;
            this.btnOrder.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnOrder.OnPressedState.BorderRadius = 1;
            this.btnOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnPressedState.BorderThickness = 1;
            this.btnOrder.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnOrder.OnPressedState.ForeColor = System.Drawing.Color.DimGray;
            this.btnOrder.OnPressedState.IconLeftImage = null;
            this.btnOrder.OnPressedState.IconRightImage = null;
            this.btnOrder.Size = new System.Drawing.Size(216, 55);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrder.TextMarginLeft = 0;
            this.btnOrder.TextPadding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnOrder.UseDefaultRadiusAndThickness = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dtgCustomerSummary
            // 
            this.dtgCustomerSummary.AllowCustomTheming = false;
            this.dtgCustomerSummary.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCustomerSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCustomerSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCustomerSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCustomerSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomerSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCustomerSummary.ColumnHeadersHeight = 40;
            this.dtgCustomerSummary.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dtgCustomerSummary.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerSummary.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerSummary.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCustomerSummary.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgCustomerSummary.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dtgCustomerSummary.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCustomerSummary.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCustomerSummary.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerSummary.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCustomerSummary.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dtgCustomerSummary.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCustomerSummary.CurrentTheme.Name = null;
            this.dtgCustomerSummary.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCustomerSummary.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtgCustomerSummary.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomerSummary.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dtgCustomerSummary.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCustomerSummary.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCustomerSummary.EnableHeadersVisualStyles = false;
            this.dtgCustomerSummary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dtgCustomerSummary.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dtgCustomerSummary.HeaderBgColor = System.Drawing.Color.Empty;
            this.dtgCustomerSummary.HeaderForeColor = System.Drawing.Color.White;
            this.dtgCustomerSummary.Location = new System.Drawing.Point(94, 200);
            this.dtgCustomerSummary.Name = "dtgCustomerSummary";
            this.dtgCustomerSummary.RowHeadersVisible = false;
            this.dtgCustomerSummary.RowTemplate.Height = 40;
            this.dtgCustomerSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCustomerSummary.Size = new System.Drawing.Size(591, 363);
            this.dtgCustomerSummary.TabIndex = 6;
            this.dtgCustomerSummary.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 636);
            this.Controls.Add(this.dtgCustomerSummary);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomerSummary)).EndInit();
            this.ResumeLayout(false);
        }

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOrder;

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCustomers;

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dtgCustomerSummary;
    }
}