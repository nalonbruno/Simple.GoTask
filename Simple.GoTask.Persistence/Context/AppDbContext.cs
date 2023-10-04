using Microsoft.EntityFrameworkCore;
using Simple.GoTask.Domain.Entities;

namespace Simple.GoTask.Persistence.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<TaskItem> TaskItems { get; set; }
}
