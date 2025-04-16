namespace WarehouseUI
{
    partial class ProductCreate
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
            this.label2 = new Krypton.Toolkit.KryptonLabel();
            this.label3 = new Krypton.Toolkit.KryptonLabel();
            this.label4 = new Krypton.Toolkit.KryptonLabel();
            this.label5 = new Krypton.Toolkit.KryptonLabel();
            this.label6 = new Krypton.Toolkit.KryptonLabel();
            this.label8 = new Krypton.Toolkit.KryptonLabel();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.label7 = new Krypton.Toolkit.KryptonLabel();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.SearchMaskPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.cbCategories = new Krypton.Toolkit.KryptonCheckedListBox();
            this.tbDescription = new Krypton.Toolkit.KryptonTextBox();
            this.tbProductName = new Krypton.Toolkit.KryptonTextBox();
            this.numProductPrice = new Krypton.Toolkit.KryptonNumericUpDown();
            this.numProductQuantity = new Krypton.Toolkit.KryptonNumericUpDown();
            this.dtProductCreatedAt = new Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).BeginInit();
            this.SearchMaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Values.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label3.Location = new System.Drawing.Point(96, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Values.Text = "Price $";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label4.Location = new System.Drawing.Point(37, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Values.Text = "Stock Quantity";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label5.Location = new System.Drawing.Point(70, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Values.Text = "Created at";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label6.Location = new System.Drawing.Point(61, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 5;
            this.label6.Values.Text = "Description";
            this.label6.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label8.Location = new System.Drawing.Point(772, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 13;
            this.label8.Values.Text = "Categories";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(12, 446);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 33);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Values.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1079, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(700, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 23;
            this.label7.Values.Text = "select and/or deselect";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(65, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(157, 24);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Values.Text = "Fetching Categories...";
            this.lblSearch.Visible = false;
            // 
            // SearchMaskPanel
            // 
            this.SearchMaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchMaskPanel.Controls.Add(this.kryptonProgressBar1);
            this.SearchMaskPanel.Controls.Add(this.lblSearch);
            this.SearchMaskPanel.Location = new System.Drawing.Point(903, 194);
            this.SearchMaskPanel.Name = "SearchMaskPanel";
            this.SearchMaskPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.SearchMaskPanel.Size = new System.Drawing.Size(273, 89);
            this.SearchMaskPanel.TabIndex = 45;
            this.SearchMaskPanel.Visible = false;
            // 
            // kryptonProgressBar1
            // 
            this.kryptonProgressBar1.Location = new System.Drawing.Point(14, 47);
            this.kryptonProgressBar1.MarqueeAnimationSpeed = 200;
            this.kryptonProgressBar1.Name = "kryptonProgressBar1";
            this.kryptonProgressBar1.Size = new System.Drawing.Size(244, 31);
            this.kryptonProgressBar1.StateCommon.Back.Color1 = System.Drawing.Color.Green;
            this.kryptonProgressBar1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote;
            this.kryptonProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kryptonProgressBar1.TabIndex = 14;
            this.kryptonProgressBar1.Values.Text = "";
            // 
            // cbCategories
            // 
            this.cbCategories.Location = new System.Drawing.Point(887, 51);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(303, 384);
            this.cbCategories.TabIndex = 46;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(184, 179);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(491, 256);
            this.tbDescription.TabIndex = 47;
            this.tbDescription.UseMnemonic = false;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(184, 51);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(276, 27);
            this.tbProductName.TabIndex = 48;
            // 
            // numProductPrice
            // 
            this.numProductPrice.AllowDecimals = true;
            this.numProductPrice.DecimalPlaces = 2;
            this.numProductPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProductPrice.Location = new System.Drawing.Point(184, 84);
            this.numProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numProductPrice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(107, 26);
            this.numProductPrice.TabIndex = 49;
            this.numProductPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // numProductQuantity
            // 
            this.numProductQuantity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProductQuantity.Location = new System.Drawing.Point(184, 116);
            this.numProductQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numProductQuantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numProductQuantity.Name = "numProductQuantity";
            this.numProductQuantity.Size = new System.Drawing.Size(109, 26);
            this.numProductQuantity.TabIndex = 50;
            this.numProductQuantity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dtProductCreatedAt
            // 
            this.dtProductCreatedAt.Location = new System.Drawing.Point(184, 148);
            this.dtProductCreatedAt.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtProductCreatedAt.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtProductCreatedAt.Name = "dtProductCreatedAt";
            this.dtProductCreatedAt.Size = new System.Drawing.Size(278, 25);
            this.dtProductCreatedAt.TabIndex = 51;
            // 
            // ProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 574);
            this.Controls.Add(this.dtProductCreatedAt);
            this.Controls.Add(this.numProductQuantity);
            this.Controls.Add(this.numProductPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.SearchMaskPanel);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(1004, 621);
            this.Name = "ProductCreate";
            this.Text = "Product Create";
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).EndInit();
            this.SearchMaskPanel.ResumeLayout(false);
            this.SearchMaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel label4;
        private Krypton.Toolkit.KryptonLabel label5;
        private Krypton.Toolkit.KryptonLabel label6;
        private Krypton.Toolkit.KryptonLabel label8;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel label7;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonPanel SearchMaskPanel;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private Krypton.Toolkit.KryptonCheckedListBox cbCategories;
        private Krypton.Toolkit.KryptonTextBox tbDescription;
        private Krypton.Toolkit.KryptonTextBox tbProductName;
        private Krypton.Toolkit.KryptonNumericUpDown numProductPrice;
        private Krypton.Toolkit.KryptonNumericUpDown numProductQuantity;
        private Krypton.Toolkit.KryptonDateTimePicker dtProductCreatedAt;
    }
}