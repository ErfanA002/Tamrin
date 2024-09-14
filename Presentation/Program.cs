using Application.Services.Person;
using Domain.Models.Persons.Repositorys;
using Domain.Models.Persons.Services;
using Infrastructure.DataBase.Sql;
using Infrastructure.DataBase.Sql.Repository;
using Microsoft.EntityFrameworkCore;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IPersonRepository,PersonRepository>();
            builder.Services.AddScoped<IPersonService,PersonService>();

            builder.Services.AddDbContext<TamrinDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("RbcDB"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
