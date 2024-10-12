using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;

namespace WarehouseApi.Repository
{
    public interface IWarehouseRepository
    {
        Task CreateAsync(ProductData productData);
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<ProductData>> GetAllAsync(SearchFilters searchFilters);
        Task UpdateAsync(ProductData productData);
        Task DeleteAsync(int id);
    }
}
