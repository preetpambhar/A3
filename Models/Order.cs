namespace A3.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string product_id { get; set; }
        public string quantity { get; set; }
        public string user_id { get; set; }
        public string order_date { get; set; }
    }
}