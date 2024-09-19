using Domain.Models.Persons.Entities;

namespace Domain.Models.Persons.Repositorys;

public interface IPersonRepository
{
    public IEnumerable<Person> Person();
    public Person GetById(int id);
    public void Update(int id,Person person);
    public void Delete(int id);
    public void DeleteLogical(int id);
    public void Create(Person person);
    public void ActivePerson(int personId);
    public void DisenablePerson(int personid);
    public void AddPersonAddess(int id,string addess);
    public void Save();
}
