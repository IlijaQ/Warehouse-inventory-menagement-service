using System.ComponentModel.DataAnnotations.Schema;
using WarehouseModels.Models;

namespace WarehouseApi.DataTransferClasses
{
    public class ProductData
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<int> CheckedCategoryIds { get; set; }
    }
}
