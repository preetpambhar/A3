namespace A3.Models
{
    public class Comments
    {

        public int id { get; set; }
        public int product_id { get; set; }
        public string user_id { get; set; }
        public string rating { get; set; }
        public string images { get; set; }
        public string text { get; set; }
    }
}