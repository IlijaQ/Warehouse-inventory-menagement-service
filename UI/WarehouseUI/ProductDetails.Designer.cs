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
            this.lblDescriptionTag = new Krypton.Toolkit.KryptonLabel();
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.lblProductName = new Krypton.Toolkit.KryptonLabel();
            this.lblPrice = new Krypton.Toolkit.KryptonLabel();
            this.lblQuantity = new Krypton.Toolkit.KryptonLabel();
            this.lblProductCreatedAt = new Krypton.Toolkit.KryptonLabel();
            this.lblCategoriesTag = new Krypton.Toolkit.KryptonLabel();
            this.btnEdit = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.SearchMaskPanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonProgressBar1 = new Krypton.Toolkit.KryptonProgressBar();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.lblNoDescTag = new Krypton.Toolkit.KryptonLabel();
            this.lblWrapDescription = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).BeginInit();
            this.SearchMaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Values.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label2.Location = new System.Drawing.Point(37, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Values.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label3.Location = new System.Drawing.Point(103, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 2;
            this.label3.Values.Text = "Price";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label4.Location = new System.Drawing.Point(34, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 3;
            this.label4.Values.Text = "Stock Quantity";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.label5.Location = new System.Drawing.Point(64, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Values.Text = "Created at";
            // 
            // lblDescriptionTag
            // 
            this.lblDescriptionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTag.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblDescriptionTag.Location = new System.Drawing.Point(55, 262);
            this.lblDescriptionTag.Name = "lblDescriptionTag";
            this.lblDescriptionTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescriptionTag.Size = new System.Drawing.Size(95, 24);
            this.lblDescriptionTag.TabIndex = 5;
            this.lblDescriptionTag.Values.Text = "Description";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblId.Location = new System.Drawing.Point(188, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 24);
            this.lblId.TabIndex = 7;
            this.lblId.Values.Text = "id";
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(188, 70);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(52, 24);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Values.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(188, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 24);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Values.Text = "$ Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(188, 132);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 24);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Values.Text = "Quantity";
            // 
            // lblProductCreatedAt
            // 
            this.lblProductCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCreatedAt.Location = new System.Drawing.Point(188, 162);
            this.lblProductCreatedAt.Name = "lblProductCreatedAt";
            this.lblProductCreatedAt.Size = new System.Drawing.Size(82, 24);
            this.lblProductCreatedAt.TabIndex = 11;
            this.lblProductCreatedAt.Values.Text = "Created at";
            // 
            // lblCategoriesTag
            // 
            this.lblCategoriesTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriesTag.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblCategoriesTag.Location = new System.Drawing.Point(61, 195);
            this.lblCategoriesTag.Name = "lblCategoriesTag";
            this.lblCategoriesTag.Size = new System.Drawing.Size(89, 24);
            this.lblCategoriesTag.TabIndex = 13;
            this.lblCategoriesTag.Values.Text = "Categories";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(404, 482);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 33);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 482);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 33);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(521, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchMaskPanel
            // 
            this.SearchMaskPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchMaskPanel.Controls.Add(this.kryptonProgressBar1);
            this.SearchMaskPanel.Controls.Add(this.lblSearch);
            this.SearchMaskPanel.Location = new System.Drawing.Point(190, 182);
            this.SearchMaskPanel.Name = "SearchMaskPanel";
            this.SearchMaskPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.SearchMaskPanel.Size = new System.Drawing.Size(272, 87);
            this.SearchMaskPanel.TabIndex = 46;
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
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(55, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(173, 24);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Values.Text = "Fetching Product Data...";
            // 
            // lblNoDescTag
            // 
            this.lblNoDescTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDescTag.Location = new System.Drawing.Point(37, 262);
            this.lblNoDescTag.Name = "lblNoDescTag";
            this.lblNoDescTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNoDescTag.Size = new System.Drawing.Size(109, 24);
            this.lblNoDescTag.TabIndex = 49;
            this.lblNoDescTag.Values.Text = "no description";
            this.lblNoDescTag.Visible = false;
            // 
            // lblWrapDescription
            // 
            this.lblWrapDescription.AutoSize = false;
            this.lblWrapDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWrapDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblWrapDescription.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            this.lblWrapDescription.Location = new System.Drawing.Point(190, 265);
            this.lblWrapDescription.Name = "lblWrapDescription";
            this.lblWrapDescription.Size = new System.Drawing.Size(442, 96);
            this.lblWrapDescription.Text = "Description text";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(644, 527);
            this.Controls.Add(this.SearchMaskPanel);
            this.Controls.Add(this.lblWrapDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCategoriesTag);
            this.Controls.Add(this.lblProductCreatedAt);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDescriptionTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoDescTag);
            this.MinimumSize = new System.Drawing.Size(662, 574);
            this.Name = "ProductDetails";
            this.ShowIcon = false;
            this.Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)(this.SearchMaskPanel)).EndInit();
            this.SearchMaskPanel.ResumeLayout(false);
            this.SearchMaskPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel label1;
        private Krypton.Toolkit.KryptonLabel label2;
        private Krypton.Toolkit.KryptonLabel label3;
        private Krypton.Toolkit.KryptonLabel label4;
        private Krypton.Toolkit.KryptonLabel label5;
        private Krypton.Toolkit.KryptonLabel lblDescriptionTag;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonLabel lblProductName;
        private Krypton.Toolkit.KryptonLabel lblPrice;
        private Krypton.Toolkit.KryptonLabel lblQuantity;
        private Krypton.Toolkit.KryptonLabel lblProductCreatedAt;
        private Krypton.Toolkit.KryptonLabel lblCategoriesTag;
        private Krypton.Toolkit.KryptonButton btnEdit;
        private Krypton.Toolkit.KryptonButton btnDelete;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonPanel SearchMaskPanel;
        private Krypton.Toolkit.KryptonProgressBar kryptonProgressBar1;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonLabel lblNoDescTag;
        private Krypton.Toolkit.KryptonWrapLabel lblWrapDescription;
    }
}