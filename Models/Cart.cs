namespace A3.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string quantity { get; set; }
        public string user_id { get; set; }
    }
}