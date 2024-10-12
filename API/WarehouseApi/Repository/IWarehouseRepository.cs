using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;

namespace WarehouseApi.Repository
{
    public interface IWarehouseRepository
    {
        Task CreateAsync(ProductData productData);
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync(SearchFilters searchFilters);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
