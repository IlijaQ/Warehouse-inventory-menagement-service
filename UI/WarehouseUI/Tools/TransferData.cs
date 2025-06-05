﻿using WarehouseUI.Models;
using WarehouseApi.DataTransferClasses;
using WarehouseUI.DataTransferClasses;

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
            data.CheckedCategoryIds = product.CheckedCategoryIds;

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

        public static CategoryData CategoryToDto(Category category)
        {
            CategoryData data = new CategoryData();

            data.Name = category.CategoryName;
            data.CreatedAt = category.CreatedAt;

            return data;
        }

        public static Category DtoToCategory(CategoryData data)
        {
            Category category = new Category();

            category.CategoryId = data.Id;
            category.CategoryName = data.Name;
            category.CreatedAt = data.CreatedAt;

            return category;
        }
    }
}
