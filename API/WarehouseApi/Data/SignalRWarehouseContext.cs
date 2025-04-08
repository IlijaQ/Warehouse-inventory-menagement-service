using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;

namespace WarehouseApi.Data
{
    public class SignalRWarehouseContext : DbContext
    {
        public SignalRWarehouseContext(DbContextOptions<SignalRWarehouseContext> options) : base (options)
        {
            
        }
    }
}
