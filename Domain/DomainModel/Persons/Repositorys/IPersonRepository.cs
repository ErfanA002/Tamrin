using Domain.DomainModel.Persons.Entities;
namespace Domain.DomainModel.Persons.Repositorys;
public interface IPersonRepository
{
    public List<Person> Person();
    public Person GetById(int id);
    public void Update(int id,Person person);
    public void Delete(int id);
    public void Create(Person person);
}