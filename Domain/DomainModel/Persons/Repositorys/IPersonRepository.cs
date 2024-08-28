using Domain.DomainModel.Persons.DTO;
using Domain.DomainModel.Persons.Entities;
namespace Domain.DomainModel.Persons.Repositorys;
public interface IPersonRepository
{
    public List<Person> Person();
    public Person GetById(int id);
    public void Update(int id,UpdatePersonDTO person);
    public void Delete(int id);
    public void Create(CreatePersonDTO person);
    public void Save();
}