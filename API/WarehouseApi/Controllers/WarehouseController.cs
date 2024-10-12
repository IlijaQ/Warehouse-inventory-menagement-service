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
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductData productData)
        {
            if (productData == null)
            {
                return BadRequest("Invalid produc data.");
            }

            try
            {
                await _repository.CreateAsync(productData);
                return StatusCode(201);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the product: {ex.Message}");
            }
        }
    }
}
