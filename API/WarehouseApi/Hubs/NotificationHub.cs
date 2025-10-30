using Microsoft.AspNetCore.SignalR;
using System.Threading;
using WarehouseApi.DataTransferClasses;

namespace WarehouseApi.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly NotificationService _notificationService;

        public NotificationHub(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task NewItemNotifyToAllAsync(ProductData item, CancellationToken cancellationToken)
        {
            await _notificationService.AddNewItemAsync(item, cancellationToken);
        }
    }
}
