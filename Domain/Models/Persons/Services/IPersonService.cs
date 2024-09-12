using Domain.Models.Persons.DTOs;
using Domain.Models.Persons.Entities;

namespace Domain.Models.Persons.Services;

public interface IPersonService
{
    public IEnumerable<Person> Person();
    public Person GetPersonById(int id);
    public void CreatePerson(CreatePersonDTO person);
    public void UpdatePerson(int id, UpdatePersonDTO person);
    public void DeletePerson(int id);
    public void DeleteLogicalPerson(int id);
    public void ActivePerson(int personId);
    public void DisenablePerson(int personid);
    public void AddAddess(int id, string addess);
}
