namespace WarehouseApi.DataTransferClasses
{
    public class SearchFilters
    {
        public string Name { get; set; }
        public DateTime? DateTimeAfter { get; set; }
        public DateTime? DateTimeBefore { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public int? StockMoreThan { get; set; }
        public int? StockLessThan { get; set; }
    }
}
