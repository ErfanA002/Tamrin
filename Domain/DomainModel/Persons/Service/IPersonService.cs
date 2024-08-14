using Domain.DomainModel.Persons.Entities;
namespace Domain.DomainModel.Persons.Service;
public interface IPersonService
{
    public List<Person> Person();
    public Person GetPersonById(int id);
    public void UpdatePerson(int id, Person person);
    public void DeletePerson(int id);
    public void CreatePerson(Person person);
}