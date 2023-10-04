using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Simple.GoTask.Domain.Interfaces;
using Simple.GoTask.Persistence.Context;
using Simple.GoTask.Persistence.Repositories;

namespace Simple.GoTask.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceApp(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ITaskItemRepository, TaskItemRepository>();
    }
}
