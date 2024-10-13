using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseUI.DataTransferClasses;

namespace WarehouseUI.Models
{
    public class ProductAndCategories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CategoryData> CategoryList { get; set; }
    }
}
