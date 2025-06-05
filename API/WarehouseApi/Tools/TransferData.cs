using WarehouseModels.Models;
using WarehouseApi.DataTransferClasses;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehouseApi.Tools
{
    public static class TransferData
    {
        public static Product FromDtoToProduct(ProductData data)
        {
            Product product = new Product();

            product.ProductId = data.Id;
            product.ProductName = data.Name;
            product.Price = data.Price;
            product.Description = data.Description;
            product.StockQuantity = data.Quantity;
            product.CreatedAt = data.CreatedAt;

            IList<ProductCategory> productCategories = new List<ProductCategory>();

            foreach (int cid in data.CheckedCategoryIds)
            {
                productCategories.Add(new ProductCategory { CategoryId = cid, ProductId = product.ProductId });
            }

            product.ProductCategory = productCategories;

            return product;
        }

        public static ProductData ProductToDto(Product product)
        {
            ProductData data = new ProductData();

            data.Id = product.ProductId;
            data.Name = product.ProductName;
            data.Price = product.Price;
            data.Description = product.Description;
            data.Quantity = product.StockQuantity;
            data.CreatedAt = product.CreatedAt;

            return data;
        }

        public static void UpdateProductFrom(ProductData data, Product product)
        {
            product.ProductId = data.Id;
            product.ProductName = data.Name;
            product.Price = data.Price;
            product.Description = data.Description;
            product.StockQuantity = data.Quantity;
            product.CreatedAt = data.CreatedAt;
        }

        public static Category FromDtoToCategory(CategoryData data)
        {
            Category category = new Category();

            category.CategoryId = data.Id;
            category.CategoryName = data.Name;
            category.CreatedAt = data.CreatedAt;

            return category;
        }

        public static CategoryData CategoryToDto(Category category)
        {
            CategoryData data = new CategoryData();

            data.Id = category.CategoryId;
            data.Name = category.CategoryName;
            data.CreatedAt = category.CreatedAt;

            return data;
        }
    }
}
