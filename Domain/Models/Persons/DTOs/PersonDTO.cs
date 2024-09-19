using Domain.Models.Persons.Entities;

namespace Domain.Models.Persons.DTOs;

public class PersonDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public ICollection<Address> Address { get; set; }
    public ICollection<Phone> Phone { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}