using Microsoft.EntityFrameworkCore;
using WarehouseApi.Data;
using WarehouseModels.Models;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarehouseApi.DataTransferClasses;
using WarehouseApi.Tools;

namespace WarehouseApi.Repository
{
    public class WarehouseRepository
    {
        private readonly WarehouseContext _context;

        public WarehouseRepository(WarehouseContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(ProductData productData)
        {
            Product newProduct = TransferData.FromDtoToProduct(productData);

            _context.Product.Add(newProduct);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(ProductData productData)
        {
            var productToUpdate = await _context.Product
                .Include(cp => cp.ProductCategory)
                .FirstOrDefaultAsync(p => p.ProductId == productData.ProductId);

            if (productToUpdate == null)
            {
                return;
            }

            var currentCategoryIds = productToUpdate.ProductCategory.Select(pc => pc.CategoryId).ToList();

            productToUpdate = TransferData.FromDtoToProduct(productData);

            var categoriesToAdd = productData.CheckedCategoryIds.Except(currentCategoryIds).ToList();
            var categoriesToRemove = currentCategoryIds.Except(productData.CheckedCategoryIds).ToList();

            foreach (var categoryId in categoriesToRemove)
            {
                var productCategory = productToUpdate.ProductCategory.FirstOrDefault(pc => pc.CategoryId == categoryId);
                if (productCategory != null)
                    _context.ProductCategory.Remove(productCategory);
            }

            foreach (var categoryId in categoriesToAdd)
            {
                _context.ProductCategory.Add(new ProductCategory{ ProductId = productData.ProductId, CategoryId = categoryId });
            }

            await _context.SaveChangesAsync();
        }
    }
}
