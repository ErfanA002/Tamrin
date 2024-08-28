using Domain.DomainModel.Persons.DTO;
using Domain.DomainModel.Persons.Entities;
namespace Domain.DomainModel.Persons.Service;
public interface IPersonService
{
    public List<Person> Person();
    public Person GetPersonById(int id);
    public void UpdatePerson(int id, UpdatePersonDTO person);
    public void DeletePerson(int id);
    public void CreatePerson(CreatePersonDTO person);
}