using Microsoft.AspNetCore.Mvc;
using WarehouseApi.Repository;
using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        [HttpPost("CreateProduct")]
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
        
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return StatusCode(404);
            }
            return Ok(product);
        }

        [HttpPost("GetProducts")]
        public async Task<IActionResult> GetAllProducts([FromBody] SearchFilters searchFilters)
        {
            var products = await _repository.GetAllAsync(searchFilters);
            return Ok(products);
        }

        [HttpPut("Update Product")]
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

        //[HttpDelete("{id}")]
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

        [HttpGet("GetCategories")]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _repository.GetAllCategories();
            return Ok(categories);
        }
    }
}
