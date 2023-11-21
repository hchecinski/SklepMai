namespace SklepMai.Core.Functions.Products.Queries.GetProductsList
{
    public class ProductInList
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal? Price { get; set; } = null;
    }
}