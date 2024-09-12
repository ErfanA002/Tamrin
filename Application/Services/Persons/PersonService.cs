using Domain.Models.Persons.DTOs;
using Domain.Models.Persons.Repositorys;
using Domain.Models.Persons.Services;

namespace Application.Services.Person;

public class PersonService : IPersonService
{
    public IPersonRepository _PersonRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _PersonRepository = personRepository;
    }

    public IEnumerable<Domain.Models.Persons.Entities.Person> Person()
    {
        return _PersonRepository.Person();
    }

    public Domain.Models.Persons.Entities.Person GetPersonById(int id)
    {
        return _PersonRepository.GetById(id);
    }

    public void CreatePerson(CreatePersonDTO person)
    {
        _PersonRepository.Create(person);
        _PersonRepository.Save();
    }

    public void UpdatePerson(int id, UpdatePersonDTO person)
    {
        _PersonRepository.Update(id,person);
        _PersonRepository.Save();
    }

    public void DeletePerson(int id)
    {
        _PersonRepository.Delete(id);
        _PersonRepository.Save();
    }

    public void DeleteLogicalPerson(int id)
    {
        _PersonRepository.DeleteLogical(id);
        _PersonRepository.Save();
    }

    public void ActivePerson(int personId)
    {
        _PersonRepository.ActivePerson(personId);
        _PersonRepository.Save();
    }

    public void DisenablePerson(int personid)
    {
        _PersonRepository.DisenablePerson(personid);
        _PersonRepository.Save();
    }

    public void AddAddess(int id ,string addess)
    {
        _PersonRepository.AddPersonAddess(id,addess);
        _PersonRepository.Save();
    }
}