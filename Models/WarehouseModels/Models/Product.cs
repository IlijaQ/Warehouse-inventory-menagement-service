﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseModels.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("ProductId")]
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
