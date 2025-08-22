using Application.Commands;
using CQR.Extensions;
using Infrastructure.Repository;
namespace TaskFlow.CQRS.Extensions;

public static class ServiceRegistryExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<ITaskRepository, TaskRepository>();

        services.AddCQR(cfg =>
        {
            cfg.AddAssembly(typeof(CreateTaskCommand).Assembly);
        });
    }
}