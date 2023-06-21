using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;
using Pronia.Core.Entitiesı;
using Pronia.Core.Entitiesş;

namespace Pronia.DataAccess.Database;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

	public DbSet<Slidaer> slidaers { get; set; }
	public DbSet<Payment> payments { get; set; }
	public DbSet<Product> products { get; set; }
	public DbSet<Banner> banners { get; set; }
	public DbSet<NewProduct> newproducts { get; set; }
}
