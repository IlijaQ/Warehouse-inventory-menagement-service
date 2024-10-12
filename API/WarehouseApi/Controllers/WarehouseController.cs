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

        [HttpPost("Create products")]
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
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the product: {ex.Message}");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductData productData)
        {
            if (productData == null)
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                bool foundAndUpdated = await _repository.UpdateAsync(productData);
                if (foundAndUpdated)
                    return StatusCode(200);
                else
                    return StatusCode(404);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the product: {ex.Message}");
            }
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct([FromBody] int id)
        {
            try
            {
                bool foundAndRemoved = await _repository.DeleteAsync(id);
                if (foundAndRemoved)
                    return StatusCode(200);
                else
                    return StatusCode(404);
            }
            catch(Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting the product: {ex.Message}");
            }
        }
    }
}
