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
using WarehouseApi.DataTransferClasses;
using WarehouseUI.DataTransferClasses;
using WarehouseUI.Models;

namespace WarehouseUI
{
    public partial class ProductUpdate : KryptonForm
    {
        public Products MainForm { get; set; }
        public Dictionary<string, int> CategoryNameId { get; set; }
        public List<int> PreSelectedCategoryIds { get; set; }

        public ProductUpdate(Product item, Products mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;

            PopulateUiWithProductData(item);
            RefreshCategoryCbList();
        }

        private void PopulateUiWithProductData(Product item)
        {
            tbProductName.Text = item.ProductName;
            numProductPrice.Value = item.Price;
            numProductQuantity.Value = item.StockQuantity;
            dtProductUpdatedAt.Value = item.CreatedAt;
            tbDescription.Text = item.Description;
            PreSelectedCategoryIds = item.CheckedCategoryIds;
        }

        private async void RefreshCategoryCbList()
        {
            SearchMaskPanel.Visible = true;

            CategoryNameId = new Dictionary<string, int>();
            var results = await UIController.GetCategories();
            cbCategories.Items.Clear();

            for (int i = 0; i < results.Count; i++)// (var category in results)
            {
                CategoryNameId.Add(results[i].CategoryName, results[i].CategoryId);
                cbCategories.Items.Add(results[i].CategoryName);

                if (PreSelectedCategoryIds.Contains(results[i].CategoryId))
                    cbCategories.SetItemChecked(i, true);
            }

            SearchMaskPanel.Visible = false;
        }

        private void btnPromptAddCategoryPanel_Click(object sender, EventArgs e)
        {
            SwitchAddCategoryUi();
        }
        private void SwitchAddCategoryUi()
        {
            btnPromptAddCategoryPanel.Enabled = !btnPromptAddCategoryPanel.Enabled;
            NewCategoryDialogPanel.Visible = !NewCategoryDialogPanel.Visible;
        }

        private async void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategoryInput = tbNewCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newCategoryInput))
            {
                MessageBox.Show("Please enter Category name.");
                return;
            }

            Category categoryToAdd = new Category
            {
                CategoryName = newCategoryInput,
                CreatedAt = DateTime.Now
            };

            bool success = await UIController.CreateCategory(categoryToAdd);

            if (success)
            {
                MessageBox.Show($"Category {tbProductName.Text} Successfully added.");
                SwitchAddCategoryUi();
                RefreshCategoryCbList();
            }
            else
            {
                throw new Exception();
            }
        }

        private void CloseNewCategoryDialogPanel_Click(object sender, EventArgs e)
        {
            tbNewCategoryName.Clear();
            SwitchAddCategoryUi();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbCategories.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select at least one Category.");
                return;
            }

            Product productToUpdate = new Product
            {
                ProductName = tbProductName.Text,
                CreatedAt = dtProductUpdatedAt.Value,
                Description = tbDescription.Text,
                StockQuantity = (int)numProductQuantity.Value,
                Price = numProductPrice.Value,
                CheckedCategoryIds = new List<int>()
            };
            foreach (var item in cbCategories.CheckedItems)
            {
                string categoryName = item.ToString().Trim();
                productToUpdate.CheckedCategoryIds.Add(CategoryNameId[categoryName]);
            }

            bool success = await UIController.UpdateProduct(productToUpdate);

            if (success)
            {
                MessageBox.Show($"Product {tbProductName.Text} Successfully added.");
                MainForm.ResetAllFilters();
                MainForm.SearchProducts();
                this.Close();
            }
            else
            {
                throw new Exception();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
