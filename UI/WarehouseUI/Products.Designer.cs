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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetAllFilters = new System.Windows.Forms.Button();
            this.tbTargetUrl = new System.Windows.Forms.TextBox();
            this.tbSearchString = new System.Windows.Forms.TextBox();
            this.btnReserNameFilter = new System.Windows.Forms.Button();
            this.dtpAfterFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpBeforeFilter = new System.Windows.Forms.DateTimePicker();
            this.btnResetDateFilter = new System.Windows.Forms.Button();
            this.butResetPriceFilter = new System.Windows.Forms.Button();
            this.btnResetQuantityFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numPriceFromFilter = new System.Windows.Forms.NumericUpDown();
            this.numPriceToFilter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numQuantityToFilter = new System.Windows.Forms.NumericUpDown();
            this.numQuantityFromFilter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTogglePriceFrom = new System.Windows.Forms.Button();
            this.btnTogglePriceTo = new System.Windows.Forms.Button();
            this.btnToggleQuantityFrom = new System.Windows.Forms.Button();
            this.btnToggleQuantityTo = new System.Windows.Forms.Button();
            this.btnToggleFromFilter = new System.Windows.Forms.Button();
            this.btnToggleToFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityFromFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 418);
            this.dataGridView1.TabIndex = 0;
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
            this.groupBox1.Size = new System.Drawing.Size(334, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Name Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnToggleToFilter);
            this.groupBox2.Controls.Add(this.btnToggleFromFilter);
            this.groupBox2.Controls.Add(this.btnResetDateFilter);
            this.groupBox2.Controls.Add(this.dtpBeforeFilter);
            this.groupBox2.Controls.Add(this.dtpAfterFilter);
            this.groupBox2.Location = new System.Drawing.Point(354, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 131);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DateTime Filter";
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
            this.groupBox3.Location = new System.Drawing.Point(697, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price Filter";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnToggleQuantityTo);
            this.groupBox4.Controls.Add(this.btnToggleQuantityFrom);
            this.groupBox4.Controls.Add(this.numQuantityToFilter);
            this.groupBox4.Controls.Add(this.numQuantityFromFilter);
            this.groupBox4.Controls.Add(this.btnResetQuantityFilter);
            this.groupBox4.Location = new System.Drawing.Point(1043, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 131);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quantity Filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Products";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnResetAllFilters
            // 
            this.btnResetAllFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAllFilters.Location = new System.Drawing.Point(1186, 12);
            this.btnResetAllFilters.Name = "btnResetAllFilters";
            this.btnResetAllFilters.Size = new System.Drawing.Size(192, 36);
            this.btnResetAllFilters.TabIndex = 8;
            this.btnResetAllFilters.Text = "Reset All Filters";
            this.btnResetAllFilters.UseVisualStyleBackColor = true;
            this.btnResetAllFilters.Click += new System.EventHandler(this.btnResetAllFilters_Click);
            // 
            // tbTargetUrl
            // 
            this.tbTargetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTargetUrl.Location = new System.Drawing.Point(777, 615);
            this.tbTargetUrl.Name = "tbTargetUrl";
            this.tbTargetUrl.Size = new System.Drawing.Size(601, 22);
            this.tbTargetUrl.TabIndex = 9;
            this.tbTargetUrl.TextChanged += new System.EventHandler(this.tbTargetUrl_TextChanged);
            // 
            // tbSearchString
            // 
            this.tbSearchString.Location = new System.Drawing.Point(6, 32);
            this.tbSearchString.Name = "tbSearchString";
            this.tbSearchString.Size = new System.Drawing.Size(322, 22);
            this.tbSearchString.TabIndex = 10;
            // 
            // btnReserNameFilter
            // 
            this.btnReserNameFilter.Location = new System.Drawing.Point(212, 90);
            this.btnReserNameFilter.Name = "btnReserNameFilter";
            this.btnReserNameFilter.Size = new System.Drawing.Size(116, 35);
            this.btnReserNameFilter.TabIndex = 10;
            this.btnReserNameFilter.Text = "Reset Filter";
            this.btnReserNameFilter.UseVisualStyleBackColor = true;
            this.btnReserNameFilter.Click += new System.EventHandler(this.btnReserNameFilter_Click);
            // 
            // dtpAfterFilter
            // 
            this.dtpAfterFilter.Enabled = false;
            this.dtpAfterFilter.Location = new System.Drawing.Point(76, 30);
            this.dtpAfterFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpAfterFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpAfterFilter.Name = "dtpAfterFilter";
            this.dtpAfterFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpAfterFilter.TabIndex = 0;
            // 
            // dtpBeforeFilter
            // 
            this.dtpBeforeFilter.Enabled = false;
            this.dtpBeforeFilter.Location = new System.Drawing.Point(76, 56);
            this.dtpBeforeFilter.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBeforeFilter.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpBeforeFilter.Name = "dtpBeforeFilter";
            this.dtpBeforeFilter.Size = new System.Drawing.Size(253, 22);
            this.dtpBeforeFilter.TabIndex = 1;
            // 
            // btnResetDateFilter
            // 
            this.btnResetDateFilter.Location = new System.Drawing.Point(213, 90);
            this.btnResetDateFilter.Name = "btnResetDateFilter";
            this.btnResetDateFilter.Size = new System.Drawing.Size(116, 35);
            this.btnResetDateFilter.TabIndex = 11;
            this.btnResetDateFilter.Text = "Reset Filter";
            this.btnResetDateFilter.UseVisualStyleBackColor = true;
            this.btnResetDateFilter.Click += new System.EventHandler(this.btnResetDateFilter_Click);
            // 
            // butResetPriceFilter
            // 
            this.butResetPriceFilter.Location = new System.Drawing.Point(218, 90);
            this.butResetPriceFilter.Name = "butResetPriceFilter";
            this.butResetPriceFilter.Size = new System.Drawing.Size(116, 35);
            this.butResetPriceFilter.TabIndex = 12;
            this.butResetPriceFilter.Text = "Reset Filter";
            this.butResetPriceFilter.UseVisualStyleBackColor = true;
            this.butResetPriceFilter.Click += new System.EventHandler(this.butResetPriceFilter_Click);
            // 
            // btnResetQuantityFilter
            // 
            this.btnResetQuantityFilter.Location = new System.Drawing.Point(213, 90);
            this.btnResetQuantityFilter.Name = "btnResetQuantityFilter";
            this.btnResetQuantityFilter.Size = new System.Drawing.Size(116, 31);
            this.btnResetQuantityFilter.TabIndex = 13;
            this.btnResetQuantityFilter.Text = "Reset Filter";
            this.btnResetQuantityFilter.UseVisualStyleBackColor = true;
            this.btnResetQuantityFilter.Click += new System.EventHandler(this.btnResetQuantityFilter_Click);
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
            // numPriceFromFilter
            // 
            this.numPriceFromFilter.DecimalPlaces = 2;
            this.numPriceFromFilter.Enabled = false;
            this.numPriceFromFilter.Location = new System.Drawing.Point(156, 29);
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
            // numPriceToFilter
            // 
            this.numPriceToFilter.DecimalPlaces = 2;
            this.numPriceToFilter.Enabled = false;
            this.numPriceToFilter.Location = new System.Drawing.Point(156, 56);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "$";
            // 
            // numQuantityToFilter
            // 
            this.numQuantityToFilter.Enabled = false;
            this.numQuantityToFilter.Location = new System.Drawing.Point(183, 55);
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
            this.numQuantityFromFilter.Location = new System.Drawing.Point(183, 28);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type procuct name or name part.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Click the Buttons next to Filters in order to enable them.";
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
            // btnToggleFromFilter
            // 
            this.btnToggleFromFilter.Location = new System.Drawing.Point(6, 21);
            this.btnToggleFromFilter.Name = "btnToggleFromFilter";
            this.btnToggleFromFilter.Size = new System.Drawing.Size(64, 31);
            this.btnToggleFromFilter.TabIndex = 23;
            this.btnToggleFromFilter.Text = "From";
            this.btnToggleFromFilter.UseVisualStyleBackColor = true;
            this.btnToggleFromFilter.Click += new System.EventHandler(this.btnToggleFromFilter_Click);
            // 
            // btnToggleToFilter
            // 
            this.btnToggleToFilter.Location = new System.Drawing.Point(6, 56);
            this.btnToggleToFilter.Name = "btnToggleToFilter";
            this.btnToggleToFilter.Size = new System.Drawing.Size(64, 30);
            this.btnToggleToFilter.TabIndex = 24;
            this.btnToggleToFilter.Text = "To";
            this.btnToggleToFilter.UseVisualStyleBackColor = true;
            this.btnToggleToFilter.Click += new System.EventHandler(this.btnToggleToFilter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paste Target Url:";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTargetUrl);
            this.Controls.Add(this.btnResetAllFilters);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1402, 696);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPriceFromFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityToFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityFromFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

