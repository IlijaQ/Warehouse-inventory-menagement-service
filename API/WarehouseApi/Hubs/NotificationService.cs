using Microsoft.AspNetCore.SignalR;

namespace WarehouseApi.Hubs
{
    public class NotificationService : INotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public NotificationService(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task NotifyUsers(string message)
        {
            await _hubContext.Clients.All.SendAsync("RecieveMessage", message);
        }
    }
}
