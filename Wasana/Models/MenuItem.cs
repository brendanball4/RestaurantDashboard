namespace Wasana.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public string Allergens { get; set; }
        public double Price { get; set; }
    }
}
