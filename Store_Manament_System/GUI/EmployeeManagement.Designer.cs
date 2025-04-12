namespace GUI
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.detail_cate = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Tick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.search_pro = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.searchbox_pro = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.addBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.detail_cate)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(252, 31);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "Employee Management";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // detail_cate
            // 
            this.detail_cate.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.detail_cate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.detail_cate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detail_cate.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.detail_cate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail_cate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.detail_cate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detail_cate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.detail_cate.ColumnHeadersHeight = 40;
            this.detail_cate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tick,
            this.UserID,
            this.Username,
            this.Email,
            this.Phone,
            this.Salary,
            this.btUpdate});
            this.detail_cate.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.detail_cate.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.detail_cate.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.detail_cate.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.detail_cate.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.detail_cate.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.detail_cate.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.detail_cate.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.detail_cate.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.detail_cate.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.detail_cate.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.detail_cate.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.detail_cate.CurrentTheme.Name = null;
            this.detail_cate.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.detail_cate.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.detail_cate.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.detail_cate.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.detail_cate.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detail_cate.DefaultCellStyle = dataGridViewCellStyle3;
            this.detail_cate.EnableHeadersVisualStyles = false;
            this.detail_cate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.detail_cate.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.detail_cate.HeaderBgColor = System.Drawing.Color.Empty;
            this.detail_cate.HeaderForeColor = System.Drawing.Color.White;
            this.detail_cate.Location = new System.Drawing.Point(13, 130);
            this.detail_cate.Name = "detail_cate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detail_cate.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detail_cate.RowHeadersVisible = false;
            this.detail_cate.RowHeadersWidth = 62;
            this.detail_cate.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_cate.RowTemplate.Height = 40;
            this.detail_cate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detail_cate.Size = new System.Drawing.Size(1199, 642);
            this.detail_cate.TabIndex = 6;
            this.detail_cate.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            // 
            // Tick
            // 
            this.Tick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tick.FillWeight = 44.8718F;
            this.Tick.Frozen = true;
            this.Tick.HeaderText = "";
            this.Tick.MinimumWidth = 10;
            this.Tick.Name = "Tick";
            this.Tick.Width = 74;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserID.FillWeight = 109.188F;
            this.UserID.Frozen = true;
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 10;
            this.UserID.Name = "UserID";
            this.UserID.Width = 80;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Username.FillWeight = 109.188F;
            this.Username.Frozen = true;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 180;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.FillWeight = 109.188F;
            this.Email.Frozen = true;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 180;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Phone.FillWeight = 109.188F;
            this.Phone.Frozen = true;
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 10;
            this.Phone.Name = "Phone";
            this.Phone.Width = 180;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salary.FillWeight = 109.188F;
            this.Salary.Frozen = true;
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 10;
            this.Salary.Name = "Salary";
            this.Salary.Width = 180;
            // 
            // btUpdate
            // 
            this.btUpdate.HeaderText = "";
            this.btUpdate.MinimumWidth = 10;
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Text = "Update";
            this.btUpdate.UseColumnTextForButtonValue = true;
            // 
            // search_pro
            // 
            this.search_pro.AllowAnimations = true;
            this.search_pro.AllowMouseEffects = true;
            this.search_pro.AllowToggling = false;
            this.search_pro.AnimationSpeed = 200;
            this.search_pro.AutoGenerateColors = false;
            this.search_pro.AutoRoundBorders = false;
            this.search_pro.AutoSizeLeftIcon = true;
            this.search_pro.AutoSizeRightIcon = true;
            this.search_pro.BackColor = System.Drawing.Color.Transparent;
            this.search_pro.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.search_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_pro.BackgroundImage")));
            this.search_pro.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_pro.ButtonText = "Search";
            this.search_pro.ButtonTextMarginLeft = 0;
            this.search_pro.ColorContrastOnClick = 45;
            this.search_pro.ColorContrastOnHover = 45;
            this.search_pro.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.search_pro.CustomizableEdges = borderEdges1;
            this.search_pro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search_pro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_pro.DisabledFillColor = System.Drawing.Color.Empty;
            this.search_pro.DisabledForecolor = System.Drawing.Color.Empty;
            this.search_pro.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.search_pro.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_pro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search_pro.IconLeft = null;
            this.search_pro.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_pro.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.search_pro.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.search_pro.IconMarginLeft = 11;
            this.search_pro.IconPadding = 10;
            this.search_pro.IconRight = null;
            this.search_pro.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_pro.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.search_pro.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.search_pro.IconSize = 25;
            this.search_pro.IdleBorderColor = System.Drawing.Color.Empty;
            this.search_pro.IdleBorderRadius = 0;
            this.search_pro.IdleBorderThickness = 0;
            this.search_pro.IdleFillColor = System.Drawing.Color.Empty;
            this.search_pro.IdleIconLeftImage = null;
            this.search_pro.IdleIconRightImage = null;
            this.search_pro.IndicateFocus = false;
            this.search_pro.Location = new System.Drawing.Point(547, 65);
            this.search_pro.Name = "search_pro";
            this.search_pro.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.search_pro.OnDisabledState.BorderRadius = 30;
            this.search_pro.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_pro.OnDisabledState.BorderThickness = 1;
            this.search_pro.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search_pro.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_pro.OnDisabledState.IconLeftImage = null;
            this.search_pro.OnDisabledState.IconRightImage = null;
            this.search_pro.onHoverState.BorderColor = System.Drawing.Color.Teal;
            this.search_pro.onHoverState.BorderRadius = 30;
            this.search_pro.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_pro.onHoverState.BorderThickness = 1;
            this.search_pro.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_pro.onHoverState.ForeColor = System.Drawing.Color.White;
            this.search_pro.onHoverState.IconLeftImage = null;
            this.search_pro.onHoverState.IconRightImage = null;
            this.search_pro.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.search_pro.OnIdleState.BorderRadius = 30;
            this.search_pro.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_pro.OnIdleState.BorderThickness = 1;
            this.search_pro.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.search_pro.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search_pro.OnIdleState.IconLeftImage = null;
            this.search_pro.OnIdleState.IconRightImage = null;
            this.search_pro.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_pro.OnPressedState.BorderRadius = 30;
            this.search_pro.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_pro.OnPressedState.BorderThickness = 1;
            this.search_pro.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.search_pro.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.search_pro.OnPressedState.IconLeftImage = null;
            this.search_pro.OnPressedState.IconRightImage = null;
            this.search_pro.Size = new System.Drawing.Size(103, 48);
            this.search_pro.TabIndex = 17;
            this.search_pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_pro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_pro.TextMarginLeft = 0;
            this.search_pro.TextPadding = new System.Windows.Forms.Padding(0);
            this.search_pro.UseDefaultRadiusAndThickness = true;
            // 
            // searchbox_pro
            // 
            this.searchbox_pro.AcceptsReturn = false;
            this.searchbox_pro.AcceptsTab = false;
            this.searchbox_pro.AnimationSpeed = 200;
            this.searchbox_pro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchbox_pro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchbox_pro.AutoSizeHeight = true;
            this.searchbox_pro.BackColor = System.Drawing.Color.Transparent;
            this.searchbox_pro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbox_pro.BackgroundImage")));
            this.searchbox_pro.BorderColorActive = System.Drawing.Color.PowderBlue;
            this.searchbox_pro.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchbox_pro.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchbox_pro.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchbox_pro.BorderRadius = 1;
            this.searchbox_pro.BorderThickness = 1;
            this.searchbox_pro.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.searchbox_pro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchbox_pro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox_pro.DefaultFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox_pro.DefaultText = "";
            this.searchbox_pro.FillColor = System.Drawing.Color.White;
            this.searchbox_pro.HideSelection = true;
            this.searchbox_pro.IconLeft = null;
            this.searchbox_pro.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox_pro.IconPadding = 10;
            this.searchbox_pro.IconRight = null;
            this.searchbox_pro.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox_pro.Lines = new string[0];
            this.searchbox_pro.Location = new System.Drawing.Point(13, 65);
            this.searchbox_pro.MaxLength = 32767;
            this.searchbox_pro.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchbox_pro.Modified = false;
            this.searchbox_pro.Multiline = false;
            this.searchbox_pro.Name = "searchbox_pro";
            stateProperties1.BorderColor = System.Drawing.Color.PowderBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox_pro.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchbox_pro.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox_pro.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchbox_pro.OnIdleState = stateProperties4;
            this.searchbox_pro.Padding = new System.Windows.Forms.Padding(3);
            this.searchbox_pro.PasswordChar = '\0';
            this.searchbox_pro.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchbox_pro.PlaceholderText = "Search here...";
            this.searchbox_pro.ReadOnly = false;
            this.searchbox_pro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchbox_pro.SelectedText = "";
            this.searchbox_pro.SelectionLength = 0;
            this.searchbox_pro.SelectionStart = 0;
            this.searchbox_pro.ShortcutsEnabled = true;
            this.searchbox_pro.Size = new System.Drawing.Size(503, 48);
            this.searchbox_pro.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchbox_pro.TabIndex = 16;
            this.searchbox_pro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbox_pro.TextMarginBottom = 0;
            this.searchbox_pro.TextMarginLeft = 3;
            this.searchbox_pro.TextMarginTop = 1;
            this.searchbox_pro.TextPlaceholder = "Search here...";
            this.searchbox_pro.UseSystemPasswordChar = false;
            this.searchbox_pro.WordWrap = true;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = false;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Delete";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges2;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Poppins", 12F);
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
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.White;
            this.bunifuButton21.IdleBorderRadius = 30;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.IdleIconRightImage")));
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(965, 65);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 30;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 30;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.BorderRadius = 30;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.OnIdleState.IconRightImage")));
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 30;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(117, 47);
            this.bunifuButton21.TabIndex = 24;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            // 
            // addBtn
            // 
            this.addBtn.AllowAnimations = false;
            this.addBtn.AllowMouseEffects = true;
            this.addBtn.AllowToggling = false;
            this.addBtn.AnimationSpeed = 200;
            this.addBtn.AutoGenerateColors = false;
            this.addBtn.AutoRoundBorders = false;
            this.addBtn.AutoSizeLeftIcon = true;
            this.addBtn.AutoSizeRightIcon = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor1 = System.Drawing.Color.CadetBlue;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.addBtn.ButtonText = "Add";
            this.addBtn.ButtonTextMarginLeft = 0;
            this.addBtn.ColorContrastOnClick = 45;
            this.addBtn.ColorContrastOnHover = 45;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.addBtn.CustomizableEdges = borderEdges3;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.addBtn.Font = new System.Drawing.Font("Poppins", 12F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addBtn.IconMarginLeft = 11;
            this.addBtn.IconPadding = 10;
            this.addBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addBtn.IconSize = 25;
            this.addBtn.IdleBorderColor = System.Drawing.Color.White;
            this.addBtn.IdleBorderRadius = 30;
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleFillColor = System.Drawing.Color.CadetBlue;
            this.addBtn.IdleIconLeftImage = null;
            this.addBtn.IdleIconRightImage = ((System.Drawing.Image)(resources.GetObject("addBtn.IdleIconRightImage")));
            this.addBtn.IndicateFocus = false;
            this.addBtn.Location = new System.Drawing.Point(1114, 65);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.OnDisabledState.BorderRadius = 30;
            this.addBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.addBtn.OnDisabledState.BorderThickness = 1;
            this.addBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addBtn.OnDisabledState.IconLeftImage = null;
            this.addBtn.OnDisabledState.IconRightImage = null;
            this.addBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.BorderRadius = 30;
            this.addBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.addBtn.onHoverState.BorderThickness = 1;
            this.addBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addBtn.onHoverState.IconLeftImage = null;
            this.addBtn.onHoverState.IconRightImage = null;
            this.addBtn.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.addBtn.OnIdleState.BorderRadius = 30;
            this.addBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.addBtn.OnIdleState.BorderThickness = 1;
            this.addBtn.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.addBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnIdleState.IconLeftImage = null;
            this.addBtn.OnIdleState.IconRightImage = ((System.Drawing.Image)(resources.GetObject("addBtn.OnIdleState.IconRightImage")));
            this.addBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.BorderRadius = 30;
            this.addBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.addBtn.OnPressedState.BorderThickness = 1;
            this.addBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnPressedState.IconLeftImage = null;
            this.addBtn.OnPressedState.IconRightImage = null;
            this.addBtn.Size = new System.Drawing.Size(98, 47);
            this.addBtn.TabIndex = 23;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addBtn.TextMarginLeft = 0;
            this.addBtn.TextPadding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.addBtn.UseDefaultRadiusAndThickness = true;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.bunifuButton21);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.search_pro);
            this.Controls.Add(this.searchbox_pro);
            this.Controls.Add(this.detail_cate);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "EmployeeManagement";
            this.Size = new System.Drawing.Size(1230, 790);
            ((System.ComponentModel.ISupportInitialize)(this.detail_cate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDataGridView detail_cate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewButtonColumn btUpdate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton search_pro;
        private Bunifu.UI.WinForms.BunifuTextBox searchbox_pro;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 addBtn;
    }
}
