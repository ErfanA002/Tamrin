using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Persons.DTOs;

public class PersonDTO
{
    public string Name { get; set; }
    public string LastName { get; set; }
    [Required(ErrorMessage = "is required to have address")]
    public string[] Addresses { get; set; } = null;
    [Required(ErrorMessage = "is required to have phone")]
    public string[] Phones { get; set; } = null;
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
}