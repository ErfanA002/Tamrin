using System.ComponentModel.DataAnnotations;
namespace Domain.DomainModel.Persons.Entities;
public class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}