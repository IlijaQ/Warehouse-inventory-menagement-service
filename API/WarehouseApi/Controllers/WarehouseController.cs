using Microsoft.AspNetCore.Mvc;
using WarehouseApi.Repository;
using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;

namespace WarehouseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _repository;
        
        public WarehouseController(IWarehouseRepository repository)
        {
            _repository = repository;
        }
    }
}
