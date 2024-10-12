using WarehouseModels.Models;
using WarehouseApi.DataTransferClasses;

namespace WarehouseApi.Tools
{
    public static class TransferData
    {
        public static Product FromDtoToProduct(ProductData data)
        {
            Product product = new Product();

            product.ProductId = data.ProductId;
            product.ProductName = data.ProductName;
            product.Price = data.Price;
            product.Description = data.Description;
            product.StockQuantity = data.StockQuantity;
            product.CreatedAt = data.CreatedAt;

            IList<ProductCategory> productCategories = new List<ProductCategory>();

            foreach (int cid in data.CheckedCategoryIds)
            {
                productCategories.Add(new ProductCategory { CategoryId = cid, ProductId = product.ProductId });
            }

            product.ProductCategory = productCategories;

            return product;
        }
    }
}
