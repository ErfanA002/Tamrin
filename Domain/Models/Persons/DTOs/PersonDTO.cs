using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Persons.DTOs;

public class PersonDTO
{
    public string Name { get; set; }
    public string LastName { get; set; }
    [Required(ErrorMessage = "is required to have address")]
    public string[] Addresses { get; set; } = null;
    [DisplayName("Name")]   
    [Display(Name="phone")]
  //  [Required(ErrorMessage = " {0} is req ")]
    [MinLength(1, ErrorMessage = " {0} is  greater than {1} ")]
    public string[] Phones { get; set; } = null;
    [Required(ErrorMessage = " {0} is req ")]
    public bool IsActive { get; set; }
    [Required(ErrorMessage = " {0} is req ")]
    public bool IsDelete { get; set; }
}