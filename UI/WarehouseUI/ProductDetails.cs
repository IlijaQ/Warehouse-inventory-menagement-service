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

namespace WarehouseUI
{
    public partial class ProductDetails : KryptonForm, IUsesCreateEditForm
    {
        public ProductDetails(string productIdInString)
        {
            InitializeComponent();
            GetProductInfo(productIdInString);
            
        }

        private async void GetProductInfo(string productId)
        {
            SearchMaskPanel.Visible = true;

            var result = await UIController.GetProductById(productId);

            FillFormWithData(result);

            SearchMaskPanel.Visible = false;
        }
        private void FillFormWithData(Models.ProductAndCategories result)
        {
            string productIdInString = result.Id.ToString();

            this.Name = $"{productIdInString} Details";
            lblId.Text = productIdInString;
            lblProductName.Text = result.Name;
            lblPrice.Text = "$" + result.Price.ToString();
            lblQuantity.Text = result.Quantity.ToString();
            lblProductCreatedAt.Text = result.CreatedAt.ToString("dd.MM.yyyy. HH:mm");
            tbCategories.Text = string.Join(", ", result.CategoryList);

            tbDescription.Text = result.Description;
            if (!string.IsNullOrEmpty(result.Description.Trim()))
            {
                tbDescription.Text = "[no description]";
                lblDescription.ForeColor = Color.Gray;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCategories_SizeChanged(object sender, EventArgs e)
        {
            Size textSize = TextRenderer.MeasureText(
                tbCategories.Text,
                tbCategories.Font,
                tbCategories.ClientSize,
                TextFormatFlags.WordBreak
                );

            tbCategories.Height = textSize.Height;
        }
    }
}
