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
    public class WarehouseRepository : IWarehouseRepository
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
        public async Task<IEnumerable<ProductData>> GetAllAsync(SearchFilters searchFilter)
        {
            var productsQuery = _context.Product.AsQueryable();

            if (!string.IsNullOrEmpty(searchFilter.Name))
            {
                productsQuery = productsQuery
                    .Where(p => p.ProductName.Contains(searchFilter.Name, StringComparison.OrdinalIgnoreCase));
            }

            productsQuery = ApplyFilters(searchFilter, productsQuery);

            var queryResults = await productsQuery.ToListAsync();

            List<ProductData> resultsInDTOs = new List<ProductData>();

            foreach (Product product in queryResults)
            {
                ProductData dataTransferObject = TransferData.ProductToDto(product);
                resultsInDTOs.Add(dataTransferObject);
            }

            return resultsInDTOs;
        }
        private static IQueryable<Product> ApplyFilters(SearchFilters searchFilter, IQueryable<Product> productsQuery)
        {
            if (searchFilter.DateTimeAfter != null)
            {
                productsQuery = productsQuery.Where(p => p.CreatedAt > searchFilter.DateTimeAfter);
            }
            if (searchFilter.DateTimeBefore != null)
            {
                productsQuery = productsQuery.Where(p => p.CreatedAt < searchFilter.DateTimeBefore);
            }

            if (searchFilter.PriceFrom != null)
            {
                productsQuery = productsQuery.Where(p => p.Price > searchFilter.PriceFrom);
            }
            if (searchFilter.PriceTo != null)
            {
                productsQuery = productsQuery.Where(p => p.Price < searchFilter.PriceTo);
            }

            if (searchFilter.StockMoreThan != null)
            {
                productsQuery = productsQuery.Where(p => p.StockQuantity > searchFilter.StockMoreThan);
            }
            if (searchFilter.StockLessThan != null)
            {
                productsQuery = productsQuery.Where(p => p.StockQuantity < searchFilter.StockLessThan);
            }

            return productsQuery;
        }

        public async Task UpdateAsync(ProductData productData)
        {
            var productToUpdate = await _context.Product
                .Include(cp => cp.ProductCategory)
                .FirstOrDefaultAsync(p => p.ProductId == productData.Id);

            if (productToUpdate == null)
            {
                return;
            }

            UpdateBridgingTable(productData, productToUpdate);

            productToUpdate = TransferData.FromDtoToProduct(productData);

            await _context.SaveChangesAsync();
        }
        private void UpdateBridgingTable(ProductData productData, Product productToUpdate)
        {
            var currentCategoryIds = productToUpdate.ProductCategory.Select(pc => pc.CategoryId).ToList();
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
                _context.ProductCategory.Add(new ProductCategory { ProductId = productData.Id, CategoryId = categoryId });
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id == null)
                return false;

            var product = await _context.Product.FindAsync(id);
            var productCategory = from p in _context.ProductCategory
                                  where p.ProductId == id
                                  select p;
            var productCategories = await productCategory.ToListAsync();

            if (product == null)
                return false;

            _context.Product.Remove(product);

            foreach (var pc in productCategories)
            {
                if (product.ProductId == pc.ProductId)
                    _context.ProductCategory.Remove(pc);
            }

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
