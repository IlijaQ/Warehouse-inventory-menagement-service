using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;

namespace WarehouseApi.Repository
{
    public interface IWarehouseRepository
    {
        Task CreateAsync(ProductData productData);
        Task<IEnumerable<ProductData>> GetAllAsync(SearchFilters searchFilters);
        Task<ProductAndCategoryData> GetByIdAsync(int id);
        Task<bool> UpdateAsync(ProductData productData);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<CategoryData>> GetAllCategories();
    }
}
