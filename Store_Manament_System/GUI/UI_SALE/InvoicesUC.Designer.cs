namespace GUI.UI_SALE
{
    partial class InvoicesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesUC));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.lb_invoices = new Bunifu.UI.WinForms.BunifuLabel();
            this.searchInvoices = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Invoices_History = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.selected_Invoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Invoice_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail_Invoice = new System.Windows.Forms.GroupBox();
            this.print_invoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.DetailTable = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Detail_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_invoice = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.invoiceTimeFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.invoiceTimeTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label_inv1 = new System.Windows.Forms.Label();
            this.label1_inv = new System.Windows.Forms.Label();
            this.btnSearchByDate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_History)).BeginInit();
            this.Detail_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_invoices
            // 
            this.lb_invoices.AllowParentOverrides = false;
            this.lb_invoices.AutoEllipsis = false;
            this.lb_invoices.AutoSize = false;
            this.lb_invoices.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_invoices.CursorType = System.Windows.Forms.Cursors.Default;
            this.lb_invoices.Font = new System.Drawing.Font("Poppins", 20F);
            this.lb_invoices.Location = new System.Drawing.Point(27, 5);
            this.lb_invoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_invoices.Name = "lb_invoices";
            this.lb_invoices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_invoices.Size = new System.Drawing.Size(164, 49);
            this.lb_invoices.TabIndex = 29;
            this.lb_invoices.Text = "Invoices";
            this.lb_invoices.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_invoices.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // searchInvoices
            // 
            this.searchInvoices.AcceptsReturn = false;
            this.searchInvoices.AcceptsTab = false;
            this.searchInvoices.AnimationSpeed = 200;
            this.searchInvoices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchInvoices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchInvoices.AutoSizeHeight = true;
            this.searchInvoices.BackColor = System.Drawing.Color.Transparent;
            this.searchInvoices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchInvoices.BackgroundImage")));
            this.searchInvoices.BorderColorActive = System.Drawing.Color.Silver;
            this.searchInvoices.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchInvoices.BorderColorHover = System.Drawing.Color.Silver;
            this.searchInvoices.BorderColorIdle = System.Drawing.Color.Silver;
            this.searchInvoices.BorderRadius = 10;
            this.searchInvoices.BorderThickness = 1;
            this.searchInvoices.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.searchInvoices.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchInvoices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInvoices.DefaultFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoices.DefaultText = "";
            this.searchInvoices.FillColor = System.Drawing.Color.White;
            this.searchInvoices.HideSelection = true;
            this.searchInvoices.IconLeft = null;
            this.searchInvoices.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInvoices.IconPadding = 10;
            this.searchInvoices.IconRight = null;
            this.searchInvoices.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInvoices.Lines = new string[0];
            this.searchInvoices.Location = new System.Drawing.Point(27, 64);
            this.searchInvoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchInvoices.MaxLength = 32767;
            this.searchInvoices.MinimumSize = new System.Drawing.Size(2, 2);
            this.searchInvoices.Modified = false;
            this.searchInvoices.Multiline = false;
            this.searchInvoices.Name = "searchInvoices";
            stateProperties1.BorderColor = System.Drawing.Color.Silver;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInvoices.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchInvoices.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInvoices.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchInvoices.OnIdleState = stateProperties4;
            this.searchInvoices.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchInvoices.PasswordChar = '\0';
            this.searchInvoices.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchInvoices.PlaceholderText = "Search invoice ...";
            this.searchInvoices.ReadOnly = false;
            this.searchInvoices.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchInvoices.SelectedText = "";
            this.searchInvoices.SelectionLength = 0;
            this.searchInvoices.SelectionStart = 0;
            this.searchInvoices.ShortcutsEnabled = true;
            this.searchInvoices.Size = new System.Drawing.Size(294, 42);
            this.searchInvoices.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchInvoices.TabIndex = 27;
            this.searchInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchInvoices.TextMarginBottom = 0;
            this.searchInvoices.TextMarginLeft = 3;
            this.searchInvoices.TextMarginTop = 1;
            this.searchInvoices.TextPlaceholder = "Search invoice ...";
            this.searchInvoices.UseSystemPasswordChar = false;
            this.searchInvoices.WordWrap = true;
            this.searchInvoices.TextChange += new System.EventHandler(this.searchInvoices_TextChange);
            // 
            // Invoices_History
            // 
            this.Invoices_History.AllowCustomTheming = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Invoices_History.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Invoices_History.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Invoices_History.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Invoices_History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Invoices_History.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Invoices_History.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoices_History.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Invoices_History.ColumnHeadersHeight = 40;
            this.Invoices_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected_Invoice,
            this.Invoice_ID,
            this.User_ID,
            this.Created_Date,
            this.Total_Price,
            this.Change,
            this.Status_Name,
            this.StatusID});
            this.Invoices_History.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.Invoices_History.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Invoices_History.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Invoices_History.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Invoices_History.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Invoices_History.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Invoices_History.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Invoices_History.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Invoices_History.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_History.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Invoices_History.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Invoices_History.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Invoices_History.CurrentTheme.Name = null;
            this.Invoices_History.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Invoices_History.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Invoices_History.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Invoices_History.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.Invoices_History.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Invoices_History.DefaultCellStyle = dataGridViewCellStyle3;
            this.Invoices_History.EnableHeadersVisualStyles = false;
            this.Invoices_History.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.Invoices_History.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.Invoices_History.HeaderBgColor = System.Drawing.Color.Empty;
            this.Invoices_History.HeaderForeColor = System.Drawing.Color.White;
            this.Invoices_History.Location = new System.Drawing.Point(27, 171);
            this.Invoices_History.Name = "Invoices_History";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoices_History.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Invoices_History.RowHeadersVisible = false;
            this.Invoices_History.RowHeadersWidth = 62;
            this.Invoices_History.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_History.RowTemplate.Height = 40;
            this.Invoices_History.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoices_History.Size = new System.Drawing.Size(681, 634);
            this.Invoices_History.TabIndex = 31;
            this.Invoices_History.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.Invoices_History.SelectionChanged += new System.EventHandler(this.Invoices_History_SelectionChanged);
            // 
            // selected_Invoice
            // 
            this.selected_Invoice.HeaderText = "Selected";
            this.selected_Invoice.MinimumWidth = 8;
            this.selected_Invoice.Name = "selected_Invoice";
            // 
            // Invoice_ID
            // 
            this.Invoice_ID.DataPropertyName = "InvoiceID";
            this.Invoice_ID.HeaderText = "Invoice ID";
            this.Invoice_ID.MinimumWidth = 8;
            this.Invoice_ID.Name = "Invoice_ID";
            this.Invoice_ID.ReadOnly = true;
            // 
            // User_ID
            // 
            this.User_ID.DataPropertyName = "UserID";
            this.User_ID.HeaderText = "User ID";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // Created_Date
            // 
            this.Created_Date.DataPropertyName = "CreatedDate";
            this.Created_Date.HeaderText = "Created Date";
            this.Created_Date.MinimumWidth = 8;
            this.Created_Date.Name = "Created_Date";
            this.Created_Date.ReadOnly = true;
            // 
            // Total_Price
            // 
            this.Total_Price.DataPropertyName = "TotalPrice";
            this.Total_Price.HeaderText = "Total Price";
            this.Total_Price.MinimumWidth = 8;
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "Change";
            this.Change.HeaderText = "Change";
            this.Change.MinimumWidth = 8;
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            // 
            // Status_Name
            // 
            this.Status_Name.DataPropertyName = "StatusName";
            this.Status_Name.HeaderText = "Status";
            this.Status_Name.MinimumWidth = 8;
            this.Status_Name.Name = "Status_Name";
            this.Status_Name.ReadOnly = true;
            // 
            // StatusID
            // 
            this.StatusID.DataPropertyName = "StatusID";
            this.StatusID.HeaderText = "Status ID";
            this.StatusID.MinimumWidth = 8;
            this.StatusID.Name = "StatusID";
            this.StatusID.Visible = false;
            // 
            // Detail_Invoice
            // 
            this.Detail_Invoice.BackColor = System.Drawing.Color.White;
            this.Detail_Invoice.Controls.Add(this.print_invoice);
            this.Detail_Invoice.Controls.Add(this.DetailTable);
            this.Detail_Invoice.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail_Invoice.Location = new System.Drawing.Point(714, 171);
            this.Detail_Invoice.Name = "Detail_Invoice";
            this.Detail_Invoice.Size = new System.Drawing.Size(563, 634);
            this.Detail_Invoice.TabIndex = 32;
            this.Detail_Invoice.TabStop = false;
            this.Detail_Invoice.Text = "Detail Invoice";
            // 
            // print_invoice
            // 
            this.print_invoice.AllowAnimations = false;
            this.print_invoice.AllowMouseEffects = true;
            this.print_invoice.AllowToggling = false;
            this.print_invoice.AnimationSpeed = 200;
            this.print_invoice.AutoGenerateColors = false;
            this.print_invoice.AutoRoundBorders = false;
            this.print_invoice.AutoSizeLeftIcon = true;
            this.print_invoice.AutoSizeRightIcon = true;
            this.print_invoice.BackColor = System.Drawing.Color.Transparent;
            this.print_invoice.BackColor1 = System.Drawing.Color.Teal;
            this.print_invoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_invoice.BackgroundImage")));
            this.print_invoice.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.print_invoice.ButtonText = "Print";
            this.print_invoice.ButtonTextMarginLeft = 0;
            this.print_invoice.ColorContrastOnClick = 45;
            this.print_invoice.ColorContrastOnHover = 45;
            this.print_invoice.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.print_invoice.CustomizableEdges = borderEdges1;
            this.print_invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.print_invoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.print_invoice.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.print_invoice.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.print_invoice.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.print_invoice.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_invoice.ForeColor = System.Drawing.Color.White;
            this.print_invoice.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.print_invoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.print_invoice.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.print_invoice.IconMarginLeft = 11;
            this.print_invoice.IconPadding = 10;
            this.print_invoice.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.print_invoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.print_invoice.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.print_invoice.IconSize = 25;
            this.print_invoice.IdleBorderColor = System.Drawing.Color.White;
            this.print_invoice.IdleBorderRadius = 30;
            this.print_invoice.IdleBorderThickness = 1;
            this.print_invoice.IdleFillColor = System.Drawing.Color.Teal;
            this.print_invoice.IdleIconLeftImage = null;
            this.print_invoice.IdleIconRightImage = null;
            this.print_invoice.IndicateFocus = false;
            this.print_invoice.Location = new System.Drawing.Point(21, 495);
            this.print_invoice.Name = "print_invoice";
            this.print_invoice.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.print_invoice.OnDisabledState.BorderRadius = 30;
            this.print_invoice.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.print_invoice.OnDisabledState.BorderThickness = 1;
            this.print_invoice.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.print_invoice.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.print_invoice.OnDisabledState.IconLeftImage = null;
            this.print_invoice.OnDisabledState.IconRightImage = null;
            this.print_invoice.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.print_invoice.onHoverState.BorderRadius = 30;
            this.print_invoice.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.print_invoice.onHoverState.BorderThickness = 1;
            this.print_invoice.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.print_invoice.onHoverState.ForeColor = System.Drawing.Color.White;
            this.print_invoice.onHoverState.IconLeftImage = null;
            this.print_invoice.onHoverState.IconRightImage = null;
            this.print_invoice.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.print_invoice.OnIdleState.BorderRadius = 30;
            this.print_invoice.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.print_invoice.OnIdleState.BorderThickness = 1;
            this.print_invoice.OnIdleState.FillColor = System.Drawing.Color.Teal;
            this.print_invoice.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.print_invoice.OnIdleState.IconLeftImage = null;
            this.print_invoice.OnIdleState.IconRightImage = null;
            this.print_invoice.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.print_invoice.OnPressedState.BorderRadius = 30;
            this.print_invoice.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.print_invoice.OnPressedState.BorderThickness = 1;
            this.print_invoice.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.print_invoice.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.print_invoice.OnPressedState.IconLeftImage = null;
            this.print_invoice.OnPressedState.IconRightImage = null;
            this.print_invoice.Size = new System.Drawing.Size(107, 36);
            this.print_invoice.TabIndex = 34;
            this.print_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print_invoice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.print_invoice.TextMarginLeft = 0;
            this.print_invoice.TextPadding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.print_invoice.UseDefaultRadiusAndThickness = true;
            this.print_invoice.Click += new System.EventHandler(this.print_invoice_Click);
            // 
            // DetailTable
            // 
            this.DetailTable.AllowCustomTheming = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DetailTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DetailTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DetailTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DetailTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DetailTable.ColumnHeadersHeight = 40;
            this.DetailTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail_ID,
            this.Product_ID,
            this.Quantity_Detail,
            this.Unit_Price,
            this.Line_Total});
            this.DetailTable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DetailTable.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DetailTable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DetailTable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DetailTable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DetailTable.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DetailTable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailTable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DetailTable.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DetailTable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DetailTable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DetailTable.CurrentTheme.Name = null;
            this.DetailTable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.DetailTable.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DetailTable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DetailTable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.DetailTable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DetailTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.DetailTable.EnableHeadersVisualStyles = false;
            this.DetailTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetailTable.HeaderBackColor = System.Drawing.Color.White;
            this.DetailTable.HeaderBgColor = System.Drawing.Color.Empty;
            this.DetailTable.HeaderForeColor = System.Drawing.Color.Black;
            this.DetailTable.Location = new System.Drawing.Point(30, 67);
            this.DetailTable.Name = "DetailTable";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DetailTable.RowHeadersVisible = false;
            this.DetailTable.RowHeadersWidth = 62;
            this.DetailTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTable.RowTemplate.Height = 40;
            this.DetailTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetailTable.Size = new System.Drawing.Size(500, 413);
            this.DetailTable.TabIndex = 34;
            this.DetailTable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Detail_ID
            // 
            this.Detail_ID.DataPropertyName = "DetailID";
            this.Detail_ID.HeaderText = "Detail ID";
            this.Detail_ID.MinimumWidth = 8;
            this.Detail_ID.Name = "Detail_ID";
            this.Detail_ID.ReadOnly = true;
            // 
            // Product_ID
            // 
            this.Product_ID.DataPropertyName = "ProductID";
            this.Product_ID.HeaderText = "Product ID";
            this.Product_ID.MinimumWidth = 8;
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            // 
            // Quantity_Detail
            // 
            this.Quantity_Detail.DataPropertyName = "Quantity";
            this.Quantity_Detail.HeaderText = "Quantity";
            this.Quantity_Detail.MinimumWidth = 8;
            this.Quantity_Detail.Name = "Quantity_Detail";
            this.Quantity_Detail.ReadOnly = true;
            // 
            // Unit_Price
            // 
            this.Unit_Price.DataPropertyName = "UnitPrice";
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.MinimumWidth = 8;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.ReadOnly = true;
            // 
            // Line_Total
            // 
            this.Line_Total.DataPropertyName = "LineTotal";
            this.Line_Total.HeaderText = "Line Total";
            this.Line_Total.MinimumWidth = 8;
            this.Line_Total.Name = "Line_Total";
            this.Line_Total.ReadOnly = true;
            // 
            // delete_invoice
            // 
            this.delete_invoice.AllowAnimations = false;
            this.delete_invoice.AllowMouseEffects = true;
            this.delete_invoice.AllowToggling = false;
            this.delete_invoice.AnimationSpeed = 200;
            this.delete_invoice.AutoGenerateColors = false;
            this.delete_invoice.AutoRoundBorders = false;
            this.delete_invoice.AutoSizeLeftIcon = true;
            this.delete_invoice.AutoSizeRightIcon = true;
            this.delete_invoice.BackColor = System.Drawing.Color.Transparent;
            this.delete_invoice.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_invoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_invoice.BackgroundImage")));
            this.delete_invoice.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.delete_invoice.ButtonText = "Delete";
            this.delete_invoice.ButtonTextMarginLeft = 0;
            this.delete_invoice.ColorContrastOnClick = 45;
            this.delete_invoice.ColorContrastOnHover = 45;
            this.delete_invoice.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.delete_invoice.CustomizableEdges = borderEdges2;
            this.delete_invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_invoice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.delete_invoice.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.delete_invoice.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.delete_invoice.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.delete_invoice.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_invoice.ForeColor = System.Drawing.Color.White;
            this.delete_invoice.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_invoice.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.delete_invoice.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.delete_invoice.IconMarginLeft = 11;
            this.delete_invoice.IconPadding = 10;
            this.delete_invoice.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_invoice.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.delete_invoice.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.delete_invoice.IconSize = 25;
            this.delete_invoice.IdleBorderColor = System.Drawing.Color.White;
            this.delete_invoice.IdleBorderRadius = 30;
            this.delete_invoice.IdleBorderThickness = 1;
            this.delete_invoice.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_invoice.IdleIconLeftImage = null;
            this.delete_invoice.IdleIconRightImage = null;
            this.delete_invoice.IndicateFocus = false;
            this.delete_invoice.Location = new System.Drawing.Point(661, 111);
            this.delete_invoice.Name = "delete_invoice";
            this.delete_invoice.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.delete_invoice.OnDisabledState.BorderRadius = 30;
            this.delete_invoice.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.delete_invoice.OnDisabledState.BorderThickness = 1;
            this.delete_invoice.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.delete_invoice.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.delete_invoice.OnDisabledState.IconLeftImage = null;
            this.delete_invoice.OnDisabledState.IconRightImage = null;
            this.delete_invoice.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.delete_invoice.onHoverState.BorderRadius = 30;
            this.delete_invoice.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.delete_invoice.onHoverState.BorderThickness = 1;
            this.delete_invoice.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.delete_invoice.onHoverState.ForeColor = System.Drawing.Color.White;
            this.delete_invoice.onHoverState.IconLeftImage = null;
            this.delete_invoice.onHoverState.IconRightImage = null;
            this.delete_invoice.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.delete_invoice.OnIdleState.BorderRadius = 30;
            this.delete_invoice.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.delete_invoice.OnIdleState.BorderThickness = 1;
            this.delete_invoice.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delete_invoice.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.delete_invoice.OnIdleState.IconLeftImage = null;
            this.delete_invoice.OnIdleState.IconRightImage = null;
            this.delete_invoice.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.delete_invoice.OnPressedState.BorderRadius = 30;
            this.delete_invoice.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.delete_invoice.OnPressedState.BorderThickness = 1;
            this.delete_invoice.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.delete_invoice.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.delete_invoice.OnPressedState.IconLeftImage = null;
            this.delete_invoice.OnPressedState.IconRightImage = null;
            this.delete_invoice.Size = new System.Drawing.Size(118, 34);
            this.delete_invoice.TabIndex = 33;
            this.delete_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_invoice.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_invoice.TextMarginLeft = 0;
            this.delete_invoice.TextPadding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.delete_invoice.UseDefaultRadiusAndThickness = true;
            this.delete_invoice.Click += new System.EventHandler(this.delete_invoice_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(27, 114);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(294, 34);
            this.cbStatus.TabIndex = 34;
            this.cbStatus.Text = " All Status...";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // invoiceTimeFrom
            // 
            this.invoiceTimeFrom.BackColor = System.Drawing.Color.Transparent;
            this.invoiceTimeFrom.BorderColor = System.Drawing.Color.Silver;
            this.invoiceTimeFrom.BorderRadius = 1;
            this.invoiceTimeFrom.Color = System.Drawing.Color.Silver;
            this.invoiceTimeFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.invoiceTimeFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.invoiceTimeFrom.DisabledColor = System.Drawing.Color.Gray;
            this.invoiceTimeFrom.DisplayWeekNumbers = false;
            this.invoiceTimeFrom.DPHeight = 0;
            this.invoiceTimeFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.invoiceTimeFrom.FillDatePicker = false;
            this.invoiceTimeFrom.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.invoiceTimeFrom.Icon = ((System.Drawing.Image)(resources.GetObject("invoiceTimeFrom.Icon")));
            this.invoiceTimeFrom.IconColor = System.Drawing.Color.Gray;
            this.invoiceTimeFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.invoiceTimeFrom.LeftTextMargin = 5;
            this.invoiceTimeFrom.Location = new System.Drawing.Point(418, 64);
            this.invoiceTimeFrom.MinimumSize = new System.Drawing.Size(0, 32);
            this.invoiceTimeFrom.Name = "invoiceTimeFrom";
            this.invoiceTimeFrom.Size = new System.Drawing.Size(218, 32);
            this.invoiceTimeFrom.TabIndex = 37;
            // 
            // invoiceTimeTo
            // 
            this.invoiceTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.invoiceTimeTo.BorderColor = System.Drawing.Color.Silver;
            this.invoiceTimeTo.BorderRadius = 1;
            this.invoiceTimeTo.Color = System.Drawing.Color.Silver;
            this.invoiceTimeTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.invoiceTimeTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.invoiceTimeTo.DisabledColor = System.Drawing.Color.Gray;
            this.invoiceTimeTo.DisplayWeekNumbers = false;
            this.invoiceTimeTo.DPHeight = 0;
            this.invoiceTimeTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.invoiceTimeTo.FillDatePicker = false;
            this.invoiceTimeTo.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTimeTo.ForeColor = System.Drawing.Color.Black;
            this.invoiceTimeTo.Icon = ((System.Drawing.Image)(resources.GetObject("invoiceTimeTo.Icon")));
            this.invoiceTimeTo.IconColor = System.Drawing.Color.Gray;
            this.invoiceTimeTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.invoiceTimeTo.LeftTextMargin = 5;
            this.invoiceTimeTo.Location = new System.Drawing.Point(418, 114);
            this.invoiceTimeTo.MinimumSize = new System.Drawing.Size(0, 32);
            this.invoiceTimeTo.Name = "invoiceTimeTo";
            this.invoiceTimeTo.Size = new System.Drawing.Size(218, 32);
            this.invoiceTimeTo.TabIndex = 38;
            // 
            // label_inv1
            // 
            this.label_inv1.AutoSize = true;
            this.label_inv1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inv1.Location = new System.Drawing.Point(356, 64);
            this.label_inv1.Name = "label_inv1";
            this.label_inv1.Size = new System.Drawing.Size(51, 26);
            this.label_inv1.TabIndex = 39;
            this.label_inv1.Text = "From";
            // 
            // label1_inv
            // 
            this.label1_inv.AutoSize = true;
            this.label1_inv.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_inv.Location = new System.Drawing.Point(356, 114);
            this.label1_inv.Name = "label1_inv";
            this.label1_inv.Size = new System.Drawing.Size(30, 26);
            this.label1_inv.TabIndex = 40;
            this.label1_inv.Text = "To";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.AllowAnimations = false;
            this.btnSearchByDate.AllowMouseEffects = true;
            this.btnSearchByDate.AllowToggling = false;
            this.btnSearchByDate.AnimationSpeed = 200;
            this.btnSearchByDate.AutoGenerateColors = false;
            this.btnSearchByDate.AutoRoundBorders = false;
            this.btnSearchByDate.AutoSizeLeftIcon = true;
            this.btnSearchByDate.AutoSizeRightIcon = true;
            this.btnSearchByDate.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchByDate.BackColor1 = System.Drawing.Color.CadetBlue;
            this.btnSearchByDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByDate.BackgroundImage")));
            this.btnSearchByDate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSearchByDate.ButtonText = "Search";
            this.btnSearchByDate.ButtonTextMarginLeft = 0;
            this.btnSearchByDate.ColorContrastOnClick = 45;
            this.btnSearchByDate.ColorContrastOnHover = 45;
            this.btnSearchByDate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSearchByDate.CustomizableEdges = borderEdges3;
            this.btnSearchByDate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchByDate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearchByDate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchByDate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearchByDate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnSearchByDate.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByDate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchByDate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearchByDate.IconMarginLeft = 11;
            this.btnSearchByDate.IconPadding = 10;
            this.btnSearchByDate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchByDate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearchByDate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearchByDate.IconSize = 25;
            this.btnSearchByDate.IdleBorderColor = System.Drawing.Color.White;
            this.btnSearchByDate.IdleBorderRadius = 30;
            this.btnSearchByDate.IdleBorderThickness = 1;
            this.btnSearchByDate.IdleFillColor = System.Drawing.Color.CadetBlue;
            this.btnSearchByDate.IdleIconLeftImage = null;
            this.btnSearchByDate.IdleIconRightImage = null;
            this.btnSearchByDate.IndicateFocus = false;
            this.btnSearchByDate.Location = new System.Drawing.Point(661, 64);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearchByDate.OnDisabledState.BorderRadius = 30;
            this.btnSearchByDate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSearchByDate.OnDisabledState.BorderThickness = 1;
            this.btnSearchByDate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearchByDate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearchByDate.OnDisabledState.IconLeftImage = null;
            this.btnSearchByDate.OnDisabledState.IconRightImage = null;
            this.btnSearchByDate.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearchByDate.onHoverState.BorderRadius = 30;
            this.btnSearchByDate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSearchByDate.onHoverState.BorderThickness = 1;
            this.btnSearchByDate.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearchByDate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.onHoverState.IconLeftImage = null;
            this.btnSearchByDate.onHoverState.IconRightImage = null;
            this.btnSearchByDate.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnSearchByDate.OnIdleState.BorderRadius = 30;
            this.btnSearchByDate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSearchByDate.OnIdleState.BorderThickness = 1;
            this.btnSearchByDate.OnIdleState.FillColor = System.Drawing.Color.CadetBlue;
            this.btnSearchByDate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.OnIdleState.IconLeftImage = null;
            this.btnSearchByDate.OnIdleState.IconRightImage = null;
            this.btnSearchByDate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearchByDate.OnPressedState.BorderRadius = 30;
            this.btnSearchByDate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnSearchByDate.OnPressedState.BorderThickness = 1;
            this.btnSearchByDate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearchByDate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearchByDate.OnPressedState.IconLeftImage = null;
            this.btnSearchByDate.OnPressedState.IconRightImage = null;
            this.btnSearchByDate.Size = new System.Drawing.Size(118, 34);
            this.btnSearchByDate.TabIndex = 41;
            this.btnSearchByDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByDate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchByDate.TextMarginLeft = 0;
            this.btnSearchByDate.TextPadding = new System.Windows.Forms.Padding(5, 2, 0, 0);
            this.btnSearchByDate.UseDefaultRadiusAndThickness = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // InvoicesUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.label1_inv);
            this.Controls.Add(this.label_inv1);
            this.Controls.Add(this.invoiceTimeTo);
            this.Controls.Add(this.invoiceTimeFrom);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.delete_invoice);
            this.Controls.Add(this.Detail_Invoice);
            this.Controls.Add(this.Invoices_History);
            this.Controls.Add(this.lb_invoices);
            this.Controls.Add(this.searchInvoices);
            this.Name = "InvoicesUC";
            this.Size = new System.Drawing.Size(1291, 848);
            this.Load += new System.EventHandler(this.InvoicesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_History)).EndInit();
            this.Detail_Invoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lb_invoices;
        private Bunifu.UI.WinForms.BunifuTextBox searchInvoices;
        private Bunifu.UI.WinForms.BunifuDataGridView Invoices_History;
        private System.Windows.Forms.GroupBox Detail_Invoice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 delete_invoice;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 print_invoice;
        private Bunifu.UI.WinForms.BunifuDataGridView DetailTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line_Total;
        private System.Windows.Forms.ComboBox cbStatus;
        private Bunifu.UI.WinForms.BunifuDatePicker invoiceTimeFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker invoiceTimeTo;
        private System.Windows.Forms.Label label_inv1;
        private System.Windows.Forms.Label label1_inv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSearchByDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected_Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
    }
}
