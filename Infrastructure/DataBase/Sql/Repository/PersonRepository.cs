using Domain.Models.Persons.DTOs;
using Domain.Models.Persons.Entities;
using Domain.Models.Persons.Repositorys;
using System.Net;

namespace Infrastructure.DataBase.Sql.Repository;
public class PersonRepository : IPersonRepository
{
    public TamrinDbContext _tamrinDbContext;

    public PersonRepository(TamrinDbContext tamrinDbContext)
    {
        _tamrinDbContext = tamrinDbContext;
    }

    public IEnumerable<Person> Person()
    {
        return _tamrinDbContext.Persons.ToList() as IEnumerable<Person>;
    }

    public Person GetById(int id)
    {
        return _tamrinDbContext.Persons.SingleOrDefault(x => x.Id == id);
    }

    public void Update(int id, UpdatePersonDTO person)
    {
        var targetPerson = GetById(id);
        
        targetPerson.Name = person.Name;
        targetPerson.LastName = person.LastName;

        _tamrinDbContext.Update(targetPerson);
    }

    public void Delete(int id)
    {
        _tamrinDbContext.Remove(id);
    }

    public void DeleteLogical(int id)
    {
        var targetPerson = GetById(id);

        targetPerson.IsDelete = true;

    }

    public void Create(CreatePersonDTO person)
    {
        var newperson = new Person()
        {
            Name = person.Name,
            LastName = person.LastName,
            Address = person.Adress,
            Numbers = person.Numbers
        };

        _tamrinDbContext.Persons.Add(newperson);
    }

    public void ActivePerson(int personId)
    {
        var targetPerson = GetById(personId);

        targetPerson.IsActive = true;
    }

    public void DisenablePerson(int personid)
    {
        var targetPerson = GetById(personid);

        targetPerson.IsActive = false;
    }

    public void AddPersonAddess(int id,string[] addess)
    {
        var targetPerson = GetById(id);

        targetPerson.Address = addess;
    }

    public void Save()
    {
        _tamrinDbContext.SaveChanges();
    }
}