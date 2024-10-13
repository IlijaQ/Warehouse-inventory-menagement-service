using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApi.DataTransferClasses;
using WarehouseUI.DataTransferClasses;
using WarehouseUI.Models;

namespace WarehouseUI
{
    public static class UIController
    {
        public static async Task<List<Product>> GetProducts(SearchFilters filters)
        {
            ApiRepository repository = new ApiRepository();
            return await repository.GetProductsAsync(filters);
        }
    }
}
