using backend.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace backend.Domain;

public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
{
   public DbSet<Recipe> Recipes { get; set; }
}