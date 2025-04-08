using Microsoft.AspNetCore.SignalR;

namespace WarehouseApi.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly NotificationService _notificationService;

        public NotificationHub(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public async Task SendMessageToAll(string message)
        {
            await _notificationService.NotifyUsers(message);
        }
    }
}
