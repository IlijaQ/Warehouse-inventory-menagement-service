namespace WarehouseApi.DataTransferClasses
{
    public class ProductAndCategoryData
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<CategoryData> CategoryList { get; set; }
    }
}
