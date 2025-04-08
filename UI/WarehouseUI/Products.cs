﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApi.DataTransferClasses;
using Krypton.Toolkit;

namespace WarehouseUI
{
    public partial class Products : KryptonForm
    {
        //private DateTime

        public Products()
        {
            InitializeComponent();
            AddTargetUrl urlDialog = new AddTargetUrl();
            urlDialog.ShowDialog();
            dgvProductsView.AutoGenerateColumns = true;
            Target.CheckSettingOf(Target.Url);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Target.Url.Trim()))
            {
                MessageBox.Show("Configure base url first.\r\nTextbox at the bottom right.");
                return;
            }
            ProductCreate dialog = new ProductCreate(this);
            dialog.ShowDialog();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Target.CheckSettingOf(Target.Url);
            await SearchProducts();
        }
        public async Task SearchProducts()
        {
            lblSearch.Visible = true;
            dgvProductsView.DataSource = null;
            dgvProductsView.Rows.Clear();
            dgvProductsView.Columns.Clear();

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

            dgvProductsView.Columns["ProductName"].HeaderText = "Product Name";
            dgvProductsView.Columns["Price"].HeaderText = "Price $";
            dgvProductsView.Columns["StockQuantity"].HeaderText = "Quantity";
            dgvProductsView.Columns["CreatedAt"].HeaderText = "Created At";

            DataGridViewButtonColumn rowButton = new DataGridViewButtonColumn();
            rowButton.Name = "More";
            rowButton.Text = "Details";
            rowButton.UseColumnTextForButtonValue = true;
            dgvProductsView.Columns.Add(rowButton);
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

        private void dgvProductsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvProductsView.Columns[e.ColumnIndex].Name == "More")
            {
                string productIdInString = dgvProductsView.Rows[e.RowIndex].Cells["ProductId"].Value.ToString().Trim();

                ProductDetails dialog = new ProductDetails(productIdInString);
                dialog.Show();
            }
        }

        private void dgvProductsView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;

            var rowIndex = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIndex, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void cbEnablePriceFromFilter_CheckedChanged(object sender, EventArgs e)
        {
            numPriceFromFilter.Enabled = !numPriceFromFilter.Enabled;
        }

        private void cbEnablePriceToFilter_CheckedChanged(object sender, EventArgs e)
        {
            numPriceToFilter.Enabled = !numPriceToFilter.Enabled;
        }

        private void cbEnableQuantityToFilter_CheckedChanged(object sender, EventArgs e)
        {
            numQuantityToFilter.Enabled = !numQuantityToFilter.Enabled;
        }

        private void cbEnableQuantityFromFilter_CheckedChanged(object sender, EventArgs e)
        {
            numQuantityFromFilter.Enabled = !numQuantityFromFilter.Enabled;
        }

        private void cbEnableDateToFilter_CheckedChanged(object sender, EventArgs e)
        {
            dtpBeforeFilter.Enabled = !dtpBeforeFilter.Enabled;
        }

        private void cbEnableDateFromFilter_CheckedChanged(object sender, EventArgs e)
        {
            dtpAfterFilter.Enabled = !dtpAfterFilter.Enabled;
        }

        private void cbEnableAllFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableAllFilters.Checked)
            {
                cbEnablePriceFromFilter.Checked = true;
                cbEnablePriceToFilter.Checked = true;
                cbEnableQuantityToFilter.Checked = true;
                cbEnableQuantityFromFilter.Checked = true;
                cbEnableDateToFilter.Checked = true;
                cbEnableDateFromFilter.Checked = true;
            }
            else
            {
                cbEnablePriceFromFilter.Checked = false;
                cbEnablePriceToFilter.Checked = false;
                cbEnableQuantityToFilter.Checked = false;
                cbEnableQuantityFromFilter.Checked = false;
                cbEnableDateToFilter.Checked = false;
                cbEnableDateFromFilter.Checked = false;
            }
        }

        private void numPriceToFilter_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numPriceToFilter.Value <= numPriceFromFilter.Value)
                    numPriceFromFilter.Value = numPriceToFilter.Value - 1;
            }
            catch { /* ignore action if sets numPriceFromFilter.Value < 0 */ }
        }

        private void numPriceFromFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numPriceFromFilter.Value >= numPriceToFilter.Value)
                numPriceToFilter.Value = numPriceFromFilter.Value + 1;
        }

        private void numQuantityToFilter_ValueChanged(object sender, EventArgs e)
        {
                if (numQuantityToFilter.Value < numQuantityFromFilter.Value + 2)
                    numQuantityFromFilter.Value = numQuantityToFilter.Value - 2;
        }

        private void numQuantityFromFilter_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantityFromFilter.Value > numQuantityToFilter.Value - 2)
                numQuantityToFilter.Value = numQuantityFromFilter.Value + 2;
        }

        private void dtpBeforeFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBeforeFilter.Value <= dtpAfterFilter.Value)
                dtpAfterFilter.Value = dtpBeforeFilter.Value.AddDays(-1);
        }

        private void dtpAfterFilter_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAfterFilter.Value >= dtpBeforeFilter.Value)
                dtpBeforeFilter.Value = dtpAfterFilter.Value.AddDays(1);
        }
    }
}
