namespace WarehouseApi.Hubs
{
    public interface INotificationService
    {
        Task NotifyUsers(string message);
    }
}
