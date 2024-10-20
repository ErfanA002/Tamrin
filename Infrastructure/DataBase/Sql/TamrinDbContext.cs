using Domain.Models.Persons.Entities;
using Infrastructure.DataBase.Sql.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataBase.Sql;

public class TamrinDbContext : DbContext
{
    public TamrinDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}

    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfiguration());
    }

}