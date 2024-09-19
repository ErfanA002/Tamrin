using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Persons.Entities;

public class Phone
{
    [Key]
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public string Number { get; set; }
    public string KindOfNumber { get; set; } = "d";
    public string? Provaider { get; set; }
}
