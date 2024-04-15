using Microsoft.EntityFrameworkCore;

namespace MySQLFun.Models;

public class RecipesDbContext : DbContext
{
    public RecipesDbContext(DbContextOptions<RecipesDbContext> options) : base(options)
    {
        
    }
    public DbSet<Recipe> Recipes { get; set; }
}