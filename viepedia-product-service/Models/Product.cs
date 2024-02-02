namespace viepedia_product_service.Models
{
    // Product.cs
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public String Thumbnail { get; set; }
    }

}
