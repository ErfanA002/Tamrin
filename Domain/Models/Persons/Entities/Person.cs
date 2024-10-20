using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models.Persons.Entities;

public class Person
{
    public Person()
    {
        IsActive = false;
        IsDelete = false;
    }

    [Key]
    public int PersonId { get; set; }

    [Column(TypeName = "VARCHAR")]
    [MaxLength(50)]
    public string Name { get; set; }
    public string LastName { get; set; }
    public ICollection<Address> Address { get; set; }
    public ICollection<Phone> Phone { get; set; }
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
    public Person Man { get; set; }
    public int? ManId { get; set; }
}
