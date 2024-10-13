using System;

namespace WarehouseApi.DataTransferClasses
{
    public class SearchFilters
    {
        public string Name { get; set; } = string.Empty;
        public DateTime? DateTimeAfter { get; set; }// = new DateTime(2020, 1, 1);
        public DateTime? DateTimeBefore { get; set; }// = new DateTime(2100, 1, 1);
        public decimal? PriceFrom { get; set; }// = 0m;
        public decimal? PriceTo { get; set; }// = 100000m;
        public int? StockMoreThan { get; set; }// = -1;
        public int? StockLessThan { get; set; }// = 100000;
    }
}
