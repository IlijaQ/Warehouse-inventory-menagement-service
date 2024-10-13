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
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReserNameFilter = new System.Windows.Forms.Button();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnToggleToFilter = new System.Windows.Forms.Button();
            this.btnToggleFromFilter = new System.Windows.Forms.Button();
            this.btnResetDateFilter = new System.Windows.Forms.Button();
            this.dtpBeforeFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpAfterFilter = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTogglePriceTo = new System.Windows.Forms.Button();
            this.btnTogglePriceFrom = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numPriceToFilter = new System.Windows.Forms.NumericUpDown();
            this.numPriceFromFilter = new System.Windows.Forms.NumericUpDown();
            this.butResetPriceFilter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnToggleQuantityTo = new System.Windows.Forms.Button();
            this.btnToggleQuantityFrom = new System.Windows.Forms.Button();
            this.numQuantityToFilter = new System.Windows.Forms.NumericUpDown();
            this.numQuantityFromFilter = new System.Windows.Forms.NumericUpDown();
            this.btnResetQuantityFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetAllFilters = new System.Windows.Forms.Button();
            this.tbTargetUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.dgvProductsView.Location = new System.Drawing.Point(12, 191);
            this.dgvProductsView.Name = "dgvProductsView";
            this.dgvProductsView.RowHeadersWidth = 51;
            this.dgvProductsView.RowTemplate.Height = 24;
            this.dgvProductsView.Size = new System.Drawing.Size(1469, 418);
            this.dgvProductsView.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(9, 617);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(58, 20);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Count";
            this.lblCount.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReserNameFilter);
            this.groupBox1.Controls.Add(this.tbSearchString);
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Name Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type procuct name or name part.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search is not case sensitive.";
            // 
            // btnReserNameFilter
            // 
            this.btnReserNameFilter.Location = new System.Drawing.Point(230, 86);
            this.btnReserNameFilter.Name = "btnReserNameFilter";
            this.btnReserNameFilter.Size = new System.Drawing.Size(116, 35);
            this.btnReserNameFilter.TabIndex = 10;
            this.btnReserNameFilter.Text = "Reset Filter";
            this.btnReserNameFilter.UseVisualStyleBackColor = true;
            this.btnReserNameFilter.Click += new System.EventHandler(this.btnReserNameFilter_Click);
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(6, 32);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(340, 22);
            this.tbSearchString.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnToggleToFilter);
            this.groupBox2.Controls.Add(this.btnToggleFromFilter);
            this.groupBox2.Controls.Add(this.btnResetDateFilter);
            this.groupBox2.Controls.Add(this.dtpBeforeFilter);
            this.groupBox2.Controls.Add(this.dtpAfterFilter);
            this.groupBox2.Location = new System.Drawing.Point(372, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DateTime Filter";
            // 
            // btnToggleToFilter
            // 
            this.btnToggleToFilter.Location = new System.Drawing.Point(18, 56);
            this.btnToggleToFilter.Name = "btnToggleToFilter";
            this.btnToggleToFilter.Size = new System.Drawing.Size(73, 30);
            this.btnToggleToFilter.TabIndex = 24;
            this.btnToggleToFilter.Text = "To";
            this.btnToggleToFilter.UseVisualStyleBackColor = true;
            this.btnToggleToFilter.Click += new System.EventHandler(this.btnToggleToFilter_Click);
            // 
            // btnToggleFromFilter
            // 
            this.btnToggleFromFilter.Location = new System.Drawing.Point(18, 21);
            this.btnToggleFromFilter.Name = "btnToggleFromFilter";
            this.btnToggleFromFilter.Size = new System.Drawing.Size(73, 31);
            this.btnToggleFromFilter.TabIndex = 23;
            this.btnToggleFromFilter.Text = "From";
            this.btnToggleFromFilter.UseVisualStyleBackColor = true;
            this.btnToggleFromFilter.Click += new System.EventHandler(this.btnToggleFromFilter_Click);
            // 
            // btnResetDateFilter
            // 
            this.btnResetDateFilter.Location = new System.Drawing.Point(246, 86);
            this.btnResetDateFilter.Name = "btnResetDateFilter";
            this.btnResetDateFilter.Size = new System.Drawing.Size(116, 35);
            this.btnResetDateFilter.TabIndex = 11;
            this.btnResetDateFilter.Text = "Reset Filter";
            this.btnResetDateFilter.UseVisualStyleBackColor = true;
            this.btnResetDateFilter.Click += new System.EventHandler(this.btnResetDateFilter_Click);
            // 
            // dtpBeforeFilter
            // 
            this.dtpBeforeFilter.Enabled = false;
            this.dtpBeforeFilter.Location = new System.Drawing.Point(109, 52);
            this.dtpBeforeFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBeforeFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpBeforeFilter.Name = "dtpBeforeFilter";
            this.dtpBeforeFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpBeforeFilter.TabIndex = 1;
            // 
            // dtpAfterFilter
            // 
            this.dtpAfterFilter.Enabled = false;
            this.dtpAfterFilter.Location = new System.Drawing.Point(109, 26);
            this.dtpAfterFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpAfterFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpAfterFilter.Name = "dtpAfterFilter";
            this.dtpAfterFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpAfterFilter.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.btnTogglePriceTo);
            this.groupBox3.Controls.Add(this.btnTogglePriceFrom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numPriceToFilter);
            this.groupBox3.Controls.Add(this.numPriceFromFilter);
            this.groupBox3.Controls.Add(this.butResetPriceFilter);
            this.groupBox3.Location = new System.Drawing.Point(748, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price Filter";
            // 
            // btnTogglePriceTo
            // 
            this.btnTogglePriceTo.Location = new System.Drawing.Point(14, 56);
            this.btnTogglePriceTo.Name = "btnTogglePriceTo";
            this.btnTogglePriceTo.Size = new System.Drawing.Size(129, 30);
            this.btnTogglePriceTo.TabIndex = 20;
            this.btnTogglePriceTo.Text = "Price To";
            this.btnTogglePriceTo.UseVisualStyleBackColor = true;
            this.btnTogglePriceTo.Click += new System.EventHandler(this.btnTogglePriceTo_Click);
            // 
            // btnTogglePriceFrom
            // 
            this.btnTogglePriceFrom.Location = new System.Drawing.Point(14, 21);
            this.btnTogglePriceFrom.Name = "btnTogglePriceFrom";
            this.btnTogglePriceFrom.Size = new System.Drawing.Size(129, 31);
            this.btnTogglePriceFrom.TabIndex = 19;
            this.btnTogglePriceFrom.Text = "Price From";
            this.btnTogglePriceFrom.UseVisualStyleBackColor = true;
            this.btnTogglePriceFrom.Click += new System.EventHandler(this.btnTogglePriceFrom_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "$";
            // 
            // numPriceToFilter
            // 
            this.numPriceToFilter.DecimalPlaces = 2;
            this.numPriceToFilter.Enabled = false;
            this.numPriceToFilter.Location = new System.Drawing.Point(189, 54);
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
            this.numPriceFromFilter.Location = new System.Drawing.Point(189, 27);
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
            // butResetPriceFilter
            // 
            this.butResetPriceFilter.Location = new System.Drawing.Point(251, 88);
            this.butResetPriceFilter.Name = "butResetPriceFilter";
            this.butResetPriceFilter.Size = new System.Drawing.Size(116, 35);
            this.butResetPriceFilter.TabIndex = 12;
            this.butResetPriceFilter.Text = "Reset Filter";
            this.butResetPriceFilter.UseVisualStyleBackColor = true;
            this.butResetPriceFilter.Click += new System.EventHandler(this.butResetPriceFilter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnToggleQuantityTo);
            this.groupBox4.Controls.Add(this.btnToggleQuantityFrom);
            this.groupBox4.Controls.Add(this.numQuantityToFilter);
            this.groupBox4.Controls.Add(this.numQuantityFromFilter);
            this.groupBox4.Controls.Add(this.btnResetQuantityFilter);
            this.groupBox4.Location = new System.Drawing.Point(1127, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 131);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quantity Filter";
            // 
            // btnToggleQuantityTo
            // 
            this.btnToggleQuantityTo.Location = new System.Drawing.Point(17, 56);
            this.btnToggleQuantityTo.Name = "btnToggleQuantityTo";
            this.btnToggleQuantityTo.Size = new System.Drawing.Size(149, 30);
            this.btnToggleQuantityTo.TabIndex = 22;
            this.btnToggleQuantityTo.Text = "Quantity To";
            this.btnToggleQuantityTo.UseVisualStyleBackColor = true;
            this.btnToggleQuantityTo.Click += new System.EventHandler(this.btnToggleQuantityTo_Click);
            // 
            // btnToggleQuantityFrom
            // 
            this.btnToggleQuantityFrom.Location = new System.Drawing.Point(17, 21);
            this.btnToggleQuantityFrom.Name = "btnToggleQuantityFrom";
            this.btnToggleQuantityFrom.Size = new System.Drawing.Size(149, 30);
            this.btnToggleQuantityFrom.TabIndex = 21;
            this.btnToggleQuantityFrom.Text = "Quantity From";
            this.btnToggleQuantityFrom.UseVisualStyleBackColor = true;
            this.btnToggleQuantityFrom.Click += new System.EventHandler(this.btnToggleQuantityFrom_Click);
            // 
            // numQuantityToFilter
            // 
            this.numQuantityToFilter.Enabled = false;
            this.numQuantityToFilter.Location = new System.Drawing.Point(202, 53);
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
            this.numQuantityFromFilter.Location = new System.Drawing.Point(202, 26);
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
            // btnResetQuantityFilter
            // 
            this.btnResetQuantityFilter.Location = new System.Drawing.Point(232, 88);
            this.btnResetQuantityFilter.Name = "btnResetQuantityFilter";
            this.btnResetQuantityFilter.Size = new System.Drawing.Size(116, 31);
            this.btnResetQuantityFilter.TabIndex = 13;
            this.btnResetQuantityFilter.Text = "Reset Filter";
            this.btnResetQuantityFilter.UseVisualStyleBackColor = true;
            this.btnResetQuantityFilter.Click += new System.EventHandler(this.btnResetQuantityFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Products";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetAllFilters
            // 
            this.btnResetAllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAllFilters.Location = new System.Drawing.Point(1303, 12);
            this.btnResetAllFilters.Name = "btnResetAllFilters";
            this.btnResetAllFilters.Size = new System.Drawing.Size(172, 36);
            this.btnResetAllFilters.TabIndex = 8;
            this.btnResetAllFilters.Text = "Reset All Filters";
            this.btnResetAllFilters.UseVisualStyleBackColor = true;
            this.btnResetAllFilters.Click += new System.EventHandler(this.btnResetAllFilters_Click);
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
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Click the Buttons next to Filters in order to enable them.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paste the Base Target Url here:";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(708, 376);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(86, 18);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Searching...";
            this.lblSearch.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(188, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 36);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1487, 649);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResetAllFilters);
            this.Controls.Add(this.tbTargetUrl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvProductsView);
            this.MinimumSize = new System.Drawing.Size(1505, 696);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityFromFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductsView;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReserNameFilter;
        private System.Windows.Forms.TextBox tbSearchString;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetDateFilter;
        private System.Windows.Forms.DateTimePicker dtpBeforeFilter;
        private System.Windows.Forms.DateTimePicker dtpAfterFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butResetPriceFilter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnResetQuantityFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetAllFilters;
        private System.Windows.Forms.TextBox tbTargetUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numPriceToFilter;
        private System.Windows.Forms.NumericUpDown numPriceFromFilter;
        private System.Windows.Forms.NumericUpDown numQuantityToFilter;
        private System.Windows.Forms.NumericUpDown numQuantityFromFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToggleToFilter;
        private System.Windows.Forms.Button btnToggleFromFilter;
        private System.Windows.Forms.Button btnTogglePriceTo;
        private System.Windows.Forms.Button btnTogglePriceFrom;
        private System.Windows.Forms.Button btnToggleQuantityTo;
        private System.Windows.Forms.Button btnToggleQuantityFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCreate;
    }
}

