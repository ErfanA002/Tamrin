using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Persons.Entities;

public class Address
{
    [Key]
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public string Name { get; set; }
}