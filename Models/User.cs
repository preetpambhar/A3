namespace A3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string username { get; set; }
        public string purchase_history { get; set; }

        public string shipping_address { get; set; }


    }
}