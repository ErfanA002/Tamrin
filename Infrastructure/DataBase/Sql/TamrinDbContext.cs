using Domain.Models.Persons.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.DataBase.Sql;
public class TamrinDbContext : DbContext
{
    public TamrinDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}

    public DbSet<Person> Persons { get; set; }

}