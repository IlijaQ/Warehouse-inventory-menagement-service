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
            this.dgvProductsView = new System.Windows.Forms.DataGridView();
            this.lblCount = new Krypton.Toolkit.KryptonLabel();
            this.label3 = new Krypton.Toolkit.KryptonLabel();
            this.label2 = new Krypton.Toolkit.KryptonLabel();
            this.btnReserNameFilter = new Krypton.Toolkit.KryptonButton();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.dtpBeforeFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpAfterFilter = new System.Windows.Forms.DateTimePicker();
            this.label8 = new Krypton.Toolkit.KryptonLabel();
            this.label7 = new Krypton.Toolkit.KryptonLabel();
            this.numPriceToFilter = new System.Windows.Forms.NumericUpDown();
            this.numPriceFromFilter = new System.Windows.Forms.NumericUpDown();
            this.numQuantityToFilter = new System.Windows.Forms.NumericUpDown();
            this.numQuantityFromFilter = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.tbTargetUrl = new System.Windows.Forms.TextBox();
            this.label1 = new Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityFromFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductsView
            // 
            this.dgvProductsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsView.Location = new System.Drawing.Point(12, 165);
            this.dgvProductsView.Name = "dgvProductsView";
            this.dgvProductsView.RowHeadersWidth = 51;
            this.dgvProductsView.RowTemplate.Height = 24;
            this.dgvProductsView.Size = new System.Drawing.Size(1469, 444);
            this.dgvProductsView.TabIndex = 0;
            this.dgvProductsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsView_CellContentClick);
            this.dgvProductsView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProductsView_RowPostPaint);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCount.Location = new System.Drawing.Point(9, 613);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(55, 24);
            this.lblCount.TabIndex = 1;
            this.lblCount.Values.Text = "Count";
            this.lblCount.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 10;
            this.label3.Values.Text = "Procuct name (or name part)";
            // 
            // label2
            // 
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 35);
            this.label2.TabIndex = 10;
            this.label2.Values.Text = "Search Inventory";
            // 
            // btnReserNameFilter
            // 
            this.btnReserNameFilter.Location = new System.Drawing.Point(596, 52);
            this.btnReserNameFilter.Name = "btnReserNameFilter";
            this.btnReserNameFilter.Size = new System.Drawing.Size(108, 25);
            this.btnReserNameFilter.TabIndex = 10;
            this.btnReserNameFilter.Values.Text = "Clear Text";
            this.btnReserNameFilter.Click += new System.EventHandler(this.btnReserNameFilter_Click);
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(224, 55);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(340, 22);
            this.tbSearchString.TabIndex = 10;
            // 
            // dtpBeforeFilter
            // 
            this.dtpBeforeFilter.Enabled = false;
            this.dtpBeforeFilter.Location = new System.Drawing.Point(866, 83);
            this.dtpBeforeFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBeforeFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpBeforeFilter.Name = "dtpBeforeFilter";
            this.dtpBeforeFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpBeforeFilter.TabIndex = 1;
            // 
            // dtpAfterFilter
            // 
            this.dtpAfterFilter.Enabled = false;
            this.dtpAfterFilter.Location = new System.Drawing.Point(866, 111);
            this.dtpAfterFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpAfterFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpAfterFilter.Name = "dtpAfterFilter";
            this.dtpAfterFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpAfterFilter.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 18;
            this.label8.Values.Text = "$";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 17;
            this.label7.Values.Text = "$";
            // 
            // numPriceToFilter
            // 
            this.numPriceToFilter.DecimalPlaces = 2;
            this.numPriceToFilter.Enabled = false;
            this.numPriceToFilter.Location = new System.Drawing.Point(418, 109);
            this.numPriceToFilter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceToFilter.Name = "numPriceToFilter";
            this.numPriceToFilter.Size = new System.Drawing.Size(146, 22);
            this.numPriceToFilter.TabIndex = 14;
            this.numPriceToFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPriceFromFilter
            // 
            this.numPriceFromFilter.DecimalPlaces = 2;
            this.numPriceFromFilter.Enabled = false;
            this.numPriceFromFilter.Location = new System.Drawing.Point(418, 82);
            this.numPriceFromFilter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceFromFilter.Name = "numPriceFromFilter";
            this.numPriceFromFilter.Size = new System.Drawing.Size(146, 22);
            this.numPriceFromFilter.TabIndex = 13;
            this.numPriceFromFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numQuantityToFilter
            // 
            this.numQuantityToFilter.Enabled = false;
            this.numQuantityToFilter.Location = new System.Drawing.Point(973, 55);
            this.numQuantityToFilter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantityToFilter.Name = "numQuantityToFilter";
            this.numQuantityToFilter.Size = new System.Drawing.Size(146, 22);
            this.numQuantityToFilter.TabIndex = 18;
            this.numQuantityToFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numQuantityFromFilter
            // 
            this.numQuantityFromFilter.Enabled = false;
            this.numQuantityFromFilter.Location = new System.Drawing.Point(973, 28);
            this.numQuantityFromFilter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantityFromFilter.Name = "numQuantityFromFilter";
            this.numQuantityFromFilter.Size = new System.Drawing.Size(146, 22);
            this.numQuantityFromFilter.TabIndex = 17;
            this.numQuantityFromFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1306, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Values.Text = "Search Products";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTargetUrl
            // 
            this.tbTargetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTargetUrl.Location = new System.Drawing.Point(880, 615);
            this.tbTargetUrl.Name = "tbTargetUrl";
            this.tbTargetUrl.Size = new System.Drawing.Size(601, 22);
            this.tbTargetUrl.TabIndex = 9;
            this.tbTargetUrl.TextChanged += new System.EventHandler(this.tbTargetUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(645, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 11;
            this.label1.Values.Text = "Paste the Base Target Url here:";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(708, 376);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 24);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Values.Text = "Searching...";
            this.lblSearch.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1306, 95);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 36);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Values.Text = "Create New";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(754, 109);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(100, 24);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Created after";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(741, 81);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(113, 24);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "Created Before";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(322, 80);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(90, 24);
            this.kryptonLabel3.TabIndex = 25;
            this.kryptonLabel3.Values.Text = "Price Below";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(322, 108);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(92, 24);
            this.kryptonLabel4.TabIndex = 26;
            this.kryptonLabel4.Values.Text = "Price Above";
            // 
            // cbEnablePriceToFilter
            // 
            this.cbEnablePriceToFilter.Location = new System.Drawing.Point(596, 83);
            this.cbEnablePriceToFilter.Name = "cbEnablePriceToFilter";
            this.cbEnablePriceToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnablePriceToFilter.TabIndex = 27;
            this.cbEnablePriceToFilter.Values.Text = "Enable Filter";
            this.cbEnablePriceToFilter.CheckedChanged += new System.EventHandler(this.cbEnablePriceToFilter_CheckedChanged);
            // 
            // cbEnablePriceFromFilter
            // 
            this.cbEnablePriceFromFilter.Location = new System.Drawing.Point(596, 109);
            this.cbEnablePriceFromFilter.Name = "cbEnablePriceFromFilter";
            this.cbEnablePriceFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnablePriceFromFilter.TabIndex = 28;
            this.cbEnablePriceFromFilter.Values.Text = "Enable Filter";
            this.cbEnablePriceFromFilter.CheckedChanged += new System.EventHandler(this.cbEnablePriceFromFilter_CheckedChanged);
            // 
            // cbEnableQuantityFromFilter
            // 
            this.cbEnableQuantityFromFilter.Location = new System.Drawing.Point(1151, 53);
            this.cbEnableQuantityFromFilter.Name = "cbEnableQuantityFromFilter";
            this.cbEnableQuantityFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableQuantityFromFilter.TabIndex = 30;
            this.cbEnableQuantityFromFilter.Values.Text = "Enable Filter";
            this.cbEnableQuantityFromFilter.CheckedChanged += new System.EventHandler(this.cbEnableQuantityFromFilter_CheckedChanged);
            // 
            // cbEnableQuantityToFilter
            // 
            this.cbEnableQuantityToFilter.Location = new System.Drawing.Point(1151, 26);
            this.cbEnableQuantityToFilter.Name = "cbEnableQuantityToFilter";
            this.cbEnableQuantityToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableQuantityToFilter.TabIndex = 29;
            this.cbEnableQuantityToFilter.Values.Text = "Enable Filter";
            this.cbEnableQuantityToFilter.CheckedChanged += new System.EventHandler(this.cbEnableQuantityToFilter_CheckedChanged);
            // 
            // cbEnableDateFromFilter
            // 
            this.cbEnableDateFromFilter.Location = new System.Drawing.Point(1151, 109);
            this.cbEnableDateFromFilter.Name = "cbEnableDateFromFilter";
            this.cbEnableDateFromFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableDateFromFilter.TabIndex = 32;
            this.cbEnableDateFromFilter.Values.Text = "Enable Filter";
            this.cbEnableDateFromFilter.CheckedChanged += new System.EventHandler(this.cbEnableDateFromFilter_CheckedChanged);
            // 
            // cbEnableDateToFilter
            // 
            this.cbEnableDateToFilter.Location = new System.Drawing.Point(1151, 81);
            this.cbEnableDateToFilter.Name = "cbEnableDateToFilter";
            this.cbEnableDateToFilter.Size = new System.Drawing.Size(108, 24);
            this.cbEnableDateToFilter.TabIndex = 31;
            this.cbEnableDateToFilter.Values.Text = "Enable Filter";
            this.cbEnableDateToFilter.CheckedChanged += new System.EventHandler(this.cbEnableDateToFilter_CheckedChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(849, 53);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(118, 24);
            this.kryptonLabel5.TabIndex = 34;
            this.kryptonLabel5.Values.Text = "Quantity Above";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(849, 26);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(115, 24);
            this.kryptonLabel6.TabIndex = 33;
            this.kryptonLabel6.Values.Text = "Quantity Below";
            // 
            // cbEnableAllFilters
            // 
            this.cbEnableAllFilters.Location = new System.Drawing.Point(596, 26);
            this.cbEnableAllFilters.Name = "cbEnableAllFilters";
            this.cbEnableAllFilters.Size = new System.Drawing.Size(136, 24);
            this.cbEnableAllFilters.TabIndex = 35;
            this.cbEnableAllFilters.Values.Text = "Enable All Filters";
            this.cbEnableAllFilters.CheckedChanged += new System.EventHandler(this.cbEnableAllFilters_CheckedChanged);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1487, 649);
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
            this.Controls.Add(this.numQuantityToFilter);
            this.Controls.Add(this.btnReserNameFilter);
            this.Controls.Add(this.numQuantityFromFilter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPriceToFilter);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.numPriceFromFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbSearchString);
            this.Controls.Add(this.dtpBeforeFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dtpAfterFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTargetUrl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvProductsView);
            this.MinimumSize = new System.Drawing.Size(1505, 696);
            this.Name = "Products";
            this.ShowIcon = false;
            this.Text = "Warehouse Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityFromFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsView;
        private Krypton.Toolkit.KryptonLabel lblCount;
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonButton btnReserNameFilter;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.DateTimePicker dtpBeforeFilter;
        private System.Windows.Forms.DateTimePicker dtpAfterFilter;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.TextBox tbTargetUrl;
        private Krypton.Toolkit.KryptonLabel label8;
        private Krypton.Toolkit.KryptonLabel label7;
        private System.Windows.Forms.NumericUpDown numPriceToFilter;
        private System.Windows.Forms.NumericUpDown numPriceFromFilter;
        private System.Windows.Forms.NumericUpDown numQuantityToFilter;
        private System.Windows.Forms.NumericUpDown numQuantityFromFilter;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel label1;
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
    }
}

