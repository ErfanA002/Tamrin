using Domain.Models.Persons.DTOs;
using Domain.Models.Persons.Entities;
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

    public void CreatePerson(PersonDTO person)
    {
        // first you must validationing data
        CheckAddress(person);
        CheckPhone(person);
        
        List<Address> addresses;
        List<Phone> phones;
        
        AddItems(person, out addresses, out phones);

        _PersonRepository.Create(new Domain.Models.Persons.Entities.Person()
        {
            Name = person.Name,
            LastName = person.LastName,
            Phone = phones,
            Address = addresses
        });

        _PersonRepository.Save();
    }

    private void AddItems(PersonDTO person, out List<Address> addresses, out List<Phone> phones)
    {
        addresses = new List<Address>();
        foreach (var item in person.Addresses)
            addresses.Add(new Address() { Name = item });
        phones = new List<Phone>();
        foreach (var item in person.Phones)
            phones.Add(new Phone() { Number = item });
    }

    private void CheckPhone(PersonDTO person)
    {
        for (var i = 0; i < person.Phones.Count() - 1; i++)
            if (person.Phones[i] == person.Phones[i + 1])
                throw new Exception("is duplicate address");
    }

    private void CheckAddress(PersonDTO person)
    {
        for (var i = 0; i < person.Addresses.Count() - 1; i++)
            if (person.Addresses[i] == person.Addresses[i + 1])
                throw new Exception("is duplicate address");
    }

    public void UpdatePerson(int id,PersonDTO person)
    {

        List<Address> addresses = new List<Address>();
        
        if (person.Addresses != null)
            foreach (var item in person.Addresses)
                addresses.Add(new Address() { Name = item });

        List<Phone> phones = new List<Phone>();

        if (person.Phones != null)
            foreach (var item in person.Phones)
                phones.Add(new Phone() { Number = item });

        _PersonRepository.Update(id,new Domain.Models.Persons.Entities.Person()
        {
            Name = person.Name,
            LastName = person.LastName,
            Address = addresses,
            Phone = phones,
            IsActive = person.IsActive,
            IsDelete = person.IsDelete
        });

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
    }

    public void DisenablePerson(int personid)
    {
        _PersonRepository.DisenablePerson(personid);

        _PersonRepository.Save();
    }

    public void Address(int id, string addess)
    {
        _PersonRepository.AddPersonAddress(id,addess);

        _PersonRepository.Save();
    }

    public void UpdatePersonAddress(int addessid, Address address)
    {
        throw new NotImplementedException();
    }

    public void UpdatePersonPhone(int id, Phone phone)
    {
        throw new NotImplementedException();
    }
}