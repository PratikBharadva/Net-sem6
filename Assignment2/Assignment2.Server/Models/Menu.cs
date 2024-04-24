using System.ComponentModel.DataAnnotations;

namespace Assignment2.Server.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int price { get; set; }
    }
}
