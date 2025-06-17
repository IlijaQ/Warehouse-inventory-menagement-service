using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseUI.Models;

namespace WarehouseUI
{
    public partial class ProductDetails : KryptonForm, IUsesCreateEditForm
    {
        private ProductAndCategories SelectedProduct { get; set; }
        private Products MainForm { get; set; }

        public ProductDetails(string productIdInString, Products mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            GetProductInfo(productIdInString);
        }

        private async void GetProductInfo(string productId)
        {
            SearchMaskPanel.Visible = true;

            var result = await UIController.GetProductById(productId);
            SelectedProduct = result;

            FillFormWithData(SelectedProduct);

            SearchMaskPanel.Visible = false;
        }
        private void FillFormWithData(ProductAndCategories selectedProduct)
        {
            string productIdInString = selectedProduct.Id.ToString();

            this.Text = $"{productIdInString} Details";
            lblId.Text = productIdInString;
            lblProductName.Text = selectedProduct.Name;
            lblPrice.Text = "$" + selectedProduct.Price.ToString();
            lblQuantity.Text = selectedProduct.Quantity.ToString();
            lblProductCreatedAt.Text = selectedProduct.CreatedAt.ToString("dd.MM.yyyy. HH:mm");
            
            int currentMaxYOffset = lblCategoriesTag.Location.Y;
            ArrangeInStacksOfFourLabels(ref currentMaxYOffset, selectedProduct);

            lblWrapDescription.Location = new Point(lblId.Location.X, currentMaxYOffset);
            lblWrapDescription.Text = selectedProduct.Description;
            
            if (string.IsNullOrEmpty(selectedProduct.Description.Trim()))
            {
                lblDescriptionTag.Visible = false;
                lblNoDescTag.Visible = true;
                lblNoDescTag.Location = new Point(lblNoDescTag.Location.X, currentMaxYOffset);
            }
            else
                lblDescriptionTag.Location = new Point(lblDescriptionTag.Location.X, currentMaxYOffset);
        }
        private void ArrangeInStacksOfFourLabels(ref int currentMaxYOffset, Models.ProductAndCategories result)
        {
            int count = 1;
            int xOffset = lblId.Location.X;
            int yOffset = currentMaxYOffset;

            List<string> categoryStringList = result.CategoryList.Select(c => c.Name).ToList();
            foreach (string categoryName in categoryStringList)
            {
                KryptonLabel lblCategory = new KryptonLabel
                {
                    Text = categoryName,
                    Location = new Point(xOffset, yOffset),
                    AutoSize = true
                };

                this.Controls.Add(lblCategory);

                yOffset += lblCategory.Height + 5;

                if (yOffset > currentMaxYOffset)
                    currentMaxYOffset = yOffset;

                if (count++ % 4 == 0)
                {
                    xOffset += 110;
                    yOffset = lblCategoriesTag.Location.Y;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ProductUpdate dialog = new ProductUpdate(SelectedProduct, this, MainForm);
            dialog.ShowDialog();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove '{SelectedProduct.Name}' from inventory?\r\nProduct Id: {SelectedProduct.Id}",
                $"Delete Id {SelectedProduct.Id}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if(result == DialogResult.Yes)
            {
                bool success = await UIController.DeleteProduct(SelectedProduct.Id.ToString());

                if (success)
                {
                    MainForm.Refresh();

                    MessageBox.Show(
                        $"Successfully removed '{SelectedProduct.Name}' from inventory.\r\nProduct Id: {SelectedProduct.Id}",
                        $"Deleted Id {SelectedProduct.Id}",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                    MainForm.ResetAllFilters();
                    MainForm.SearchProducts();
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
