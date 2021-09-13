namespace XESShop.Controllers
{
    public class FilterViewModel
    {
        public int? ManufacturerId { get; set; }
        public int? CategoryId { get; set; }

        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
    }
}