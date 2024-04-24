namespace Assignment1.Model
{
    public class Menu
    {
        public int FoodId { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public double price { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
