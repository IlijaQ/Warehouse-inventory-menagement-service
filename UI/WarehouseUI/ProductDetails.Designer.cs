namespace WarehouseUI
{
    partial class ProductDetails
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
            this.lblDescription = new Krypton.Toolkit.KryptonLabel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.lblProductName = new Krypton.Toolkit.KryptonLabel();
            this.lblPrice = new Krypton.Toolkit.KryptonLabel();
            this.lblQuantity = new Krypton.Toolkit.KryptonLabel();
            this.lblProductCreatedAt = new Krypton.Toolkit.KryptonLabel();
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.label8 = new Krypton.Toolkit.KryptonLabel();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Values.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Values.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label3.Location = new System.Drawing.Point(94, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Values.Text = "Price $";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Values.Text = "Stock Quantity";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label5.Location = new System.Drawing.Point(66, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Values.Text = "Created at";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblDescription.Location = new System.Drawing.Point(57, 244);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 24);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Values.Text = "Description";
            this.lblDescription.Visible = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDescription.Location = new System.Drawing.Point(210, 244);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(290, 232);
            this.tbDescription.TabIndex = 6;
            this.tbDescription.Visible = false;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblId.Location = new System.Drawing.Point(206, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 7;
            this.lblId.Values.Text = "id";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(206, 75);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 24);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Values.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(206, 115);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 24);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Values.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(206, 155);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 24);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Values.Text = "Quantity";
            // 
            // lblProductCreatedAt
            // 
            this.lblProductCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCreatedAt.Location = new System.Drawing.Point(206, 199);
            this.lblProductCreatedAt.Name = "lblProductCreatedAt";
            this.lblProductCreatedAt.Size = new System.Drawing.Size(82, 24);
            this.lblProductCreatedAt.TabIndex = 11;
            this.lblProductCreatedAt.Values.Text = "Created at";
            // 
            // tbCategories
            // 
            this.tbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCategories.Location = new System.Drawing.Point(595, 75);
            this.tbCategories.Multiline = true;
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.ReadOnly = true;
            this.tbCategories.Size = new System.Drawing.Size(334, 401);
            this.tbCategories.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label8.Location = new System.Drawing.Point(595, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 24);
            this.label8.TabIndex = 13;
            this.label8.Values.Text = "Categories";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(595, 482);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Values.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Values.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(818, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblSearch.Location = new System.Drawing.Point(506, 244);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(96, 24);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Values.Text = "Searching...";
            this.lblSearch.Visible = false;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(941, 527);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCategories);
            this.Controls.Add(this.lblProductCreatedAt);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(959, 574);
            this.Name = "ProductDetails";
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel label4;
        private Krypton.Toolkit.KryptonLabel label5;
        private Krypton.Toolkit.KryptonLabel lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonLabel lblProductName;
        private Krypton.Toolkit.KryptonLabel lblPrice;
        private Krypton.Toolkit.KryptonLabel lblQuantity;
        private Krypton.Toolkit.KryptonLabel lblProductCreatedAt;
        private System.Windows.Forms.TextBox tbCategories;
        private Krypton.Toolkit.KryptonLabel label8;
        private Krypton.Toolkit.KryptonButton btnEdit;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonLabel lblSearch;
    }
}