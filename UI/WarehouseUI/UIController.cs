using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApi.DataTransferClasses;
using WarehouseApi.Tools;
using WarehouseUI.DataTransferClasses;
using WarehouseUI.Models;

namespace WarehouseUI
{
    public static class UIController
    {
        public static async Task<ProductAndCategories> GetProductById(string productIdInString)
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetProductByIdAsync(productIdInString);
        }

        public static async Task<List<Product>> GetProducts(SearchFilters filters)
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetProductsAsync(filters);
        }

        public static async Task<List<Category>> GetCategories()
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetCategoriesAsync();
        }

        public static async Task<bool> CreateProduct(Product product)
        {
            ApiRepository repository = new ApiRepository();
            ProductData productDto = TransferData.ProductToDto(product);
            bool success = await repository.CreateProductAsync(productDto);
            return success;
        }

        public static async Task<bool> CreateCategory(Category category)
        {
            ApiRepository repository = new ApiRepository();
            CategoryData categoryDto = TransferData.CategoryToDto(category);
            bool success = await repository.CreateCategoryAsync(categoryDto);
            return success;
        }

        public static async Task<bool> UpdateProduct(Product product)
        {
            ApiRepository repository = new ApiRepository();
            ProductData productDto = TransferData.ProductToDto(product);
            bool success = await repository.CreateProductAsync(productDto);
            return success;
        }

        public static async Task<bool> DeleteProduct(string productIdInString)
        {
            ApiRepository repository = new ApiRepository();
            bool success = await repository.DeleteProductAsync(productIdInString);
            return success;
        }
    }
}
