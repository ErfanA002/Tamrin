using Domain.DomainModel.Persons.Repositorys;
using Domain.DomainModel.Persons.Service;
using Domain.DomainModel.Persons.Entities;

namespace Application.Services.Person;
public class PersonService : IPersonService
{
    public IPersonRepository _PersonRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _PersonRepository = personRepository;
    }

    public void CreatePerson(Domain.DomainModel.Persons.Entities.Person person)
    {
        _PersonRepository.Create(person);
    }

    public void DeletePerson(int id)
    {
        _PersonRepository.Delete(id);
    }

    public Domain.DomainModel.Persons.Entities.Person GetPersonById(int id)
    {
        return _PersonRepository.GetById(id);
    }

    public List<Domain.DomainModel.Persons.Entities.Person> Person()
    {
        return _PersonRepository.Person();
    }

    public void UpdatePerson(int id, Domain.DomainModel.Persons.Entities.Person person)
    {
        _PersonRepository.Update(id,person);
    }
}