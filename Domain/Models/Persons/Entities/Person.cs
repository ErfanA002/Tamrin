using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Persons.Entities;

public class Person
{

    public Person()
    {
        IsActive = false;
        IsDelete = false;
    }

    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public ICollection<Address> Address { get; set; }
    public ICollection<Phone> Phone { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}
