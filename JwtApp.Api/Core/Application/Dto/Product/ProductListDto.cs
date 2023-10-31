namespace JwtApp.Api.Core.Application.Dto.Product
{
    public class ProductListDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
