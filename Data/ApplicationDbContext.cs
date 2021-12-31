using bulky_book.Models;
using Microsoft.EntityFrameworkCore;

namespace bulky_book.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
