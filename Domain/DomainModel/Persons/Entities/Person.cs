using System.ComponentModel.DataAnnotations;
namespace Domain.DomainModel.Persons.Entities;
public class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string[] Phones { get; set; }
    public string Adress { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}