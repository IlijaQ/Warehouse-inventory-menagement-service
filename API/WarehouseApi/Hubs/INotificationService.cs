using WarehouseApi.DataTransferClasses;

namespace WarehouseApi.Hubs
{
    public interface INotificationService
    {
        Task AddNewItemAsync(ProductData item, CancellationToken cancellationToken);
    }
}
