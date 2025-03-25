namespace GUI
{
    partial class ProductManagement
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.prodPages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.viewBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.prodPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodPages
            // 
            this.prodPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.prodPages.AllowTransitions = false;
            this.prodPages.Controls.Add(this.tabPage1);
            this.prodPages.Controls.Add(this.tabPage2);
            this.prodPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodPages.Location = new System.Drawing.Point(0, 0);
            this.prodPages.Multiline = true;
            this.prodPages.Name = "prodPages";
            this.prodPages.Page = this.tabPage2;
            this.prodPages.PageIndex = 1;
            this.prodPages.PageName = "tabPage2";
            this.prodPages.PageTitle = "prod_Edit";
            this.prodPages.SelectedIndex = 0;
            this.prodPages.Size = new System.Drawing.Size(1230, 790);
            this.prodPages.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.prodPages.Transition = animation1;
            this.prodPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editBtn);
            this.tabPage1.Controls.Add(this.bunifuLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "prod_View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viewBtn);
            this.tabPage2.Controls.Add(this.bunifuLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "prod_Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(569, 366);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(32, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "View";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(547, 354);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(26, 20);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "edit";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // viewBtn
            // 
            this.viewBtn.AllowAnimations = true;
            this.viewBtn.AllowMouseEffects = true;
            this.viewBtn.AllowToggling = false;
            this.viewBtn.AnimationSpeed = 200;
            this.viewBtn.AutoGenerateColors = false;
            this.viewBtn.AutoRoundBorders = false;
            this.viewBtn.AutoSizeLeftIcon = true;
            this.viewBtn.AutoSizeRightIcon = true;
            this.viewBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.viewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewBtn.BackgroundImage")));
            this.viewBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.ButtonText = "View";
            this.viewBtn.ButtonTextMarginLeft = 0;
            this.viewBtn.ColorContrastOnClick = 45;
            this.viewBtn.ColorContrastOnHover = 45;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.viewBtn.CustomizableEdges = borderEdges2;
            this.viewBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.viewBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.viewBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.viewBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.viewBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.viewBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.IconLeft = null;
            this.viewBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.viewBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.viewBtn.IconMarginLeft = 11;
            this.viewBtn.IconPadding = 10;
            this.viewBtn.IconRight = null;
            this.viewBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.viewBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.viewBtn.IconSize = 25;
            this.viewBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.viewBtn.IdleBorderRadius = 0;
            this.viewBtn.IdleBorderThickness = 0;
            this.viewBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.viewBtn.IdleIconLeftImage = null;
            this.viewBtn.IdleIconRightImage = null;
            this.viewBtn.IndicateFocus = false;
            this.viewBtn.Location = new System.Drawing.Point(488, 415);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.viewBtn.OnDisabledState.BorderRadius = 1;
            this.viewBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnDisabledState.BorderThickness = 1;
            this.viewBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.viewBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.viewBtn.OnDisabledState.IconLeftImage = null;
            this.viewBtn.OnDisabledState.IconRightImage = null;
            this.viewBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.viewBtn.onHoverState.BorderRadius = 1;
            this.viewBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.onHoverState.BorderThickness = 1;
            this.viewBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.viewBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.onHoverState.IconLeftImage = null;
            this.viewBtn.onHoverState.IconRightImage = null;
            this.viewBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.viewBtn.OnIdleState.BorderRadius = 1;
            this.viewBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnIdleState.BorderThickness = 1;
            this.viewBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.viewBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.OnIdleState.IconLeftImage = null;
            this.viewBtn.OnIdleState.IconRightImage = null;
            this.viewBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.viewBtn.OnPressedState.BorderRadius = 1;
            this.viewBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.viewBtn.OnPressedState.BorderThickness = 1;
            this.viewBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.viewBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.viewBtn.OnPressedState.IconLeftImage = null;
            this.viewBtn.OnPressedState.IconRightImage = null;
            this.viewBtn.Size = new System.Drawing.Size(150, 39);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewBtn.TextMarginLeft = 0;
            this.viewBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.viewBtn.UseDefaultRadiusAndThickness = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AllowAnimations = true;
            this.editBtn.AllowMouseEffects = true;
            this.editBtn.AllowToggling = false;
            this.editBtn.AnimationSpeed = 200;
            this.editBtn.AutoGenerateColors = false;
            this.editBtn.AutoRoundBorders = false;
            this.editBtn.AutoSizeLeftIcon = true;
            this.editBtn.AutoSizeRightIcon = true;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.editBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBtn.BackgroundImage")));
            this.editBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.ButtonText = "edit";
            this.editBtn.ButtonTextMarginLeft = 0;
            this.editBtn.ColorContrastOnClick = 45;
            this.editBtn.ColorContrastOnHover = 45;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.editBtn.CustomizableEdges = borderEdges1;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.editBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.editBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.editBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconLeft = null;
            this.editBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.editBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.editBtn.IconMarginLeft = 11;
            this.editBtn.IconPadding = 10;
            this.editBtn.IconRight = null;
            this.editBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.editBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.editBtn.IconSize = 25;
            this.editBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.editBtn.IdleBorderRadius = 0;
            this.editBtn.IdleBorderThickness = 0;
            this.editBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.editBtn.IdleIconLeftImage = null;
            this.editBtn.IdleIconRightImage = null;
            this.editBtn.IndicateFocus = false;
            this.editBtn.Location = new System.Drawing.Point(507, 413);
            this.editBtn.Name = "editBtn";
            this.editBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.editBtn.OnDisabledState.BorderRadius = 1;
            this.editBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnDisabledState.BorderThickness = 1;
            this.editBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.editBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.editBtn.OnDisabledState.IconLeftImage = null;
            this.editBtn.OnDisabledState.IconRightImage = null;
            this.editBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.editBtn.onHoverState.BorderRadius = 1;
            this.editBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.onHoverState.BorderThickness = 1;
            this.editBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.editBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.editBtn.onHoverState.IconLeftImage = null;
            this.editBtn.onHoverState.IconRightImage = null;
            this.editBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editBtn.OnIdleState.BorderRadius = 1;
            this.editBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnIdleState.BorderThickness = 1;
            this.editBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.editBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.editBtn.OnIdleState.IconLeftImage = null;
            this.editBtn.OnIdleState.IconRightImage = null;
            this.editBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editBtn.OnPressedState.BorderRadius = 1;
            this.editBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.editBtn.OnPressedState.BorderThickness = 1;
            this.editBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.editBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.editBtn.OnPressedState.IconLeftImage = null;
            this.editBtn.OnPressedState.IconRightImage = null;
            this.editBtn.Size = new System.Drawing.Size(150, 39);
            this.editBtn.TabIndex = 1;
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBtn.TextMarginLeft = 0;
            this.editBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.editBtn.UseDefaultRadiusAndThickness = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.prodPages);
            this.Name = "ProductManagement";
            this.Size = new System.Drawing.Size(1230, 790);
            this.prodPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages prodPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton editBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton viewBtn;
    }
}
