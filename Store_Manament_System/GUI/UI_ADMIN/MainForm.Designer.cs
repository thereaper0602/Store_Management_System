namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productManagement1 = new GUI.ProductManagement();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.categoryManagement1 = new GUI.CategoryManagement();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeManagement1 = new GUI.EmployeeManagement();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.promotion1 = new GUI.Promotion();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.statistics1 = new GUI.Statistics();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_SignOut = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.User_FullName = new Bunifu.UI.WinForms.BunifuLabel();
            this.avatar = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuButton26 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton25 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton24 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton23 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuFormControlBox1 = new Bunifu.UI.WinForms.BunifuFormControlBox();
            this.bunifuPanel3.SuspendLayout();
            this.pages.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 3;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.pages);
            this.bunifuPanel3.Location = new System.Drawing.Point(264, 32);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(1238, 819);
            this.bunifuPanel3.TabIndex = 5;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Controls.Add(this.tabPage3);
            this.pages.Controls.Add(this.tabPage4);
            this.pages.Controls.Add(this.tabPage5);
            this.pages.Controls.Add(this.tabPage6);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(0, 0);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage3;
            this.pages.PageIndex = 1;
            this.pages.PageName = "tabPage3";
            this.pages.PageTitle = "Category Management";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1238, 819);
            this.pages.TabIndex = 1;
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
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productManagement1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1230, 786);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productManagement1
            // 
            this.productManagement1.BackColor = System.Drawing.Color.White;
            this.productManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productManagement1.Location = new System.Drawing.Point(0, 0);
            this.productManagement1.Name = "productManagement1";
            this.productManagement1.Size = new System.Drawing.Size(1230, 786);
            this.productManagement1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.categoryManagement1);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1230, 786);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Category Management";
            // 
            // categoryManagement1
            // 
            this.categoryManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryManagement1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryManagement1.Location = new System.Drawing.Point(0, 0);
            this.categoryManagement1.Name = "categoryManagement1";
            this.categoryManagement1.Size = new System.Drawing.Size(1230, 790);
            this.categoryManagement1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.employeeManagement1);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1230, 786);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Employee Management";
            // 
            // employeeManagement1
            // 
            this.employeeManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeManagement1.Location = new System.Drawing.Point(0, 0);
            this.employeeManagement1.Name = "employeeManagement1";
            this.employeeManagement1.Size = new System.Drawing.Size(1230, 786);
            this.employeeManagement1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.promotion1);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1230, 786);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Promotion";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // promotion1
            // 
            this.promotion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotion1.Location = new System.Drawing.Point(0, 0);
            this.promotion1.Name = "promotion1";
            this.promotion1.Size = new System.Drawing.Size(1230, 786);
            this.promotion1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.statistics1);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1230, 786);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Statistics Reports";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // statistics1
            // 
            this.statistics1.AutoScroll = true;
            this.statistics1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistics1.Location = new System.Drawing.Point(0, 0);
            this.statistics1.Name = "statistics1";
            this.statistics1.Size = new System.Drawing.Size(1230, 786);
            this.statistics1.TabIndex = 0;
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
            this.bunifuPanel2.Controls.Add(this.btn_SignOut);
            this.bunifuPanel2.Controls.Add(this.User_FullName);
            this.bunifuPanel2.Controls.Add(this.avatar);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Controls.Add(this.bunifuPictureBox1);
            this.bunifuPanel2.Controls.Add(this.bunifuButton26);
            this.bunifuPanel2.Controls.Add(this.bunifuButton25);
            this.bunifuPanel2.Controls.Add(this.bunifuButton24);
            this.bunifuPanel2.Controls.Add(this.bunifuButton23);
            this.bunifuPanel2.Controls.Add(this.bunifuButton21);
            this.bunifuPanel2.Location = new System.Drawing.Point(-1, 31);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(264, 819);
            this.bunifuPanel2.TabIndex = 4;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.AllowAnimations = true;
            this.btn_SignOut.AllowMouseEffects = true;
            this.btn_SignOut.AllowToggling = false;
            this.btn_SignOut.AnimationSpeed = 1;
            this.btn_SignOut.AutoGenerateColors = false;
            this.btn_SignOut.AutoRoundBorders = true;
            this.btn_SignOut.AutoSizeLeftIcon = true;
            this.btn_SignOut.AutoSizeRightIcon = true;
            this.btn_SignOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignOut.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btn_SignOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SignOut.BackgroundImage")));
            this.btn_SignOut.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btn_SignOut.ButtonText = "Sign out";
            this.btn_SignOut.ButtonTextMarginLeft = 0;
            this.btn_SignOut.ColorContrastOnClick = 45;
            this.btn_SignOut.ColorContrastOnHover = 45;
            this.btn_SignOut.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_SignOut.CustomizableEdges = borderEdges1;
            this.btn_SignOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_SignOut.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SignOut.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SignOut.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SignOut.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_SignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SignOut.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_SignOut.IconMarginLeft = 11;
            this.btn_SignOut.IconPadding = 10;
            this.btn_SignOut.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SignOut.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_SignOut.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_SignOut.IconSize = 25;
            this.btn_SignOut.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btn_SignOut.IdleBorderRadius = 41;
            this.btn_SignOut.IdleBorderThickness = 1;
            this.btn_SignOut.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btn_SignOut.IdleIconLeftImage = global::GUI.Properties.Resources.sign_out_white;
            this.btn_SignOut.IdleIconRightImage = null;
            this.btn_SignOut.IndicateFocus = false;
            this.btn_SignOut.Location = new System.Drawing.Point(3, 752);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_SignOut.OnDisabledState.BorderRadius = 1;
            this.btn_SignOut.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_SignOut.OnDisabledState.BorderThickness = 1;
            this.btn_SignOut.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_SignOut.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_SignOut.OnDisabledState.IconLeftImage = null;
            this.btn_SignOut.OnDisabledState.IconRightImage = null;
            this.btn_SignOut.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btn_SignOut.onHoverState.BorderRadius = 1;
            this.btn_SignOut.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_SignOut.onHoverState.BorderThickness = 1;
            this.btn_SignOut.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn_SignOut.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_SignOut.onHoverState.IconLeftImage = global::GUI.Properties.Resources.sign_out_black;
            this.btn_SignOut.onHoverState.IconRightImage = null;
            this.btn_SignOut.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btn_SignOut.OnIdleState.BorderRadius = 1;
            this.btn_SignOut.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btn_SignOut.OnIdleState.BorderThickness = 1;
            this.btn_SignOut.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.btn_SignOut.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.sign_out_white;
            this.btn_SignOut.OnIdleState.IconRightImage = null;
            this.btn_SignOut.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_SignOut.OnPressedState.BorderRadius = 1;
            this.btn_SignOut.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_SignOut.OnPressedState.BorderThickness = 1;
            this.btn_SignOut.OnPressedState.FillColor = System.Drawing.Color.White;
            this.btn_SignOut.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btn_SignOut.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.employee_man_black;
            this.btn_SignOut.OnPressedState.IconRightImage = null;
            this.btn_SignOut.Size = new System.Drawing.Size(261, 43);
            this.btn_SignOut.TabIndex = 8;
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_SignOut.TextMarginLeft = 0;
            this.btn_SignOut.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.btn_SignOut.UseDefaultRadiusAndThickness = true;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // User_FullName
            // 
            this.User_FullName.AllowParentOverrides = false;
            this.User_FullName.AutoEllipsis = false;
            this.User_FullName.AutoSize = false;
            this.User_FullName.Cursor = System.Windows.Forms.Cursors.Default;
            this.User_FullName.CursorType = System.Windows.Forms.Cursors.Default;
            this.User_FullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.User_FullName.ForeColor = System.Drawing.Color.White;
            this.User_FullName.Location = new System.Drawing.Point(77, 699);
            this.User_FullName.Name = "User_FullName";
            this.User_FullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.User_FullName.Size = new System.Drawing.Size(123, 40);
            this.User_FullName.TabIndex = 1;
            this.User_FullName.Text = "User";
            this.User_FullName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.User_FullName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // avatar
            // 
            this.avatar.AllowFocused = false;
            this.avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.avatar.AutoSizeHeight = true;
            this.avatar.BorderRadius = 24;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.IsCircle = true;
            this.avatar.Location = new System.Drawing.Point(13, 690);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(49, 49);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 7;
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
            this.bunifuLabel2.Location = new System.Drawing.Point(85, 31);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(186, 40);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "WPN Shop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 33;
            this.bunifuPictureBox1.Image = global::GUI.Properties.Resources.Black_and_White_Modern_Shoes_Store_Logo__1_;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(13, 18);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(66, 66);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuButton26
            // 
            this.bunifuButton26.AllowAnimations = true;
            this.bunifuButton26.AllowMouseEffects = true;
            this.bunifuButton26.AllowToggling = false;
            this.bunifuButton26.AnimationSpeed = 1;
            this.bunifuButton26.AutoGenerateColors = false;
            this.bunifuButton26.AutoRoundBorders = true;
            this.bunifuButton26.AutoSizeLeftIcon = true;
            this.bunifuButton26.AutoSizeRightIcon = true;
            this.bunifuButton26.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton26.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton26.BackgroundImage")));
            this.bunifuButton26.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton26.ButtonText = "Statistics Reports";
            this.bunifuButton26.ButtonTextMarginLeft = 0;
            this.bunifuButton26.ColorContrastOnClick = 45;
            this.bunifuButton26.ColorContrastOnHover = 45;
            this.bunifuButton26.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton26.CustomizableEdges = borderEdges2;
            this.bunifuButton26.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton26.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton26.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton26.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton26.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton26.ForeColor = System.Drawing.Color.White;
            this.bunifuButton26.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton26.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton26.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton26.IconMarginLeft = 11;
            this.bunifuButton26.IconPadding = 10;
            this.bunifuButton26.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton26.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton26.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton26.IconSize = 25;
            this.bunifuButton26.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton26.IdleBorderRadius = 41;
            this.bunifuButton26.IdleBorderThickness = 1;
            this.bunifuButton26.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton26.IdleIconLeftImage = global::GUI.Properties.Resources.chart_histogram_white;
            this.bunifuButton26.IdleIconRightImage = null;
            this.bunifuButton26.IndicateFocus = false;
            this.bunifuButton26.Location = new System.Drawing.Point(3, 508);
            this.bunifuButton26.Name = "bunifuButton26";
            this.bunifuButton26.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton26.OnDisabledState.BorderRadius = 1;
            this.bunifuButton26.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton26.OnDisabledState.BorderThickness = 1;
            this.bunifuButton26.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton26.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton26.OnDisabledState.IconLeftImage = null;
            this.bunifuButton26.OnDisabledState.IconRightImage = null;
            this.bunifuButton26.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton26.onHoverState.BorderRadius = 1;
            this.bunifuButton26.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton26.onHoverState.BorderThickness = 1;
            this.bunifuButton26.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton26.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton26.onHoverState.IconLeftImage = global::GUI.Properties.Resources.chart_histogram;
            this.bunifuButton26.onHoverState.IconRightImage = null;
            this.bunifuButton26.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton26.OnIdleState.BorderRadius = 1;
            this.bunifuButton26.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton26.OnIdleState.BorderThickness = 1;
            this.bunifuButton26.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton26.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton26.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.chart_histogram_white;
            this.bunifuButton26.OnIdleState.IconRightImage = null;
            this.bunifuButton26.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton26.OnPressedState.BorderRadius = 1;
            this.bunifuButton26.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton26.OnPressedState.BorderThickness = 1;
            this.bunifuButton26.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton26.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton26.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.chart_histogram;
            this.bunifuButton26.OnPressedState.IconRightImage = null;
            this.bunifuButton26.Size = new System.Drawing.Size(261, 43);
            this.bunifuButton26.TabIndex = 6;
            this.bunifuButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton26.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton26.TextMarginLeft = 0;
            this.bunifuButton26.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.bunifuButton26.UseDefaultRadiusAndThickness = true;
            this.bunifuButton26.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // bunifuButton25
            // 
            this.bunifuButton25.AllowAnimations = true;
            this.bunifuButton25.AllowMouseEffects = true;
            this.bunifuButton25.AllowToggling = false;
            this.bunifuButton25.AnimationSpeed = 1;
            this.bunifuButton25.AutoGenerateColors = false;
            this.bunifuButton25.AutoRoundBorders = true;
            this.bunifuButton25.AutoSizeLeftIcon = true;
            this.bunifuButton25.AutoSizeRightIcon = true;
            this.bunifuButton25.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton25.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton25.BackgroundImage")));
            this.bunifuButton25.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton25.ButtonText = "Promotion";
            this.bunifuButton25.ButtonTextMarginLeft = 0;
            this.bunifuButton25.ColorContrastOnClick = 45;
            this.bunifuButton25.ColorContrastOnHover = 45;
            this.bunifuButton25.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton25.CustomizableEdges = borderEdges3;
            this.bunifuButton25.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton25.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton25.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton25.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton25.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton25.ForeColor = System.Drawing.Color.White;
            this.bunifuButton25.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton25.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton25.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton25.IconMarginLeft = 11;
            this.bunifuButton25.IconPadding = 10;
            this.bunifuButton25.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton25.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton25.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton25.IconSize = 25;
            this.bunifuButton25.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton25.IdleBorderRadius = 41;
            this.bunifuButton25.IdleBorderThickness = 1;
            this.bunifuButton25.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton25.IdleIconLeftImage = global::GUI.Properties.Resources.gift_white;
            this.bunifuButton25.IdleIconRightImage = null;
            this.bunifuButton25.IndicateFocus = false;
            this.bunifuButton25.Location = new System.Drawing.Point(2, 423);
            this.bunifuButton25.Name = "bunifuButton25";
            this.bunifuButton25.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton25.OnDisabledState.BorderRadius = 1;
            this.bunifuButton25.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton25.OnDisabledState.BorderThickness = 1;
            this.bunifuButton25.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton25.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton25.OnDisabledState.IconLeftImage = null;
            this.bunifuButton25.OnDisabledState.IconRightImage = null;
            this.bunifuButton25.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton25.onHoverState.BorderRadius = 1;
            this.bunifuButton25.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton25.onHoverState.BorderThickness = 1;
            this.bunifuButton25.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton25.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton25.onHoverState.IconLeftImage = global::GUI.Properties.Resources.gift;
            this.bunifuButton25.onHoverState.IconRightImage = null;
            this.bunifuButton25.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton25.OnIdleState.BorderRadius = 1;
            this.bunifuButton25.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton25.OnIdleState.BorderThickness = 1;
            this.bunifuButton25.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton25.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton25.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.gift_white;
            this.bunifuButton25.OnIdleState.IconRightImage = null;
            this.bunifuButton25.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton25.OnPressedState.BorderRadius = 1;
            this.bunifuButton25.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton25.OnPressedState.BorderThickness = 1;
            this.bunifuButton25.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton25.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton25.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.gift;
            this.bunifuButton25.OnPressedState.IconRightImage = null;
            this.bunifuButton25.Size = new System.Drawing.Size(261, 43);
            this.bunifuButton25.TabIndex = 5;
            this.bunifuButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton25.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton25.TextMarginLeft = 0;
            this.bunifuButton25.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.bunifuButton25.UseDefaultRadiusAndThickness = true;
            this.bunifuButton25.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // bunifuButton24
            // 
            this.bunifuButton24.AllowAnimations = true;
            this.bunifuButton24.AllowMouseEffects = true;
            this.bunifuButton24.AllowToggling = false;
            this.bunifuButton24.AnimationSpeed = 1;
            this.bunifuButton24.AutoGenerateColors = false;
            this.bunifuButton24.AutoRoundBorders = true;
            this.bunifuButton24.AutoSizeLeftIcon = true;
            this.bunifuButton24.AutoSizeRightIcon = true;
            this.bunifuButton24.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton24.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton24.BackgroundImage")));
            this.bunifuButton24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton24.ButtonText = "Employee Management";
            this.bunifuButton24.ButtonTextMarginLeft = 0;
            this.bunifuButton24.ColorContrastOnClick = 45;
            this.bunifuButton24.ColorContrastOnHover = 45;
            this.bunifuButton24.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton24.CustomizableEdges = borderEdges4;
            this.bunifuButton24.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton24.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton24.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton24.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton24.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton24.ForeColor = System.Drawing.Color.White;
            this.bunifuButton24.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton24.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton24.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton24.IconMarginLeft = 11;
            this.bunifuButton24.IconPadding = 10;
            this.bunifuButton24.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton24.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton24.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton24.IconSize = 25;
            this.bunifuButton24.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton24.IdleBorderRadius = 41;
            this.bunifuButton24.IdleBorderThickness = 1;
            this.bunifuButton24.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton24.IdleIconLeftImage = global::GUI.Properties.Resources.employee_man_white;
            this.bunifuButton24.IdleIconRightImage = null;
            this.bunifuButton24.IndicateFocus = false;
            this.bunifuButton24.Location = new System.Drawing.Point(2, 338);
            this.bunifuButton24.Name = "bunifuButton24";
            this.bunifuButton24.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton24.OnDisabledState.BorderRadius = 1;
            this.bunifuButton24.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton24.OnDisabledState.BorderThickness = 1;
            this.bunifuButton24.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton24.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton24.OnDisabledState.IconLeftImage = null;
            this.bunifuButton24.OnDisabledState.IconRightImage = null;
            this.bunifuButton24.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton24.onHoverState.BorderRadius = 1;
            this.bunifuButton24.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton24.onHoverState.BorderThickness = 1;
            this.bunifuButton24.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton24.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton24.onHoverState.IconLeftImage = global::GUI.Properties.Resources.employee_man_black;
            this.bunifuButton24.onHoverState.IconRightImage = null;
            this.bunifuButton24.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton24.OnIdleState.BorderRadius = 1;
            this.bunifuButton24.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton24.OnIdleState.BorderThickness = 1;
            this.bunifuButton24.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton24.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton24.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.employee_man_white;
            this.bunifuButton24.OnIdleState.IconRightImage = null;
            this.bunifuButton24.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton24.OnPressedState.BorderRadius = 1;
            this.bunifuButton24.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton24.OnPressedState.BorderThickness = 1;
            this.bunifuButton24.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton24.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton24.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.employee_man_black;
            this.bunifuButton24.OnPressedState.IconRightImage = null;
            this.bunifuButton24.Size = new System.Drawing.Size(261, 43);
            this.bunifuButton24.TabIndex = 4;
            this.bunifuButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton24.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton24.TextMarginLeft = 0;
            this.bunifuButton24.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.bunifuButton24.UseDefaultRadiusAndThickness = true;
            this.bunifuButton24.Click += new System.EventHandler(this.btnSideMenu_Click);
            // 
            // bunifuButton23
            // 
            this.bunifuButton23.AllowAnimations = true;
            this.bunifuButton23.AllowMouseEffects = true;
            this.bunifuButton23.AllowToggling = false;
            this.bunifuButton23.AnimationSpeed = 1;
            this.bunifuButton23.AutoGenerateColors = false;
            this.bunifuButton23.AutoRoundBorders = true;
            this.bunifuButton23.AutoSizeLeftIcon = true;
            this.bunifuButton23.AutoSizeRightIcon = true;
            this.bunifuButton23.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton23.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton23.BackgroundImage")));
            this.bunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton23.ButtonText = "Category Management";
            this.bunifuButton23.ButtonTextMarginLeft = 0;
            this.bunifuButton23.ColorContrastOnClick = 45;
            this.bunifuButton23.ColorContrastOnHover = 45;
            this.bunifuButton23.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.bunifuButton23.CustomizableEdges = borderEdges5;
            this.bunifuButton23.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton23.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton23.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton23.IconMarginLeft = 11;
            this.bunifuButton23.IconPadding = 10;
            this.bunifuButton23.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton23.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton23.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton23.IconSize = 25;
            this.bunifuButton23.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton23.IdleBorderRadius = 41;
            this.bunifuButton23.IdleBorderThickness = 1;
            this.bunifuButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton23.IdleIconLeftImage = global::GUI.Properties.Resources.tags__1_;
            this.bunifuButton23.IdleIconRightImage = null;
            this.bunifuButton23.IndicateFocus = false;
            this.bunifuButton23.Location = new System.Drawing.Point(3, 253);
            this.bunifuButton23.Name = "bunifuButton23";
            this.bunifuButton23.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton23.OnDisabledState.BorderRadius = 1;
            this.bunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnDisabledState.BorderThickness = 1;
            this.bunifuButton23.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton23.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton23.OnDisabledState.IconLeftImage = null;
            this.bunifuButton23.OnDisabledState.IconRightImage = null;
            this.bunifuButton23.onHoverState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton23.onHoverState.BorderRadius = 1;
            this.bunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.onHoverState.BorderThickness = 1;
            this.bunifuButton23.onHoverState.FillColor = System.Drawing.Color.White;
            this.bunifuButton23.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton23.onHoverState.IconLeftImage = global::GUI.Properties.Resources.tags;
            this.bunifuButton23.onHoverState.IconRightImage = null;
            this.bunifuButton23.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton23.OnIdleState.BorderRadius = 1;
            this.bunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton23.OnIdleState.BorderThickness = 1;
            this.bunifuButton23.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton23.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton23.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.tags__1_;
            this.bunifuButton23.OnIdleState.IconRightImage = null;
            this.bunifuButton23.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton23.OnPressedState.BorderRadius = 1;
            this.bunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton23.OnPressedState.BorderThickness = 1;
            this.bunifuButton23.OnPressedState.FillColor = System.Drawing.Color.White;
            this.bunifuButton23.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton23.OnPressedState.IconLeftImage = global::GUI.Properties.Resources.tags;
            this.bunifuButton23.OnPressedState.IconRightImage = null;
            this.bunifuButton23.Size = new System.Drawing.Size(261, 43);
            this.bunifuButton23.TabIndex = 3;
            this.bunifuButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton23.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton23.TextMarginLeft = 0;
            this.bunifuButton23.TextPadding = new System.Windows.Forms.Padding(35, 2, 0, 0);
            this.bunifuButton23.UseDefaultRadiusAndThickness = true;
            this.bunifuButton23.Click += new System.EventHandler(this.btnSideMenu_Click);
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
            this.bunifuButton21.ButtonText = "Product Management";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges6;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuButton21.IdleIconLeftImage = global::GUI.Properties.Resources.cube_white;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(2, 168);
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
            this.bunifuButton21.onHoverState.IconLeftImage = global::GUI.Properties.Resources.cube_black;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = global::GUI.Properties.Resources.cube_white;
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.bunifuFormControlBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(2, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1496, 29);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 14;
            this.bunifuPictureBox2.Image = global::GUI.Properties.Resources.Black_and_White_Modern_Shoes_Store_Logo__1_;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(29, 29);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 1;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.Location = new System.Drawing.Point(35, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(150, 25);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "WPN Management";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuFormControlBox1
            // 
            this.bunifuFormControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFormControlBox1.BackColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.BunifuFormDrag = null;
            this.bunifuFormControlBox1.CloseBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.CloseBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.CloseBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.CloseBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.CloseBoxOptions.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.CloseBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.CloseBoxOptions.Icon")));
            this.bunifuFormControlBox1.CloseBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.CloseBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.CloseBoxOptions.IconHoverColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconPressedColor = System.Drawing.Color.White;
            this.bunifuFormControlBox1.CloseBoxOptions.IconSize = new System.Drawing.Size(18, 18);
            this.bunifuFormControlBox1.CloseBoxOptions.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.bunifuFormControlBox1.HelpBox = false;
            this.bunifuFormControlBox1.HelpBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.HelpBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.HelpBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.HelpBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.HelpBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.HelpBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.HelpBoxOptions.Icon")));
            this.bunifuFormControlBox1.HelpBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.HelpBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.HelpBoxOptions.IconSize = new System.Drawing.Size(22, 22);
            this.bunifuFormControlBox1.HelpBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Location = new System.Drawing.Point(1335, 0);
            this.bunifuFormControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuFormControlBox1.MaximizeBox = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MaximizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MaximizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MaximizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconAlt = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MaximizeBoxOptions.IconAlt")));
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MaximizeBoxOptions.IconSize = new System.Drawing.Size(16, 16);
            this.bunifuFormControlBox1.MaximizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.MinimizeBox = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormControlBox1.MinimizeBoxOptions.BorderRadius = 0;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Enabled = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.EnableDefaultAction = true;
            this.bunifuFormControlBox1.MinimizeBoxOptions.HoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormControlBox1.MinimizeBoxOptions.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuFormControlBox1.MinimizeBoxOptions.Icon")));
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconAlt = null;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormControlBox1.MinimizeBoxOptions.IconSize = new System.Drawing.Size(14, 14);
            this.bunifuFormControlBox1.MinimizeBoxOptions.PressedColor = System.Drawing.Color.Silver;
            this.bunifuFormControlBox1.Name = "bunifuFormControlBox1";
            this.bunifuFormControlBox1.ShowDesignBorders = false;
            this.bunifuFormControlBox1.Size = new System.Drawing.Size(161, 29);
            this.bunifuFormControlBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bunifuPanel3.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormControlBox bunifuFormControlBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        //private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Promotion promotion1;
        private EmployeeManagement employeeManagement1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton25;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton24;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton23;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton26;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        //private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private CategoryManagement categoryManagement1;
        private ProductManagement productManagement1;
        private Statistics statistics1;
        private Bunifu.UI.WinForms.BunifuLabel User_FullName;
        private Bunifu.UI.WinForms.BunifuPictureBox avatar;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_SignOut;
    }
}
