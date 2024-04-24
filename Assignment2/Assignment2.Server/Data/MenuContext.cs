using Assignment2.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Server.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) :base(options){ }
        public DbSet<Menu> menus { get; set; }
    }
}
