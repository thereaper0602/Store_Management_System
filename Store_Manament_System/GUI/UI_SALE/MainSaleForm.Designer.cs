namespace GUI.UI_SALE
{
    partial class MainSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSaleForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.avatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnSideMenu = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPages = new Bunifu.UI.WinForms.BunifuPages();
            this.Stock = new System.Windows.Forms.TabPage();
            this.stockUC1 = new GUI.UI_SALE.StockUC();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sellingUC1 = new GUI.UI_SALE.SellingUC();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPages.SuspendLayout();
            this.Stock.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel2.Controls.Add(this.avatar);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel2.Controls.Add(this.bunifuButton21);
            this.bunifuPanel2.Controls.Add(this.btnSideMenu);
            this.bunifuPanel2.Location = new System.Drawing.Point(1, 2);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(265, 1053);
            this.bunifuPanel2.TabIndex = 6;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.AutoSize = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(97, 1005);
            this.bunifuLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(109, 32);
            this.bunifuLabel3.TabIndex = 8;
            this.bunifuLabel3.Text = "bunifuLabel3";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // avatar
            // 
            this.avatar.AllowFocused = false;
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.avatar.AutoSizeHeight = true;
            this.avatar.BorderRadius = 22;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.IsCircle = true;
            this.avatar.Location = new System.Drawing.Point(13, 998);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(44, 44);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 9;
            this.avatar.TabStop = false;
            this.avatar.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(85, 30);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(158, 36);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "WPN Shop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 33;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.Black_and_White_Modern_Shoes_Store_Logo__1_;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(13, 18);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(67, 67);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 1;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = true;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton21.ButtonText = "Stock";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges1;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.IdleBorderRadius = 41;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.IdleIconLeftImage = global::GUI.Properties.Resources.box_open_full;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(3, 249);
            this.bunifuButton21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 1;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.BorderRadius = 1;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton21.onHoverState.IconLeftImage = global::GUI.Properties.Resources.box_open_full__1_;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.box_open_full;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.BorderRadius = 1;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton21.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.cube_black;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(261, 43);
            this.bunifuButton21.TabIndex = 2;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.AllowAnimations = true;
            this.btnSideMenu.AllowMouseEffects = true;
            this.btnSideMenu.AllowToggling = false;
            this.btnSideMenu.AnimationSpeed = 5;
            this.btnSideMenu.AutoGenerateColors = false;
            this.btnSideMenu.AutoRoundBorders = true;
            this.btnSideMenu.AutoSizeLeftIcon = true;
            this.btnSideMenu.AutoSizeRightIcon = true;
            this.btnSideMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnSideMenu.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btnSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSideMenu.BackgroundImage")));
            this.btnSideMenu.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btnSideMenu.ButtonText = "Selling";
            this.btnSideMenu.ButtonTextMarginLeft = 0;
            this.btnSideMenu.ColorContrastOnClick = 45;
            this.btnSideMenu.ColorContrastOnHover = 45;
            this.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSideMenu.CustomizableEdges = borderEdges2;
            this.btnSideMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSideMenu.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSideMenu.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSideMenu.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSideMenu.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideMenu.ForeColor = System.Drawing.Color.White;
            this.btnSideMenu.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenu.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSideMenu.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSideMenu.IconMarginLeft = 11;
            this.btnSideMenu.IconPadding = 10;
            this.btnSideMenu.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSideMenu.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSideMenu.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSideMenu.IconSize = 25;
            this.btnSideMenu.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btnSideMenu.IdleBorderRadius = 41;
            this.btnSideMenu.IdleBorderThickness = 1;
            this.btnSideMenu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btnSideMenu.IdleIconLeftImage = global::GUI.Properties.Resources.cube_white;
            this.btnSideMenu.IdleIconRightImage = null;
            this.btnSideMenu.IndicateFocus = false;
            this.btnSideMenu.Location = new System.Drawing.Point(3, 167);
            this.btnSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSideMenu.OnDisabledState.BorderRadius = 1;
            this.btnSideMenu.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSideMenu.OnDisabledState.BorderThickness = 1;
            this.btnSideMenu.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSideMenu.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSideMenu.OnDisabledState.IconLeftImage = null;
            this.btnSideMenu.OnDisabledState.IconRightImage = null;
            this.btnSideMenu.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSideMenu.onHoverState.BorderRadius = 1;
            this.btnSideMenu.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSideMenu.onHoverState.BorderThickness = 1;
            this.btnSideMenu.onHoverState.FillColor = System.Drawing.Color.White;
            this.btnSideMenu.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSideMenu.onHoverState.IconLeftImage = global::GUI.Properties.Resources.cube_black;
            this.btnSideMenu.onHoverState.IconRightImage = null;
            this.btnSideMenu.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btnSideMenu.OnIdleState.BorderRadius = 1;
            this.btnSideMenu.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btnSideMenu.OnIdleState.BorderThickness = 1;
            this.btnSideMenu.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btnSideMenu.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSideMenu.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.cube_white;
            this.btnSideMenu.OnIdleState.IconRightImage = null;
            this.btnSideMenu.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnSideMenu.OnPressedState.BorderRadius = 1;
            this.btnSideMenu.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSideMenu.OnPressedState.BorderThickness = 1;
            this.btnSideMenu.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btnSideMenu.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnSideMenu.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.apps_black;
            this.btnSideMenu.OnPressedState.IconRightImage = null;
            this.btnSideMenu.Size = new System.Drawing.Size(261, 43);
            this.btnSideMenu.TabIndex = 1;
            this.btnSideMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideMenu.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSideMenu.TextMarginLeft = 0;
            this.btnSideMenu.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.btnSideMenu.UseDefaultRadiusAndThickness = true;
            this.btnSideMenu.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // bunifuPages
            // 
            this.bunifuPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages.AllowTransitions = false;
            this.bunifuPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPages.Controls.Add(this.Stock);
            this.bunifuPages.Controls.Add(this.tabPage1);
            this.bunifuPages.Location = new System.Drawing.Point(266, 2);
            this.bunifuPages.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPages.Multiline = true;
            this.bunifuPages.Name = "bunifuPages";
            this.bunifuPages.Page = this.tabPage1;
            this.bunifuPages.PageIndex = 1;
            this.bunifuPages.PageName = "tabPage1";
            this.bunifuPages.PageTitle = "Selling";
            this.bunifuPages.SelectedIndex = 0;
            this.bunifuPages.Size = new System.Drawing.Size(1755, 1102);
            this.bunifuPages.TabIndex = 8;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages.Transition = animation1;
            this.bunifuPages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.stockUC1);
            this.Stock.Location = new System.Drawing.Point(4, 4);
            this.Stock.Margin = new System.Windows.Forms.Padding(4);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(4);
            this.Stock.Size = new System.Drawing.Size(1747, 1073);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // stockUC1
            // 
            this.stockUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockUC1.Location = new System.Drawing.Point(4, 4);
            this.stockUC1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.stockUC1.Name = "stockUC1";
            this.stockUC1.Size = new System.Drawing.Size(1739, 1065);
            this.stockUC1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sellingUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1747, 1073);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Selling";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sellingUC1
            // 
            this.sellingUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellingUC1.Location = new System.Drawing.Point(3, 3);
            this.sellingUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellingUC1.Name = "sellingUC1";
            this.sellingUC1.Size = new System.Drawing.Size(1741, 1067);
            this.sellingUC1.TabIndex = 0;
            // 
            // MainSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.bunifuPages);
            this.Controls.Add(this.bunifuPanel2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPages.ResumeLayout(false);
            this.Stock.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSideMenu;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages;
        private System.Windows.Forms.TabPage Stock;
        private StockUC stockUC1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuPictureBox avatar;
        private System.Windows.Forms.TabPage tabPage1;
        private SellingUC sellingUC1;
    }
}