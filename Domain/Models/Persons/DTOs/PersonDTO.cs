namespace Domain.Models.Persons.DTOs;

public class PersonDTO
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string[] Addresses { get; set; }
    public string[] Phones { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}