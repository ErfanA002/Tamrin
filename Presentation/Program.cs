using Application.Services.Person;
using Domain.Models.Persons.Repositorys;
using Domain.Models.Persons.Services;
using Infrastructure.DataBase.Sql;
using Infrastructure.DataBase.Sql.Repository;
using Microsoft.EntityFrameworkCore;

namespace Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigServices(builder.Services);
        ConfigDataBase(builder.Services,builder.Configuration);

        var app = builder.Build();

        ConfigSwagger(app);
        ConfigMiddleWares(app);

        app.Run();
    }

    private static void ConfigMiddleWares(WebApplication app)
    {
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();
    }

    private static void ConfigSwagger(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }

    private static void ConfigServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen();

        IOC(services);
    }

    private static void IOC(IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPersonService, PersonService>();
    }

    private static void ConfigDataBase(IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<TamrinDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DataBase"));
        });
    }
}
