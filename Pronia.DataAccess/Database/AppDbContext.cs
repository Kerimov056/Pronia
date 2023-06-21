using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;

namespace Pronia.DataAccess.Database;

public class AppDbContext:DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

	public DbSet<Slidaer> slidaers { get; set; }
}
