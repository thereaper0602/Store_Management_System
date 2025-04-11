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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.detail_cate = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Tick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btAddUser = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.remove_cate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.bunifuLabel1.Size = new System.Drawing.Size(411, 50);
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
            this.detail_cate.Location = new System.Drawing.Point(13, 95);
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
            this.detail_cate.Size = new System.Drawing.Size(1001, 677);
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
            // btAddUser
            // 
            this.btAddUser.AllowAnimations = true;
            this.btAddUser.AllowMouseEffects = true;
            this.btAddUser.AllowToggling = false;
            this.btAddUser.AnimationSpeed = 200;
            this.btAddUser.AutoGenerateColors = false;
            this.btAddUser.AutoRoundBorders = false;
            this.btAddUser.AutoSizeLeftIcon = true;
            this.btAddUser.AutoSizeRightIcon = true;
            this.btAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btAddUser.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddUser.BackgroundImage")));
            this.btAddUser.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAddUser.ButtonText = "+ Add";
            this.btAddUser.ButtonTextMarginLeft = 0;
            this.btAddUser.ColorContrastOnClick = 45;
            this.btAddUser.ColorContrastOnHover = 45;
            this.btAddUser.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btAddUser.CustomizableEdges = borderEdges1;
            this.btAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btAddUser.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btAddUser.DisabledFillColor = System.Drawing.Color.Empty;
            this.btAddUser.DisabledForecolor = System.Drawing.Color.Empty;
            this.btAddUser.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btAddUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAddUser.IconLeft = null;
            this.btAddUser.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddUser.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btAddUser.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btAddUser.IconMarginLeft = 11;
            this.btAddUser.IconPadding = 10;
            this.btAddUser.IconRight = null;
            this.btAddUser.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddUser.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btAddUser.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btAddUser.IconSize = 25;
            this.btAddUser.IdleBorderColor = System.Drawing.Color.Empty;
            this.btAddUser.IdleBorderRadius = 0;
            this.btAddUser.IdleBorderThickness = 0;
            this.btAddUser.IdleFillColor = System.Drawing.Color.Empty;
            this.btAddUser.IdleIconLeftImage = null;
            this.btAddUser.IdleIconRightImage = null;
            this.btAddUser.IndicateFocus = false;
            this.btAddUser.Location = new System.Drawing.Point(870, 20);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btAddUser.OnDisabledState.BorderRadius = 30;
            this.btAddUser.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAddUser.OnDisabledState.BorderThickness = 1;
            this.btAddUser.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddUser.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btAddUser.OnDisabledState.IconLeftImage = null;
            this.btAddUser.OnDisabledState.IconRightImage = null;
            this.btAddUser.onHoverState.BorderColor = System.Drawing.Color.Teal;
            this.btAddUser.onHoverState.BorderRadius = 30;
            this.btAddUser.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAddUser.onHoverState.BorderThickness = 1;
            this.btAddUser.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAddUser.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btAddUser.onHoverState.IconLeftImage = null;
            this.btAddUser.onHoverState.IconRightImage = null;
            this.btAddUser.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.btAddUser.OnIdleState.BorderRadius = 30;
            this.btAddUser.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAddUser.OnIdleState.BorderThickness = 1;
            this.btAddUser.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.btAddUser.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAddUser.OnIdleState.IconLeftImage = null;
            this.btAddUser.OnIdleState.IconRightImage = null;
            this.btAddUser.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btAddUser.OnPressedState.BorderRadius = 30;
            this.btAddUser.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btAddUser.OnPressedState.BorderThickness = 1;
            this.btAddUser.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btAddUser.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btAddUser.OnPressedState.IconLeftImage = null;
            this.btAddUser.OnPressedState.IconRightImage = null;
            this.btAddUser.Size = new System.Drawing.Size(144, 59);
            this.btAddUser.TabIndex = 13;
            this.btAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAddUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btAddUser.TextMarginLeft = 0;
            this.btAddUser.TextPadding = new System.Windows.Forms.Padding(0);
            this.btAddUser.UseDefaultRadiusAndThickness = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // remove_cate
            // 
            this.remove_cate.AllowAnimations = true;
            this.remove_cate.AllowMouseEffects = true;
            this.remove_cate.AllowToggling = false;
            this.remove_cate.AnimationSpeed = 200;
            this.remove_cate.AutoGenerateColors = false;
            this.remove_cate.AutoRoundBorders = false;
            this.remove_cate.AutoSizeLeftIcon = true;
            this.remove_cate.AutoSizeRightIcon = true;
            this.remove_cate.BackColor = System.Drawing.Color.Transparent;
            this.remove_cate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.remove_cate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove_cate.BackgroundImage")));
            this.remove_cate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.remove_cate.ButtonText = "Delete";
            this.remove_cate.ButtonTextMarginLeft = 0;
            this.remove_cate.ColorContrastOnClick = 45;
            this.remove_cate.ColorContrastOnHover = 45;
            this.remove_cate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.remove_cate.CustomizableEdges = borderEdges2;
            this.remove_cate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.remove_cate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.remove_cate.DisabledFillColor = System.Drawing.Color.Empty;
            this.remove_cate.DisabledForecolor = System.Drawing.Color.Empty;
            this.remove_cate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.remove_cate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remove_cate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.remove_cate.IconLeft = null;
            this.remove_cate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_cate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.remove_cate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.remove_cate.IconMarginLeft = 11;
            this.remove_cate.IconPadding = 10;
            this.remove_cate.IconRight = null;
            this.remove_cate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove_cate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.remove_cate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.remove_cate.IconSize = 25;
            this.remove_cate.IdleBorderColor = System.Drawing.Color.Empty;
            this.remove_cate.IdleBorderRadius = 0;
            this.remove_cate.IdleBorderThickness = 0;
            this.remove_cate.IdleFillColor = System.Drawing.Color.Empty;
            this.remove_cate.IdleIconLeftImage = null;
            this.remove_cate.IdleIconRightImage = null;
            this.remove_cate.IndicateFocus = false;
            this.remove_cate.Location = new System.Drawing.Point(699, 20);
            this.remove_cate.Name = "remove_cate";
            this.remove_cate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.remove_cate.OnDisabledState.BorderRadius = 30;
            this.remove_cate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.remove_cate.OnDisabledState.BorderThickness = 1;
            this.remove_cate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remove_cate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.remove_cate.OnDisabledState.IconLeftImage = null;
            this.remove_cate.OnDisabledState.IconRightImage = null;
            this.remove_cate.onHoverState.BorderColor = System.Drawing.Color.Teal;
            this.remove_cate.onHoverState.BorderRadius = 30;
            this.remove_cate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.remove_cate.onHoverState.BorderThickness = 1;
            this.remove_cate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.remove_cate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.remove_cate.onHoverState.IconLeftImage = null;
            this.remove_cate.onHoverState.IconRightImage = null;
            this.remove_cate.OnIdleState.BorderColor = System.Drawing.Color.CadetBlue;
            this.remove_cate.OnIdleState.BorderRadius = 30;
            this.remove_cate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.remove_cate.OnIdleState.BorderThickness = 1;
            this.remove_cate.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.remove_cate.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.remove_cate.OnIdleState.IconLeftImage = null;
            this.remove_cate.OnIdleState.IconRightImage = null;
            this.remove_cate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.remove_cate.OnPressedState.BorderRadius = 30;
            this.remove_cate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.remove_cate.OnPressedState.BorderThickness = 1;
            this.remove_cate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.remove_cate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.remove_cate.OnPressedState.IconLeftImage = null;
            this.remove_cate.OnPressedState.IconRightImage = null;
            this.remove_cate.Size = new System.Drawing.Size(145, 59);
            this.remove_cate.TabIndex = 12;
            this.remove_cate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remove_cate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.remove_cate.TextMarginLeft = 0;
            this.remove_cate.TextPadding = new System.Windows.Forms.Padding(0);
            this.remove_cate.UseDefaultRadiusAndThickness = true;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.remove_cate);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton remove_cate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btAddUser;
    }
}
