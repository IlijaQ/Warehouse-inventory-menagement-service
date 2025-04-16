namespace WarehouseUI
{
    partial class Products
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
            this.lblCount = new Krypton.Toolkit.KryptonLabel();
            this.label3 = new Krypton.Toolkit.KryptonLabel();
            this.label2 = new Krypton.Toolkit.KryptonLabel();
            this.btnReserNameFilter = new Krypton.Toolkit.KryptonButton();
            this.label8 = new Krypton.Toolkit.KryptonLabel();
            this.label7 = new Krypton.Toolkit.KryptonLabel();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.cbEnablePriceToFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.cbEnablePriceFromFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.cbEnableQuantityFromFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.cbEnableQuantityToFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.cbEnableDateFromFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.cbEnableDateToFilter = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.cbEnableAllFilters = new Krypton.Toolkit.KryptonCheckBox();
            this.tbSearchString = new Krypton.Toolkit.KryptonTextBox();
            this.numPriceFromFilter = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numPriceToFilter = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numQuantityFromFilter = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numQuantityToFilter = new Krypton.Toolkit.KryptonNumericUpDown();
            this.dtpBeforeFilter = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpAfterFilter = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dgvProductsView = new Krypton.Toolkit.KryptonDataGridView();
            this.SearchMaskPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).BeginInit();
            this.SearchMaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCount.Location = new System.Drawing.Point(12, 137);
            this.lblCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(55, 24);
            this.lblCount.TabIndex = 1;
            this.lblCount.Values.Text = "Count";
            this.lblCount.Visible = false;
            // 
            // label3
            // 
            this.label3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 24);
            this.label3.TabIndex = 10;
            this.label3.Values.Text = "Procuct name (or name part)";
            // 
            // label2
            // 
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 35);
            this.label2.TabIndex = 10;
            this.label2.Values.Text = "Search Inventory";
            // 
            // btnReserNameFilter
            // 
            this.btnReserNameFilter.Location = new System.Drawing.Point(596, 50);
            this.btnReserNameFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserNameFilter.Name = "btnReserNameFilter";
            this.btnReserNameFilter.Size = new System.Drawing.Size(108, 27);
            this.btnReserNameFilter.TabIndex = 10;
            this.btnReserNameFilter.Values.Text = "Clear Text";
            this.btnReserNameFilter.Click += new System.EventHandler(this.btnReserNameFilter_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 18;
            this.label8.Values.Text = "$";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 17;
            this.label7.Values.Text = "$";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(225, 613);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "Search Products";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(162, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 24);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Values.Text = "Searching...";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(12, 613);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 36);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Values.Text = "Create New";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(910, 118);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(109, 24);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Created After";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(899, 87);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(120, 24);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "Created Before";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(301, 84);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(96, 24);
            this.kryptonLabel3.TabIndex = 25;
            this.kryptonLabel3.Values.Text = "Price Below";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(298, 113);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(98, 24);
            this.kryptonLabel4.TabIndex = 26;
            this.kryptonLabel4.Values.Text = "Price Above";
            // 
            // cbEnablePriceToFilter
            // 
            this.cbEnablePriceToFilter.Location = new System.Drawing.Point(596, 87);
            this.cbEnablePriceToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnablePriceToFilter.Name = "cbEnablePriceToFilter";
            this.cbEnablePriceToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnablePriceToFilter.TabIndex = 27;
            this.cbEnablePriceToFilter.Values.Text = "Enable Filter";
            this.cbEnablePriceToFilter.CheckedChanged += new System.EventHandler(this.cbEnablePriceToFilter_CheckedChanged);
            // 
            // cbEnablePriceFromFilter
            // 
            this.cbEnablePriceFromFilter.Location = new System.Drawing.Point(596, 117);
            this.cbEnablePriceFromFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnablePriceFromFilter.Name = "cbEnablePriceFromFilter";
            this.cbEnablePriceFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnablePriceFromFilter.TabIndex = 28;
            this.cbEnablePriceFromFilter.Values.Text = "Enable Filter";
            this.cbEnablePriceFromFilter.CheckedChanged += new System.EventHandler(this.cbEnablePriceFromFilter_CheckedChanged);
            // 
            // cbEnableQuantityFromFilter
            // 
            this.cbEnableQuantityFromFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnableQuantityFromFilter.Location = new System.Drawing.Point(1223, 52);
            this.cbEnableQuantityFromFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnableQuantityFromFilter.Name = "cbEnableQuantityFromFilter";
            this.cbEnableQuantityFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableQuantityFromFilter.TabIndex = 30;
            this.cbEnableQuantityFromFilter.Values.Text = "Enable Filter";
            this.cbEnableQuantityFromFilter.CheckedChanged += new System.EventHandler(this.cbEnableQuantityFromFilter_CheckedChanged);
            // 
            // cbEnableQuantityToFilter
            // 
            this.cbEnableQuantityToFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnableQuantityToFilter.Location = new System.Drawing.Point(1223, 20);
            this.cbEnableQuantityToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnableQuantityToFilter.Name = "cbEnableQuantityToFilter";
            this.cbEnableQuantityToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableQuantityToFilter.TabIndex = 29;
            this.cbEnableQuantityToFilter.Values.Text = "Enable Filter";
            this.cbEnableQuantityToFilter.CheckedChanged += new System.EventHandler(this.cbEnableQuantityToFilter_CheckedChanged);
            // 
            // cbEnableDateFromFilter
            // 
            this.cbEnableDateFromFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnableDateFromFilter.Location = new System.Drawing.Point(1223, 117);
            this.cbEnableDateFromFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnableDateFromFilter.Name = "cbEnableDateFromFilter";
            this.cbEnableDateFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableDateFromFilter.TabIndex = 32;
            this.cbEnableDateFromFilter.Values.Text = "Enable Filter";
            this.cbEnableDateFromFilter.CheckedChanged += new System.EventHandler(this.cbEnableDateFromFilter_CheckedChanged);
            // 
            // cbEnableDateToFilter
            // 
            this.cbEnableDateToFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEnableDateToFilter.Location = new System.Drawing.Point(1223, 86);
            this.cbEnableDateToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnableDateToFilter.Name = "cbEnableDateToFilter";
            this.cbEnableDateToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableDateToFilter.TabIndex = 31;
            this.cbEnableDateToFilter.Values.Text = "Enable Filter";
            this.cbEnableDateToFilter.CheckedChanged += new System.EventHandler(this.cbEnableDateToFilter_CheckedChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(896, 54);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(126, 24);
            this.kryptonLabel5.TabIndex = 34;
            this.kryptonLabel5.Values.Text = "Quantity Above";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(895, 20);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(124, 24);
            this.kryptonLabel6.TabIndex = 33;
            this.kryptonLabel6.Values.Text = "Quantity Below";
            // 
            // cbEnableAllFilters
            // 
            this.cbEnableAllFilters.Location = new System.Drawing.Point(596, 20);
            this.cbEnableAllFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEnableAllFilters.Name = "cbEnableAllFilters";
            this.cbEnableAllFilters.Size = new System.Drawing.Size(136, 24);
            this.cbEnableAllFilters.TabIndex = 35;
            this.cbEnableAllFilters.Values.Text = "Enable All Filters";
            this.cbEnableAllFilters.CheckedChanged += new System.EventHandler(this.cbEnableAllFilters_CheckedChanged);
            // 
            // tbSearchString
            // 
            this.tbSearchString.CueHint.CueHintText = "leave empty to disable this filter";
            this.tbSearchString.Location = new System.Drawing.Point(251, 50);
            this.tbSearchString.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(315, 27);
            this.tbSearchString.TabIndex = 36;
            this.tbSearchString.ToolTipValues.Description = "Case Insensitive";
            this.tbSearchString.ToolTipValues.Heading = "";
            // 
            // numPriceFromFilter
            // 
            this.numPriceFromFilter.AllowDecimals = true;
            this.numPriceFromFilter.DecimalPlaces = 2;
            this.numPriceFromFilter.Enabled = false;
            this.numPriceFromFilter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPriceFromFilter.Location = new System.Drawing.Point(419, 114);
            this.numPriceFromFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceFromFilter.Maximum = new decimal(new int[] {
            999998,
            0,
            0,
            0});
            this.numPriceFromFilter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPriceFromFilter.Name = "numPriceFromFilter";
            this.numPriceFromFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numPriceFromFilter.Size = new System.Drawing.Size(147, 26);
            this.numPriceFromFilter.TabIndex = 37;
            this.numPriceFromFilter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPriceFromFilter.ValueChanged += new System.EventHandler(this.numPriceFromFilter_ValueChanged);
            // 
            // numPriceToFilter
            // 
            this.numPriceToFilter.AllowDecimals = true;
            this.numPriceToFilter.DecimalPlaces = 2;
            this.numPriceToFilter.Enabled = false;
            this.numPriceToFilter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPriceToFilter.Location = new System.Drawing.Point(419, 82);
            this.numPriceToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPriceToFilter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPriceToFilter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPriceToFilter.Name = "numPriceToFilter";
            this.numPriceToFilter.Size = new System.Drawing.Size(147, 26);
            this.numPriceToFilter.TabIndex = 38;
            this.numPriceToFilter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPriceToFilter.ValueChanged += new System.EventHandler(this.numPriceToFilter_ValueChanged);
            // 
            // numQuantityFromFilter
            // 
            this.numQuantityFromFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantityFromFilter.Enabled = false;
            this.numQuantityFromFilter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantityFromFilter.Location = new System.Drawing.Point(1043, 52);
            this.numQuantityFromFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQuantityFromFilter.Maximum = new decimal(new int[] {
            999998,
            0,
            0,
            0});
            this.numQuantityFromFilter.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numQuantityFromFilter.Name = "numQuantityFromFilter";
            this.numQuantityFromFilter.Size = new System.Drawing.Size(149, 26);
            this.numQuantityFromFilter.TabIndex = 39;
            this.numQuantityFromFilter.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numQuantityFromFilter.ValueChanged += new System.EventHandler(this.numQuantityFromFilter_ValueChanged);
            // 
            // numQuantityToFilter
            // 
            this.numQuantityToFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantityToFilter.Enabled = false;
            this.numQuantityToFilter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantityToFilter.Location = new System.Drawing.Point(1043, 20);
            this.numQuantityToFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQuantityToFilter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQuantityToFilter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numQuantityToFilter.Name = "numQuantityToFilter";
            this.numQuantityToFilter.Size = new System.Drawing.Size(149, 26);
            this.numQuantityToFilter.TabIndex = 40;
            this.numQuantityToFilter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numQuantityToFilter.ValueChanged += new System.EventHandler(this.numQuantityToFilter_ValueChanged);
            // 
            // dtpBeforeFilter
            // 
            this.dtpBeforeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBeforeFilter.CustomFormat = "dd. MM. yyyy.";
            this.dtpBeforeFilter.Enabled = false;
            this.dtpBeforeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBeforeFilter.Location = new System.Drawing.Point(1043, 85);
            this.dtpBeforeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBeforeFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpBeforeFilter.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpBeforeFilter.Name = "dtpBeforeFilter";
            this.dtpBeforeFilter.Size = new System.Drawing.Size(149, 25);
            this.dtpBeforeFilter.TabIndex = 41;
            this.dtpBeforeFilter.ValueChanged += new System.EventHandler(this.dtpBeforeFilter_ValueChanged);
            // 
            // dtpAfterFilter
            // 
            this.dtpAfterFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAfterFilter.CustomFormat = "dd. MM. yyyy.";
            this.dtpAfterFilter.Enabled = false;
            this.dtpAfterFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAfterFilter.Location = new System.Drawing.Point(1043, 117);
            this.dtpAfterFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpAfterFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpAfterFilter.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpAfterFilter.Name = "dtpAfterFilter";
            this.dtpAfterFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpAfterFilter.Size = new System.Drawing.Size(149, 25);
            this.dtpAfterFilter.TabIndex = 42;
            this.dtpAfterFilter.ValueChanged += new System.EventHandler(this.dtpAfterFilter_ValueChanged);
            // 
            // dgvProductsView
            // 
            this.dgvProductsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductsView.ColumnHeadersHeight = 36;
            this.dgvProductsView.Location = new System.Drawing.Point(12, 166);
            this.dgvProductsView.Name = "dgvProductsView";
            this.dgvProductsView.RowHeadersWidth = 51;
            this.dgvProductsView.RowTemplate.Height = 24;
            this.dgvProductsView.Size = new System.Drawing.Size(1516, 442);
            this.dgvProductsView.TabIndex = 43;
            this.dgvProductsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsView_CellContentClick);
            this.dgvProductsView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProductsView_RowPostPaint);
            // 
            // SearchMaskPanel
            // 
            this.SearchMaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchMaskPanel.Controls.Add(this.kryptonProgressBar1);
            this.SearchMaskPanel.Controls.Add(this.lblSearch);
            this.SearchMaskPanel.Location = new System.Drawing.Point(580, 304);
            this.SearchMaskPanel.Name = "SearchMaskPanel";
            this.SearchMaskPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.SearchMaskPanel.Size = new System.Drawing.Size(414, 100);
            this.SearchMaskPanel.TabIndex = 44;
            this.SearchMaskPanel.Visible = false;
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.Location = new System.Drawing.Point(16, 47);
            this.kryptonProgressBar1.MarqueeAnimationSpeed = 200;
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(381, 31);
            this.kryptonProgressBar1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kryptonProgressBar1.TabIndex = 14;
            this.kryptonProgressBar1.Values.Text = "";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 657);
            this.Controls.Add(this.SearchMaskPanel);
            this.Controls.Add(this.dgvProductsView);
            this.Controls.Add(this.dtpAfterFilter);
            this.Controls.Add(this.dtpBeforeFilter);
            this.Controls.Add(this.numQuantityToFilter);
            this.Controls.Add(this.numQuantityFromFilter);
            this.Controls.Add(this.numPriceToFilter);
            this.Controls.Add(this.numPriceFromFilter);
            this.Controls.Add(this.tbSearchString);
            this.Controls.Add(this.cbEnableAllFilters);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.cbEnableDateFromFilter);
            this.Controls.Add(this.cbEnableDateToFilter);
            this.Controls.Add(this.cbEnableQuantityFromFilter);
            this.Controls.Add(this.cbEnableQuantityToFilter);
            this.Controls.Add(this.cbEnablePriceFromFilter);
            this.Controls.Add(this.cbEnablePriceToFilter);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReserNameFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1505, 694);
            this.Name = "Products";
            this.ShowIcon = false;
            this.Text = "Warehouse Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).EndInit();
            this.SearchMaskPanel.ResumeLayout(false);
            this.SearchMaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblCount;
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonButton btnReserNameFilter;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private Krypton.Toolkit.KryptonLabel label8;
        private Krypton.Toolkit.KryptonLabel label7;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonCheckBox cbEnablePriceToFilter;
        private Krypton.Toolkit.KryptonCheckBox cbEnablePriceFromFilter;
        private Krypton.Toolkit.KryptonCheckBox cbEnableQuantityFromFilter;
        private Krypton.Toolkit.KryptonCheckBox cbEnableQuantityToFilter;
        private Krypton.Toolkit.KryptonCheckBox cbEnableDateFromFilter;
        private Krypton.Toolkit.KryptonCheckBox cbEnableDateToFilter;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonCheckBox cbEnableAllFilters;
        private Krypton.Toolkit.KryptonTextBox tbSearchString;
        private Krypton.Toolkit.KryptonNumericUpDown numPriceFromFilter;
        private Krypton.Toolkit.KryptonNumericUpDown numPriceToFilter;
        private Krypton.Toolkit.KryptonNumericUpDown numQuantityFromFilter;
        private Krypton.Toolkit.KryptonNumericUpDown numQuantityToFilter;
        private Krypton.Toolkit.KryptonDateTimePicker dtpBeforeFilter;
        private Krypton.Toolkit.KryptonDateTimePicker dtpAfterFilter;
        private Krypton.Toolkit.KryptonDataGridView dgvProductsView;
        private Krypton.Toolkit.KryptonPanel SearchMaskPanel;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
    }
}

