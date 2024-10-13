using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseUI
{
    public partial class ProductDetails : Form, IUsesCreateEditForm
    {
        public ProductDetails(string productIdInString)
        {
            InitializeComponent();
            GetProductInfo(productIdInString);
        }

        private async void GetProductInfo(string productId)
        {
            lblSearch.Visible = true;

            var result = await UIController.GetProductById(productId);

            FillFormWithData(result);

            lblSearch.Visible = false;
        }
        private void FillFormWithData(Models.ProductAndCategories result)
        {
            lblId.Text = result.Id.ToString();
            lblProductName.Text = result.Name;
            lblPrice.Text = result.Price.ToString();
            lblQuantity.Text = result.Quantity.ToString();
            lblProductCreatedAt.Text = result.CreatedAt.ToString("dd.MM.yyyy. HH:mm");

            if (!string.IsNullOrEmpty(result.Description))
            {
                lblDescription.Visible = true;
                tbDescription.Visible = true;
                tbDescription.Text = result.Description;
            }

            foreach (var c in result.CategoryList)
            {
                tbCategories.Text = tbCategories.Text + $"Id: {c.Id} Category Name: {c.Name}\r\nCreated at {c.CreatedAt}\r\n\r\n";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
