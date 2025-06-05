using Microsoft.EntityFrameworkCore;
using WarehouseApi.Data;
using WarehouseModels.Models;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarehouseApi.DataTransferClasses;
using WarehouseApi.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

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
            if (!string.IsNullOrEmpty(searchFilter.Name))
            {
                string nameFilter = searchFilter.Name.ToLower().Trim();

                productsQuery = productsQuery
                    .Where(p => p.ProductName.ToLower().Contains(nameFilter));
            }

            if (searchFilter.DateTimeAfter != null)
            {
                DateOnly dateAfter = new DateOnly(searchFilter.DateTimeAfter.Value.Year,
                    searchFilter.DateTimeAfter.Value.Month,
                    searchFilter.DateTimeAfter.Value.Day);

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

        public async Task<ProductAndCategoryData> GetByIdAsync(int id)
        {
            var product = await _context.Product
                .Include(pc => pc.ProductCategory)
                .ThenInclude(c => c.Category)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            ProductAndCategoryData productDto = new ProductAndCategoryData
            {
                Id = product.ProductId,
                Name = product.ProductName,
                Price = product.Price,
                Description = product.Description,
                Quantity = product.StockQuantity,
                CreatedAt = product.CreatedAt,
                CategoryList = product.ProductCategory
                    .Select(pc => new CategoryData
                    {
                        Id = pc.Category.CategoryId,
                        Name = pc.Category.CategoryName,
                        CreatedAt = pc.Category.CreatedAt
                    }).ToList()
            };

            return productDto;
        }

        public async Task<bool> UpdateAsync(ProductData productData)
        {
            var productToUpdate = await _context.Product
                .Include(cp => cp.ProductCategory)
                .FirstOrDefaultAsync(p => p.ProductId == productData.Id);

            if (productToUpdate == null)
            {
                return false;
            }

            UpdateBridgingTable(productData, productToUpdate);
            TransferData.UpdateProductFrom(productData, productToUpdate);

            await _context.SaveChangesAsync();
            return true;
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

        public async Task<IEnumerable<CategoryData>> GetAllCategories()
        {
            var categories = await _context.Category.ToListAsync();

            List<CategoryData> categoriesInDTOs = new List<CategoryData>();

            foreach (Category c in categories)
            {
                CategoryData dataTransferObject = TransferData.CategoryToDto(c);
                categoriesInDTOs.Add(dataTransferObject);
            }

            return categoriesInDTOs;
        }

        public async Task AddNewCategoryAsync(CategoryData categoryData)
        {
            Category newCategory = TransferData.FromDtoToCategory(categoryData);

            _context.Category.Add(newCategory);
            await _context.SaveChangesAsync();
        }
    }
}
