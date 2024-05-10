namespace Wasana.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderTime { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
