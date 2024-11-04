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
            this.label1 = new Krypton.Toolkit.KryptonLabel();
            this.label2 = new Krypton.Toolkit.KryptonLabel();
            this.label3 = new Krypton.Toolkit.KryptonLabel();
            this.label4 = new Krypton.Toolkit.KryptonLabel();
            this.label5 = new Krypton.Toolkit.KryptonLabel();
            this.label6 = new Krypton.Toolkit.KryptonLabel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new Krypton.Toolkit.KryptonLabel();
            this.btnCreate = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.numProductPrice = new System.Windows.Forms.NumericUpDown();
            this.numProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtProductCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.cbCategories = new System.Windows.Forms.CheckedListBox();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.label7 = new Krypton.Toolkit.KryptonLabel();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Values.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Values.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label3.Location = new System.Drawing.Point(103, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Values.Text = "Price $";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Values.Text = "Stock Quantity";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label5.Location = new System.Drawing.Point(75, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Values.Text = "Created at";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label6.Location = new System.Drawing.Point(66, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 5;
            this.label6.Values.Text = "Description";
            this.label6.Visible = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(210, 254);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescription.Size = new System.Drawing.Size(276, 260);
            this.tbDescription.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label8.Location = new System.Drawing.Point(624, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 13;
            this.label8.Values.Text = "Categories";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(12, 529);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 33);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Values.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(863, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(210, 85);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(276, 22);
            this.tbProductName.TabIndex = 17;
            // 
            // numProductPrice
            // 
            this.numProductPrice.DecimalPlaces = 2;
            this.numProductPrice.Location = new System.Drawing.Point(210, 126);
            this.numProductPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(276, 22);
            this.numProductPrice.TabIndex = 18;
            // 
            // numProductQuantity
            // 
            this.numProductQuantity.Location = new System.Drawing.Point(210, 167);
            this.numProductQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numProductQuantity.Name = "numProductQuantity";
            this.numProductQuantity.Size = new System.Drawing.Size(276, 22);
            this.numProductQuantity.TabIndex = 19;
            // 
            // dtProductCreatedAt
            // 
            this.dtProductCreatedAt.Location = new System.Drawing.Point(210, 211);
            this.dtProductCreatedAt.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtProductCreatedAt.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtProductCreatedAt.Name = "dtProductCreatedAt";
            this.dtProductCreatedAt.Size = new System.Drawing.Size(276, 22);
            this.dtProductCreatedAt.TabIndex = 20;
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.CheckOnClick = true;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(624, 85);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(350, 429);
            this.cbCategories.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(206, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(116, 24);
            this.lblId.TabIndex = 22;
            this.lblId.Values.Text = "To Be Assigned";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(813, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 23;
            this.label7.Values.Text = "select and/or deselect";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(728, 289);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(157, 24);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Values.Text = "Fetching Categories...";
            this.lblSearch.Visible = false;
            // 
            // ProductCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 574);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.dtProductCreatedAt);
            this.Controls.Add(this.numProductQuantity);
            this.Controls.Add(this.numProductPrice);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductCreate";
            this.Text = "Product Create";
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel label4;
        private Krypton.Toolkit.KryptonLabel label5;
        private Krypton.Toolkit.KryptonLabel label6;
        private System.Windows.Forms.TextBox tbDescription;
        private Krypton.Toolkit.KryptonLabel label8;
        private Krypton.Toolkit.KryptonButton btnCreate;
        private Krypton.Toolkit.KryptonButton btnClose;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.NumericUpDown numProductPrice;
        private System.Windows.Forms.NumericUpDown numProductQuantity;
        private System.Windows.Forms.DateTimePicker dtProductCreatedAt;
        private System.Windows.Forms.CheckedListBox cbCategories;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonLabel label7;
        private Krypton.Toolkit.KryptonLabel lblSearch;
    }
}