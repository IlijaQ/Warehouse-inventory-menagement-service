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

namespace WarehouseUI
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            dgvProductsView.AutoGenerateColumns = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbTargetUrl.Text.Trim()))
            {
                MessageBox.Show("Configure base url first.\r\nTextbox at the bottom right.");
                return;
            }
            ProductCreate dialog = new ProductCreate(this);
            dialog.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await SearchProducts();
        }
        public async Task SearchProducts()
        {
            lblSearch.Visible = true;
            dgvProductsView.DataSource = null;

            SearchFilters filters = new SearchFilters();
            ApplyFilters(filters);

            var results = await UIController.GetProducts(filters);
            dgvProductsView.DataSource = results;

            FormatGridView();

            lblCount.Text = $"Count: {results.Count}";
            lblCount.Visible = true;
            lblSearch.Visible = false;
        }

        private void ApplyFilters(SearchFilters filters)
        {
            if (!string.IsNullOrEmpty(tbSearchString.Text))
                filters.Name = tbSearchString.Text.Trim();

            if (dtpAfterFilter.Enabled && dtpAfterFilter.Value != null)
                filters.DateTimeAfter = dtpAfterFilter.Value;
            if (dtpBeforeFilter.Enabled && dtpAfterFilter.Value != null)
                filters.DateTimeBefore = dtpBeforeFilter.Value;

            if (numPriceFromFilter.Enabled && numPriceFromFilter.Value != null)
                filters.PriceFrom = numPriceFromFilter.Value;
            if (numPriceToFilter.Enabled && numPriceToFilter.Value != null)
                filters.PriceTo = numPriceToFilter.Value;

            if (numQuantityFromFilter.Enabled && numQuantityFromFilter.Value != null)
                filters.StockMoreThan = (int?)numQuantityFromFilter.Value;
            if (numQuantityToFilter.Enabled && numQuantityToFilter.Value != null)
                filters.StockLessThan = (int?)numQuantityToFilter.Value;
        }
        private void FormatGridView()
        {
            dgvProductsView.Columns["ProductId"].Width = 70;
            dgvProductsView.Columns["ProductName"].Width = 150;
            dgvProductsView.Columns["Price"].Width = 70;
            dgvProductsView.Columns["StockQuantity"].Width = 70;
            dgvProductsView.Columns["Description"].Width = 400;
            dgvProductsView.Columns["CreatedAt"].Width = 150;
            
            dgvProductsView.Columns["CreatedAt"].DefaultCellStyle.Format = "dd.MM.yyyy. HH:mm";

            dgvProductsView.Columns["ProductName"].Name = "Product Name";
            dgvProductsView.Columns["Price"].Name = "Price $";
            dgvProductsView.Columns["StockQuantity"].Name = "Quantity";
            dgvProductsView.Columns["CreatedAt"].Name = "Created At";
        }

        private void btnReserNameFilter_Click(object sender, EventArgs e)
        {
            tbSearchString.Text = string.Empty;
        }

        private void btnToggleFromFilter_Click(object sender, EventArgs e)
        {
            dtpAfterFilter.Enabled = !dtpAfterFilter.Enabled;
        }
        private void btnToggleToFilter_Click(object sender, EventArgs e)
        {
            dtpBeforeFilter.Enabled = !dtpBeforeFilter.Enabled;
        }
        private void btnResetDateFilter_Click(object sender, EventArgs e)
        {
            ResetDateFilter();
        }
        private void ResetDateFilter()
        {
            dtpAfterFilter.Enabled = false;
            dtpAfterFilter.Value = DateTime.Now;

            dtpBeforeFilter.Enabled = false;
            dtpBeforeFilter.Value = DateTime.Now;
        }

        private void btnTogglePriceFrom_Click(object sender, EventArgs e)
        {
            numPriceFromFilter.Enabled = !numPriceFromFilter.Enabled;
        }
        private void btnTogglePriceTo_Click(object sender, EventArgs e)
        {
            numPriceToFilter.Enabled = !numPriceToFilter.Enabled;
        }
        private void butResetPriceFilter_Click(object sender, EventArgs e)
        {
            ResetPriceFilter();
        }
        private void ResetPriceFilter()
        {
            numPriceFromFilter.Enabled = false;
            numPriceFromFilter.Value = 0m;

            numPriceToFilter.Enabled = false;
            numPriceToFilter.Value = 0m;
        }

        private void btnToggleQuantityFrom_Click(object sender, EventArgs e)
        {
            numQuantityFromFilter.Enabled = !numQuantityFromFilter.Enabled;
        }
        private void btnToggleQuantityTo_Click(object sender, EventArgs e)
        {
            numQuantityToFilter.Enabled = !numQuantityToFilter.Enabled;
        }

        private void btnResetQuantityFilter_Click(object sender, EventArgs e)
        {
            ResetQuantityFilter();
        }
        private void ResetQuantityFilter()
        {
            numQuantityFromFilter.Enabled = false;
            numQuantityFromFilter.Value = 0;

            numQuantityToFilter.Enabled = false;
            numQuantityFromFilter.Value = 0;
        }

        private void btnResetAllFilters_Click(object sender, EventArgs e)
        {
            ResetAllFilters();
        }
        public void ResetAllFilters()
        {
            tbSearchString.Text = string.Empty;
            ResetDateFilter();
            ResetPriceFilter();
            ResetQuantityFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTargetUrl_TextChanged(object sender, EventArgs e)
        {
            string targetBaseUrl = tbTargetUrl.Text.Trim();
            
            int indexOfLastChar = targetBaseUrl.Length - 1;
            if (targetBaseUrl.Length > 0 && targetBaseUrl[indexOfLastChar] != '/')
                targetBaseUrl = targetBaseUrl + "/";
            
            if (targetBaseUrl.Contains("swagger/index.html"))
                targetBaseUrl = targetBaseUrl.Remove(targetBaseUrl.IndexOf("swagger/index.html"));
            
            Target.Url = tbTargetUrl.Text;
        }
    }
}
