using Microsoft.AspNetCore.SignalR;
using WarehouseApi.DataTransferClasses;

namespace WarehouseApi.Hubs
{
    public class NotificationService : INotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationService(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task AddNewItemAsync(ProductData item, CancellationToken cancellationToken)
        {
            await _hubContext.Clients.All.SendAsync("RecieveNewItem", item, cancellationToken);
        }
    }
}
