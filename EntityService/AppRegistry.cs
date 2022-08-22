using EntityWeb.DatabaseContext;
using EntityWeb.Interface;
using EntityWeb.Model;
using EntityWeb.Service;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;

namespace EntityWeb
{
    public static class AppRegistry
    {
        public static void RegisterDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddHttpLogging(logging =>
            {
                logging.LoggingFields = HttpLoggingFields.All;
            });

            builder.Services.AddDbContext<EntityDbContext>(opt => opt.UseInMemoryDatabase("InMemory"));

            builder.Services.AddTransient<IService<Entity>, EntityService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
        }
    }
}
