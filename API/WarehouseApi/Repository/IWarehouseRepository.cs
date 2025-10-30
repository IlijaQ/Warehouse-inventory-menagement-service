using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;

namespace WarehouseApi.Repository
{
    public interface IWarehouseRepository
    {
        Task CreateAsync(ProductData productData, CancellationToken cancellationToken);
        Task<IEnumerable<ProductData>> GetAllAsync(SearchFilters searchFilters, CancellationToken cancellationToken);
        Task<ProductAndCategoryData> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<bool> UpdateAsync(ProductData productData, CancellationToken cancellationToken);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken);
        Task<IEnumerable<CategoryData>> GetAllCategories(CancellationToken cancellationToken);
        Task AddNewCategoryAsync(CategoryData productData, CancellationToken cancellationToken);
    }
}
