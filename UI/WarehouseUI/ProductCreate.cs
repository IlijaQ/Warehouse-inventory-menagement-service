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
    public partial class ProductCreate : Form
    {
        public Products PreviousForm { get; set; }
        public Dictionary<string, int> CategoryNameId { get; set; }

        public ProductCreate(Products previousForm)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            FillCategoryCbList();
        }

        private async void FillCategoryCbList()
        {
            lblSearch.Visible = true;

            CategoryNameId = new Dictionary<string, int>();
            var results = await UIController.GetCategories();
            cbCategories.Items.Clear();

            foreach (var category in results)
            {
                CategoryNameId.Add(category.CategoryName, category.CategoryId);
                cbCategories.Items.Add(category.CategoryName);
            }
            lblSearch.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if(cbCategories.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select at least one Category.");
                return;
            }

            Product productToAdd = new Product
            {
                ProductName = tbProductName.Text,
                CreatedAt = dtProductCreatedAt.Value,
                Description = tbDescription.Text,
                StockQuantity = (int)numProductQuantity.Value,
                Price = numProductPrice.Value,
                CheckedCategoryIds = new List<int>()
            };
            foreach(var item in cbCategories.CheckedItems)
            {
                string categoryName = item.ToString().Trim();
                productToAdd.CheckedCategoryIds.Add(CategoryNameId[categoryName]);
            }

            bool success = await UIController.CreateProduct(productToAdd);

            if (success)
            {
                MessageBox.Show($"Product {tbProductName.Text} Successfully added.");
                PreviousForm.ResetAllFilters();
                PreviousForm.SearchProducts();
                this.Close();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
