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

            this.Text = $"{productIdInString} Details";
            lblId.Text = productIdInString;
            lblProductName.Text = result.Name;
            lblPrice.Text = "$" + result.Price.ToString();
            lblQuantity.Text = result.Quantity.ToString();
            lblProductCreatedAt.Text = result.CreatedAt.ToString("dd.MM.yyyy. HH:mm");
            
            int currentMaxYOffset = lblCategoriesTag.Location.Y;
            ArrangeInStacksOfFiveLabels(ref currentMaxYOffset, result);

            tbDescription.Location = new Point(lblId.Location.X, currentMaxYOffset);
            lblDescriptionTag.Location = new Point(lblDescriptionTag.Location.X, currentMaxYOffset);
            
            tbDescription.Text = result.Description;
            if (!string.IsNullOrEmpty(result.Description.Trim()))
            {
                tbDescription.Text = "no description";
                lblDescriptionTag.ForeColor = Color.Gray;
            }
        }
        private void ArrangeInStacksOfFiveLabels(ref int currentMaxYOffset, Models.ProductAndCategories result)
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

                if (count++ % 5 == 0)
                {
                    xOffset += 110;
                    yOffset = lblCategoriesTag.Location.Y;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCategories_SizeChanged(object sender, EventArgs e)
        {
            //Size textSize = TextRenderer.MeasureText(
            //    tbCategories.Text,
            //    tbCategories.Font,
            //    tbCategories.ClientSize,
            //    TextFormatFlags.WordBreak
            //    );

            //tbCategories.Height = textSize.Height;
        }
    }
}
