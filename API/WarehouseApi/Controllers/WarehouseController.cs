using Microsoft.AspNetCore.Mvc;
using WarehouseApi.Repository;
using WarehouseApi.DataTransferClasses;
using WarehouseModels.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using WarehouseApi.Hubs;
using WarehouseApi.Tools;
using System.Threading;

namespace WarehouseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : Controller
    {
        private readonly IWarehouseRepository _repository;
        private readonly INotificationService _signalR;

        public WarehouseController(IWarehouseRepository repository, INotificationService notificationService)
        {
            _repository = repository;
            _signalR = notificationService;
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] ProductData productData, CancellationToken cancellationToken)
        {
            if (productData == null)
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                await _repository.CreateAsync(productData, cancellationToken);
                _signalR.AddNewItemAsync(productData, cancellationToken);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the product: {ex.Message}");
            }
        }
        
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(id, cancellationToken);
            if (product == null)
            {
                return StatusCode(404);
            }
            return Ok(product);
        }

        [HttpPost("GetProducts")]
        public async Task<IActionResult> GetAllProducts([FromBody] SearchFilters searchFilters, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync(searchFilters, cancellationToken);
            return Ok(products);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductData productData, CancellationToken cancellationToken)
        {
            if (productData == null)
            {
                return BadRequest("Invalid product data.");
            }

            try
            {
                bool foundAndUpdated = await _repository.UpdateAsync(productData, cancellationToken);
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

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id, CancellationToken cancellationToken)
        {
            try
            {
                bool foundAndRemoved = await _repository.DeleteAsync(id, cancellationToken);
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
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllCategories(cancellationToken);
            return Ok(categories);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryData categoryData, CancellationToken cancellationToken)
        {
            if (categoryData == null)
            {
                return BadRequest("Invalid category data.");
            }

            try
            {
                await _repository.AddNewCategoryAsync(categoryData, cancellationToken);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the category: {ex.Message}");
            }
        }
    }
}
