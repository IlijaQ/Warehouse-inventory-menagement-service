using Microsoft.EntityFrameworkCore;
using WarehouseApi.Data;
using WarehouseModels.Models;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc.Rendering;
using WarehouseApi.DataTransferClasses;
using WarehouseApi.Tools;

namespace WarehouseApi.Repository
{
    public class WarehouseRepository
    {
        private readonly WarehouseContext _context;

        public WarehouseRepository(WarehouseContext context)
        {
            _context = context;
        }
    }
}
